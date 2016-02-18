using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CalculatorForm : Window
    {

        private const int START_LEFT = 20;
        private const int START_TOP = 20;
        private const int BUTTON_PADDING = 40;
        private const int BUTTON_SIZE = 35;

        public CalculatorForm()
        {
            InitializeComponent();

            int number = 1; 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    double left = CalculatorForm.START_LEFT + j * CalculatorForm.BUTTON_PADDING;
                    double top = CalculatorForm.START_TOP + i * CalculatorForm.BUTTON_PADDING;              
                    button.Margin = new Thickness(left, top, 0, 0);
                    button.Height = CalculatorForm.BUTTON_SIZE;
                    button.Width = CalculatorForm.BUTTON_SIZE;
                    button.Name = "bNumber" + number.ToString();
                    button.TabIndex = number;
                    button.Tag = number;
                    
                    button.Content = number.ToString();
                    button.Click += numbersOnClick;
                    this.buttonCanvas.Children.Add(button);
                    number++;
                }
            }
            number = 0;
            Button buttonZero = new Button();
            double leftZero = CalculatorForm.START_LEFT + 1 * CalculatorForm.BUTTON_PADDING;
            double topZero = CalculatorForm.START_TOP + 3 * CalculatorForm.BUTTON_PADDING;
            buttonZero.Margin = new Thickness(leftZero, topZero, 0, 0);
            buttonZero.Height = CalculatorForm.BUTTON_SIZE;
            buttonZero.Width = CalculatorForm.BUTTON_SIZE;
            buttonZero.Name = "bNumber" + number.ToString();
            buttonZero.TabIndex = number;
            buttonZero.Tag = number;
            buttonZero.Content = number.ToString();
            buttonZero.Click += numbersOnClick;
            this.buttonCanvas.Children.Add(buttonZero);
        }

        private void numbersOnClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                if (button.Tag != null && button.Tag is Int32)
                {
                    Int32 tag = (Int32)button.Tag;
                    this.tbCalculator.Text += tag;
                }
            }
        }

    }
}
