using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominios.Classes
{
    public class Emprestimos
    {

        //ID do aluno, id no livro, data do emprestimo, data limite devolução, finalizado

        [Required]
        [ForeignKey("Livros")]
        [Column("IdLivroEmprestado", TypeName = "int")]
        public int IdLivroEmprestado { get; set; }
        public Livros Livro { get; set; }

        [Required]
        [ForeignKey("Alunos")]
        [Column("IdLivroEmprestado", TypeName = "int")]
        public int IdAluno { get; set; }
        public Alunos Aluno { get; set; }


        [Required]
        [Column("DataEmprestimo", TypeName = "date")]
        public DateTime DataEmprestimo { get; set; }

        [Required]
        [Column("DataDevolucao", TypeName = "date")]
        public DateTime DataDevolucao { get; set; }
    }
}
