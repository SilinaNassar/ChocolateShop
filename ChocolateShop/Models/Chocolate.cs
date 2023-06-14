using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChocolateShop.Models
{
    public class Chocolate
    {

        [Key]
        public int ChocolateId { get; set; }

        [Required, StringLength(40)]
        public String ChocolateName { get; set; }

        public int Stock { get; set; }

        [StringLength(25)]
        public String Image { get; set; }
    }
}