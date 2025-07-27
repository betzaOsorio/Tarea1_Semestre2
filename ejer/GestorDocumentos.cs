using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer
{
    internal class GestorDocumentos
    {
        public class GestorDocumentos
        {
            private List<DocumentoFiscal> documentos = new List<DocumentoFiscal>();

            public void AgregarDocumento(DocumentoFiscal doc)
            {
                documentos.Add(doc);
            }

            public void GenerarTodosLosPDFs()
            {
                foreach (var doc in documentos)
                {
                    doc.GenerarPDF();
                }
            }
        }
    }
}
