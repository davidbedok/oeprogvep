using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public interface EditorCommand
    {
        void process(Graphics imgGra);
        void undo(Graphics imgGra);
    }
}
