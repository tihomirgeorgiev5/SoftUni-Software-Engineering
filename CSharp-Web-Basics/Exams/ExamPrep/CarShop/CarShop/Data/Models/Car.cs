using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static CarShop.Data.DataConstants;

namespace CarShop.Data.Models
{
    public class Car
    {
        public Car()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Issues = new HashSet<Issue>();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        [MaxLength(DefaultMaxLength)]
        public string Model { get; set; }

        
        public int Year { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        [MaxLength(PlateNumberMaxLength)]
        public string PlateNumber { get; set; }

        [Required]
        public string OwnerId { get; set; }

        public User Owner { get; set; }

        public ICollection<Issue> Issues { get; init; }
    }
}
