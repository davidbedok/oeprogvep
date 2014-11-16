using CommandDesignPatternWPF.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace CommandDesignPatternWPF.engine
{
    public interface IEditor
    {
        void drawImage();

        void draw(IShape shape);
        void changePenWidth(IShape shape, double width);
        void changeColor(IShape shape, ColorType type, Nullable<Color> color);
        void move(IShape shape, MoveType moveType, double param);

        void undo();
        void redo();
    }
}
