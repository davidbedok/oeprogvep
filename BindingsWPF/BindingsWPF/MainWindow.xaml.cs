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
			Binding binding = new Binding("SelectedItem");
			binding.Source = this.lbCars;
			this.gCar.SetBinding(ListBox.SelectedItemProperty, binding);
		}

		private void bChangeRover_Click(object sender, RoutedEventArgs e)
		{
			this.rover.EngineCapacity++;

			this.lbCars.Items.Refresh();

			// workaround..
			Car currectCar = (Car) this.lbCars.SelectedItem;
			this.lbCars.SelectedItem = null;
			this.lbCars.SelectedItem = currectCar;
		}
	}
}
