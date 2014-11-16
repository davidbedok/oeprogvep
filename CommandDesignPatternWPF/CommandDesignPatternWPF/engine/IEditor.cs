using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace CommandDesignPatternWPF
{
    public interface IEditor
    {
        void drawImage();

        void draw(IShape shape);
        void changeColor(IShape shape, Color newColor);
        void move(IShape shape, MoveType moveType, double param);

        void undo();
        void redo();
    }
}
