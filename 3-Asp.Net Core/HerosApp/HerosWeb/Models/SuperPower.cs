using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HerosWeb.Models
{
    public class SuperPower
    {
            [HiddenInput(DisplayValue = false)]
            public int Id { get; set; }
            [Required]
            [DataType(DataType.Text)]
            public string Name { get; set; }

            [DataType(DataType.MultilineText)]    
            public string Description { get; set; }
    }
}
