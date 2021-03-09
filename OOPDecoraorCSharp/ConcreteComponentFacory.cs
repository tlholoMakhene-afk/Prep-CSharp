using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
    public class ConcreteComponentFacory
    {
        public ICarComponent GetNewCarType(MyEnums.CarType  carType)
        {
            //we using factory method here 
            //create an object without exposing the creation logic to the client
            //and refer to the newly created object using a common interface
            if (carType.Equals(null) ) { return null; }

            if (carType == MyEnums.CarType.sportsCar) { return new SportsCar(); }
            if (carType == MyEnums.CarType.simpleCar ) { return new SimpleCar(); }

            return null;
        }
    }
}
