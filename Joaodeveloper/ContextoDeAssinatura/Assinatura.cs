using JOAODEVELOPER.ContextoCompartilhado;

namespace JOAODEVELOPER.ContextoDeAssinatura
{
    public class Assinatura : Base
    {
        public Plan Plan { get; set; }
        //Se não tem uma data final da assinatura significa que o aluno está ativo
        //Se o EndDate está no futuro, o aluno cancelo seu curso mas ainda tem acesso por que ele pagou 
        //Se o EndDate estiver no passado ele não tem acesso
        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate <= DateTime.Now;

        internal static void Add(Assinatura assinatura)
        {
            throw new NotImplementedException();
        }
    }
}