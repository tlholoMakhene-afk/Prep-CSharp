using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOPQuestionsAnswers
{
    class Program
    {

        public enum OOPPillars
        {
            Abstraction = 1,
            Encapsulation,
            Inheritance,
            Polymorphism,
            Exit
        }

   
        public static void DisplayPillars()
        {
            Console.WriteLine(@"Please select one of the OOP Pillars
            Abstraction = 1,
            Encapsulation,
            Inheritance,
            Polymorphism,
            Exit");

        }

        public static void DisplayClassObjectDifferences()
            {
                  Console.WriteLine("Class vs Object");
                  Console.WriteLine("What is a class?" + "\t" +"\t" +"\t" + "\t" +  "|||" + "\t" + "\t" + "\t" + "\t" + "What is an object? " + "\n");
                  Console.WriteLine("Class is a blueprint for creating an object" + "\t" +"|||" + "\t" + "Objects are created based on a class " + "\n") ;
                  Console.WriteLine("Class defines abstract characteristics of objects" + "\t" + "|||" + "\t" + "Objects are created at runtime" + "\n");
                  Console.WriteLine("Class defines data and functional members" + "\t" + "And objects posses these members" + "\n");

            }
    static void Main(string[] args)
        {
            // we are going to discuss important OOP Question
            
            while (true)
            {
                Console.WriteLine("OOPS");
                Console.WriteLine("Object Oriented Programming Systems");
                Console.WriteLine("in which programs are considered as a collection of objects.");
                bool bPillars = true;
                do
                {
                    DisplayPillars();
                    string sselect = Console.ReadLine();
                    int pillarSelection = int.Parse(sselect);
                    OOPPillars oopPillar = (OOPPillars)pillarSelection;

                    switch (oopPillar)
                    {
                        case OOPPillars.Abstraction:
                            Console.WriteLine(OOPPillars.Abstraction.ToString());
                            Console.WriteLine(@"Is the process or result of revealing low level detail in other words the process of exposing essential features of an entity by hiding irrealavent information");
                            Console.WriteLine("The process of generalisation by reducing the information content of concept, we use this to retain revelant information" +
                                " for a particular purpose ");
                            break;
                        case OOPPillars.Encapsulation:
                            Console.WriteLine(OOPPillars.Encapsulation.ToString());
                            Console.WriteLine(@"Can be defined as the binding of data variables and functions together into classes  as well as the process of putting data and operations that can be performed on that data
                                               into a single container");
                            break;
                        case OOPPillars.Inheritance:
                            Console.WriteLine(OOPPillars.Inheritance.ToString());
                            Console.WriteLine("Is the ability to create a new class based on another existing class");
                            break;
                        case OOPPillars.Polymorphism:
                            Console.WriteLine(OOPPillars.Polymorphism.ToString());
                            Console.WriteLine(@"The ability to create members of the same name, in diffferent classes, inheriting the same parent and share the same signature but with different implementation ");
                            break;
                        case OOPPillars.Exit:
                            bPillars = false;
                            break;
                        default:
                            Console.WriteLine("Invalid entry...exited loop");
                            bPillars = false;
                            break;
                    }
                } while (bPillars == true);

                OOPParadigm.WhatIsOOP();
                Console.WriteLine("Just so you know");
                Pillars.Encapsulation.GetPillarData();
                Pillars.Abstraction.GetPillarData();
                Pillars.Inheritance.GetPillarData();
                Pillars.Polymorphism.GetPillarData();


                levelsOfAccessToObjects.Internal.GetAccessLevelString();
                levelsOfAccessToObjects.InternalProtected.GetAccessLevelString();
                levelsOfAccessToObjects.Protected.GetAccessLevelString();
                levelsOfAccessToObjects.Private.GetAccessLevelString();
                levelsOfAccessToObjects.Public.GetAccessLevelString();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("What is a class?");
                Console.WriteLine("A class is the logical representation of objects/" +
                                  "it a simple representation of a type of object");
                Console.WriteLine("It is the blueprint/ plan/ template that describes the details of an object.");
                Console.WriteLine("Through classes we are able to categorise the world and the world" +
                                   " as we know it into objects and events ");
                Console.WriteLine("They are the basic building blocks of OOP");

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("What is a object?");

                Console.WriteLine("An object is an instance of a class");
                Console.WriteLine("It has its own state, behavior, and identity");

                DisplayClassObjectDifferences();

                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Console.WriteLine("We created a inline function()=>{}");
                    Console.WriteLine("An inline function is a technique used by the compilers and " +
                        "instructs to insert complete body of the function wherever that function is used in the program source code");
                }));

                thread.Start();
                Console.WriteLine("Constructor");
                OOPParadigm.WhatIsAConstructor();
                OOPParadigm.RulesForConstructor();
                OOPParadigm.Destructor();
                Console.WriteLine("");
                OOPParadigm.WhatAreManipulators();
                OOPParadigm.VirtualVsAbstract();
                DummyUser du = new DummyUser();

                du.VirtualMethod();

                OOPParadigm.WhatIsAFriendFunction();

                du.DisplayDetails();



               
            }
            Console.ReadKey();
        }
    }
}
