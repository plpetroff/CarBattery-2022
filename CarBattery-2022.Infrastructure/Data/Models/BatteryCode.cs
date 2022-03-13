namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BatteryCode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(BatteryCodeValueMaxLength)]
        public string BatteryCodeValue { get; set; }

        public Battery Battery { get; set; }
    }
}
