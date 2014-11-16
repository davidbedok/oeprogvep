using CommandDesignPatternWPF.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CommandDesignPatternWPF
{
    public class MoveCommand : Command
    {

        private MoveType moveType;
        private double param;

        public MoveCommand(List<IShape> shapes, IShape shape, MoveType moveType, double param) : base(shapes, shape)
        {
            this.moveType = moveType;
            this.param = param;
        }

        public override void process()
        {
            this.changeReferencePoint(param);
        }

        private void changeReferencePoint( double param )
        {
            switch (this.moveType)
            {
                case MoveType.LEFT:
                    this.shape.ReferencePoint = new Point(this.shape.ReferencePoint.X - param, this.shape.ReferencePoint.Y);
                    break;
                case MoveType.UP:
                    this.shape.ReferencePoint = new Point(this.shape.ReferencePoint.X, this.shape.ReferencePoint.Y - param);
                    break;
                case MoveType.DOWN:
                    this.shape.ReferencePoint = new Point(this.shape.ReferencePoint.X, this.shape.ReferencePoint.Y + param);
                    break;
                case MoveType.RIGHT:
                    this.shape.ReferencePoint = new Point(this.shape.ReferencePoint.X + param, this.shape.ReferencePoint.Y);
                    break;
            }
        }

        public override void undo()
        {
            this.changeReferencePoint(param * -1);
        }

    }
}
