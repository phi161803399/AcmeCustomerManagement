﻿using ACM.BL;
using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private static void PlaceOrder()
        {
            // CUSTOMER
            var customer = new Customer();
            // populate the customer instance

            // ORDER
            var order = new Order();
            // populate the order instance

            // PAYMENT
            var payment = new Payment();
            // populate the payment info from the UI

            // extra info from UI 
            var allowSplitOrders = true;
            var emailReceipt = true;

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders, emailReceipt);
        }
    }
}
