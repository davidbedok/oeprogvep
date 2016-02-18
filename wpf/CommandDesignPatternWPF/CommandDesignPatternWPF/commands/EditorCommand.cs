using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF.commands
{
    public interface EditorCommand
    {
        void process();
        void undo();
    }
}
