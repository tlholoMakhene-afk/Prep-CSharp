using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
    public class GreenExterior : DecoratorFactory
    {
        public GreenExterior(ICarComponent component) : base(component)
        {
        }

        public string addExteriorColour()
        {
            return " with green exterior colour added";
        }
        public override string Drive()
        {
            return component.Drive() + addExteriorColour();
        }
    }
}
