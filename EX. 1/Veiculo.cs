namespace AtividadePilaresPOO
{
    public class Veiculo
    {
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Marca: {Marca}");
        }
    }
}