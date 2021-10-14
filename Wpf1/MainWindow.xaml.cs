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
using Wpf1.DataHelper;
using Wpf1.MainPage;

namespace Wpf1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AppFrame.mainFrm = FrmMain;
            FrmMain.Navigate(new LgPage());

        }

        private void FrmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void FrmMain_Navigated_1(object sender, NavigationEventArgs e)
        {

        }
    }
}