namespace AtividadePilaresPOO
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Cilindradas: {Cilindradas}");
        }
    }
}