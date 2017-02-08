//Mudrak Patel; 300878960; Programming 3 Lab03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //invoiceArray variable to store some Invoice objects
                Invoice[] invoiceArray =  {
                new Invoice(83, "Electric sander", 7, 57.98),
                new Invoice(24, "Power saw", 18, 99.99),
                new Invoice(7, "Sledge hammer", 11, 21.50),
                new Invoice(77, "Hammer", 76, 11.99),
                new Invoice(39, "Lawn mover", 3, 79.50),
                new Invoice(68, "Screwdriver", 106, 6.99),
                new Invoice(56, "Jigsaw", 21, 11.00),
                new Invoice(3, "Wrench", 34, 7.50)
            };

                Invoice.ObjectsByPartDescription(invoiceArray);
                Invoice.ObjectsByPrice(invoiceArray);
                Invoice.ObjectsByPartDescriptionAndQuantity(invoiceArray);
                Invoice.ObjectsByPartDesAndInvoice(invoiceArray);
                Invoice.InvoicesRangeDisplayMethod(invoiceArray);
            }
            catch (Exception exception)
            {
                Console.WriteLine("An exception occured!\n"+"<<"+ exception.Message + ">>\n");
            }
        }
    }
}
