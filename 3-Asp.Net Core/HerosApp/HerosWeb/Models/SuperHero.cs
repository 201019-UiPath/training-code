using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HerosWeb.Models
{
    public class SuperHero
    {
        [Required]
        [DisplayName("Real Name")]
        [DataType(DataType.Text)]
        public string RealName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        //[StringLength(10,ErrorMessage ="Alias should be atleast with 2 letter upto 10 letters", MinimumLength =2)]
        [RegularExpression(@"^[a-zA-z]{2,10}",ErrorMessage = "Alias should be atleast with 2 letter upto 10 letters")]
        public string Alias { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Hide Out")]
        public string HideOut { get; set; }
        public List<SuperPower> SuperPowers { get; set; }
    }
}
