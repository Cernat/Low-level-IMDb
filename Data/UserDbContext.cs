using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<CommentOfList> CommentOfList { get; set; }
        public DbSet<ListOfMovies> ListOfMovies { get; set; }

        public DbSet<Movies> Movies { get; set; }

        public DbSet<ListAndMovies> ListAndMovies { get; set; }

    }
}
