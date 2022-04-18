using JOAODEVELOPER.ContextoCompartilhado;
using JOAODEVELOPER.ContextoDeNotificacoes;

namespace JOAODEVELOPER.ContextoDeAssinatura
{
    public class Ustudent : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public Ustudent()
        {
            Assinaturas = new List<Assinatura>();
        }
        public IList<Assinatura> Assinaturas { get; set; }
        public void CriarAssinatura(Assinatura assinatura)
        {
            if (IsPremium)
            {
                AddNotification(new Notificacoes("Premium", "O aluno ja tem uma assinatura"));
                return;
            }
            Assinatura.Add(assinatura);
        }
        public bool IsPremium => Assinaturas.Any(x => !x.IsInactive);
    }
}