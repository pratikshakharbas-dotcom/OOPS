using System;

public class Chocolate
{
    public string Color1;
    public string Color2;
    public int Weight;
    public string MfgDate;
    public string ExpiryDate;
    public string NutritionInfo;
}

public class Validator
{
    public void CheckChocolate(Chocolate c)
    {
        // 1. Check wrapper colors
        if (c.Color1 != "Blue" || c.Color2 != "White")
        {
            Console.WriteLine("Error: Wrapper must be Blue and White");
            return;
        }

        // 2. Check weight
        if (c.Weight != 20)
        {
            Console.WriteLine("Error: Weight must be 20g");
            return;
        }

        // 3. Check Mfg Date
        if (string.IsNullOrEmpty(c.MfgDate))
        {
            Console.WriteLine("Error: Mfg date is missing");
            return;
        }

        // 4. Check Expiry Date
        if (string.IsNullOrEmpty(c.ExpiryDate))
        {
            Console.WriteLine("Error: Expiry date is missing");
            return;
        }

        // 5. Check nutrition info
        if (string.IsNullOrEmpty(c.NutritionInfo))
        {
            Console.WriteLine("Error: Nutrition info is missing");
            return;
        }

        Console.WriteLine("All tests passed. Chocolate is ready!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Welcome to " + companyName);

        Chocolate snatch = new Chocolate();

        Console.WriteLine("Enter Color 1:");
        snatch.Color1 = Console.ReadLine();

        Console.WriteLine("Enter Color 2:");
        snatch.Color2 = Console.ReadLine();

        Console.WriteLine("Enter Weight:");
        snatch.Weight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Manufacturing Date:");
        snatch.MfgDate = Console.ReadLine();

        Console.WriteLine("Enter Expiry Date:");
        snatch.ExpiryDate = Console.ReadLine();

        Console.WriteLine("Enter Nutrition Info:");
        snatch.NutritionInfo = Console.ReadLine();
        snatch.NutritionInfo = Console.ReadLine();

        Validator v = new Validator();
        v.CheckChocolate(snatch);
    }
}

