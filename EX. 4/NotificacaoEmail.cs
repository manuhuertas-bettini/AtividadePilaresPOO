namespace AtividadePilaresPOO
{
    class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Notificação enviada por e-mail! ");
        }
    }
}