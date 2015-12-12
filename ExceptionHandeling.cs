using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OrderExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num=0, quan=0, day=0;
            Order[] orderList = new Order[2];

            for (int i = 0; i < orderList.Length; i++)
            {
                try
                {
                    Write("Enter an item number(100-999): ");
                    num = Convert.ToInt32(ReadLine());
                    Write("Enter quantity number(1-12): ");
                    quan = Convert.ToInt32(ReadLine());
                    Write("Enter the day ordered(1-31): ");
                    day = Convert.ToInt32(ReadLine());
                    orderList[i] = new Order(num, quan, day);
                }
                catch (ArgumentException e)
                {
                    WriteLine(e.Message);
                    --i;
                }
            }
            for (int i = 0; i < orderList.Length; i++)
            {
                WriteLine("Item# {0,10}", orderList[i].ItemNum);
                WriteLine("Quantity: {0,4}", orderList[i].Quantity);
                WriteLine("Day ordered: {0}", orderList[i].DayOrdered);
            }
        }
    }
    class Order
    {
        private int itemNum;
        private int quantity;
        private int dayOrdered;

        public int ItemNum { get { return itemNum; } set { itemNum = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public int DayOrdered { get { return dayOrdered; } set { dayOrdered = value; } }

        public Order(int num, int quan, int day)
        {
            if(!(num >= 100 && num <= 999) || !(quan >= 1 && quan <= 12) || !(day >= 1 && day <= 31))
            {
                throw new ArgumentException("Error with entering data.");
            }
            if ((num >= 100 && num <= 999) && (quan >= 1 && quan <= 12) && (day >= 1 && day <= 31))
            {
                this.itemNum = num;
                this.quantity = quan;
                this.dayOrdered = day;
            }
            else
            {
                this.itemNum = 0;
                this.quantity = 0;
                this.dayOrdered = 0;
            }



        }
    }
}
