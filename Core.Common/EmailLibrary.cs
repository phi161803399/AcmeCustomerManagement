﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class EmailLibrary
    {
        public void SendEmail(string emailAddress, string v)
        {
            // if a valid email address is provided
            try
            {
                // send email to customer
            }
            catch (Exception ex)
            {
                // log
                throw; // re-throw 
            }
            
        }
    }
}
