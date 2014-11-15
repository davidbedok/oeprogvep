using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public interface IEditorHistory
    {
        void addCommand(Graphics imgGra, EditorCommand command);
        void undo(Graphics imgGra);
        void redo(Graphics imgGra);
    }
}
