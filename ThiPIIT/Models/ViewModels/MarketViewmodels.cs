using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThiPIIT.Models.ViewModels
{
    public class MarketViewmodels
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name market.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter description.")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [Required(ErrorMessage = "Please choose status.")]
        public int Status { get; set; }
    }
}