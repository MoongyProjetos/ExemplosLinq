using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = CriaListaPessoas();
            Console.WriteLine($"Pessoas na lista: {database.Count}");

            var primeiraPessoa = database.FirstOrDefault();
            Console.WriteLine($"Nome da Primeira pessoa: {primeiraPessoa.Nome} - Idade: {primeiraPessoa.Idade}");


            var primeiroPedro = database.FirstOrDefault(p => p.Nome.StartsWith("Pedro"));
            Console.WriteLine($"Nome da Primeiro Pedro: {primeiroPedro.Nome} - Idade: {primeiroPedro.Idade}");

            ////NAO USAR ESSE, FOI APENAS EXEMPLO
            //foreach (var item in database)
            //{
            //    if(item.Nome.StartsWith("Pedro"))
            //    {
            //        Console.WriteLine($"Nome da Primeiro Pedro: {item.Nome} - Idade: {item.Idade}");
            //        break;
            //    }
            //}


            var pessoasComDataNascimento = database.Where(batata => batata.DataNascimento != new DateTime()).ToList();
            Console.WriteLine($"Pessoas com DataNascimento: {pessoasComDataNascimento.Count}");


            Console.ReadLine();
        }

        private static List<Pessoa> CriaListaPessoas()
        {
            var resultado = new List<Pessoa>();
            resultado.Add(new Pessoa { Id = 1, Nome = "Joao da Silva", DataNascimento = new DateTime(2010, 01, 01) });
            resultado.Add(new Pessoa { Id = 2, Nome = "Maria da Silva", DataNascimento = new DateTime(2009, 01, 01) });
            resultado.Add(new Pessoa { Id = 3, Nome = "Pedro da Silva", DataNascimento = new DateTime(2019, 01, 01) });
            resultado.Add(new Pessoa { Id = 4, Nome = "Joaquim da Silva", DataNascimento = new DateTime(2020, 01, 01) });

            for (int i = 5; i < 1001; i++)
            {
                resultado.Add(new Pessoa { Id = i, Nome = "Pessoa - " + i });
            }

            return resultado;
        }
    }
}
