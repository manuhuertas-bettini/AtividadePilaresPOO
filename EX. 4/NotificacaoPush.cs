namespace AtividadePilaresPOO
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Notificação enviada por Push!");
        }
    }
}