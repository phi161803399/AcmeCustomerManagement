using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ValidateEmail()
        {
            // ensure valid email
            // if not,
            // request an email adress
        }

        public double CalculatePercentOfGoalSteps(string text1, string text2)
        {
            var result = 75.4;
            return result;
        }
    }
}
