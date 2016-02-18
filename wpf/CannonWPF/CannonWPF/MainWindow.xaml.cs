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

namespace CannonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random;
        private Cannon cannon;
        private List<Bullet> bullets;

        private readonly DispatcherTimer timer;

        public MainWindow()
        {
            this.random = new Random();
            InitializeComponent();
            this.cannon = new Cannon(320, 240, 40);
            this.bullets = new List<Bullet>();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            timer.Tick += timerTick;
            timer.Stop();
        }

        private void timerTick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.bullets.Count; i++)
            {
                this.bullets[i].move();
            }
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            this.canvas.Children.Add(this.cannon.build());
            timer.Start();
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                this.cannon.Angle -= 5;
            }
            else if (e.Key == Key.Right)
            {
                this.cannon.Angle += 5;
            } else if ( e.Key == Key.Space ) {
                Bullet bullet = this.cannon.shoot();
                this.canvas.Children.Add(bullet.build(this.random));
                this.bullets.Add(bullet);
            }
        }
    }
}
