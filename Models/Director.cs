using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }

        [Display(Name = "Profile Picture")]
        public String ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        public String FullName { get; set; }
        [Display(Name = "Biography")]
        public String Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
