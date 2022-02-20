using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ramis_Cinema.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "Logga")]
        public string Logo { get; set; }
        [Display(Name = "Salong")]

        public string Name { get; set; }
        [Display(Name = "Mer om salongen")]

        public string Desc { get; set; }

        public List<Movie> Movies { get; set; }

    }
}
