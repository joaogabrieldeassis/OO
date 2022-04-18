namespace JOAODEVELOPER.ContextoDeNotificacoes
{
    //Class para adicionar as notificações
    public abstract class Notificavel
    {
        public List<Notificacoes> Notifications { get; set; }
        //Adicionar uma notificação
        public Notificavel()
        {
            Notifications = new List<Notificacoes>();
        }
        public void AddNotification(Notificacoes notification)
        {
            Notifications.Add(notification);
        }
        //Adicionar varias notificações
        public void AddNotifications(IEnumerable<Notificacoes> notificacoes)
        {
            Notifications.AddRange(notificacoes);
        }
        public bool IsInvalid => Notificacoes.Any();
    }
}
