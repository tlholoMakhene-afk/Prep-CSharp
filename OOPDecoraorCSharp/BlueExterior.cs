using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
    public class BlueExterior : DecoratorFactory
    {
        public BlueExterior(ICarComponent component) : base(component)
        {
        }

        private string addExteriorColour()
        {
            return " with blue exterior colour added"; 
}
        public override string Drive()
        {
            return component.Drive() + addExteriorColour();
        }
    }
}
