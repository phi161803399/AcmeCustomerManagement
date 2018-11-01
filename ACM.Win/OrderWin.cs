using ACM.BL;
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
            // CUSTOMER
            var customer = new Customer();
            // populate the customer instance
            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);

            // extra info from UI 
            var allowSplitOrders = true;
            var emailReceipt = true;

            // ORDER
            var order = new Order();
            // populate the order instance
            var orderRepository = new OrderRepository();
            orderRepository.Add(order);

            // INVENTORY
            var inventoryRepository = new InventoryRepository();
            // populate inventoryrepository
            inventoryRepository.OrderItems(order, allowSplitOrders);

            // PAYMENT
            var payment = new Payment();
            // populate the payment info from the UI
            payment.ProcessPayment();

            // EMAIL
            if (emailReceipt)
            {
                customer.ValidateEmail();
                customerRepository.Update();

                var emailLibrary = new EmailLibrary();
                emailLibrary.SendEmail(customer.EmailAddress,
                                        "Here is your receipt");
            }
        }
    }
}
