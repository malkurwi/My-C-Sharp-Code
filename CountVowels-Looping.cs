using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Write a phrase: ");
            string word = ReadLine();
            int i = 0;
            int x;
           
            for (x = 0; x < word.Length; ++x)
            {
                
                 
                switch(word[x])
                {
                    case 'a':
                        ++i;
                        break;
                    case 'A':
                        ++i;
                        break;
                    case 'e':
                        ++i;
                        break;
                    case 'E':
                        ++i;
                        break;
                    case 'u':
                        ++i;
                        break;
                    case 'U':
                        ++i;
                        break;
                    case 'O':
                        ++i;
                        break;
                    case 'o':
                        ++i;
                        break;
                    case 'I':
                        ++i;
                        break;
                    case 'i':
                        ++i;
                        break;
                }
            }
            
            WriteLine("the number of vowel letters is: {0}", i);
        }
    }
}
