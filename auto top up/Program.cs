using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_top_up
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto Top Up For Me console app version 1.0.0 \n");

            double airtimeBalance = 100;
            double accountBalance = 100000000;
            double newAirtimeBalance;
            double newAccountBalance;

            if (airtimeBalance <= 20)
            {
                newAirtimeBalance = airtimeBalance + 100;
                newAccountBalance = accountBalance - 100;
                Console.WriteLine("Your account has been credited with 100 naira \n Your new airtime balance is " + " " + newAirtimeBalance);
                Console.WriteLine("Your account has been debited  with 100 naira \n Your new account balance is " + " " + newAccountBalance);
            }

            else if (airtimeBalance <= 100)
            {
                Console.WriteLine("You airtime balance is less than 100 naira Do you want an auto top up[ Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    newAirtimeBalance = airtimeBalance + 100;
                    newAccountBalance = accountBalance - 100;
                    Console.WriteLine("Your account has been credited with 100 naira \n Your new airtime balance is " + " " + newAirtimeBalance);
                    Console.WriteLine("Your account has been debited  with 100 naira \n Your new account balance is " + " " + newAccountBalance);
                }
                else if (answer == "N")
                {
                    return;
                }

                else
                    return;
            }
            else
                return;












































            Console.ReadKey();

        }
    }
}
