﻿using MovieTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "ProfilePicture")]
        public String ProfilePicture { get; set; }

        [Display(Name = "FullName")]
        public String FullName { get; set; }

        [Display(Name = "Bio")]
        public String Bio { get; set; }

        //Relationship
        public List<Actor_Movie> ? Actors_Movies { get; set; }
    }
}
