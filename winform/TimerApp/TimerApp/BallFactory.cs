using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimerApp
{
    public class BallFactory
    {
        private readonly Random rand;
        private readonly Frame frame;

        public BallFactory(Random rand, Frame frame)
        {
            this.rand = rand;
            this.frame = frame;
        }

        public Ball createBall(float jumpSpeed, float radius)
        {
            return new Ball(Ball.getRandColor(this.rand), this.frame.getMiddlePoint(), jumpSpeed, radius, this.frame, DirectionExtensions.randomDirection(this.rand));
        }

        public Ball createBall()
        {
            return new Ball(Ball.getRandColor(rand), this.frame.getRandomPoint(), Ball.getRandJumpSpeed(this.rand), Ball.getRandRadius(this.rand), this.frame, DirectionExtensions.randomDirection(rand));
        }

    }
}
