using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public static class Repository
    {
        //Properties
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> customers = new List<Customer>();

        //Constructor
        static Repository() {
            //Customers

            Customer c1 = new Customer(1, "Bo", "Høeg", "Postvej 9", "8200", "Århus", new DateTime(1997, 8, 12));
            c1.AddPhone("12345678");
            c1.AddPhone("23456789");

            Customer c2 = new Customer(2, "Jacob-Emil", "Hansen", "Gugvej 19", "9000", "Aalborg", new DateTime(1985, 07, 04));
            c2.AddPhone("11223344");
            c2.AddPhone("22334455");

            Customer c3 = new Customer(2, "Hans-Peter", "Hansen", "Strandvejen 88", "7800", "Skive", new DateTime(1985, 07, 04));
            c3.AddPhone("11223344");
            c3.AddPhone("22334355");

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            //Books
            Book Harddays = new Book("Steve Turner", 1994, "A Hard Day's Write: The Stories Behind Every Beatles Song", 128m, "Harddays.jpg",1);
            Harddays.ISBN = "0060844094";
            Harddays.Publisher = "It Books";
            Harddays.Category = "Book";

            Book WithALittle = new Book("George Martin", 1995, "With a Little Help from My Friends: The Making of Sgt. Pepper ", 165m, "WithALittle.jpg",2);
            WithALittle.ISBN = "0316547832";
            WithALittle.Publisher = "Little Brown & Co";
            WithALittle.Category = "Book";

            Products.Add(Harddays);
            Products.Add(WithALittle);

            MusicCD AbbeyRoad = new MusicCD("The Beatles", 1969, "Abbey Road", 128m, "AbbeyRoad.jpg", 3);
            Track m1t1 = new Track("Come Together", "Lennon", new TimeSpan(0, 2, 3));
            Track m1t2 = new Track("Something", "Lennon", new TimeSpan(0, 3, 03));
            Track m1t3 = new Track("Maxwell's Silver Hammer", "Lennon", new TimeSpan(0, 3, 27));
            Track m1t4 = new Track("Oh! Darling", "Lennon", new TimeSpan(0, 3, 27));
            Track m1t5 = new Track("Octopus's Garden", "Lennon", new TimeSpan(0, 2, 51));
            Track m1t6 = new Track("I Want You (She's So Heavy)", "Lennon", new TimeSpan(0, 7, 47));
            Track m1t7 = new Track("Because", "Lennon", new TimeSpan(0, 2, 46));
            Track m1t8 = new Track("Medley", "Lennon", new TimeSpan(0, 3, 46));
            Track m1t9 = new Track("Her Majesty", "Lennon", new TimeSpan(0, 0, 23));

            AbbeyRoad.AddTrack(m1t1);
            AbbeyRoad.AddTrack(m1t2);
            AbbeyRoad.AddTrack(m1t3);
            AbbeyRoad.AddTrack(m1t4);
            AbbeyRoad.AddTrack(m1t5);
            AbbeyRoad.AddTrack(m1t6);
            AbbeyRoad.AddTrack(m1t7);
            AbbeyRoad.AddTrack(m1t8);
            AbbeyRoad.AddTrack(m1t9);
            AbbeyRoad.Label = "Apple";
            AbbeyRoad.Category = "Music";

            MusicCD Revolver = new MusicCD("The Beatles", 1966, "Revolver", 128m, "Revolver.jpg",4);
            Track m2t1 = new Track("Taxman", "Lennon", new TimeSpan(0, 2, 41));
            Track m2t2 = new Track("Eleanor Rigby", "Lennon", new TimeSpan(0, 3, 5));
            Track m2t3 = new Track("I'm Only Sleeping", "Lennon", new TimeSpan(0, 3, 27));
            Track m2t4 = new Track("Love You To", "Lennon", new TimeSpan(0, 3, 27));
            Track m2t5 = new Track("Here, There and Everywhere", "Lennon", new TimeSpan(0, 2, 51));
            Track m2t6 = new Track("Yellow Submarine", "Lennon", new TimeSpan(0, 7, 47));
            Track m2t7 = new Track("She Said She Said", "Lennon", new TimeSpan(0, 2, 46));
            Track m2t8 = new Track("Good Day Sunshine", "Lennon", new TimeSpan(0, 3, 46));
            Track m2t9 = new Track("And Your Bird Can Sing", "Lennon", new TimeSpan(0, 0, 23));

            Revolver.AddTrack(m2t1);
            Revolver.AddTrack(m2t2);
            Revolver.AddTrack(m2t3);
            Revolver.AddTrack(m2t4);
            Revolver.AddTrack(m2t5);
            Revolver.AddTrack(m2t6);
            Revolver.AddTrack(m2t7);
            Revolver.AddTrack(m2t8);
            Revolver.AddTrack(m2t9);
            Revolver.Label = "Parlophone";
            Revolver.Category = "Music";

            Products.Add(AbbeyRoad);
            Products.Add(Revolver);

            Movie jungleBook = new Movie("Jungle Book", 160.506m, "junglebook.jpg", "Director jungle",5);
            jungleBook.Category = "Movie";
            Movie forrestGump = new Movie("Forrest Gump", 120.50m, "forrest-gump.jpg", "Director forrest",6);
            forrestGump.Category = "Movie";
            Movie gladiator = new Movie("Gladiator", 142.50m, "gladiator.jpg", "Director gladiator",7);
            gladiator.Category = "Movie";

            Products.Add(jungleBook);
            Products.Add(forrestGump);
            Products.Add(gladiator);

            //Invoices
            Invoice i1 = new Invoice(1, new DateTime(2004, 10, 21),c1);
            i1.AddOrderItem(AbbeyRoad, 1);
            i1.AddOrderItem(Revolver, 1);

            Invoice i2 = new Invoice(2, new DateTime(2005, 12, 15), c2);
            i2.AddOrderItem(WithALittle, 1);
            i2.AddOrderItem(Harddays, 1);

            Invoices.Add(i1);
            Invoices.Add(i2);
        }
    }
}