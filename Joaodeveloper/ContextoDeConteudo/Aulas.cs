using JOAODEVELOPER.ContextoDeConteudo.Enumeradores;

namespace JOAODEVELOPER.ContextoDeConteudo
{
    public class Lecture
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContextoNivel Nivel { get; set; }
    }
}