using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static FootballManager.Data.DataConstants;

namespace FootballManager.Data.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserPlayers = new HashSet<UserPlayer>();
        }
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        [MaxLength(UserMaxUsername)]
        public string Username { get; set; }

        [Required]
        [MaxLength(UserMaxEmail)]
        public string Email { get; set; }

        [Required]
        [MaxLength(UserMaxPassword)]
        public string Password { get; set; }

        public ICollection<UserPlayer> UserPlayers { get; init; }


    }
}
