using System;
using JOAODEVELOPER.ContextoDeConteudo;

namespace Joaodeveloper
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigo = new List<Artigo>();
            artigo.Add(new Artigo("João e Mariana", "https:balta.io.com.br"));
            foreach (var item in artigo)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Url);
            }
        }
    }
}

