namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Terminals
    {
        public int Id { get; set; }

        public string Description { get; set; }
        //public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
