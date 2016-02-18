using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bloxorz
{
    public delegate void CustomKeyHandler(Move move);

    public class KeyMessageFilter : IMessageFilter
    {

        public event CustomKeyHandler keyPressed;

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
                                // Console.WriteLine("Left");
                                if (this.keyPressed != null)
                                {
                                    this.keyPressed(Move.Left);
                                }
                                ret = true;
                                break;
                            case 38:
                                // Console.WriteLine("Up");
                                if (this.keyPressed != null)
                                {
                                    this.keyPressed(Move.Up);
                                }
                                ret = true;
                                break;
                            case 39:
                                // Console.WriteLine("Right");
                                if (this.keyPressed != null)
                                {
                                    this.keyPressed(Move.Right);
                                }
                                ret = true;
                                break;
                            case 40:
                                // Console.WriteLine("Down");
                                if (this.keyPressed != null)
                                {
                                    this.keyPressed(Move.Down);
                                }
                                ret = true;
                                break;
                        }
                    }
                    break;
            }
            return ret;
        }


    }
}
