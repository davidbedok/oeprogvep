using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace Bloxorz
{
    public class Terrain
    {
        private const char FIELD = 'o';
        private const char START = 'S';
        private const char GOAL = 'G';

        private readonly String name;
        private readonly int width;
        private readonly int height;
        private readonly bool[,] map;
        private readonly Position start;
        private readonly Position goal;

        private Block startBlock;
        private Block block;

        public Block Block
        {
            get { return this.block; }
            set { this.block = value; }
        }

        public Terrain(String name, bool[,] map, Position start, Position goal)
        {
            this.name = name;
            this.width = map.GetLength(1);
            this.height = map.GetLength(0);
            this.map = map;
            this.start = start;
            this.goal = goal;
            this.startBlock = new Block(this.start, this.start);
            this.block = this.startBlock;
        }

        public void reStart()
        {
            this.block = this.startBlock;
        }

        public bool check()
        {
            return check(this.block);
        }

        private bool check(Block block)
        {
            return block.isStanding() && block.B1.check(this.goal);
        }

        public void draw(Graphics g, float unit)
        {
            for (int i = 0; i < this.map.GetLength(0); i++ )
            {
                for (int j = 0; j < this.map.GetLength(1); j++)
                {
                    this.drawField(g, i, j, unit);
                }
            }
        }

        private void drawField( Graphics g, int x, int y, float unit )
        {
            if (map[x, y])
            {
                RectangleF fieldRect = new RectangleF(y * unit, x * unit, unit, unit);
                if (start.check(x, y))
                {
                    Position.drawStart(g, fieldRect);
                }
                else if (goal.check(x, y))
                {
                    Position.drawGoal(g, fieldRect);
                }
                else
                {
                    Position.drawField(g, fieldRect);
                }
            }
        }

        public void eraseBlock(Graphics g, float unit, bool withNeighbors)
        {
            this.eraseBlockSub(this.block, g, unit);
            if (withNeighbors)
            {
                List<Tuple<Block, Move>> neighbors = this.block.legalNeighbors(this);
                foreach (Tuple<Block, Move> neighbor in neighbors)
                {
                    if (!this.check(neighbor.Item1))
                    {
                        this.eraseBlockSub(neighbor.Item1, g, unit);
                    }
                }
            }
        }

        private void eraseBlockSub(Block block, Graphics g, float unit)
        {
            this.drawField(g, block.B1.X, block.B1.Y, unit);
            if (!block.isStanding())
            {
                this.drawField(g, block.B2.X, block.B2.Y, unit);
            }
        }

        public void drawBlock(Graphics g, float unit, bool withNeighbors)
        {
            this.block.draw(g, unit, false);
            if (withNeighbors)
            {
                List<Tuple<Block, Move>> neighbors = this.block.legalNeighbors(this);
                foreach (Tuple<Block, Move> neighbor in neighbors)
                {
                    if (!this.check(neighbor.Item1))
                    {
                        neighbor.Item1.draw(g, unit, true);
                    }
                }
            }
        }

        public bool isLegalBlock( Block block )
        {
            bool legal = false;
            if (block.B1.X >= 0 && block.B1.Y >= 0 && block.B2.X >= 0 && block.B2.Y >= 0)
            {
                if (block.B1.X < this.height && block.B1.Y < this.width && block.B2.X < this.height && block.B2.Y < this.width)
                {
                    legal = map[block.B1.X, block.B1.Y] && map[block.B2.X, block.B2.Y];
                }
            }
            return legal;
        }

        public override string ToString()
        {
            return this.name + " ("+this.width+"x"+this.height+")";
        }

        public static Terrain loadTerrain(String fileName)
        {
            Terrain terrain = null;
            List<String> lines;
            int width;
            try
            {
                StreamReader sr = new StreamReader(File.Open(fileName, FileMode.Open));
                string line = sr.ReadLine();
                if (line != null)
                {
                    width = line.Length;
                    lines = new List<String>();
                    lines.Add(line);
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (width != line.Length)
                        {
                            throw new InvalidMapFileException(fileName, "Not all line have the same width (first line width: " + width + ", invalid width: " + line.Length + ")!");
                        }
                        lines.Add(line);
                    }
                }
                else
                {
                    throw new InvalidMapFileException(fileName, "File is empty!");
                }
                sr.Close();
            }
            catch (Exception e)
            {
                throw new InvalidMapFileException(fileName, e.Message, e);
            }
            if (lines != null)
            {
                terrain = Terrain.parseTerrain(fileName, width, lines);
            }
            return terrain;
        }

        private static Terrain parseTerrain(String fileName, int width, List<String> lines)
        {
            bool[,] map = new bool[lines.Count, width];
            Position start = null;
            Position goal = null;
            int i = 0;
            foreach (String line in lines)
            {
                int j = 0;
                foreach (char c in line)
                {
                    map[i,j] = Terrain.isField(c);
                    if (c == Terrain.START)
                    {
                        start = new Position(i, j);
                    }
                    else if (c == Terrain.GOAL)
                    {
                        goal = new Position(i, j);
                    }
                    j++;
                }
                i++;
            }
            if ((start != null) && (goal != null))
            {
                return new Terrain(Path.GetFileNameWithoutExtension(fileName), map, start, goal);
            }
            else
            {
                throw new InvalidMapFileException(fileName, "There is no start and/or goal position in file.");
            }
        }

        private static bool isField(char c)
        {
            return c == Terrain.FIELD || c == Terrain.START || c == Terrain.GOAL;
        }


    }
}
