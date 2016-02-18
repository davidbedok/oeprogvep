using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSLogoApplication
{
    public class ConvertHelper
    {

        public static float parseFloat(TextBox textBox)
        {
            float result = 0;
            if (textBox != null)
            {
                try
                {
                    result = Single.Parse(textBox.Text);
                }
                catch (FormatException e)
                {
                    //
                }
                catch (OverflowException e)
                {
                    //
                }
            }
            return result;
        }

        public static int parseInt(TextBox textBox)
        {
            int result = 0;
            if (textBox != null)
            {
                try
                {
                    result = Int32.Parse(textBox.Text);
                }
                catch (FormatException e)
                {
                    //
                }
                catch (OverflowException e)
                {
                    //
                }
            }
            return result;
        }

    }
}
