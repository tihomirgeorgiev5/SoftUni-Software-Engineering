using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static BusStation.Data.DataConstants.Destination;

namespace BusStation.Data.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DestinationNameMaxLenght)]
        
        public string DestinationName { get; set; }

        [Required]
        [MaxLength(OriginMaxLenght)]
        public string Origin { get; set; }

        [Required]
        [MaxLength(DateMaxLenght)]
        public string Date { get; set; }

        [Required]
        [MaxLength(TimeMaxLenght)]
        public string Time { get; set; }

        [Required]
        [MaxLength(ImageUrlMaxLenght)]
        public string ImageUrl { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
