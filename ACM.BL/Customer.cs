using Core.Common;
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

        // METHOD RETURNS A BOOLEAN VALUE, BUT WITHOUT FURTHER INFORMATION
        //public Boolean ValidateEmail()
        //{
        //    var valid = true;

        //    if (String.IsNullOrWhiteSpace(this.EmailAddress))
        //    {
        //        valid = false;
        //    }

        //    bool isValidFormat = true;
        //    // code here that validates the format of the email
        //    // using regular expression
        //    if (!isValidFormat) valid = false;

        //    bool isRealDomain = true;
        //    // code here that confirms whether domain exists
        //    if (!isRealDomain) valid = false;

        //    return valid;
        //}

        // METHOD USES GUARD CLAUSES WITH ARGUMENTEXCEPTIONS (ARE USED FOR HANDLING EXCEPTIONAL CIRCUMSTANCES)
        // NOT FOR VALIDATION!!!
        //public void ValidateEmail()
        //{
        //    if (String.IsNullOrWhiteSpace(this.EmailAddress)) throw new ArgumentException("Email address is null");

        //    bool isValidFormat = true;
        //    // code here that validates the format of the email
        //    // using regular expression
        //    if (!isValidFormat) throw new ArgumentException("Email address is not in correct format");

        //    bool isRealDomain = true;
        //    // code here that confirms whether domain exists
        //    if (!isRealDomain) throw new ArgumentException("Email address does not include a valid domain");
        //}

        // VALIDATION WITH BOOLEANS AND STRINGS THROUGH TUPLES
        //public Tuple<bool, string> ValidateEmail()
        //{
        //    Tuple<Boolean, String> result = Tuple.Create(true, "");

        //    if (String.IsNullOrWhiteSpace(this.EmailAddress))
        //    {
        //        result = Tuple.Create(false, "Email address is null");
        //    }

        //    if (result.Item1 == true)
        //    {
        //        bool isValidFormat = true;
        //        // code here that validates the format of the email
        //        // using regular expression
        //        if (!isValidFormat) Tuple.Create(false, "Email address is not in correct format");
        //    }

        //    if (result.Item1 == true)
        //    {
        //        bool isRealDomain = true;
        //        // code here that confirms whether domain exists
        //        if (!isRealDomain) Tuple.Create(false, "Email address does not include a valid domain");
        //    }
            

        //    return result;
        //}

        // using class OperationResult
        public OperationResult ValidateEmail()
        {
            var op = new OperationResult();

            if (String.IsNullOrWhiteSpace(this.EmailAddress))
            {
                op.Success = false;
                op.AddMessage("Email address is null");
            }

            if (op.Success)
            {
                bool isValidFormat = true;
                // code here that validates the format of the email
                // using regular expression
                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email address is not in correct format");
                }
            }

            if (op.Success)
            {
                bool isRealDomain = true;
                // code here that confirms whether domain exists
                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email address does not include a valid domain");
                }
            }
            return op;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal actualStepCount = 0;
            decimal goalStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual steps must be entered", "actualSteps");

            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric");
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual step must be numeric", "actualStepCount");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
            return Math.Round((actualStepCount / goalStepCount)*100,2);
        }
    }
}
