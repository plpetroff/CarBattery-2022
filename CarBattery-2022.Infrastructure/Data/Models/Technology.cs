namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Technology
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TechnologyNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
