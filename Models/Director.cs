using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }

        public String ProfilePicture { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
