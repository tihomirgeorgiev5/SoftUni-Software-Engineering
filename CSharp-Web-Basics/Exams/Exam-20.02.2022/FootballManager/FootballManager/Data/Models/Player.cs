using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static FootballManager.Data.DataConstants;

namespace FootballManager.Data.Models
{
    public class Player
    {
        public Player()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserPlayers = new HashSet<UserPlayer>();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        [MaxLength(PlayerMaxFullName)]
        public string FullName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(PlayerMaxPosition)]
        public string Position { get; set; }

        [Required]
        [MaxLength(PlayerMaxSpeed)]
        public byte Speed { get; set; }

        [Required]
        [MaxLength(PlayerMaxEndurance)]
        public byte Endurance { get; set; }

        [Required]
        [MaxLength(PlayerMaxStringDescription)]
        public string Description { get; set; }

        public ICollection<UserPlayer> UserPlayers { get; init; }
    }
}
