using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QTetris
{
    public class FallItemState : System.Object
    {
        private FallItemStateRow[] state;
        private byte columnSize;
        
        public FallItemStateRow this[int columnIndex]
        {
            set
            {
                state[columnIndex] = value;
            }
            get
            {
                return state[columnIndex];
            }
        }

        public byte ColumnSize
        {
            get {
                return columnSize; 
            }
        }

        public FallItemState( byte columnSize )
        {
            this.columnSize = columnSize;
            state = new FallItemStateRow[columnSize];
        }

        public void print()
        {
            System.Console.WriteLine("FallItemState PRINT");
            for (int i = 0; i < this.ColumnSize; i++)
            {
                for (int j = 0; j < this.state[i].RowSize; j++)
                {
                    System.Console.Write((this.state[i][j] == 1 ? 'X' : 'O'));
                }
                System.Console.WriteLine();
            }
        }

    }
}
