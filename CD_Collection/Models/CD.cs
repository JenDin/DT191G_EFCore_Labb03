using System;
namespace CD_Collection.Models
{
	public class Album
	{
        public int Id { get; set; }

        public string? Title { get; set; }

        public int Tracks { get; set; }

        public Artist? Artist { get; set; }

        public int ArtistId { get; set; }
    }

    public class Artist
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? BirthDate { get; set; }

        public List<Album>? Album { get; set; }
    }
}

