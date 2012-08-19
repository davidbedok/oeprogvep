using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPattern
{
    public class MoveCommand : EditorCommand
    {

        private Shape shape;
        private MoveType moveType;
        private float param;

        public MoveCommand(Shape shape, MoveType moveType, float param)
        {
            this.shape = shape;
            this.moveType = moveType;
            this.param = param;
        }

        public void process(Graphics imgGra)
        {
            shape.erase(imgGra);
            this.changeReferencePoint(param);
            shape.draw(imgGra);
        }

        private void changeReferencePoint( float param )
        {
            switch (this.moveType)
            {
                case MoveType.LEFT:
                    this.shape.ReferencePoint = new PointF(this.shape.ReferencePoint.X - param, this.shape.ReferencePoint.Y);
                    break;
                case MoveType.UP:
                    this.shape.ReferencePoint = new PointF(this.shape.ReferencePoint.X, this.shape.ReferencePoint.Y - param);
                    break;
                case MoveType.DOWN:
                    this.shape.ReferencePoint = new PointF(this.shape.ReferencePoint.X, this.shape.ReferencePoint.Y + param);
                    break;
                case MoveType.RIGHT:
                    this.shape.ReferencePoint = new PointF(this.shape.ReferencePoint.X + param, this.shape.ReferencePoint.Y);
                    break;
            }
        }

        public void undo(Graphics imgGra)
        {
            shape.erase(imgGra);
            this.changeReferencePoint(param * -1);
            shape.draw(imgGra);
        }

    }
}
