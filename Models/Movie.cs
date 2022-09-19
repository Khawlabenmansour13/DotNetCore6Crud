using System.ComponentModel.DataAnnotations;

namespace DotNetCore6Crud.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        public double Role { get; set; }
        [Required, MaxLength(2540) ]
        public string Storeline { get; set; }
        [Required]
        public byte[] Poster { get; set; }
        public byte  GenderId { get; set; }

        public Genre Genre { get; set;  }   
    
    
    }
}
