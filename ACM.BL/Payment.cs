using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    public class Payment
    {
        public int PaymentType { get; set; }
        public void ProcessPayment()
        {
            PaymentType paymentTypeOption;
            //if (!enum.TryParse(PaymentType.ToString(), out paymentTypeOption)
            //{
            //    throw new InvalidEnumArgumentException("Payment Type", (int)this.PaymentType, typeof(PaymentType));
            //}

            switch (PaymentType)
            {
                case (int)ACM.BL.PaymentType.CreditCard:
                    // Process credit card
                    break;
                case (int)ACM.BL.PaymentType.PayPal:
                    // Process PayPal
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
