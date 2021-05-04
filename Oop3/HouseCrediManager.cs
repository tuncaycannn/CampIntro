using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class HouseCrediManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");

        }

        public void Interest()
        {
            throw new NotImplementedException();
        }
    }
}
