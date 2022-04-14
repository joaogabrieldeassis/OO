namespace JOAODEVELOPER.ContextoDeConteudo
{
    //O contexto sera a classe em que as outras classes irão herdar, então nela tera que ter em comum suas devidas propriedades e métodos que irão fazer sentido para as outras classes
    public abstract class Contexto
    {
        public Contexto()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}