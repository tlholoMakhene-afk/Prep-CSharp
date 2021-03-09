using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
   public  class EnginePackageA : DecoratorFactory

    {
        public EnginePackageA(ICarComponent component) : base(component)
        {
        }

         

        public override string Drive()
        {
            return component.Drive() + AddEnginePackage();
        }
        private string AddEnginePackage()
        {
            return " with an engine package A";

        }
    }
}
