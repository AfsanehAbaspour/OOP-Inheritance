namespace OOPExamples.Entities.Shopping
{
    /// <summary>
    /// موجودیت آیتم های فاکتور
    /// </summary>
    public class InvoiceItem
    {
      
        public int ID
        {
            get
            {
                return SadrTools.Utility.Utility.GetRandomNumber();
            }
        }


        public Product ProductObject { get; set; }

        public byte Qty { get; set; }

        public Invoice InvoiceObject { get; }


        /// <summary>
        /// جمع کل یک ردیف
        /// </summary>
        public ulong TotalRowPrice
        {
            get
            {
                return (ulong)(ProductObject.Price * Qty);
            }
        }


        public InvoiceItem(Product productObject, byte qty)
        {
            ProductObject = productObject;
            Qty = qty;
        }

        public override string ToString()
        {
            return $"{ProductObject} * {Qty} = {TotalRowPrice}";
        }

    }
}
