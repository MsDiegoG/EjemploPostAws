using Microsoft.EntityFrameworkCore;
using PostAwsBbdd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAwsBbdd.Data
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options) { }
        public DbSet<Libro> Libros { get; set; }
    }
}
