using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public interface IEditor
    {
        void drawShape(Graphics imgGra, CDPShape shape);
        void changeColor(Graphics imgGra, CDPShape shape, Color newColor);
        void moveShape(Graphics imgGra, CDPShape shape, MoveType moveType, float param);
        void undo(Graphics imgGra);
        void redo(Graphics imgGra);
    }
}
