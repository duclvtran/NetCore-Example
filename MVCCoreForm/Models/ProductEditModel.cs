using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreForm.Models
{
    public class ProductEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Rating { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}