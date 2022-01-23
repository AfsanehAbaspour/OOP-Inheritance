using OOPExamples.Entities.Shopping;
using System;
using System.Collections.Generic;

namespace OOPExamples.InMemoryData
{
    public static class Shopping
    {
        /// <summary>
        /// Helper Method
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetCustomers()
        {
            var result = new List<Customer>();

            result.Add(new Customer("Customer1", "111111111"));
            result.Add(new Customer("Customer2", "111111112"));
            result.Add(new Customer("Customer3", "111111113"));
            result.Add(new Customer("Customer4", "111111114"));
            result.Add(new Customer("Customer5", "111111115"));
            result.Add(new VIPCustomer("VIPCustomer1", "100000001"));
            result.Add(new ForeignCustomer("Mr Jones !!", "100000001",countryName:"China"));


            return result;
        }

        public static List<Product> GetProducts()
        {
            var result = new List<Product>();

            result.Add(new Product("Product1", 1000));
            result.Add(new Product("Product2", 2000));
            result.Add(new Product("Product3", 3000));
            result.Add(new Product("Product4", 4000));
            result.Add(new Product("Product5", 5000));

            return result;
        }
       
        public static List<Invoice> GetInvoices()
        {
            return new List<Invoice>
            {
                new Invoice(GetCustomers()[0],"1000",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[0],1),
                    new InvoiceItem(GetProducts()[1],2),
                    new InvoiceItem(GetProducts()[2],3),
                    new InvoiceItem(GetProducts()[3],4),
                }),

                new Invoice(GetCustomers()[1],"1001",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[0],1),
                    new InvoiceItem(GetProducts()[1],2),
                    new InvoiceItem(GetProducts()[2],3),
                }),

                new Invoice(GetCustomers()[2],"1002",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[0],1),
                    new InvoiceItem(GetProducts()[1],2),
                }),

                new Invoice(GetCustomers()[3],"1003",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[0],1),
                }),

               new Invoice(GetCustomers()[0],"1004",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[3],4),
                }),

                new Invoice(GetCustomers()[5],"1005",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[3], byte.MaxValue),
                }),

                 new Invoice(GetCustomers()[6],"1006",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[3], byte.MaxValue),
                }),

                new Invoice(GetCustomers()[6],"1007",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[4], 10),
                }),


                new Invoice(GetCustomers()[6],"1008",new List<InvoiceItem>
                {
                    new InvoiceItem(GetProducts()[4], 10),
                }),

            };
        }
    
    }
}
