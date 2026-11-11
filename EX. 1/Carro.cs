namespace AtividadePilaresPOO
{
    public class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Número de Portas: {NumeroDePortas}");
        }
    }
}