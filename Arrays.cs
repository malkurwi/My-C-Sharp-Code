using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Array;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demo = new int[8] { 12, 15, 7, 3, 19, 8, 10, 2 };
            int userInput;
            
            WriteLine("The list order from first to last:");
            for (int x =0; x < demo.Length; ++x)
                {   
                    Write("{0, 4}",demo[x]);
                }
            WriteLine("\n-----------------------------------");
            
            WriteLine("The list order from last to first:");
            Reverse(demo);
            for (int x = 0; x < demo.Length; ++x)
            {
                
                Write("{0, 4}", demo[x]);
            }
            WriteLine("\n-----------------------------------");
            Reverse(demo);
            Write("Enter a number from 0 - 7 to view it's value: ");
            userInput = Convert.ToInt32(ReadLine());
            while (userInput != 999)
            {
                WriteLine("Position {0} has a value of {1}.", userInput, demo[userInput]); 
                Write("Enter a number from 1 - 8 to view it's value: ");
                userInput = Convert.ToInt32(ReadLine());
            }
        }
    }
}
