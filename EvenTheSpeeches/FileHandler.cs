using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//To Access filestream, streamwrite ....

namespace EvenTheSpeeches
{
    public class FileHandler
    {
        //Purpose of this class is to methods dynamic therefore any object can use them
        private string filePath;
        private FileStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public FileHandler(string filepara = "Problem.txt")
        {
            this.filePath = filepara;
        }

        public List<string> ReadData()
        {
            //returning a list makes the method dynamic to use in all objects
            List<string> rawData = new List<string>();
            try
            {
                stream = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);

                while (!reader.EndOfStream)
                {
                    rawData.Add(reader.ReadLine());
                }

            }
            catch (FileNotFoundException)
            {
                FileHandler file = new FileHandler();
                file.WriteData(new List<string>() {
                string.Format("File = {0} Not Found at {1} {2}",
                this.filePath,
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToShortTimeString())});

            }
            catch (DirectoryNotFoundException)
            {
                FileHandler file = new FileHandler();
                file.WriteData(new List<string>() {
                string.Format("Directory for = {0} Not Found at {1} {2}",
                this.filePath,
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToShortTimeString())});
            }
            catch (IOException)
            {
                FileHandler file = new FileHandler();
                file.WriteData(new List<string>() { "I dont know what happened but it was bad" });
            }
            finally
            {
                reader.Close();
                stream.Close();
            }

            return rawData;
        }

        public void WriteData(List<string> dataToWrite)//passing a list of strings makes the method dinamic to use in all objects
        {

            try
            {
                //if the file exists we need to update it with the append mode
                if (File.Exists(this.filePath))
                {
                    stream = new FileStream(this.filePath, FileMode.Append, FileAccess.Write);
                }
                //if it does not exist we need to create it. Open or create mode overrides data in the file
                else
                {
                    stream = new FileStream(this.filePath, FileMode.Create, FileAccess.Write);
                }

                writer = new StreamWriter(stream);

                foreach (string itemToWrite in dataToWrite)
                {
                    writer.WriteLine(itemToWrite);
                    writer.Flush();
                }

            }
            catch (FileNotFoundException)
            {
                FileHandler file = new FileHandler();
                file.WriteData(new List<string>() {
                string.Format("File = {0} Not Found at {1} {2}",
                this.filePath,
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToShortTimeString())});

            }
            catch (DirectoryNotFoundException)
            {
                FileHandler file = new FileHandler();
                file.WriteData(new List<string>() {
                string.Format("Directory for = {0} Not Found at {1} {2}",
                this.filePath,
                DateTime.UtcNow.ToShortDateString(),
                DateTime.UtcNow.ToShortTimeString())});
            }
            catch (IOException)
            {
                FileHandler file = new FileHandler();
                file.WriteData(new List<string>() { "I dont know what happened but it was bad" });
            }
            finally
            {
                writer.Close();
                stream.Close();
            }


        }


    }
}


