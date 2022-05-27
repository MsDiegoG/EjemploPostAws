using PostAwsBbdd.Data;
using PostAwsBbdd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAwsBbdd.Repositories
{
    public class RepositoryPost
    {
        private PostContext context;

        public RepositoryPost(PostContext context)
        {
            this.context = context;
        }

        public List<Libro> GetLibros()
        {
            return this.context.Libros.ToList();
        }
    }
}
