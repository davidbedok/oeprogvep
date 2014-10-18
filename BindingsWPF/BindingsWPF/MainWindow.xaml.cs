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

namespace BindingsWPF
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car toyota;
        private Car rover;

        public MainWindow()
        {
            this.toyota = new Car(Brand.TOYOTA, "Verso", 148);
            this.rover = new Car(Brand.ROVER, "45i", 110);
            InitializeComponent();
            this.lbCars.Items.Add(this.toyota);
            this.lbCars.Items.Add(this.rover);

            this.wpCar.DataContext = this.rover;

            // Binding from code
            Binding binding = new Binding("Value");
            binding.Source = this.sWithBinding;
            binding.Converter = new SliderValueConverter();
            this.lBindInCode.SetBinding(Label.ContentProperty, binding);
        }

        private void bChangeRover_Click(object sender, RoutedEventArgs e)
        {
            this.rover.EngineCapacity++;

            this.lbCars.Items.Refresh();
        }


        private void generalWay_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // general way (reusable event handler)
            if (this.lWithoutBinding != null)
            {
                if (sender is Slider)
                {
                    Slider slider = (Slider)sender;
                    this.lWithoutBinding.Content = Math.Round(slider.Value, 0);
                }
            }
        }

        private void useEventArgs_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // use the EventArgs argument to get the slider value
            if (this.lWithoutBinding != null)
            {
                this.lWithoutBinding.Content = Math.Round(e.NewValue, 0);
            }
        }

        private void argumentIndependent_ValueChanged3(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // argument independent
            if (this.lWithoutBinding != null)
            {
                this.lWithoutBinding.Content = Math.Round(this.sWithoutBinding.Value, 0);
            }
        }
    }
}
