using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOManipulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           //DirectoryInfo dir = new DirectoryInfo(@"C:\SampleDirectory1");
           //dir.Create();

           //FileInfo file = new FileInfo(@"C:\SampleDirectory1\sample.txt");
           //file.Create();

              //Console.WriteLine("The directory and the text file have been created sucessfully");

            FileStream fs = new FileStream(@"C:\SampleDirectory1\sample.txt", FileMode.OpenOrCreate,FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This text has been written to the file using file input/output manipulation");
            sw.WriteLine("Education is the manifestation of the perfection already in human beings ");
            sw.WriteLine("This text has been appended to the existing content");
            sw.Close();
            fs.Close();
            Console.WriteLine("Some content is written to the file");

            fs = new FileStream(@"C:\SampleDirectory1\sample.txt", FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //var content = sr.ReadToEnd();

            //Console.WriteLine("The file content: {0}", content);

            string lineByLine;
            while ((lineByLine = sr.ReadLine()) != null)
            {
                Console.WriteLine("\nThe file content: {0}", lineByLine);
            }
            sr.Close();
            fs.Close();
          

           Console.ReadKey();
        }
    }
}
