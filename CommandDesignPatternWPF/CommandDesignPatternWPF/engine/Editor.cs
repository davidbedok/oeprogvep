using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public class Editor : IEditor
    {

        private IEditorHistory history;       
 
        public Editor()
        {
            this.history = new EditorHistory();
        }

        public void drawShape(Graphics imgGra, CDPShape shape)
        {
            this.history.addCommand(imgGra, new DrawCommand(shape));
        }

        public void changeColor(Graphics imgGra, CDPShape shape, Color newColor)
        {
            this.history.addCommand(imgGra, new ChangeColorCommand(shape, newColor));
        }

        public void moveShape(Graphics imgGra, CDPShape shape, MoveType moveType, float param)
        {
            this.history.addCommand(imgGra, new MoveCommand(shape, moveType, param));
        }

        public void undo(Graphics imgGra)
        {
            this.history.undo(imgGra);
        }

        public void redo(Graphics imgGra)
        {
            this.history.redo(imgGra);
        }

    }
}
