using System;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.Search.Models
{
    public class Query : EntityBase
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(500)]
        public string QueryText { get; set; }

        public int ResultsCount { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
