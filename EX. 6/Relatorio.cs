using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilaresPOO
{
     public class Relatorio : IExportavel, IImprimivel
    {
        public void Exportar()
        {
            Console.WriteLine("Exportando relatório...");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório...");
        }
    }
}