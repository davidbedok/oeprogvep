using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TimerApp
{

    public class Ball
    {
        private const int MIN_RADIUS = 5;
        private const int MAX_RADIUS = 15;
        private const int MIN_SPEED = 5;
        private const int MAX_SPEED = 15;

        private readonly Frame frame;
        private readonly Pen pen;
        private readonly float jumpSpeed;
        private readonly float radius;

        private float x;
        private float y;

        private MoveType xmt;
        private MoveType ymt;

        private float X
        {
            set
            {
                if (value < this.frame.Width - radius * 2 - 2)
                {
                    if (value > 0)
                    {
                        x = value;
                    }
                    else
                    {
                        xmt = MoveType.Down;
                    }
                }
                else
                {
                    xmt = MoveType.Up;
                }
            }
        }

        private float Y
        {
            set
            {
                if (value < this.frame.Height - radius * 2 - 2)
                {
                    if (value > 0)
                    {
                        y = value;
                    }
                    else
                    {
                        ymt = MoveType.Down;
                    }
                }
                else
                {
                    ymt = MoveType.Up;
                }
            }
        }

        public Ball(Color color, PointF point, float jumpSpeed, float radius, Frame frame, Direction direction)
        {
            this.pen = new Pen(color);
            this.frame = frame;
            this.x = point.X;
            this.y = point.Y;
            this.jumpSpeed = jumpSpeed;
            this.radius = radius;

            switch (direction)
            {
                case Direction.DOWN:
                    xmt = MoveType.Down;
                    ymt = MoveType.Down;
                    break;
                case Direction.LEFT:
                    xmt = MoveType.Up;
                    ymt = MoveType.Down;
                    break;
                case Direction.RIGHT:
                    xmt = MoveType.Down;
                    ymt = MoveType.Up;
                    break;
                case Direction.UP:
                    xmt = MoveType.Up;
                    ymt = MoveType.Up;
                    break;
            }
        }

        public void jump(Graphics graphics)
        {
            this.erase(graphics);
            this.jump();
            this.draw(graphics);
        }

        private void erase(Graphics graphics)
        {
            graphics.DrawEllipse(this.frame.ErasePen, this.x, this.y, this.radius * 2, this.radius * 2);
        }

        private void jump()
        {
            if (xmt == MoveType.Down)
            {
                this.X = this.x + this.jumpSpeed;
            }
            else
            {
                this.X = this.x - this.jumpSpeed;
            }
            if (ymt == MoveType.Down)
            {
                this.Y = this.y + this.jumpSpeed;
            }
            else
            {
                this.Y = this.y - this.jumpSpeed;
            }
        }

        private void draw(Graphics graphics)
        {
            graphics.DrawEllipse(this.pen, this.x, this.y, this.radius * 2, this.radius * 2);
        }

        public static Color getRandColor(Random rand)
        {
            return Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }

        public static int getRandJumpSpeed(Random rand)
        {
            return rand.Next(Ball.MIN_SPEED, Ball.MAX_SPEED);
        }

        public static int getRandRadius(Random rand)
        {
            return rand.Next(Ball.MIN_RADIUS, Ball.MAX_RADIUS);
        }

    }
}
