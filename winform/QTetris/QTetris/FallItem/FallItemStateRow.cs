using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QTetris
{
    public class FallItemStateRow : System.Object
    {
        private byte[] stateRow;
        private byte rowSize;

        public byte this[int rowIndex]
        {
            set
            {
                stateRow[rowIndex] = value;
            }
            get
            {
                return stateRow[rowIndex];
            }
        }

        public byte RowSize
        {
            get
            {
                return rowSize;
            }
        }

        public FallItemStateRow(params byte[] stateRow)
        {
            this.rowSize = Convert.ToByte(stateRow.Length);
            this.stateRow = new byte[rowSize];
            this.stateRow = stateRow;
        }

    }
}
