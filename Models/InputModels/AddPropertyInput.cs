using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace build.Models.InputModels
{
    public class AddPropertyInput
    {
        [Required]
        public string inputName { get; set; }   ="Random House";
        [Required]
        public string inputAddress0 { get; set; } = "123";
        [Required]
        public string inputAddress1 { get; set; } = "Random Street";
        [Required]
        public string inputAddress2 { get; set; } = "Random Town";
        [Required]
        public string inputAddress3 { get; set; } = "ABC123";
        [Required]
        [MaxLength(250)]
        public string inputDescription { get; set; } = "A truly random, mythical place.";
    }
}