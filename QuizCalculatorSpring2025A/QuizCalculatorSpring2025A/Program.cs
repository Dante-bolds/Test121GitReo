using QuizCalculatorSpring2025;

namespace QuizCalculatorSpring2025A
{

    public class Program
    {
        public static void Main(string[] args)
        {
            QuizCalculator aQuizcalculator = new QuizCalculator();
            aQuizcalculator.Quiz1 = 80.0;
            aQuizcalculator.Quiz2 = 85.0;
            aQuizcalculator.Quiz3 = 90.0;
            aQuizcalculator.Quiz4 = 85.0;

            Console.WriteLine("Total:" + aQuizcalculator.CalcTotal());
            Console.WriteLine("Average:" + aQuizcalculator.CalcAverage());
            Console.WriteLine("Letter grade:" + aQuizcalculator.CalcLetterGrade());
        }

    }
}
