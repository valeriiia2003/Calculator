namespace userCalculator;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter two nums to use userCalculaor: ");

            int firstArg = Convert.ToInt32(Console.ReadLine());
            int secondArg = Convert.ToInt32(Console.ReadLine());
            int result = new Operations().AddNums(firstArg, secondArg);

            Console.WriteLine($"Result of adding nums = {result}");
        }
        catch 
        {
            throw new FormatException();
        }finally { Console.WriteLine("\nWe have been working at userCalculator"); }
        Console.ReadKey();
    }
}

