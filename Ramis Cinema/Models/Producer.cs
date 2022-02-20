using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ramis_Cinema.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profilbild")]
        public string ImgURL { get; set; }
        [Display(Name = "Namn")]
        public string Name { get; set; }
        [Display(Name = "Om Producent")]
        public string Desc { get; set; }

        public List<Movie> Movies { get; set; }

    }
    
}
