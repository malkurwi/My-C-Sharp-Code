using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FoodOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Choose one of the Items number(20, 23, 25, 31)\nOr\nChoose one of the Items Description(Enchilada, Burrito, Taco, Tostada)\n >>  ");
            string choosen =ReadLine();
            
            int num;
            if(int.TryParse(choosen, out num))
            {
                GetDetailes(num,choosen);
            
            }
            else
            GetDetailes(choosen, num);
        }
        private static void GetDetailes(int choosenNum, string choosenString)
        {
            if (choosenNum == 20)
            {
                WriteLine("The item description is Enchilada and the item price is $2.95");
            }
            else if (choosenNum == 23)
            {
                WriteLine("The item description is Burrito and the item price is $1.95");
            }
            else if (choosenNum == 25)
            {
                WriteLine("The item description is Taco and the item price is $2.25");
            }
            else if (choosenNum == 31)
            {
                WriteLine("The item description is Tostada and the item price is $3.10");
            }
            else if((choosenNum != 20) && (choosenNum != 23) && (choosenNum != 25) && (choosenNum != 31))
                WriteLine("Item number was not found.");

        }
        private static void GetDetailes(string choosenString, int choosenNum)
        {
            if (!int.TryParse(choosenString, out choosenNum))
            {
                if (choosenString == "Enchilada")
                {
                    WriteLine("The Item number is 20 and the item price is $2.95");
                }
                else if (choosenString == "Burrito")
                {
                    WriteLine("The Item number is 23 and the item price is $1.95");
                }
                else if (choosenString == "Taco")
                {
                    WriteLine("The Item number is 25 and the item price is $2.25");
                }
                else if (choosenString == "Tostada")
                {
                    WriteLine("The Item number is 31 and the item price is $3.10");
                }
                if ((choosenString != "Enchilada") && (choosenString != "Burrito") && (choosenString != "Taco") && (choosenString != "Tostada"))
                {
                    WriteLine("Item description was not found.");
                }
            }
        }
    }
}
