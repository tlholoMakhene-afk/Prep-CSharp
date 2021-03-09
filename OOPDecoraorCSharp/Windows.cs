using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
    public class TintedWindows : DecoratorFactory

    {
        public  TintedWindows(ICarComponent component) : base(component)
        {
        }


        public override string Drive() => component.Drive() + AddWindowsState();
        private string AddWindowsState()
        {
            return " with A grade tinted windows";

        }
    }
    public class TintedllessWindows : DecoratorFactory

    {
        public TintedllessWindows(ICarComponent component) : base(component)
        {
        }


        public override string Drive() => component.Drive() + AddWindowsState();
        private string AddWindowsState()
        {
            return " without tinted windows";

        }
    }
}
