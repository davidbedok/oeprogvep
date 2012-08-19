using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace QTetris
{
    public class FallItemZMirror : FallItem
    {

        public FallItemZMirror(Color color, int pos_x, int pos_y, byte actualState)
            : base(color, pos_x, pos_y, actualState )
        {
            byte stateWindowMax = 3;

            this.states[0] = new FallItemState(stateWindowMax);
            this.states[0][0] = new FallItemStateRow(0, 1, 0);
            this.states[0][1] = new FallItemStateRow(1, 1, 0);
            this.states[0][2] = new FallItemStateRow(1, 0, 0);


            this.states[1] = new FallItemState(stateWindowMax);
            this.states[1][0] = new FallItemStateRow(1, 1, 0);
            this.states[1][1] = new FallItemStateRow(0, 1, 1);
            this.states[1][2] = new FallItemStateRow(0, 0, 0);

            this.states[2] = new FallItemState(stateWindowMax);
            this.states[2][0] = new FallItemStateRow(0, 1, 0);
            this.states[2][1] = new FallItemStateRow(1, 1, 0);
            this.states[2][2] = new FallItemStateRow(1, 0, 0);

            this.states[3] = new FallItemState(stateWindowMax);
            this.states[3][0] = new FallItemStateRow(1, 1, 0);
            this.states[3][1] = new FallItemStateRow(0, 1, 1);
            this.states[3][2] = new FallItemStateRow(0, 0, 0);
        }

    }
}
