using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominios.Classes
{
    public class Alunos
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nome", TypeName = "varchar(255)")]
        public string Nome { get; set; }

        [Required]
        [Column("Senha", TypeName = "varchar(255)")]
        public string Senha{ get; set; }

        
        //[ForeignKey("Produtos")]
        //[Column("IdLivroEmprestado", TypeName = "int")]
        //public int IdLivroEmprestado { get; set; }
        //public Livros Livro { get; set; }

    }
}
