using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace AdmissionModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your GPA: ");
            double gradePointAverage= Convert.ToDouble(ReadLine());
            Write("Enter your admission test score: ");
            double admissionScore = Convert.ToDouble(ReadLine());
            WriteLine("the result is: {0}", returningResult(gradePointAverage, admissionScore));
            


        }
        public static string returningResult(double gpa, double atc)
        {
            
            if ((gpa >= 3.0 && atc >= 60.0) || (gpa < 3.0 && atc >= 80.0))
                return ("Accepted!");
            else
                return ("Rejected");
        }
    }
}
