namespace DefenseofConsolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";

            Console.Write("What is the Target Row?: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the Target Column?: ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row - 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");

            Console.Beep();
        }
    }
}
