﻿namespace CarBattery_2022.Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Battery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }

        [Required]
        public int CapacityId { get; set; }
        public Capacity Capacity { get; set; }

        public int AmperageId { get; set; }
        public Amperage Amperage { get; set; }


        public int TerminalsId { get; set; }
        public Terminals Terminals { get; set; }

        public int BoxTypeId { get; set; }
        public BoxType BoxType { get; set; }

        public int? ImageId { get; set; }
        public Image Image { get; set; }

        public int? BatteryCodeId { get; set; }
        public BatteryCode BatteryCode { get; set; }


        public int LengthId { get; set; }
        public Length Length { get; set; }

        public int WidthId { get; set; }
        public Width Width { get; set; }

        public int HeightId { get; set; }
        public Height Height { get; set; }

        public int HeightPlusId { get; set; }
        public HeightPlus HeightPlus { get; set; }

        public int WeightId { get; set; }
        public Weight Weight { get; set; }

        public int PriceId { get; set; }
        public Price Price { get; set; }
    }
}
