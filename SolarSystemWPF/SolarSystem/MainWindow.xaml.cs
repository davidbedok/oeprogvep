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
    public partial class MainWindow : Window
    {
        private const String PLANETS_DATA_INPUT_FILE = "planets.txt";
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
            this.solarSystem = SolarSystem.parse(PLANETS_DATA_INPUT_FILE, this.spaceCanvas.ActualWidth, this.spaceCanvas.ActualHeight);
            this.image.Source = this.solarSystem.drawOrbits();
            foreach (Planet planet in this.solarSystem.Planets)
            {
                this.spaceCanvas.Children.Add(planet.buildPlanet());
                Label meta = planet.buildMeta();
                if (meta != null)
                {
                    this.spaceCanvas.Children.Add(meta);
                }
            }
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            this.solarSystem.Move(20);
        }

    }
}
