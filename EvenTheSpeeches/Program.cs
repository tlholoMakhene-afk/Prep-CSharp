using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheSpeeches
{
    class Program
    {
        static void Main(string[] args)
        {

            Speech speech = new Speech();
            List<string>  sspeechList = speech.GetSpeechFromTxtFile();
            foreach  (string s in sspeechList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();


        }
    }
}
