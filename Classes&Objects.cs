using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TaxPayerDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxPayer[] arrayList = new TaxPayer[3];

            int userInput;
            string userSocial;

            for (int i = 0; i < arrayList.Length; i++)
            {
                arrayList[i] = new TaxPayer();

                Write("Enter your Social Security Number: ");
                userSocial = ReadLine();
                Write("Enter your income: ");
                userInput = Convert.ToInt32(ReadLine());

                arrayList[i].SocialSecurity = userSocial;
                arrayList[i].GrossIncome = userInput;
            }
            WriteLine(); WriteLine();
            Array.Sort(arrayList);
            for (int i = 0; i < arrayList.Length; i++)
            {
                WriteLine("SSN for payer#{1}: {0,10}", arrayList[i].SocialSecurity, i + 1);
                WriteLine("Gross income: {0,8}", arrayList[i].GrossIncome.ToString("C"));
                WriteLine("Tax: {0,25}", arrayList[i].IncomeTaxOwed.ToString("C"));
                WriteLine(); WriteLine();
            }
        }
    }

    class TaxPayer: IComparable
    {
        private string socialSecurity;
        private double grossIncome;
        private double incomeTaxOwed;

        public string SocialSecurity
        {
            get { return this.socialSecurity; }
            set { this.socialSecurity = value; }

        }
        public double GrossIncome
        {
            get { return this.grossIncome; }
            set { this.grossIncome = value; getTax(); }
        }
        public double IncomeTaxOwed
        {
            get { return this.incomeTaxOwed; }
        }

        private void getTax()
        {
            if (grossIncome < 30000)
                incomeTaxOwed = grossIncome * 0.15;
            else if (grossIncome >= 30000)
                incomeTaxOwed = grossIncome * 0.28;
        }
        int IComparable.CompareTo(object o)
        {
            int returnVal;
            TaxPayer temp = (TaxPayer)o;
            if (this.incomeTaxOwed > temp.incomeTaxOwed)
                returnVal = 1;
            else if (this.incomeTaxOwed < temp.incomeTaxOwed)
                returnVal = -1;
            else
                returnVal = 0;
            return returnVal;
        }
    }
}
