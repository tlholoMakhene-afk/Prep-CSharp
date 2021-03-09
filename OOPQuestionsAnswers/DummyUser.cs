using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuestionsAnswers
{
    public class DummyUser : Person, IDummyUser
    {
        
        private string username;
        //a field are a container of data (username) thats part of a type or itrs instance
        private string password;
        //methods process data on a class,
        //field serves as the datastorage associated with a class or its instance
        private readonly int usersCounted;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public int UsersCounted => usersCounted;

        public DummyUser(string sName, string sSurname, string username, string pword, int age) : base(sName, sSurname, age)
        {
            this.Username = username;
            this.Password = pword;
            this.usersCounted++;
        }

        public DummyUser() : base()
        {
            this.usersCounted++;
        }

        public DummyUser(string sName, string sSurname, int age) : base(sName, sSurname, age)
        {
        }


        public override void DisplayDetails()
        {
            Console.WriteLine("Displayed see {0}", this.ToString());
          
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string VirtualMethod()
        {
            return string.Format("VM in the  dummy");   }




    }
}
