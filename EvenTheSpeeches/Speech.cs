using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheSpeeches
{
   public class Speech
    {

        private string sSpeech;
        private DateTime dateTime;

        public string SSpeech { get => sSpeech; set => sSpeech = (value== null) || (value== String.Empty) ? value: "No Speech"; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }

        public Speech()
        {
                
        }


        public Speech(string speech)
        {
            this.sSpeech = speech;
            this.dateTime = DateTime.Now;
        }

        public List<string> GetSpeechFromTxtFile()
        {
            FileHandler fh = new FileHandler("IDefinitelyGotTheJob.txt");
            List<string> speechList = fh.ReadData();

            return speechList;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
