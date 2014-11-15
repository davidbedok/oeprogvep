using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public class EditorHistory : IEditorHistory
    {

        private Stack<EditorCommand> history;
        private Stack<EditorCommand> redoStack;

        public EditorHistory()
        {
            this.history = new Stack<EditorCommand>();
            this.redoStack = new Stack<EditorCommand>();
        }

        public void addCommand(Graphics imgGra, EditorCommand command)
        {
            this.history.Push(command);
            command.process(imgGra);
        }

        public void undo(Graphics imgGra)
        {
            if (this.history.Count > 0)
            {
                EditorCommand command = this.history.Pop();
                command.undo(imgGra);
                this.redoStack.Push(command);
            }
        }

        public void redo(Graphics imgGra)
        {
            if (this.redoStack.Count > 0)
            {
                EditorCommand command = this.redoStack.Pop();
                command.process(imgGra);
                this.history.Push(command);
            }
        }

    }
}
