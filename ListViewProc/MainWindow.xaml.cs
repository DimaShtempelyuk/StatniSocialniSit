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

namespace ListViewProc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person.InitPersons();
            Persons.DataContext = Person.AllPersons;
        }
        private void Persons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person u = ((KeyValuePair<string, Person>)(sender as ListView).SelectedItem).Value;
            DataContext = u;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Persons.SelectedItem = 0; 
        }

    }
}
