using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("--Objects sorted by part description--\n--------------------------------------------------------------------------------------------------------------------");
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
            
            Console.WriteLine("--Objects sorted by part description--\n--------------------------------------------------------------------------------------------------------------------");
            foreach (Invoice part in objectsByQuantity)
            {
                Console.WriteLine("<<Price: " + part.price + "--" + part.partDescription + "==" + part.quantity + "==No's; Part number: " + part.partNumber + ">>");
            }
        }
    }
}
