public class Program
{
    static void Main()
    {
        Computer workingPC = new ComputerBuilder()
            .SetCPU("Intel i5")
            .SetGPU("None")
            .SetRam("8gb DDR4 3200Hz")
            .SetStorage("Samsong 1tb SSD")
            .Build();

        Console.WriteLine(workingPC);

        Computer gamingPC = new ComputerBuilder()
            .SetCPU("Intel i9")
            .SetGPU("Nvidia 5090")
            .SetRam("32gb DDR5 6400Hz")
            .SetStorage("Samsong 2tb SSD")
            .Build();

        Console.WriteLine(gamingPC);
    }
}