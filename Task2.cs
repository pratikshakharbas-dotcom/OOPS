using System;
public class TechNova
{
    public string ScreenType;
    public string BatteryCapacity;
    public string OperatingSystem;
    public string CameraResolution;
    public string StorageOptions;
    public int Warranty;

}

public class Validatorclass
{
    public void CheckNovaX12(TechNova t)

    {
        if (t.ScreenType != "OLED screen")
        {
            Console.WriteLine("Error: Screen type must be OLED screen");
            return;
        }
        if (t.BatteryCapacity != "4000mah")
        {
            Console.WriteLine("Error: Battery capacity must be at least 4000mah");
            return;
        }
        if (t.OperatingSystem != "Android 14")
        {
            Console.WriteLine("Error: Operating system must be Android 14");
            return;
        }
        if (t.CameraResolution != "108MP")
        {
            Console.WriteLine("Error: Camera resolution must be 108MP");
            return;
        }
        if (t.StorageOptions != "128GB/256GB")
        {
            Console.WriteLine("Error: Storage options must be 128GB/256GB");
            return;
        }
        if (t.Warranty >= 2)
        {
            Console.WriteLine("Error: Warranty must be 2 years");
            return;
        }
    }
}
public class main
{
    static void Main(string[] args)
    {
        TechNova nova = new TechNova();
        nova.ScreenType = "OLED screen";
        nova.BatteryCapacity = "4500mah";
        nova.OperatingSystem = "Android 14";
        nova.CameraResolution = "108MP";
        nova.StorageOptions = "128GB/256GB";
        nova.Warranty = 2;
        Validatorclass validator = new Validatorclass();
        validator.CheckNovaX12(nova);
    }
}




