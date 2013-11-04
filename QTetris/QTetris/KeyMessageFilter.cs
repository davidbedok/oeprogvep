using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QTetris
{
    class KeyMessageFilter : IMessageFilter
    {

        Tetris tetris;
        Timer fallTimer;

        public void setTetris(Tetris tetris, Timer fallTimer)
        {
            this.tetris = tetris;
            this.fallTimer = fallTimer;
        }

       
        
            public bool PreFilterMessage(ref Message m)
            {
                bool ret = false;
                switch (m.Msg)
                {
                    case (int)WindowsMessages.WM_KEYDOWN:

                        if (m.WParam != null)
                        {
                            switch (m.WParam.ToInt32())
                            {
                                case 37:
                                    Console.WriteLine("Left");
                                    if ((tetris != null) && (tetris.IsDraw))
                                    {
                                        tetris.left();
                                    } 
                                    ret = true;
                                    break;
                                case 38:
                                    Console.WriteLine("Up");
                                    if ((tetris != null) && (tetris.IsDraw))
                                    {
                                        tetris.rotate();
                                    }
                                    ret = true;
                                    break;
                                case 39:
                                    Console.WriteLine("Right");
                                    if ( (tetris != null) && (tetris.IsDraw) )
                                    {
                                        tetris.right();
                                    } 
                                    ret = true;
                                    break;
                                case 40:
                                    Console.WriteLine("Down");
                                    if ( (fallTimer != null) && (tetris != null) )
                                    {
                                        tetris.IsDraw = false;
                                        fallTimer.Interval = Tetris.MAX_SPEED_VALUE;
                                    }
                                    ret = true;
                                    break;
                            }
                        }
                        // Console.WriteLine("Processing the messages : " + m.Msg);
                        // Console.WriteLine("Processing the messages WPARAM : " + m.WParam.ToString());
                        // Console.WriteLine("Processing the messages LPARAM : " + m.LParam.ToString());
                        break;
                }
                return ret;
            }
        

    }
}
