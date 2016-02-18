using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CommandDesignPatternWPF.commands;

namespace CommandDesignPatternWPF.engine
{
    public interface IEditorHistory
    {
        int Count { get; }

        void addCommand(EditorCommand command);
        void undo();
        void redo();
    }
}
