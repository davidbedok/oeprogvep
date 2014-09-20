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

namespace EventsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly Random random;
        private readonly String[] people;
        private readonly String[] actions;
        private Process process;

        public MainWindow()
        {
            InitializeComponent();
            this.random = new Random();
            this.people = new String[]{"Steve", "Joe", "Sue", "Stephen"};
            this.actions = new String[] { "test", "implement", "review", "repair", "refactor" };
        }

        private void bStart_Click(object sender, RoutedEventArgs e)
        {
            int minimum = Int32.Parse(this.tbMin.Text);
            int maximum = Int32.Parse(this.tbMax.Text);
            this.process = new Process(minimum, maximum);
            this.process.commonEvent += process_commonEvent;
            this.process.featuredProgressEvent += process_featuredProgressEvent;

            this.process.commonEvent += new EventHandler(this.other_process_commonEvent);
            this.process.featuredProgressEvent += delegate
            {
                MessageBox.Show("From Anonymous method!");
            };

            this.pbDemo.Minimum = minimum;
            this.pbDemo.Maximum = maximum;
            this.bStep.IsEnabled = true;
            this.bStart.IsEnabled = false;
        }

        private void process_featuredProgressEvent(double progressPercent, string message)
        {
            MessageBox.Show("Featured progress! " + message + " ( " + progressPercent + " % )");
        }

        private void process_commonEvent(object sender, EventArgs e)
        {
            double progressPercent = 0;
            if (sender is Process)
            {
                progressPercent = (sender as Process).getPercent();
            }

            MessageBox.Show("Common event! Progress: " + progressPercent + " % ");
        }

        private void other_process_commonEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Other common event!");
        }

        private void bStep_Click(object sender, RoutedEventArgs e)
        {
            int step = this.random.Next(20);
            this.process.step(step, this.getActor(), this.getAction());
            this.pbDemo.Value += step;
            if (this.pbDemo.Value == this.pbDemo.Maximum)
            {
                MessageBox.Show("Done.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                this.bStep.IsEnabled = false;
                this.bStart.IsEnabled = true;
                this.pbDemo.Value = 0;
            }
        }

        private String getActor() {
            return this.people[this.random.Next(this.people.Length)];
        }

        private String getAction()
        {
            return this.actions[this.random.Next(this.actions.Length)];
        }

    }
}
