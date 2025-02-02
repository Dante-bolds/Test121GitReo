namespace DominionofKings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many estates do you have?");
            int estateCounter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many duchies do you have?");
            int duchyCounter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many provinces do you have?");
            int provinceCounter = Convert.ToInt32(Console.ReadLine());

            int total = (estateCounter * 1) + (duchyCounter * 3) + (provinceCounter * 6);
            Console.WriteLine("Your point total: " + total);
        }
    }
}
