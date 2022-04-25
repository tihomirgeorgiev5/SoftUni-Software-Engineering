using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static BusStation.Data.DataConstants.User;

namespace BusStation.Data.Models
{
    public class User
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(UsernameMaxLength)]
        public string Username { get; set; }

        [Required]
        [MaxLength(EmailMaxLength)]

        public string Email { get; set; }

        [Required]

        public string Password { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
