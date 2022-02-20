using System;

namespace Ramis_Cinema.Models
{
    public class ActorMovie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }


    }
}
