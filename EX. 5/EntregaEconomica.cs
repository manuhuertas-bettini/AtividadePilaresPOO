namespace AtividadePilaresPOO
{
    class EntregaEconomica : Entrega
    {
        public override decimal CalcularFrete()
        {
            Console.WriteLine("Calculando frete para entrega econômica...");
            decimal frete = Distancia * 1.0m;
            Console.WriteLine($"O valor do frete para entrega econômica é: R$ {frete:F2}");
            return frete;
        }
    }
}