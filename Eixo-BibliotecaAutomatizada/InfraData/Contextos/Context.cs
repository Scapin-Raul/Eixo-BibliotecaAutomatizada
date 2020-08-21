using Dominios.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Contextos
{
    public class Context: DbContext
    {

        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Emprestimos> Emprestimos { get; set; }
        public DbSet<Livros> Livros { get; set; }


        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Verifica se o contexto já não esta configurado, caso não eseja utiliza a string de conexão abaixo
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=SRVWIN\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Livros>().HasData(
               new Livros()
               {
                   Id = 1,
                   Titulo = "Pequeno princípe"
               }
               );

            modelBuilder.Entity<Alunos>().HasData(
                new Alunos()
                {
                    Id = 1,
                    RM = 1212,
                    Nome = "Fernando",
                    Senha = "132",
                    }
                );

            modelBuilder.Entity<Emprestimos>().HasNoKey().HasData(
               new Emprestimos()
               {
                   IdAluno = 1,
                   IdLivroEmprestado = 1,
                   DataDevolucao = Convert.ToDateTime("11/11/2020"),
                   DataEmprestimo = Convert.ToDateTime("7/11/2020"),
               }
               );




            base.OnModelCreating(modelBuilder);

        }



    }
}
