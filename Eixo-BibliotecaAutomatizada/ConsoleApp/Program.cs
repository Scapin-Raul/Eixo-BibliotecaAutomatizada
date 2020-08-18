using Dominios.Classes;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        List<Alunos> ListaDeAlunos = new List<Alunos>();



        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu RM:");
            var RmAluno = Console.ReadLine();

            if (RmAluno == "1313")
            {

                Console.WriteLine("Insira sua senha:");
                var SenhaAluno = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Rm inválido");

            }
        
        
        }
    }
}
