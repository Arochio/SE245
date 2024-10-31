//import libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lab {
    class Program {
        static void Main (string[] args) {
            
            Person p1 = new Person();

            Console.WriteLine("Enter the person's First name: ");
            p1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the person's Middle name: ");
            p1.MiddleName = Console.ReadLine();
            Console.WriteLine("Enter the person's Last name: ");
            p1.LastName = Console.ReadLine();
            Console.WriteLine("Enter the person's Street 1: ");
            p1.Street1 = Console.ReadLine();
            Console.WriteLine("Enter the person's Street 2: ");
            p1.Street2 = Console.ReadLine();
            Console.WriteLine("Enter the person's City: ");
            p1.City = Console.ReadLine();
            Console.WriteLine("Enter the person's State: ");
            p1.State = Console.ReadLine();
            Console.WriteLine("Enter the person's Zip cope: ");
            p1.Zip = Console.ReadLine();
            Console.WriteLine("Enter the person's Phone: ");
            p1.Phone = Console.ReadLine();
            Console.WriteLine("Enter the person's Email: ");
            p1.Email = Console.ReadLine();

            Console.WriteLine($"First name: {p1.FirstName}\nMiddle name: {p1.MiddleName}\nlast name: {p1.LastName}\nStreet 1: {p1.Street1}\nStreet 2: {p1.Street2}\nCity: {p1.City}\nState: {p1.State}\nZip: {p1.Zip}\nPhone number: {p1.Phone}\nEmail: {p1.Email}\n");
        
        }
        
        public class Person {

            public String FirstName {
                get; set;
            }
            public String MiddleName {
                get; set;
            }
            public String LastName {
                get; set;
            }
            public String Street1 {
                get; set;
            }
            public String Street2 {
                get; set;
            }
            public String City {
                get; set;
            }
            public String State {
                get; set;
            }
            public String Zip {
                get; set;
            }
            public String Phone {
                get; set;
            }
            public String Email {
                get; set;
            }
        }
    }
}