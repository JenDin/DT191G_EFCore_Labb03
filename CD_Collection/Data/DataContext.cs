using System;
using CD_Collection.Models;
using Microsoft.EntityFrameworkCore;

namespace CD_Collection.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Artist> Artist { get; set; }

        public DbSet<Album> Album { get; set; }
    }
}