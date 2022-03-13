namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string CategoryName { get; set; }

        //public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
