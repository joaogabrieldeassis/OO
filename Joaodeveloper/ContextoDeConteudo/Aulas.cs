using JOAODEVELOPER.ContextoCompartilhado;
using JOAODEVELOPER.ContextoDeConteudo.Enumeradores;

namespace JOAODEVELOPER.ContextoDeConteudo
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContextoNivel Nivel { get; set; }
    }
}