using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace _4_A_WriteCustomersRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            double miniBal;
            const char DELIM = ',';
            Customer c1 = new Customer();
            string records;
            string[] arrayList;
            FileStream file = new FileStream("customers.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            Write("Enter minimum balance due>> ");
            miniBal = Convert.ToDouble(ReadLine());

            WriteLine("  ID#   |   NAME   |   BALANCE");

            records = reader.ReadLine();
            while (records != null)
            {
                arrayList = records.Split(DELIM);
                c1.IdNum = Convert.ToInt32(arrayList[0]);
                c1.Name = arrayList[1];
                c1.Balance = Convert.ToDouble(arrayList[2]);
                if (c1.Balance >= miniBal)
                { WriteLine("{0,5}{1,11}{2,13}", c1.IdNum, c1.Name, c1.Balance.ToString("C")); }

                records = reader.ReadLine();
            }
            reader.Close();
            file.Close();
        }
    }
    class Customer
    {
        public int IdNum { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public Customer(int id, string name, double bal)
        {
            this.IdNum = id;
            this.Name = name;
            this.Balance = bal;
        }
        public Customer() { }
    }
}
