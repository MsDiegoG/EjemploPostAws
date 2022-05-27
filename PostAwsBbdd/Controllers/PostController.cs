using Microsoft.AspNetCore.Mvc;
using PostAwsBbdd.Models;
using PostAwsBbdd.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAwsBbdd.Controllers
{
    public class PostController : Controller
    {
        private RepositoryPost repo;

        public PostController(RepositoryPost repo)
        {
            this.repo = repo;
        }

        public IActionResult GetLibros()
        {
            List<Libro> libros = this.repo.GetLibros();
            return View(libros);
        }
    }
}
