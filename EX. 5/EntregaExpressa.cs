namespace AtividadePilaresPOO
{
    class EntregaExpressa : Entrega
    {
        public override decimal CalcularFrete()
        {
            Console.WriteLine("Calculando frete para entrega expressa...");
            decimal frete = Distancia * 2.0m;
            Console.WriteLine($"Valor do frete: R$ {frete:F2}");
            return frete;
        }
    }
}