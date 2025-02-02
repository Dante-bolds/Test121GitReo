namespace TriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle's width: ");
            double width = Convert.ToDouble(widthText);

            Console.WriteLine("Triangle's height: ");
            double height = Convert.ToDouble(heightText);

            double area = (width * height) / 2;
            Console.WriteLine("Area: " + area);
        }
    }
}
