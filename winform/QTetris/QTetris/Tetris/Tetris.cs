using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace QTetris
{
    public delegate void TetrisNotifyhandler ( LevelItem param ); 

    public class Tetris : System.Object
    {
        // FallItem speed if User fire
        public const int MAX_SPEED_VALUE = 10;

        // Jump to next Level if reached
        public const int MAX_LEVEL_ROW_POINT = 10;
       
        public readonly int MAPSIZE_X;
        public readonly int MAPSIZE_Y;

        // calculate from MAPSIZE
        private readonly float LEGOSIZE_WIDTH;
        private readonly float LEGOSIZE_HEIGHT;

        private TetrisLego[][] map;
        private FallItem fallItem;
        private FallItem nextFallItem;
        private LevelItem startLevelItem;
        private LevelItem actLevelItem;
        private int actLevelRowPoints;
        private int points;
        private bool isDraw;

        public event TetrisNotifyhandler changeLevel;

        public int ActLevelRowPoints
        {
            get { return this.actLevelRowPoints; }
        }

        public LevelItem StartLevelItem
        {
            get { return startLevelItem; }
            set { startLevelItem = value; }
        }

        public LevelItem ActLevelItem
        {
            get { return actLevelItem; }
            set { actLevelItem = value; }
        }

        public int Points
        {
            get { return this.points; }
        }

        public bool IsDraw
        {
            get
            {
                return this.isDraw;
            }
            set
            {
                this.isDraw = value;
            }
        }

        public Tetris(int mapsize_x, int mapsize_y, int picture_width, int picture_height, LevelItem startLevelItem)
        {
            this.MAPSIZE_X = mapsize_x;
            this.MAPSIZE_Y = mapsize_y;

            this.LEGOSIZE_WIDTH = (float)(picture_width / mapsize_x);
            this.LEGOSIZE_HEIGHT = (float)(picture_height / mapsize_y);

            map = new TetrisLego[this.MAPSIZE_X][];
            for (int i = 0; i < this.MAPSIZE_X; i++)
            {
                map[i] = new TetrisLego[this.MAPSIZE_Y];
            }
            initMap();
            this.isDraw = true;
            this.points = 0;
            this.startLevelItem = startLevelItem;
            this.actLevelItem = startLevelItem;
        }

        public void createNewFallItem( Random rand )
        {
            if (nextFallItem == null)
            {
                nextFallItem = FallItem.getNewFallItem(rand, this.MAPSIZE_X);
            }
            fallItem = nextFallItem;
            nextFallItem = FallItem.getNewFallItem(rand,this.MAPSIZE_X);
        }

        public void initMap (){
            for (int i = 0; i < this.MAPSIZE_X; i++){
                for (int j = 0; j < this.MAPSIZE_Y; j++){
                    map[i][j] = new TetrisLego( this.LEGOSIZE_WIDTH, this.LEGOSIZE_HEIGHT );
                }
            }
        }

        public void draw( Graphics g )
        {
            for (int i = 0; i < this.MAPSIZE_X; i++)
            {
                for (int j = 0; j < this.MAPSIZE_Y; j++)
                {
                    map[i][j].draw(g, i, j);
                }
            }

            if (fallItem != null)
            {
                try
                {
                    for (int i = 0; i < fallItem.StateWindowMaxColumn; i++)
                    {
                        for (int j = 0; j < fallItem.StateWindowMaxRow; j++)
                        {
                            if (fallItem.isLego(i, j))
                            {
                                if (map[fallItem.X + j][fallItem.Y + i].IsEmpty)
                                {
                                    map[fallItem.X + j][fallItem.Y + i].draw(g, fallItem.ItemColor, (fallItem.X + j), (fallItem.Y + i));
                                }
                                else
                                {
                                    System.Console.WriteLine("drawMap NotSupportedDrawException ");
                                    throw new NotSupportedDrawException();
                                }
                            }
                        }
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    System.Console.WriteLine("drawMap"+e.Message);
                    throw new NotSupportedDrawException();
                }
            }
        }

        public void fixItem()
        {
            if (fallItem != null)
            {
                if (fallItem.Y > 1)
                {
                    for (int i = 0; i < fallItem.StateWindowMaxColumn; i++)
                    {
                        for (int j = 0; j < fallItem.StateWindowMaxRow; j++)
                        {
                            if (fallItem.isLego(i, j))
                            {
                                map[fallItem.X + j][fallItem.Y + i] = new TetrisLego(fallItem.ItemColor, this.LEGOSIZE_WIDTH, this.LEGOSIZE_HEIGHT);
                            }
                        }
                    }
                }
                else
                {
                    throw new EndOfGameException();
                }
            }
            this.checkRow();
        }

        public void fall()
        {
            fallItem.fall();
            try
            {
                this.validateFallItem();
            }
            catch (NotSupportedMoveException e)
            {
                System.Console.WriteLine("fall() " + e.Message);
                fallItem.undoFall();
                throw new BlockException();
            }
        }

        public void left()
        {
            fallItem.left();
            try
            {
                this.validateFallItem();
            }
            catch (NotSupportedMoveException e)
            {
                System.Console.WriteLine("left() " + e.Message);
                fallItem.right();
            }
        }

        public void right()
        {
            fallItem.right();
            try
            {
                this.validateFallItem();
            }
            catch (NotSupportedMoveException e)
            {
                System.Console.WriteLine("right() " + e.Message);
                fallItem.left();
            }           
        }

        public void rotate()
        {
            // this.printInfo("BEFORE ROTATE");
            fallItem.rotate();
            try
            {
                this.validateFallItem();
            }
            catch (NotSupportedMoveException e)
            {
                System.Console.WriteLine("rotate() "+e.Message);
                fallItem.undoRotate();
            }
            // this.printInfo("AFTER ROTATE");
        }

        private void validateFallItem(){
            if (fallItem != null)
            {
                try
                {
                    for (int i = 0; i < fallItem.StateWindowMaxColumn; i++)
                    {
                        for (int j = 0; j < fallItem.StateWindowMaxRow; j++)
                        {
                            if (fallItem.isLego(i, j))
                            {
                                if (!map[fallItem.X + j][fallItem.Y + i].IsEmpty) {
                                    System.Console.WriteLine("validateFallItem() - NotSupportedMoveException");
                                    throw new NotSupportedMoveException();
                                }
                            }
                        }
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    System.Console.WriteLine("validateFallItem() " + e.Message);
                    throw new NotSupportedMoveException();
                }
            }
        }

        private void checkRow()
        {
            int legoNumberInRow;
            for (int i = 0; i < this.MAPSIZE_Y; i++)
            {
                legoNumberInRow = 0;
                for (int j = 0; j < this.MAPSIZE_X; j++)
                {
                    if (!map[j][i].IsEmpty)
                    {
                        ++legoNumberInRow;
                    } 
                }
                if (legoNumberInRow == this.MAPSIZE_X)
                {
                    this.eraseRow(i);
                }
            }
        }

        private void addPoints()
        {
            this.points += this.actLevelItem.Point;
            this.actLevelRowPoints++;
            if (this.actLevelRowPoints >= Tetris.MAX_LEVEL_ROW_POINT)
            {
                this.actLevelItem = Level.jumpLevel(this.actLevelItem);
                this.actLevelRowPoints = 0;
                if (this.changeLevel != null)
                {
                    this.changeLevel(this.actLevelItem);
                }
            }
        }

        private void eraseRow( int row )
        {
            for (int i = row; i > 0; i--){
                for (int j = 0; j < this.MAPSIZE_X; j++){
                    map[j][i] = map[j][i-1];
                }
            }
            this.addPoints();
        }

        public void drawFallItem(Graphics g)
        {
            this.nextFallItem.drawItem(g);
        }

       

    }
}
