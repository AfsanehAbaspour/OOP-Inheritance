using System;

namespace OOPExamples.Entities.Shopping
{
    /// <summary>
    /// محصول
    /// </summary>
    public class Product
    {
        public int ID
        {
            get
            {
                return SadrTools.Utility.Utility.GetRandomNumber();
            }
        }

        public string Title { get; set; }

        public int Price { get; set; }


        public Product(string title, int price)
        {
            // ?          :       
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Price = price;
        }


        public override string ToString()
        {
            return $"{Title} : {Price}";
        }


    }

}
