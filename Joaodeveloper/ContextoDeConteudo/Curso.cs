using JOAODEVELOPER.ContextoDeConteudo.Enumeradores;

namespace JOAODEVELOPER.ContextoDeConteudo
{
    //Inicializando o curso Com os seus devidos modulos
    public class Curso : Contexto
    {
        public Curso(string title, string url, int nivel)
        : base(title, url, nivel)
        {
            Modules = new List<Modulo>();
        }
        public string Tag { get; set; }
        public IList<Modulo> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContextoNivel Nivel { get; set; }


    }


}