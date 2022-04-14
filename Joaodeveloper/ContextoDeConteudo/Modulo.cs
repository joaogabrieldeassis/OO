namespace JOAODEVELOPER.ContextoDeConteudo
{
     public class Modulo
    {
        public Modulo()
        {
            Lectures = new List<Lecture>();
        }
        //Ordem em que os cursos irão ficar
        public int Order { get; set; }
        //Titulo dos modulos
        public string Title { get; set; }
        //Listas das aulas 
        public IList<Lecture> Lectures { get; set; }
    }
    //Aulas que ficarão dentro dos modulos, "coloquei como palestra para não confundir com claas"
}