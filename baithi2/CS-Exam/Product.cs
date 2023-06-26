using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exam
{

        abstract class Product
        {
            private string productId;
            private string name;
            private double price;
            private string producer;

            public string ProductId
            {
                get { return productId; }
                set { productId = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }

            public string Producer
            {
                get { return producer; }
                set { producer = value; }
            }

            public Product(string productId, string name, double price, string producer)
            {
                this.productId = productId;
                this.name = name;
                this.price = price;
                this.producer = producer;
            }

            public abstract double ComputeTax();
        }
}
