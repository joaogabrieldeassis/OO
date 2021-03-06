using JOAODEVELOPER.ContextoCompartilhado;

namespace JOAODEVELOPER.ContextoDeConteudo
{
    //O contexto sera a classe em que as outras classes irão herdar, então nela tera que ter em comum suas devidas propriedades e métodos que irão fazer sentido para as outras classes
    public abstract class Contexto : Base
    {
        public Contexto(string title, string url, int nivel)
        {
            Nivel = nivel;
            Url = url;
            Title = title;

        }

        public string Title { get; set; }
        public string Url { get; set; }
        public int Nivel { get; set; }

    }
}