using System;
using JOAODEVELOPER.ContextoDeConteudo;

namespace Joaodeveloper
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigo = new List<Artigo>();
            artigo.Add(new Artigo("Curso de C#", "Curso de csharp"));
            artigo.Add(new Artigo("Curso de OOP", "Curso de Orientação a objetos"));
            artigo.Add(new Artigo("Curso .net", "Curso de dotnet"));
            // foreach (var item in artigo)
            // {
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item.Title);
            //     Console.WriteLine(item.Url);
            // }
            var curso = new List<Curso>();
            curso.Add(new Curso("Curso João developer Junior", "João Developer Junior"));
            curso.Add(new Curso("Curso Joao developer Pleno", "Joao developer Pleno"));
            var carreiras = new List<Carreira>();
            var carreira = new Carreira("Carreira de .NET", "https: dotnet");
            var itensDeCarreira = new ItensDeCarreira(3, "Finalizando Carreira do .net", "", null);
            var itensDeCarreira1 = new ItensDeCarreira(2, "Cursando Carreira de .NET", "", null);
            var itensDeCarreira2 = new ItensDeCarreira(1, "Comecando Carreira do .NET", "", null);
            carreira.Itens.Add(itensDeCarreira);
            carreira.Itens.Add(itensDeCarreira1);
            carreira.Itens.Add(itensDeCarreira2);
            carreiras.Add(carreira);
            foreach (var item in carreiras)
            {
                Console.WriteLine(item.Title);
                foreach (var item2 in item.Itens.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item2.Order} - {item2.Title}");
                }
            }


        }
    }
}

