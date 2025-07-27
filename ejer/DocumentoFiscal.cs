using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer
{
    internal class DocumentoFiscal
    {
        public abstract class DocumentoFiscal
        {
            public string Numero { get; set; }

            public DocumentoFiscal(string numero)
            {
                Numero = numero;
            }

            public abstract void GenerarPDF();
        }
        internal abstract class DocumentoFiscal
        {
            public string Numero { get; set; }

       
            public DocumentoFiscal(string numero)
            {
                Numero = numero;
            }

            public abstract void GenerarPDF();
        }
    }
}
