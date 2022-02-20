using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ramis_Cinema.Models
{
    public class Actor 

    {
        [Key]
        public int Id { get; set; }
      
        [Display(Name = "Bild-Länk")]
        [Required(ErrorMessage = "Du behöver lägga till en bild")]
        public string ImgURL { get; set; }

        [Display(Name = "Namn")]
        [Required(ErrorMessage = "Du behöver lägga till ett namn")]

        public string Name { get; set; }

        [Display(Name = "Beskrivning")]
        [Required(ErrorMessage = "Du behöver lägga till en beskrivning av skådelspelaren")]

        public string Desc { get; set; }

        public List<ActorMovie> ActorMovies { get; set; }



    }
}