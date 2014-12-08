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

namespace SolarSystemWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private SolarSystem solarSystem;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            timer.Tick += timerTick;
            timer.Stop();
        }

        private void windowLoaded(object sender, RoutedEventArgs e)
        {
            this.solarSystem = SolarSystem.parse("planets.txt", this.ActualWidth, this.ActualHeight);
            foreach (Planet planet in this.solarSystem.Planets)
            {
                this.spaceCanvas.Children.Add(planet.buildPlanet());
                this.spaceCanvas.Children.Add(planet.buildMeta());
            }
            this.image.Source = this.solarSystem.getOrbits();
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            this.solarSystem.Move(20);
        }

    }
}
