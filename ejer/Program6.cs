using System;

class Program
{
    static void Main(string[] args)
    {
        GestorDocumentos gestor = new GestorDocumentos();

        gestor.AgregarDocumento(new Factura("F001-000123"));
        gestor.AgregarDocumento(new NotaCredito("NC001-000456"));
        gestor.AgregarDocumento(new NotaDebito("ND001-000789"));
        gestor.AgregarDocumento(new Factura("F001-000124"));

        Console.WriteLine("Generando documentos fiscales en PDF:\n");
        gestor.GenerarTodosLosPDFs();

        Console.ReadKey(); 
    }
}