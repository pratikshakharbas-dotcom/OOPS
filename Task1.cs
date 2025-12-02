//Class and Object 
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
        Chocolate snatch = new Chocolate();
        snatch.Color1 = "Blue";
        snatch.Color2 = "yellow";
        snatch.Weight = 20;
        snatch.MfgDate = "01-01-2025";
        snatch.ExpiryDate = "01-01-2026";
        snatch.NutritionInfo = "Good";

        Validator v = new Validator();
        v.CheckChocolate(snatch);
    }
}


