namespace JOAODEVELOPER.ContextoDeConteudo
{
    // Carreira será a classe onde tera seus devidos cursos
    public class Carreira : Contexto
    {
        public Carreira()
        {
            Itens = new List<ItensDeCarreira>();
        }
        public IList<ItensDeCarreira> Itens { get; set; }

        // TotalCourses será sempre uma contagens de itens que tem
        public int TotalCourses => Itens.Count;

    }
}