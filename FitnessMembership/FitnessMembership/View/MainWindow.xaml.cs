﻿using FitnessMembership.ViewModel;
using System.Windows;

namespace FitnessMembership.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IClosable
    {
        public MainWindow()
        {
            InitializeComponent();
            // DataContext = this;
        }
    }
}
