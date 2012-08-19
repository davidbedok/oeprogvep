using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPattern
{
    public interface IEditor
    {
        void drawShape(Graphics imgGra, Shape shape);
        void changeColor(Graphics imgGra, Shape shape, Color newColor);
        void moveShape(Graphics imgGra, Shape shape, MoveType moveType, float param);
        void undo(Graphics imgGra);
        void redo(Graphics imgGra);
    }
}
