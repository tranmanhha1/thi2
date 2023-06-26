using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exam
{
    class Book : Product
    {
        public Book(string productId, string name, double price, string producer)
           : base(productId, name, price, producer)
        {

        }

        public override double ComputeTax()
        {
            return Price * 0.08;
        }
    }
}
