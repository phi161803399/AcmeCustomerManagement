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

        public double CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            double result = 0;

            var goalStepCount = Convert.ToDouble(goalSteps);
            if (goalStepCount > 0)
            {
                result = (Convert.ToDouble(actualSteps)/goalStepCount) * 100;
            }

            return result;
        }
    }
}
