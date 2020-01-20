using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        //Declare the list
        private List<SelectListItem> customers = new List<SelectListItem>();

        // GET: Invoice
        public ActionResult Index()
        {
            

            //Generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem { Text = invoice.Customer.Firstname + " " + 
                    invoice.Customer.Lastname, Value = invoice.Customer.CustomerId.ToString() });

            }

            //Removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();
            ViewBag.CustomerId = customers;

            //Old
            IList<Invoice> invoices = new List<Invoice>();

            invoices = Repository.Invoices.OfType<Invoice>().ToList();

            ViewBag.Invoices = Repository.Invoices;
            return View();
        }

        [HttpPost]
        public ActionResult Index(int? CustomerId)
        {
            //Old
            IEnumerable<Invoice> invoices = new List<Invoice>();

            invoices = Repository.Invoices.OfType<Invoice>().ToList();


            //Generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.Firstname + " " +
                    invoice.Customer.Lastname,
                    Value = invoice.Customer.CustomerId.ToString()
                });

            }

            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            
            if (CustomerId != null)
            {
                //Select invoices for a customer with linq
                invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == CustomerId);
            }
            ViewBag.CustomerId = customers;
            ViewBag.Invoices = invoices;
            return View();
        }
    }
}