using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostAwsBbdd.Models
{
    [Table("libros")]
    public class Libro
    {
        [Key]
        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("autor")]
        public string Autor { get; set; }

        [Column("categoria")]
        public string Categoria { get; set; }

        [Column("pais")]
        public string Pais { get; set; }

        [Column("imagen")]
        public string Imagen { get; set; }

    }
}
