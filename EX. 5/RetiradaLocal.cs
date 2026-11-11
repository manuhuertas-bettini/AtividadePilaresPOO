using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilaresPOO
{
    class RetiradaLocal : Entrega
    {
        public override decimal CalcularFrete()
        {
            Console.WriteLine("Calculando frete para retirada local...");
            Console.WriteLine("Não há custo de frete para retirada local.");
            return 0.0m;
        }
    }
}