using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaID { get; set; }

        [Display(Name = "Logo")]
        public String Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public String Name { get; set; }
        [Display(Name = "Description")]
        public String Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
