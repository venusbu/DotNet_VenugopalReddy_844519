using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 85, 89, 94, 96, 97, 98 };

            Result objR = new Result(); ;
            var avg = objR.GetAverageMarks(marks);
            objR.DisplayAverage(avg);

            Console.ReadKey();

        }
        public interface  IExam
        {
            double GetAverageMarks(int[] marks);
            void DisplayAverage(double avg);
        }
        public interface IStudent
        {
            void ShowGrade(double avg);
        }
        public class Result : IExam, IStudent
        {
            public void DisplayAverage(double avg)
            {
                Console.WriteLine("The average marks = {0}", avg);
            }
            public double GetAverageMarks(int[] marks)
            {
                int total;
                double avg;
                total = 0;
                for (int i = 0; i < marks.Length; i++)
                total += marks[i];

                avg = total / marks.Length;
                return avg;
            }
            public void ShowGrade(double avg)
            {
                if (avg >= 70.00)
                    Console.WriteLine("passed in distinction");
                else
                    Console.WriteLine("Not a distinction");
            }
           
        }
    }
}
