using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        //Fields
        private List<string> phoneNumbers = new List<string>();
        private DateTime birthDate;

        //properties
        public int CustomerId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Address { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }


        public List<string> PhoneNumbers
        {
            get { return phoneNumbers; }
        }

        public DateTime BirthDate
        {

            set
            {
                if (DateTime.Now.Year - value.Year < 0 || DateTime.Now.Year - value.Year > 120) { throw new Exception("Age not accepted"); }
                else { birthDate = value; }
            }
            get { return birthDate; }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;

                }
                return age;
            }

        }

        public List<Invoice> Invoices { get; set; }


        public void AddPhone(string phone)
        {
            phoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }

        //Constructor
        public Customer(int customerId, string firstname, string lastname, string address, string zip, string city, DateTime birthDate)
        {
            CustomerId = customerId;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city;
            BirthDate = birthDate;
        }
    }
}