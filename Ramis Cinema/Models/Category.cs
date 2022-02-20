using System.ComponentModel.DataAnnotations;

namespace Ramis_Cinema.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
