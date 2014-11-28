﻿using System;
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

namespace CannonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Cannon cannon;

        public MainWindow()
        {
            InitializeComponent();
            this.cannon = new Cannon(200, 200, 40);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.canvas.Children.Add(this.cannon.build());
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                this.cannon.Angle += 5;
            }
            else if (e.Key == Key.Right)
            {
                this.cannon.Angle -= 5;
            }
        }
    }
}
