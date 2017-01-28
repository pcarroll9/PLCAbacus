/*
 * Author: Peter Carroll
 * Purpose: This view model acts as an intermediary between the controller and model.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAbacus.Models
{
    public class AbacusViewModel
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Sum { get; set; }
    }
}