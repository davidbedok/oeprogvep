using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Bloxorz
{
    public class Block
    {
        // test commit

        private Position b1;
        private Position b2;

        public Position B1
        {
            get { return this.b1; }
        }

        public Position B2
        {
            get { return this.b2; }
        }

        public Block(Position b1, Position b2)
        {
            this.b1 = b1;
            this.b2 = b2;
            if ((b1.X > b2.X) || (b1.Y > b2.Y))
            {
                throw new InvalidArgumentException("b2 is 'smaller' then b1");
            }
        }

        public Block dx(int d1, int d2)
        {
            return new Block(b1.dx(d1), b2.dx(d2));
        }

        public Block dy(int d1, int d2)
        {
            return new Block(b1.dy(d1), b2.dy(d2));
        }

        public bool isStanding()
        {
            return b1.X == b2.X && b1.Y == b2.Y;
        }

        public Block left()
        {
            if (this.isStanding()) return this.dy(-2, -1);
            else if (b1.X == b2.X) return this.dy(-1, -2);
            else return this.dy(-1, -1);
        }

        public Block right()
        {
            if (this.isStanding()) return this.dy(1, 2);
            else if (b1.X == b2.X) return this.dy(2, 1);
            else return this.dy(1, 1);
        }

        public Block up()
        {
            if (this.isStanding()) return this.dx(-2, -1);
            else if (b1.X == b2.X) return this.dx(-1, -1);
            else return this.dx(-1, -2);
        }

        public Block down()
        {
            if (this.isStanding()) return this.dx(1, 2);
            else if (b1.X == b2.X) return this.dx(1, 1);
            else return this.dx(2, 1);
        }

        public List<Tuple<Block, Move>> neighbors()
        {
            List<Tuple<Block, Move>> result = new List<Tuple<Block, Move>>();
            result.Add(new Tuple<Block, Move>(this.left(), Move.Left));
            result.Add(new Tuple<Block, Move>(this.right(), Move.Right));
            result.Add(new Tuple<Block, Move>(this.up(), Move.Up));
            result.Add(new Tuple<Block, Move>(this.down(), Move.Down));
            return result;
        }

        public List<Tuple<Block, Move>> legalNeighbors(Terrain terrain)
        {
            return this.neighbors().Where(item => terrain.isLegalBlock(item.Item1)).ToList();
        }

        public void draw(Graphics g, float unit, bool isNeighbor)
        {
            this.b1.drawBlock(g, unit, isNeighbor);
            if (!this.isStanding())
            {
                this.b2.drawBlock(g, unit, isNeighbor);
            }
        }

        public override string ToString()
        {
            return "["+this.b1 + " " + this.b2 +"]";
        }

    }
}
