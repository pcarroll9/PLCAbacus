/*
 * Author: Peter Carroll
 * Purpose: This is the Model for the application. It handles the actual calculation.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAbacus.Models
{
    public class AbacusModel
    {
        public AbacusModel(string number1, string number2)
        {
            Number1 = number1;
            Number2 = number2;
            Sum = CalculateSum(Number1, Number2);
        }

        public string Sum { get; set; }
        public string Number1 { get; set; }
        public string Number2 { get; set; }

        private string CalculateSum(string number1, string number2)
        {
            double n1 = Convert.ToDouble(number1);
            double n2 = Convert.ToDouble(number2);
            double s = n1 + n2;
            Sum = s.ToString();
            return Sum;
        }
    }
}