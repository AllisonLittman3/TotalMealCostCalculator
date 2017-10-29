using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMealCostCalculator
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("What was your meal cost?");
            double mealCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What percentage of your meal cost would you like to tip?");
            double tipPercent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the tax percentage?");
            double taxPercent = Convert.ToDouble(Console.ReadLine());

            double totalCost = (mealCost + Tip(mealCost, tipPercent) + Tax(mealCost, taxPercent));

            Console.WriteLine("Your total meal cost is: $" + totalCost);
            Console.ReadLine();
        }
        public static double Tip(double mealCost, double tipPercent)
        {
            double tip;
            if (tipPercent == 0)

                tip = 0;

            else

                tip = mealCost * (tipPercent / 100);

            return tip;
        }
        public static double Tax(double mealCost, double taxPercent)
        {
            double tax;
            if (taxPercent == 0)
                tax = 0;
            else
                tax = mealCost * (taxPercent / 100);
         
            return tax;
        }

    }
}