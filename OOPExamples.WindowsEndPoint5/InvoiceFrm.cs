using OOPExamples.WindowsEndPoint5.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPExamples.WindowsEndPoint5
{
    public partial class InvoiceFrm : Form
    {
        public InvoiceFrm()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var invoices = OOPExamples.InMemoryData.Shopping.GetInvoices();


            var linq01 = (from i in invoices
                          group i by i.CustomerObject.Name into grp
                          select new
                          {
                              DearCustomerName = grp.Key,
                              Orders = grp,
                              NumberOfOrders = grp.Count(),
                          }).ToList();

            var linq02 = (from i in invoices
                          group i by i.InvoiceItems.Select(x=>x.ProductObject.Title) into grp
                          select new
                          {
                              ProductName = grp.Key,
                              Orders = grp,
                              NumberOfOrders = grp.Count(),
                          }).ToList();


            var all_of_invoice_items = (from i in invoices
                                        select i.InvoiceItems).ToList() ;


            var products = OOPExamples.InMemoryData.Shopping.GetProducts();


            var join = (from ii in invoices.SelectMany(x => x.InvoiceItems)
                       join p in products on ii.ProductObject.Title equals p.Title
                       select new
                       {
                           Title = p.Title,
                           Tedad = ii.Qty
                       }).ToList();


            var grppp = (from x in @join
                         group x by x.Title into grp
                         select new
                         {
                             Title = grp.Key,
                             Tedad = grp.Sum(x => x.Tedad)
                         }).ToList();



            var linq03 = from ii in all_of_invoice_items
                         group ii by ii.Select(x => x.ProductObject.Title) into grp
                         select new
                         {
                             Title = grp.Key,
                             GRP = grp
                         };



            var linq04 = (from i in invoices
                          select new ProductCountViewModel
                          {
                             CustomerName = i.CustomerObject.Name,
                             OrderNo = i.OrderNo,
                             ProductTitle = i.InvoiceItems.Select(x=>x.ProductObject.Title).ToList()
                          }).ToList();

            var finalTest = (from x in linq04
                             group x by x.ProductTitle.GroupBy(x => x) into grp
                             select new
                             {
                                 X = grp.Key,
                                 Y = grp,
                                 Z = grp.Count()
                             }).ToList();


          


        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            // گرفتن دیتا از بیش از یک کلاس شی گرایی -
            // یا همان جدول دیتابیسی

            // is-a
            // VIP Customer is a Customer

            // has-a
            // Navigation Property

            // Order Has a Customer 
            // OrderDetail has a Product

            // Join ( condition )   

            var invoices = InMemoryData.Shopping.GetInvoices();
            var customers = InMemoryData.Shopping.GetCustomers();
            var products = InMemoryData.Shopping.GetProducts();

            var linq01 = from i in invoices
                        // join c in customers on i.CustomerObject.ID equals c.ID
                         join c in customers on i.CustomerObject.Name equals c.Name

                         select new
                         {
                             i.Note,
                             i.OrderNo,
                             i.TotalPriceToPay,
                             c.Name,
                             c.Telephone
                         };

            GridInvoices.DataSource = linq01; // Pay Attention !!

            GridInvoices.DataSource = linq01.ToList();


            MessageBox.Show("Done !!");

            GridInvoices.DataSource = null;






            var all_invoice_items = invoices.SelectMany(x => x.InvoiceItems).ToList();

            var linq02 = (from p in products
//                          join ii in all_invoice_items on p.Title equals ii.ProductObject.Title
                          join ii in invoices.SelectMany(x=>x.InvoiceItems) on p.Title equals ii.ProductObject.Title
                          select new
                          {
                              p.Title,
                              ii.Qty
                          }).ToList();

            GridInvoices.DataSource = linq02;

            MessageBox.Show("Done !!");


            var linq03 = (from g in linq02
                          group g by g.Title into grp
                          select new
                          {
                              Title = grp.Key,
                              Total = grp.Sum(s => s.Qty),
                              Tedad = grp.Count()
                          }).ToList();

            GridInvoices.DataSource = linq03;

            MessageBox.Show("Done !!");

            GridInvoices.DataSource = linq03.OrderByDescending(x => x.Tedad).ToList();



            MessageBox.Show("Done !!");

            GridInvoices.DataSource = linq03.OrderByDescending(x => x.Total).ToList();


        }

        private void InvoiceFrm_Load(object sender, EventArgs e)
        {
            OOPExamples.Entities.Extra.TestClass t1 = new Entities.Extra.TestClass();
            t1.F1();
        }
    }
}
