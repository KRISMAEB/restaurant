using System;

public class Menu
{
    public static void DisplayMenu(string day)
    {
        switch (day.ToLower())
        {
            case "lunes":
            case "miyerkules":
            case "biyernes":
                Console.WriteLine("Menu for " + day + ":");
                Console.WriteLine("1. Gotong Batangas ... 70 pesos");
                Console.WriteLine("2. Carbonara ... 120 pesos");
                Console.WriteLine("3. Instant Noodles ... 40 pesos");
                break;
            case "martes":
            case "huwebes":
            case "sabado":
                Console.WriteLine("Menu for " + day + ":");
                Console.WriteLine("1. Arroz Caldo ... 143 pesos");
                Console.WriteLine("2. Spaghetti ... 59 pesos");
                Console.WriteLine("3. Palabok ... 133 pesos");
                break;
            default:
                Console.WriteLine("Restaurant is closed on Linggo.");
                Console.WriteLine("Please input another day:");
                string newDay = Console.ReadLine();
                DisplayMenu(newDay);
                break;
        }
    }
}

public class Order
{
    public string Meal { get; set; }
    public int Quantity { get; set; }

    public Order(string meal, int quantity)
    {
        Meal = meal;
        Quantity = quantity;
    }

    public double CalculateTotalPrice()
    {
        double price = 0;

        switch (Meal.ToLower())
        {
            case "gotong batangas":
                price = 70 * Quantity;
                break;
            case "carbonara":
                price = 120 * Quantity;
                break;
            case "instant noodles":
                price = 40 * Quantity;
                break;
            case "arroz caldo":
                price = 143 * Quantity;
                break;
            case "spaghetti":
                price = 59 * Quantity;
                break;
            case "palabok":
                price = 133 * Quantity;
                break;
            default:
                Console.WriteLine("Invalid meal choice.");
                break;
        }

        if (Quantity > 5)
        {
            return price * 0.9; // 10% discount for quantities greater than 5
        }

        return price;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("What day is it?");
        string day = Console.ReadLine();

        Menu.DisplayMenu(day);

        Console.WriteLine("Enter your preferred meal:");
        string meal = Console.ReadLine();
.
        Console.WriteLine("Enter quantity:");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Order customerOrder = new Order(meal, quantity);
        double totalPrice = customerOrder.CalculateTotalPrice();

        Console.WriteLine("Total Price: " + totalPrice + " pesos");
    }
}