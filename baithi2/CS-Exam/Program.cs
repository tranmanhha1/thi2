using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[6];
            products[0] = new Book("B001", "Book 1", 120.4, "Publisher 1");
            products[1] = new Book("B002", "Book 2", 15.4, "Publisher 2");
            products[2] = new Book("B003", "Book 3", 22.12, "Publisher 3");
            products[3] = new MobilePhone("M001", "Phone 15", 5500.21, "Apple");
            products[4] = new MobilePhone("M002", "SamSung ", 80.124, "SamSung");
            products[5] = new MobilePhone("M003", "Oppo", 120.345, "Oppo");

            double totalBookTax = 0.0;
            double totalMobilePhoneTax = 0.0;

            foreach (Product product in products)
            {
                if (product is Book book)
                {
                    totalBookTax += book.ComputeTax();
                }
                else if (product is MobilePhone mobilePhone)
                {
                    totalMobilePhoneTax += mobilePhone.ComputeTax();
                }
            }

            Console.WriteLine("Total tax for books: " + totalBookTax);
            Console.WriteLine("Total tax for mobile phones: " + totalMobilePhoneTax);

            Console.ReadLine();
        }
    }
}
