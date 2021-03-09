using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
    public class RedExterior : DecoratorFactory
    {
        public RedExterior(ICarComponent component) : base(component)
        {
        }

       private string addExteriorColour()
        {
            return " with green exterior colour added";
        }
        public override string Drive()
        {
            return component.Drive() + addExteriorColour();
        }
    }
}
