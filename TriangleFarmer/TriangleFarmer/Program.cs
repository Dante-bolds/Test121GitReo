namespace TriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the triangle's width?");
            string widthText = Console.ReadLine();
            double width = Convert.ToSingle(widthText);

            Console.WriteLine("What is the triangle's height?");
            string heightText = Console.ReadLine();
            double height = Convert.ToSingle(heightText);

            double area = (width * height) / 2;
            Console.WriteLine("The area is " + area);
        }
    }
}
