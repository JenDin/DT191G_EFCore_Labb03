using System;
using System.ComponentModel.DataAnnotations;

namespace CD_Collection.Models
{
    // Album class
	public class Album
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "* Enter a title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "* Enter amount of tracks")]
        public int Tracks { get; set; }

        public Artist? Artist { get; set; }

        // FK to the artist table
        [Required(ErrorMessage = "* Enter an artist name")]
        public int ArtistId { get; set; }
    }

    // Artist class
    public class Artist
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* Enter a name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "* Enter a date of birth")]
        [Display(Name = "Date of birth")]
        public string? BirthDate { get; set; }

        public List<Album>? Album { get; set; }
    }
}

