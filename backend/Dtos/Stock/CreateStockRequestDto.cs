using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Stock
{
    public class CreateStockRequestDto
    {

        [Required]
        public string Symbol { get; set; } = String.Empty;

        [Required]
        public string CompanyName { get; set; } = String.Empty;

        [Required]
        public decimal Purchase { get; set; }

        [Required]
        public decimal LastDiv { get; set; }

        [Required]
        public string Industry { get; set; } = String.Empty;

        [Required]
        public long MarketCap { get; set; }
    }
}