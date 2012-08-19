using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOPEvent
{
    public class TestValueEventHandler : IValueChange
    {
        public void onChange(Object sender, Int32 value)
        {
            String senderText = "";
            if (sender is Form)
            {
                senderText = (sender as Form).Text;
            }
            MessageBox.Show("Value is changed. New value: " + value + " (sender: " + senderText + ")");
        }
    }
}
