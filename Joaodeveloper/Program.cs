using System;
using JOAODEVELOPER.ContextoDeConteudo;

namespace Joaodeveloper
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigo = new List<Artigo>();
            artigo.Add(new Artigo("Curso de C#", "Curso de csharp", 1));
            artigo.Add(new Artigo("Curso de OOP", "Curso de Orientação a objetos", 3));
            artigo.Add(new Artigo("Curso .net", "Curso de dotnet", 4));
            // foreach (var item in artigo)
            // {
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item.Title);
            //     Console.WriteLine(item.Url);
            // }
            var corseOOP = new Curso("Curso de Orientação a objetos", "Especialista em OOP", 1);
            var corseCharp = new Curso("Curso de Charp", "Especialista em Charp", 2);
            var corseAspNet = new Curso("Curso de ASP.NET", "Especialista em ASP.NET", 3);
            var carreiras = new List<Carreira>();
            var carreira = new Carreira("Carreira de .NET", "https: dotnet", 1);
            var itensDeCarreira = new ItensDeCarreira(3, "Finalizando Carreira do .net", "", corseAspNet);
            var itensDeCarreira1 = new ItensDeCarreira(2, "Cursando Carreira de .NET", "", corseOOP);
            var itensDeCarreira2 = new ItensDeCarreira(1, "Comecando Carreira do .NET", "", corseCharp);
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
                    Console.WriteLine(item.Title);
                    Console.WriteLine(item.Nivel);
                }
            }


        }
    }
}

