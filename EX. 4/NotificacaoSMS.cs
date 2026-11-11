namespace AtividadePilaresPOO
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Notificação enviada por SMS!");
        }
    }
}