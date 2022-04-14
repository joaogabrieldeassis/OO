using System;
using JOAODEVELOPER.ContextoDeConteudo;

namespace Joaodeveloper
{
    class Program
    {
        static void Main(string[] args)
        {
            var carreira = new Carreira();
            var curso = new Curso();
            curso.Nivel = JOAODEVELOPER.ContextoDeConteudo.Enumeradores.EContextoNivel.iniciante;
            foreach (var item in curso.Modules)
            {

            }
            carreira.Itens.Add(new ItensDeCarreira());
            Console.WriteLine(carreira.TotalCourses);

        }
    }
    public class Payment
    {

    }
}

