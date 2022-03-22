namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BoxType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(BoxTypeCodeMaxLength)]
        public string BoxTypeCode { get; set; }

        public ICollection<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
