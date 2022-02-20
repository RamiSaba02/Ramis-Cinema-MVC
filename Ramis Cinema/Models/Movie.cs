using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ramis_Cinema.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display (Name = "Filmtitel")]
        public string Title { get; set; }
        [Display(Name = "Beskrivning")]

        public string Description { get; set; }
        [Display(Name = "Pris")]

        public double Price { get; set; }
        [Display(Name = "Bild")]

        public string ImgURL { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int CategoryId { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Location Location { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }


    }
}
