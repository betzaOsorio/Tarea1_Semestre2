using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejer
{
    internal class Factura
    {
        public class Factura : DocumentoFiscal
        {
            public Factura(string numero) : base(numero) { }

            public override void GenerarPDF()
            {
                Console.WriteLine($"Generando PDF de la FACTURA #{Numero}...");
            }
        }
    }
}
