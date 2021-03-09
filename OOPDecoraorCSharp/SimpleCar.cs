using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
   public  class SimpleCar : ICarComponent
    {
        public string Drive()
        {
           return "Driving my simple car";
        }

    }
}
