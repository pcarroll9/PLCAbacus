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
        public AbacusModel(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
            Sum = CalculateSum(Number1, Number2);
        }

        public double Sum { get; set; }
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        private double CalculateSum(double number1, double number2)
        {
            Sum = number1 + number2;
            return Sum;
        }
    }
}