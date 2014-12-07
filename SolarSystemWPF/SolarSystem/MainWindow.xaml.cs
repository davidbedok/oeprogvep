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
using System.Windows.Threading;
using System.IO;

namespace SolarSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private Planet planet;
        private SolSystem solar;

        public MainWindow()
        {
            InitializeComponent();
            this.solar = SolSystem.parse("planets.txt");
            timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            timer.Tick += Timer_Tick;
            timer.Stop();            
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            // Teszt bolygó
            // this.planet = new Planet("Bolygó1", 58, 88, 54, 2439);
            // this.spaceCanvas.Children.Add(planet.Build());

            foreach (Planet planet in this.solar.Planets )
            {
                this.spaceCanvas.Children.Add(planet.buildPlanet());
                this.spaceCanvas.Children.Add(planet.buildMeta());
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // this.planet.Move(1);

            this.solar.Move(20);
        }

        private void Button_Start(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Button_Stop(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Button_Kilep(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
