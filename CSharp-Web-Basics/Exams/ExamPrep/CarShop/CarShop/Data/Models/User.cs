using System;
using System.ComponentModel.DataAnnotations;
using static CarShop.Data.DataConstants;

namespace CarShop.Data.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }
       [Key]
       [Required]
       [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        [MaxLength(DefaultMaxLength)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsMechanic { get; set; }
    }
}
