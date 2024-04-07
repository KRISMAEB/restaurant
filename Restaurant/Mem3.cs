using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    using System;

    public class Mem3
    {
        public static string DisplayMenu(string day)
        {
            string welcome = "";
            string firstMenu = "";
            string secondMenu = "";
            string thirdMenu = "";

            switch (day.ToLower())
            {
                case "lunes":
                case "miyerkules":
                case "biyernes":
                    welcome = "Menu for " + day + ":";
                    firstMenu = "Gotong Batangas ... 70 pesos";
                    secondMenu = "Carbonara ... 120 pesos";
                    thirdMenu = "Instant Noodles ... 40 pesos";
                    break;
                case "martes":
                case "huwebes":
                case "sabado":
                    welcome = "Menu for " + day + ":";
                    firstMenu = "Arroz Caldo ... 143 pesos";
                    secondMenu = "Spaghetti ... 59 pesos";
                    thirdMenu = "Palabok ... 133 pesos";
                    break;
                default:
                    return "Restaurant is closed on Linggo.\nPlease input another day:";
            }

            return welcome + "\n" + firstMenu + "\n" + secondMenu + "\n" + thirdMenu;
        }

        public static double ComputeTotalPrice(int quantity, double price)
        {
            double totalPrice = quantity * price;

            if (quantity > 5)
            {
                totalPrice *= 0.9; // Apply 10% discount for orders greater than 5
            }

            return totalPrice;
        }
    }
}
