namespace FourSistersandTheDuckBear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How chocolate eggs have you gathered?");
            int eggCounter = Convert.ToInt32(Console.ReadLine());


            int forSisters = eggCounter / 4;
            int forDuckbear = eggCounter % 4;

            Console.WriteLine("Each sister gets " + forSisters + ".");
            Console.WriteLine("The duckbear gets " + forDuckbear + ".");
        }
    }
}
