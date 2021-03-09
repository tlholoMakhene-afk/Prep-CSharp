using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuestionsAnswers
{

    public enum Pillars
    {
        Encapsulation = 1,
        Polymorphism,
        Abstraction,
        Inheritance

    }
    public enum levelsOfAccessToObjects
    {
        Private = 1,
        Public,
        Internal,
        Protected,
        InternalProtected
    }

    public static class OOPParadigm
    {
      

        public static string WhatIsOOP()
        {
            return string.Format(@"
        It is a programming paradigm based upon objects (having both data and methods) 
            that aims to incorporate the advantages of modularity and reusability. 
        Objects, which are usually instances of classes, are used to interact with one another 
             to design applications and computer programs.

        The important features of object–oriented programming are −
             Bottom–up approach in program design.
             Programs organized around objects, grouped in classes.
             Focus on data with methods to operate upon object’s data.
             Interaction between objects through functions.
             Reusability(Inheritance) of design through creation of new classes by adding features to existing classes.");
        }

        public static void GetPillarData(this Pillars pillars)
        {
            switch (pillars)
            {
                case Pillars.Encapsulation:
                    Console.WriteLine("______________");
                    Console.WriteLine("What is encapsulation?");
                    Console.WriteLine("Encapsulation is an attribute(getters && setters) of an object and contains all its hiddeen data");
                    Console.WriteLine("The data was hidden due to to access modifiers");
                    break;
                case Pillars.Polymorphism:
                    Console.WriteLine("______________");
                    Console.WriteLine("What is polymorphism?");
                    Console.WriteLine("The ability to create methods pf the same name," +
                        " in different claasses inheiriting the same parent");
                    break;
                case Pillars.Abstraction:
                    Console.WriteLine("______________");
                    Console.WriteLine("What is abstraction?");
                    Console.WriteLine("Is exposing essential features of an entity by hiding irrelevant data");

                    break;
                case Pillars.Inheritance:
                    Console.WriteLine("What does inheritance mean?");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Is a concept where one single claass shares the structure and behaviour defined by another class.");
                    Console.WriteLine(" If inheritance applied on one class is called Single Inheritance, and if it depends on multiple classes,then it is called multiple Inheritance.");

                    break;
                default:
                    Console.WriteLine("Only 4");
                    break;
            }
        }
 public static void GetAccessLevelString(this levelsOfAccessToObjects levelsOfAccess)
        {
            switch (levelsOfAccess)
            {
               
            
                case levelsOfAccessToObjects.Private:
                    Console.WriteLine(" Private = accesss to only members of the same class");
                    break;
                case levelsOfAccessToObjects.Public:
                    Console.WriteLine("Public = access to all code in program");
                    break;
                case levelsOfAccessToObjects.Internal:
                    Console.WriteLine("internal = access to current assembly");
                    break;
                case levelsOfAccessToObjects.Protected:
                    Console.WriteLine("protected = A protected member is accessible within its class and by derived class instances.");
                    break;
                case levelsOfAccessToObjects.InternalProtected:
                    Console.WriteLine("internal protected = A protected internal member is accessible from the current assembly or from types that are derived from the containing class");
                    break;
                default:
                    break;
            }
        }

        public static void WhatAreManipulators()
        {
            Console.WriteLine("What are manipulators??<</>>");

            Console.WriteLine("Manipulators are the functions which can be used in conjunction with the insertion (<<) and extraction (>>) operators on an object." +
                "Examples are endl and setw these is used in c++..." +
                "Manipulators are used to changing formatting parameters on streams and to insert or extract certain special characters.");
        }

        public static void WhatIsAConstructor()
        {
            Console.WriteLine("What is a Constructor?");
            Console.WriteLine("______________________-");
            Console.WriteLine("*Constructor is a method used to initialize the state of an object");
            Console.WriteLine("*it gets invoked at the time of object creation. ");
        }

        public static void RulesForConstructor()
            {
            Console.WriteLine("Rules for constructor are:" +
                "Constructor Name should be same as class name." +
                "A constructor must have no return type");
            }

        public static void Destructor()
        {
            Console.WriteLine("Destructor");
            Console.WriteLine("A destructor is a method which is automatically called when the object is made of scope or destroyed.Destructor name is also same as class name but with the tilde symbol before the name.");
            Console.WriteLine("~OOPParadigm");
        }
        
        public static void VirtualVsAbstract()
        {
            Console.WriteLine("VirtualVsAbstract");
            Console.WriteLine("With abstract methods it has to be implmeneted in the derived unlike virtual that can be");
            Console.WriteLine("Virtual however have implementation in base aswell as in derived unlike abstract which only has in the derived");
            Console.WriteLine("A virtual function is a member function of a class, and its functionality can be overridden in its derivedclass." +
                " This function can be implemented by using a keyword called virtual, and it can be given duringfunction declaration.");
            Console.WriteLine(@"what is an abstract method?
        method without implementation in the base
        but must be implementedin derived classes");
        }

        public static void WhatIsAFriendFunction()
        {
            Console.WriteLine("What are friend function?");
            Console.WriteLine("A friend function is a friend of a class that is allowed to access to Public, private or protected data inthat same class." +
                " If the function is defined outside the class cannot access such information.Friend can be declared anywhere in the class declaration," +
                " and it cannot be affected by access controlkeywords like private, public or protected");
            Console.WriteLine("these are functions which perform operations on data members");
        }

    }
}
