//Mudrak Patel; 300878960; Programming 3 Lab03

using System;
using System.Linq;

namespace MudrakPatel_Lab03
{
    class Invoice
    {
        //Properties
        public int partNumber { get; set; }
        public string partDescription { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        //Methods and constructor
        //constructor
        public Invoice(int PartNumber, string PartDescription, int Quantity, double Price)
        {
            partNumber = PartNumber;
            partDescription = PartDescription;
            quantity = Quantity;
            price = Price;
        }
        //Methods
        public static void ObjectsByPartDescription(Invoice[] invoiceArray)
        {
            var objectsByPartDescription = from part in invoiceArray
                                           orderby part.partDescription
                                           select part;
            Console.WriteLine("--Objects sorted by part description--\n--------------------------------------------------------------------------------------------------------------------");
            foreach (Invoice part in objectsByPartDescription)
            {
                Console.WriteLine("<<Part description: "+part.partDescription+"--"+part.partNumber+"=="+part.quantity+"==No's; Price: "+part.price+">>");
            }
        }


        public static void ObjectsByPrice(Invoice[] invoiceArray)
        {
            var objectsByPriceDescription = from part in invoiceArray
                                           orderby part.price
                                           select part;
            Console.WriteLine("\n\n\n--Objects sorted by part description--\n--------------------------------------------------------------------------------------------------------------------");
            foreach (Invoice part in objectsByPriceDescription)
            {
                Console.WriteLine("<<Price: " + part.price + "--" + part.partDescription + "==" + part.quantity + "==No's; Part number: " + part.partNumber + ">>");
            }
        }

        public static void ObjectsByPartDescriptionAndQuantity(Invoice[] invoiceArray)
        {
            var objectsByQuantity = from part in invoiceArray
                                            orderby part.quantity
                                            select new { part.partDescription, part.quantity };
            
            Console.WriteLine("\n\n\n--Object's part description and quantity sorted by quantity--\n--------------------------------------------------------------------------------------------------------------------");
            foreach (var part in objectsByQuantity)
            {
                Console.WriteLine("<<Part description: " + "--" + part.partDescription  + "==" + part.quantity + ">>");
            }
        }

        public static void ObjectsByPartDesAndInvoice(Invoice[] invoiceArray)
        {
            var objectsByPartDesAndInvoice = from part in invoiceArray
                                    let invoice = (part.quantity * part.price)
                                    select new { part.partDescription, invoice };

            Console.WriteLine("\n\n\n--Object's part description and quantity sorted by quantity--\n--------------------------------------------------------------------------------------------------------------------");
            foreach (var part in objectsByPartDesAndInvoice)
            {
                Console.WriteLine("<<Part description: " + "--" + part.partDescription + "==Invoice: " + part.invoice + ">>");
            }
        }

        public static void InvoicesRangeDisplayMethod(Invoice[] invoiceArray)
        {
            var objectsByInvoiceRange = from part in invoiceArray
                                             let invoice = (part.quantity * part.price)
                                        where (invoice >= 200 && invoice <=500)
                                             select new { part.partNumber , part.partDescription, invoice };

            Console.WriteLine("\n\n\n--Object's part description, quantity and invoice ($200-$500)--\n--------------------------------------------------------------------------------------------------------------------");
            foreach (var part in objectsByInvoiceRange)
            {
                Console.WriteLine("<<Part description: " + part.partDescription + "--Part Number: "+ part.partNumber +" ==Invoice: " + part.invoice + ">>");
            }
        }
    }
}
