namespace JOAODEVELOPER.ContextoDeNotificacoes
{
    public sealed class Notificacoes
    {
        public string Property { get; set; }
        public string Messagem { get; set; }
        public Notificacoes()
        {

        }
        public Notificacoes(string property, string messagem)
        {
            Property = property;
            Messagem = messagem;
        }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
