using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class VehicleCrediManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi ödeme planı hesaplandı.");
        }

        public void Interest()
        {
            throw new NotImplementedException();
        }
    }
}
