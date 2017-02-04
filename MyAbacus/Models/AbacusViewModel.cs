/*
 * Author: Peter Carroll
 * Purpose: This view model acts as an intermediary between the controller and model.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyAbacus.Models
{
    public class AbacusViewModel
    {
        private const string REGULAR_EXPRESSION_NUMBER_VALIDATION = @"[-+]?([0-9]*\.[0-9]+|[0-9]+)";
        
        private const string VALIDATION_ERROR_MESSAGE = 
            "The number format is invalid. Enter a number of the form +-#.###, where the # is a digit 0-9";

        [Required(ErrorMessage = "Missing numerical Value.")]
        [RegularExpression(REGULAR_EXPRESSION_NUMBER_VALIDATION,
            ErrorMessage = VALIDATION_ERROR_MESSAGE)]
        public string Number1 { get; set; } = string.Empty;

        [Required(ErrorMessage = "Missing numerical Value.")]
        [RegularExpression(REGULAR_EXPRESSION_NUMBER_VALIDATION,
            ErrorMessage = VALIDATION_ERROR_MESSAGE)]
        public string Number2 { get; set; } = string.Empty;
        public string Sum { get; set; } = string.Empty;
    }
}
