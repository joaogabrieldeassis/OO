namespace JOAODEVELOPER.ContextoDeConteudo
{
    public class ItensDeCarreira
    {
        public ItensDeCarreira(int order, string title, string description, Curso curso)
        {
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