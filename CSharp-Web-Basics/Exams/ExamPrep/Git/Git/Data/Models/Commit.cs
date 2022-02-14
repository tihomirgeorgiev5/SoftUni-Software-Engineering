using System;
using System.ComponentModel.DataAnnotations;
using static Git.Data.DataConstants;

namespace Git.Data.Models
{
    public class Commit
    {
        public Commit()
        {
            this.Id = Guid.NewGuid().ToString();

        }
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        
        public string CreatorId { get; set; }

        public User Creator { get; set; }

        public string RepositoryId { get; set; }

        public Repository Repository { get; set; }


    }
}
