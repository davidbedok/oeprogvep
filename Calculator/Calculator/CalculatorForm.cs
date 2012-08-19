using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {

        private const int START_LEFT = 20;
        private const int START_TOP = 20;
        private const int BUTTON_PADDING = 40;
        private const int BUTTON_SIZE = 35;
        
        public CalculatorForm()
        {
            InitializeComponent();
            int number = 1;
            for (int i = 0; i < 3; i++ )
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(CalculatorForm.START_LEFT + j * CalculatorForm.BUTTON_PADDING, CalculatorForm.START_TOP + i * CalculatorForm.BUTTON_PADDING);
                    button.Name = "bNumber" + number.ToString();
                    button.Size = new Size(CalculatorForm.BUTTON_SIZE, CalculatorForm.BUTTON_SIZE);
                    button.TabIndex = number;
                    button.Tag = number;
                    button.Text = "&" + number.ToString();
                    button.Click += new EventHandler(numbersOnClick);
                    this.Controls.Add(button);
                    number++;
                }
            }
            number = 0;
            Button buttonZero = new Button();
            buttonZero.Location = new Point(CalculatorForm.START_LEFT + 1 * CalculatorForm.BUTTON_PADDING, CalculatorForm.START_TOP + 3 * CalculatorForm.BUTTON_PADDING);
            buttonZero.Name = "bNumber" + number.ToString();
            buttonZero.Size = new Size(CalculatorForm.BUTTON_SIZE, CalculatorForm.BUTTON_SIZE);
            buttonZero.TabIndex = number;
            buttonZero.Tag = number;
            buttonZero.Text = number.ToString();
            buttonZero.Click += new EventHandler(numbersOnClick);
            this.Controls.Add(buttonZero);

        }

        private void numbersOnClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                if (button.Tag != null && button.Tag is Int32)
                {
                    Int32 tag = (Int32)button.Tag;
                    tbCalculator.Text += tag;
                }
            }
        }

    }
}
