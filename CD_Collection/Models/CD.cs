using System;
using System.ComponentModel.DataAnnotations;

namespace CD_Collection.Models
{
	public class Album
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "* Enter a title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "* Enter amount of tracks")]
        public int Tracks { get; set; }

        public Artist? Artist { get; set; }

        [Required(ErrorMessage = "* Enter an artist name")]
        public int ArtistId { get; set; }
    }

    public class Artist
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* Enter a name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "* Enter a date of birth")]
        [Display(Name = "Date of birth YYYY-MM-DD")]
        public string? BirthDate { get; set; }

        public List<Album>? Album { get; set; }
    }
}

