using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static Git.Data.DataConstants;

namespace Git.Data.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Repositories = new HashSet<Repository>();
            this.Commits = new HashSet<Commit>();
        }
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        [MaxLength(UserMaxDefaultLength)]
        public string Username { get; set; }

        [Required]
        
        public string Email { get; set; }

        [Required]
        [MaxLength(UserMaxDefaultLength)]
        public string Password { get; set; }

        public ICollection<Repository> Repositories { get; init; }
        public ICollection<Commit> Commits { get; init; }

    }
}
