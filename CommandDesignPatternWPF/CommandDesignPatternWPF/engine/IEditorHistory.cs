using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public interface IEditorHistory
    {
        void addCommand(EditorCommand command);
        void undo();
        void redo();
    }
}
