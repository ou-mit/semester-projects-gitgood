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

namespace TACalender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DB db = new DB();
            Task t1 = new Task();
            t1.Weekday = "Wednesday";
            Time StartTime = new Time(1, 30, "pm");
            Time EndTime = new Time(3, 00, "pm");
            t1.StartTime = StartTime;
            t1.EndTime = EndTime;
            db.Tasks.Add(t1);
            db.SaveChanges();


        }

        private void btnHomeAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminPassword adminPassword = new AdminPassword();
            adminPassword.Show();
        }

        private void btnHomeTA_Click(object sender, RoutedEventArgs e)
        {
            TAPage tAPage = new TAPage();
            tAPage.Show();
        }
    }
}
