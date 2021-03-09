using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecoraorCSharp
{
    class Program
    {
   

        public static void DisplayEnginePackageMenu()
        {
            Console.WriteLine(@"Please select one of the following 
            1. EnginePackageA,
            2. EnginePackageB");
        }
         public static void DisplayConcreteType()
        {
            Console.WriteLine(@"Please select one of the following 
            simpleCar = 1,
            sportsCar = 2");
        }
        public static void DisplayExteriorColorOptions()
        {
            Console.WriteLine(@"Please select one of the following 
             Blue = 1,
            Green = 2,
            Red");
        }
        public static void DisplayWindowsState()
        {
            Console.WriteLine(@"Please select one of the following 
             TintedWindows = 1,
             TintlessWindows");
        }

        static void Main(string[] args)
        {
            bool bApp = true;
            ICarComponent carprotoType = null;

            do
            {
                DisplayConcreteType();
                int selectOfTypes = int.Parse(Console.ReadLine());
                MyEnums.CarType carTypeSelected = (MyEnums.CarType)selectOfTypes;
                ConcreteComponentFacory concreteComponentFacory = new ConcreteComponentFacory();
                switch (carTypeSelected)
                {
                    case MyEnums.CarType.simpleCar:
                        carprotoType = concreteComponentFacory.GetNewCarType(MyEnums.CarType.simpleCar);
                        break;
                    case MyEnums.CarType.sportsCar:
                        carprotoType = concreteComponentFacory.GetNewCarType(MyEnums.CarType.sportsCar);
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        carprotoType = null;
                        
                        break;
                }
                DisplayEnginePackageMenu();
                int selection = int.Parse(Console.ReadLine());
                MyEnums.EnginePackage epCurrent = (MyEnums.EnginePackage)selection;

                ICarComponent withEnginecomponent = null;

                //favor object composition over inheritance
                // design patterns are based on that
                //as well as program to an interface and not implementation


                switch (epCurrent)
                {
                    case MyEnums.EnginePackage.EnginePackageA:

                        {
                            withEnginecomponent = new EnginePackageA(carprotoType);
                        }
                        break;
                    case MyEnums.EnginePackage.EnginePackageB:
                        {
                            withEnginecomponent = new EnginePackageB(carprotoType);

                        }

                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

                DisplayExteriorColorOptions();
                int selectionColor = int.Parse(Console.ReadLine());
                MyEnums.ExteriorColour colorSelected = (MyEnums.ExteriorColour)selectionColor;

                ICarComponent withColoredExterior = null;
                switch (colorSelected)
                {
                    case MyEnums.ExteriorColour.Blue:

                        withColoredExterior = new BlueExterior(withEnginecomponent);
                        break;
                    case MyEnums.ExteriorColour.Green:

                        withColoredExterior = new GreenExterior(withEnginecomponent);
                        break;
                    case MyEnums.ExteriorColour.Red:

                        withColoredExterior = new RedExterior(withEnginecomponent);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                DisplayWindowsState();
                int selectionWindowsState = int.Parse(Console.ReadLine());
                MyEnums.WindowsState ws = (MyEnums.WindowsState)selectionWindowsState;

                ICarComponent withNewWindowsState = null;
                switch (ws)
                {
                    case MyEnums.WindowsState.TintedWindows:
                        withNewWindowsState = new TintedWindows(withColoredExterior);
                        break;
                    case MyEnums.WindowsState.TintlessWindows:
                        withNewWindowsState = new TintedllessWindows(withColoredExterior);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine(withNewWindowsState.Drive());

                //Console.WriteLine(withEnginecomponent.Drive()) ;

                Console.WriteLine("Do you want to continue, Y= yes AND N = no");
                string schoice = Console.ReadLine().ToLower();
                switch (schoice)
                {
                    case "y":
                        bApp = true;
                        break;
                    case "n":
                        bApp = false;
                        break;
                    default:
                        bApp = false;
                        break;
                }

            } while (bApp == true);
            Console.ReadKey();
        }


    }
}
