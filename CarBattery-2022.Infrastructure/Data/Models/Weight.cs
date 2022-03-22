namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Weight
    {
        [Key]
        public int Id { get; set; }

        public double ValueInKg { get; set; }

        public ICollection<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
