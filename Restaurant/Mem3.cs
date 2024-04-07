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
    public static double GetPrice(string menuItem, string day)
    {
        double price = 0;
        if (day.ToLower() == "lunes" || day.ToLower() == "miyerkules" || day.ToLower() == "biyernes")
        {
            switch (menuItem.ToLower())
            {
                case "gotong batangas":
                    return price = 70;
                case "carbonara":
                    return price = 120;
                case "instant noodles":
                    return price = 40;
                default:
                    return 0;
            }
        }
        else if (day.ToLower() == "martes" || day.ToLower() == "huwebes" || day.ToLower() == "sabado")
        {
            switch (menuItem.ToLower())
            {
                case "arroz caldo":
                    return price = 143;
                case "spaghetti":
                    return price = 59;
                case "palabok":
                    return price = 133;
                default:
                    return 0;

            }
        }
        return price;
    }

    public static double ComputeTotalPrice(int quantity, double price)
    {
        double totalPrice = quantity * price;

        return totalPrice;
    }
    public static double discount(int quantity, double price)
    {
        double discount = 0;

        if (quantity > 5)
        {
            discount = price * 0.10;

        }

        return discount;
    }
    public static double discounted(double price, double discount)
    {

        return price - discount;
    }



}