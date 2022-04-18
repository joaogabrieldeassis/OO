using JOAODEVELOPER.ContextoDeNotificacoes;

namespace JOAODEVELOPER.ContextoCompartilhado
{
    public abstract class Base : Notificavel
    {
        public Guid Id { get; set; }
        public Base()
        {
            Id = Guid.NewGuid();
        }
    }
}