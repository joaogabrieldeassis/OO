using JOAODEVELOPER.ContextoCompartilhado;
using JOAODEVELOPER.ContextoDeNotificacoes;

namespace JOAODEVELOPER.ContextoDeConteudo
{
    public class ItensDeCarreira : Base
    {
        public ItensDeCarreira(int order, string title, string description, Curso curso)
        {
            if (curso == null)
            {
                AddNotification(new Notificacoes("Curso", "Curso inavalido"));
            }
            Order = order;
            Title = title;
            Description = description;
            Curso = curso;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Curso Curso { get; set; }
    }
}