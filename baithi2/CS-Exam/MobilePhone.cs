using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exam
{
    class MobilePhone : Product
    {
        public MobilePhone(string productId,string name,double price,sting producer)
            : base (productId,name,price,producer)
        { 
        }

        public MobilePhone(string productId, string name, double price, string producer) : base(productId, name, price, producer)
        {
        }

        public override double ComputeTax()
        {
            return Price * 0.1;
        }
    }
}
