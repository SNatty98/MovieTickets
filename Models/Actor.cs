using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        public String ProfilePicture { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
