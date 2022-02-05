using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helicopter.Models
{
    public class BalanceModel
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string CvvCode { get; set; }

    }
}