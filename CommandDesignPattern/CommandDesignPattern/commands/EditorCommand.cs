using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPattern
{
    public interface EditorCommand
    {
        void process(Graphics imgGra);
        void undo(Graphics imgGra);
    }
}
