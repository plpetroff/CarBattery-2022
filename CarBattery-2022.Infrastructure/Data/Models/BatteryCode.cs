namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BatteryCode
    {
        public int Id { get; set; }

        public string BatteryCodeValue { get; set; }

        public Battery Battery { get; set; }
    }
}
