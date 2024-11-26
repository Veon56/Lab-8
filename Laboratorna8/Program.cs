using Laboratorna8;

namespace Lab8;
public static class Program
{
    private static readonly List<Animal> DataList = [];

    internal static void Main()
    {
        Animals();
        bool run = true;

        while (run)
        {
            int choose;

            Console.WriteLine($"\n1.Output all informtion\n2.Change certain characteristics\n3.Compare 2 objects\n4.Work with Fraction\n5.Close programm");
            Console.Write($"Choose action:");
            choose = int.Parse(Console.ReadLine()!);

            switch(choose)
            {
                case 1:
                    OutInfo();
                    break;
                
                case 2:
                    ChangeInfo();
                    break;

                case 3:
                    CompareObj();
                    break;
                
                case 4:
                    FractionProg();
                    break;

                case 5:
                    Console.Write($"Closing...: ");
                    run = false;
                    break;


                default:
                    Console.WriteLine("\nWrong choice, try again.\n");
                    break;
            }
        }
    }

    public static void Animals()
    {
        var fish1 = new Fish(6, 2, AnimalGender.Female, Fishtype.Freshwater);
        DataList.Add(fish1);
        var fish2 = new Fish(7, 3, AnimalGender.Male, Fishtype.Oceanic);
        DataList.Add(fish2);
        var fish3 = new Fish(4, 1, AnimalGender.Female, Fishtype.Freshwater);
        DataList.Add(fish3);
        var fish4 = new Fish(8, 5, AnimalGender.Male, Fishtype.Freshwater);
        DataList.Add(fish4);
        var fish5 = new Fish(5, 2, AnimalGender.Female, Fishtype.Oceanic);
        DataList.Add(fish5);

        var bird1 = new Bird(3, 1, AnimalGender.Female, Birdtype.Flying);
        DataList.Add(bird1);
        var bird2 = new Bird(5, 2, AnimalGender.Male, Birdtype.Ground);
        DataList.Add(bird2);
        var bird3 = new Bird(4, 1, AnimalGender.Female, Birdtype.Flying);
        DataList.Add(bird3);
        var bird4 = new Bird(6, 3, AnimalGender.Male, Birdtype.Flying);
        DataList.Add(bird4);
        var bird5 = new Bird(2, 1, AnimalGender.Female, Birdtype.Ground);
        DataList.Add(bird5);
    }

    public static void OutInfo()
    {
        Console.WriteLine("Animals: ");
        int i = 0;
        foreach (var data in DataList)
        {
            Console.Write($"{i}. ");
            data.ShowInfo();
            i++;
        }
    }

    public static void ChangeInfo()
    {
        Console.WriteLine("Animals: ");
       
        foreach (var data in DataList)
        {
            data.ShowInfo();
        }

        bool run = true;
        int c = 0;

        while (run)
        {
            int choose;
            Console.WriteLine("Choose what you want to change: ");
            Console.WriteLine("1. Add 1 year for animal");
            Console.WriteLine("2. Change weight of animal");
            Console.WriteLine("3. Change type of animal");
            Console.WriteLine("select units of measurement:");
            choose = int.Parse(Console.ReadLine()!);

            switch (choose)
            {
                case 1:
                    Console.Write("Choose animal: ");
                    c = int.Parse(Console.ReadLine()!);
                    DataList[c].Birthday();
                    Console.WriteLine("data changed successfully");
                    
                    break;

                case 2:
                    Console.Write("Choose animal: ");
                    c = int.Parse(Console.ReadLine()!);
                    DataList[c].ChangeWeight();
                    Console.WriteLine("data changed successfully");

                    break;

                case 3:
                    Console.Write("Choose animal: ");
                    c = int.Parse(Console.ReadLine()!);
                    DataList[c].ChangeType();
                    Console.WriteLine("data changed successfully");
                    break;
                
                default:
                    Console.WriteLine("\nWrong choice, try again.\n");
                    continue;
            }

            run = false;
        }
    }

    public static void CompareObj()
    {
        Console.WriteLine("Animals: ");
        int i = 0;
        foreach (var data in DataList)
        {
            Console.Write($"{i++}. ");
            data.ShowInfo();
        }

        Console.Write($"Choose 1 entrant: ");
        ushort s1 = Convert.ToUInt16(Console.ReadLine());

        Console.Write($"Choose 2 entrant: ");
        ushort s2 = Convert.ToUInt16(Console.ReadLine());

        if (DataList[s1] == DataList[s2])
            Console.WriteLine("Objects are equal!");
        else 
            Console.WriteLine("Objects are not equal!"); 
    }

    public static void FractionProg()
    {
        Console.WriteLine("Fraction Class Demonstration\n");

        Fraction fraction1 = new Fraction(3, 4);
        Fraction fraction2 = new Fraction(5, 6);

        Console.WriteLine($"Fraction 1: {fraction1}");
        Console.WriteLine($"Fraction 2: {fraction2}\n");

        Console.WriteLine("Unary Operations:");
        Console.WriteLine($"Positive of Fraction 1: {+fraction1}");
        Console.WriteLine($"Negative of Fraction 2: {-fraction2}\n");

        Console.WriteLine("Binary Operations:");
        Console.WriteLine($"Fraction 1 + Fraction 2 = {fraction1 + fraction2}");
        Console.WriteLine($"Fraction 1 - Fraction 2 = {fraction1 - fraction2}");
        Console.WriteLine($"Fraction 1 * Fraction 2 = {fraction1 * fraction2}");
        Console.WriteLine($"Fraction 1 / Fraction 2 = {fraction1 / fraction2}\n");

        Console.WriteLine("Comparison Operations:");
        Console.WriteLine($"Fraction 1 > Fraction 2: {fraction1 > fraction2}");
        Console.WriteLine($"Fraction 1 < Fraction 2: {fraction1 < fraction2}");
        Console.WriteLine($"Fraction 1 >= Fraction 2: {fraction1 >= fraction2}");
        Console.WriteLine($"Fraction 1 <= Fraction 2: {fraction1 <= fraction2}");
        Console.WriteLine($"Fraction 1 == Fraction 2: {fraction1 == fraction2}");
        Console.WriteLine($"Fraction 1 != Fraction 2: {fraction1 != fraction2}\n");

        Console.WriteLine("Reducing Fractions:");
        Fraction fraction3 = new Fraction(8, 12);
        Console.WriteLine($"Original Fraction: {fraction3}");
        Console.WriteLine($"Reduced Fraction: {fraction3.Reduce()}\n");

        Fraction fraction = new Fraction(3, 4);
double decimalValue = fraction.Doooble();
Console.WriteLine($"Decimal value: {decimalValue}");

        Console.WriteLine("\nProgram completed successfully.");
    }
   
}