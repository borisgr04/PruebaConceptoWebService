using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConceptoWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            var pse = new WsPse.GetDatosClient();
            var obtenerInformation=pse.GetTransactionInformation("1", 1, "1");
            Console.WriteLine(obtenerInformation.Amount);

            var transaction=new WsPse.CLSTransaction();
            transaction.TickedID = "1";
            var taxPaers=new WsPse.CLSTaxPaers();
            var response=pse.InsertTransaction(transaction, taxPaers);
            Console.WriteLine(response);
            var obtenerInformationSegundaParte = pse.GetTransactionInformation("1", 1, "1");
            Console.WriteLine(obtenerInformation.Amount);
            Console.ReadKey();
        }
    }
}
