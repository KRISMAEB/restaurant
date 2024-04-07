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
class Program
{
    static void Main(string[] args)
    {
        string choice;

        do
        {
            string selectedDay;
            bool validDay = false;
            do
            {
                Console.WriteLine("Enter the day of the week (Lunes, Martes, Huwebes, Miyerkules, Biyernes, Sabado):");
                selectedDay = Console.ReadLine();

                try
                {
                    List<(string, double)> menuForDay = GetMenuForDay(selectedDay);

                    if (menuForDay == null)
                    {
                        continue;
                    }

                    Console.WriteLine($"Menu for {selectedDay}:");
                    foreach (var item in menuForDay)
                    {
                        Console.WriteLine($"{item.Item1}: {item.Item2} pesos");
                    }
                    Console.WriteLine();

                    validDay = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            } while (!validDay);

            choice = GetYesNoInput("Do you want to order another meal?");

        } while (choice.Equals("yes", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Thank you for coming! Have a nice day.");
    }

    static List<(string, double)> GetMenuForDay(string day)
    {
        List<(string, double)> menu = new List<(string, double)>();

        switch (day.ToLower())
        {
            case "lunes":
            case "martes":
            case "miyerkules":
                menu.Add(("Gotong Batangas", 70));
                menu.Add(("Carbonara", 120));
                menu.Add(("Instant Noodles", 40));
                break;
            case "huwebes":
            case "biyernes":
            case "sabado":
                menu.Add(("Arroz Caldo", 143));
                menu.Add(("Spaghetti", 59));
                menu.Add(("Palabok", 133));
                break;
            default:
                throw new ArgumentException("Invalid day. Please enter a valid day of the week.");
        }

        return menu;
    }

    static string GetYesNoInput(string message)
    {
        string input;
        do
        {
            Console.WriteLine($"{message} (yes/no)");
            input = Console.ReadLine();

            if (!input.Equals("yes", StringComparison.OrdinalIgnoreCase) && !input.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        } while (!input.Equals("yes", StringComparison.OrdinalIgnoreCase) && !input.Equals("no", StringComparison.OrdinalIgnoreCase));

        return input;
    }
}
