using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuestionsAnswers
{
   public abstract class Person
    {
        private string sName;//actaul name
        private string sSurname;//fields are variables within a class defintion
        private int age;

        //Encapsulation is an attributes of an object, and it contains all data which is hidden.
        //That hidden data can be restricted to the members of that class


      //properties -- are a mix between state and operations 

        public string SName { get => sName; set => sName = (value == null ) || (value == String.Empty) ? "None": value; }
        public string SSurname { get => sSurname; set => sSurname = (value == null) || (value == String.Empty) ? "None" : value; }
        public int Age { get => age; set => age = (value == 0) ? 25 : value; }
        //get is readonly 
        //set is writeonly
        protected Person(string sName, string sSurname, int age)
        {
            this.sName = sName;
            this.sSurname = sSurname;
            this.age = age;
        }

        protected Person()
        {

        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Surname: {1}", this.sName, this.sSurname);
        }

        public abstract void DisplayDetails();

        public virtual string VirtualMethod()
        {
            return "WE in the base";
        }
        


    }
}
