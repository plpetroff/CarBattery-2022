namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Image
    {
        [Key]
        public int Id { get; set; }

        public string ImageTitle { get; set; }

        public byte[] ImageData { get; set; }

        public Battery Battery { get; set; }
    }
}
