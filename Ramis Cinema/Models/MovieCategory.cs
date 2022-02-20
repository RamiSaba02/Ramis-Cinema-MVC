using System.ComponentModel.DataAnnotations;

namespace Ramis_Cinema.Models
{
    public class MovieCategory
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
    }
}
