using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            salesRecord();
        }
        
        static void salesRecord()

        {
            Console.Write("How many sales did you make?: ");

            CommissionEarned();
        }

        static void CommissionEarned()
        {


            double commissionMade;
            int totalSales;


            totalSales = Int32.Parse(Console.ReadLine());


            if (totalSales >= 0 || totalSales <= 999)
            {
                commissionMade = totalSales * 0.03;
            }

            else if (totalSales <= 2999)
            {
                commissionMade = totalSales * 0.04;
            }

            else
            {
                commissionMade = totalSales * 0.05;
            }


            Console.WriteLine($"You Made {commissionMade:c} In Commissions.");

        }
    }
    }

