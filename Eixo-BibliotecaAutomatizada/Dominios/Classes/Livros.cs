using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominios.Classes
{
    public class Livros
    {

        //Título, autor, editora, edição

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Titulo", TypeName = "varchar(255)")]
        public string Titulo { get; set; }

        [Column("Editora", TypeName = "varchar(255)")]
        public string Editora { get; set; }

        [Column("Edicao", TypeName = "varchar(255)")]
        public string Edicao { get; set; }

    }
}
