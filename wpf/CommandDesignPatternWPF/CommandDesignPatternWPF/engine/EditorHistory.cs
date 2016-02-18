using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using CommandDesignPatternWPF.commands;

namespace CommandDesignPatternWPF.engine
{
    public class EditorHistory : IEditorHistory, INotifyPropertyChanged
    {

        private Stack<EditorCommand> history;
        private Stack<EditorCommand> redoStack;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Count
        {
            get { return this.history.Count; }
        }

        public EditorHistory()
        {
            this.history = new Stack<EditorCommand>();
            this.redoStack = new Stack<EditorCommand>();
        }

        public void addCommand(EditorCommand command)
        {
            this.history.Push(command);
            command.process();
            this.onPropertyChange("Count");
        }

        public void undo()
        {
            if (this.history.Count > 0)
            {
                EditorCommand command = this.history.Pop();
                command.undo();
                this.redoStack.Push(command);
                this.onPropertyChange("Count");
            }
        }

        public void redo()
        {
            if (this.redoStack.Count > 0)
            {
                EditorCommand command = this.redoStack.Pop();
                command.process();
                this.history.Push(command);
                this.onPropertyChange("Count");
            }
        }

        private void onPropertyChange(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
