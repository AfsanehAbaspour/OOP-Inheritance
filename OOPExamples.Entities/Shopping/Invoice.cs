using System.Collections.Generic;
using System;
using SadrTools.ExtensionMethods;

namespace OOPExamples.Entities.Shopping
{
    /// <summary>
    /// موجودیت فاکتور
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// کلید فنی
        /// </summary>
        public int ID
        {
            get
            {
                return SadrTools.Utility.Utility.GetRandomNumber();
            }
        }

        public Customer CustomerObject { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        /// <summary>
        /// کلید بیزینسی 
        /// </summary>
        public string OrderNo { get; set; }

        public string Note { get; set; } = "با تشکر از خرید شما";

        public List<InvoiceItem>  InvoiceItems { get; set; }


        /// <summary>
        /// مبلغ کل قابل پرداخت
        /// </summary>
        public ulong TotalPriceToPay
        {
            get
            {
                var result = TotalPrice;

                if (CustomerObject is VIPCustomer)
                {
                    byte percent = (byte)(CustomerObject as VIPCustomer).MembershipCard;
                    result -= ((result * percent) / 100);
                }

                return result;
            }
        }


        /// <summary>
        /// مبلغ کل
        /// </summary>
        public ulong TotalPrice
        {
            get
            {
                ulong result = 0;
                foreach (InvoiceItem item in InvoiceItems)
                {
                    result += item.TotalRowPrice;
                }

                return result;
            }
        }


        public ulong Discount { get { return TotalPrice - TotalPriceToPay; } }


        public Invoice(Customer customerObject, string orderNo, List<InvoiceItem> invoiceItems)
        {
            CustomerObject = customerObject;
            OrderNo = orderNo;
            InvoiceItems = invoiceItems;
        }



        public override string ToString()
        {
            return $"{CustomerObject} : {OrderNo} : {OrderDate.ToPersianDate()} : {TotalPrice} - {Discount} = {TotalPriceToPay}";
        }


    }
}
