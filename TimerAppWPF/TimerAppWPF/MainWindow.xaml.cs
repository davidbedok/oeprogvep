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
using TimerApp;

namespace TimerAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int NUMBER_OF_BALLS = 100;

        private readonly Random rand;
        private readonly DispatcherTimer timerSingle;
        private readonly DispatcherTimer timerMultiple;
        private AppFrame frame;
        private BallFactory ballFactory;

        private Ball ball;
        private Ball[] balls;

        public MainWindow()
        {
            this.rand = new Random();
            InitializeComponent();

            timerSingle = new DispatcherTimer();
            timerSingle.Interval = new TimeSpan(0, 0, 0, 0, 50);
            timerSingle.Tick += timerSingle_Tick;
            timerSingle.Stop();

            timerMultiple = new DispatcherTimer();
            timerMultiple.Interval = new TimeSpan(0, 0, 0, 0, 50);
            timerMultiple.Tick += timerMultiple_Tick;
            timerMultiple.Stop();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.frame = new AppFrame(this.rand, this.canvas.ActualWidth, this.canvas.ActualHeight);
            this.ballFactory = new BallFactory(this.rand, this.frame);
            this.canvas.Children.Add(this.frame.getRect());
        }

        private void timerSingle_Tick(object sender, EventArgs e)
        {
            this.ball.jump();
        }

        private void timerMultiple_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.balls.Length; i++)
            {
                this.balls[i].jump();
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.ball = this.ballFactory.createBall(10, 15);
            this.canvas.Children.Add(this.ball.getEllipse());

            this.timerSingle.Start();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            this.timerSingle.Stop();
        }

        private void StartMultiple_Click(object sender, RoutedEventArgs e)
        {
            this.balls = new Ball[NUMBER_OF_BALLS];
            for (int i = 0; i < this.balls.Length; i++)
            {
                this.balls[i] = this.ballFactory.createBall();
                canvas.Children.Add(this.balls[i].getEllipse());
            }

            this.timerMultiple.Start();
        }

        private void StopMultiple_Click(object sender, RoutedEventArgs e)
        {
            this.timerMultiple.Stop();
        }

    }
}
