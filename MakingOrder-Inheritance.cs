using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OrderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippedOrder[] myArray = new ShippedOrder[2];
            double total = 0;
            int orderNumber = 0;
            string customerName = "";
            int orderQuantity = 0;
            for (int i = 0; i < myArray.Length; i++)
            {

                Write("Enter order number: ");
                orderNumber = Convert.ToInt32(ReadLine());

                Write("Enter customer name: ");
                customerName = ReadLine();
                Write("Enter order quantty: ");
                orderQuantity = Convert.ToInt32(ReadLine());
                myArray[i] = new ShippedOrder(orderNumber, customerName, orderQuantity);
                if (i > 0)
                {
                    for (int x = i - 1; x >= 0; x--)
                    {
                        while (myArray[i].OrderNumber == myArray[x].OrderNumber)
                        {
                            Console.WriteLine("Duplicate ORder Numbers found.  Please re-enter a valid order number.");
                            orderNumber = Convert.ToInt32(ReadLine());
                            myArray[i].OrderNumber = orderNumber;
                        }
                    }
                }
                total += myArray[i].TotalPrice;
            }
            Array.Sort(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                WriteLine(myArray[i].ToString());
            }
            WriteLine("the price total for all orders is: {0}", total.ToString("C"));

        }
    }
    class Order
    {
        private int orderNumber;
        private string customerName;
        private int quantityOrdered;
        protected double totalPrice;

        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public int QuantityOrdered
        {
            get { return quantityOrdered; }
            set { quantityOrdered = value; }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
        }

        public Order(int number, string name, int quantity)
        {
            orderNumber = number;
            customerName = name;
            quantityOrdered = quantity;
            totalPrice = quantity * 19.95;
        }
        public Order()
        {

        }

        public override bool Equals(object obj)
        {
            bool x = true;
            if (this.GetType() != obj.GetType())
                x = false;
            else
            {
                Order temp = (Order)obj;
                if (OrderNumber == temp.OrderNumber)
                    x = true;
                else
                    x = false;
            }
            return x;

        }

        public override int GetHashCode()
        {
            return OrderNumber;
        }

        public static void Test2Orders(Order o1, Order o2)
        {
            if (o1.Equals(o2))
                WriteLine("The orders are equal.");
            else
                WriteLine("The orders are not equal.");
        }

        public override string ToString()
        {
            return ("Order# " + GetHashCode() + ", Name: " + CustomerName + ". For " + QuantityOrdered + " items, the total is: " + TotalPrice.ToString("C"));
        }
    }
    class ShippedOrder : Order , IComparable
    {
        public ShippedOrder(int num, string name, int quan) : base(num, name, quan)
        {
            int shippingFee = 4;
            totalPrice = (quan * 19.95) + shippingFee;
        }
        int IComparable.CompareTo(object obj)
        {
            int returnVal;
            ShippedOrder temp = (ShippedOrder)obj;
            if (this.OrderNumber > temp.OrderNumber)
                returnVal = 1;
            else if (this.OrderNumber < temp.OrderNumber)
                returnVal = -1;
            else returnVal = 0;
            return returnVal;
        }
    }
}
