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
using System.Windows;


namespace Practic11
{
    public partial class MainWindow : Window
    {
        private yandex_storeEntities context = new yandex_storeEntities();


        public MainWindow()
        {
            InitializeComponent();
            Orders.ItemsSource = context.OrdersToList();

        }


}

    