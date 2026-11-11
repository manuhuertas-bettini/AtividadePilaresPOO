namespace AtividadePilaresPOO
{
    public abstract class Entrega
    {
        public decimal Distancia { get; set; }

        public abstract decimal CalcularFrete();
    }
}