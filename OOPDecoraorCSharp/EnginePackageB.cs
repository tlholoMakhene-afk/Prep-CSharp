using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
   public  class EnginePackageB : DecoratorFactory

    {
        public EnginePackageB(ICarComponent component) : base(component)
        {
        }


        public override string Drive() => component.Drive() + AddEnginePackage();
        private string AddEnginePackage()
        {
            return " with an engine package B";

        }
    }
}
