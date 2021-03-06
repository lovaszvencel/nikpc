﻿using Nikpc.Controllers;
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
using System.Windows.Shapes;

namespace Nikpc.Windows
{
    /// <summary>
    /// Interaction logic for OrderPlacementWindow.xaml
    /// </summary>
    public partial class OrderPlacementWindow : Window
    {
        CartController cc;
        OrderController oc;
        int? fullPrice;

        public OrderPlacementWindow()
        {
            cc = new CartController();
            oc = new OrderController();
            Init();
            InitializeComponent();
            deliveryPriceTxt.DataContext = 0;
            totalSumTxt.DataContext = fullPrice;
            basketList.DataContext = cc;
        }

        private void Init()
        {
            fullPrice = 0;

            foreach (var item in UserController.currentUser.Cart)
            {
                fullPrice += item.Product.Price * item.Quantity;
            }
        }

        private void deliveryChkBox_Checked(object sender, RoutedEventArgs e)
        {
            deliveryPriceTxt.DataContext = 1000;
            totalSumTxt.DataContext = fullPrice +1000;
        }

        private void deliveryChkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            deliveryPriceTxt.DataContext = 0;
            totalSumTxt.DataContext = fullPrice;
        }

        private void placeOrderButton_Click(object sender, RoutedEventArgs e)
        {
            PaymentWindow pw = new PaymentWindow(totalSumTxt.DataContext);
            oc.PlaceOrder(deliveryChkBox.IsChecked, (int)double.Parse(totalSumTxt.DataContext.ToString()), Enums.PaymentMethod.Card);
            pw.Show();
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
