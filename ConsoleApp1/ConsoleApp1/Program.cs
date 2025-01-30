// Written by Dante
// 1/15/2025

namespace FirstProjectSpring2025A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> aListOfStudents = new List<Student>();
            Student aStudent1 = new Student();
            Student aStudent2 = new Student();
            Student aStudent3 = new Student();
            Student aStudent4 = new Student(4, "John", "Doe", "", "Undecided");  
            Student aStudent5 = new Student(5, "Jane", "Doe", "", "Aviation");  

            aStudent1.StudentId = 1;
            aStudent1.FirstName = "Marie";
            aStudent1.LastName = "Romanov";
            aStudent1.MiddleName = "Anne";
            aStudent1.Major = "Biology";

 
            aStudent2.StudentId = 2;
            aStudent2.FirstName = "Faith";
            aStudent2.LastName = "Bolden";
            aStudent2.MiddleName = "";
            aStudent2.Major = "Information Technology";

            aStudent3.StudentId = 3;
            aStudent3.FirstName = "Greg";
            aStudent3.LastName = "Chun";
            aStudent3.MiddleName = "O.";
            aStudent3.Major = "Undecided";

            aListOfStudents.Add(aStudent1);
            aListOfStudents.Add(aStudent2);
            aListOfStudents.Add(aStudent3);
            aListOfStudents.Add(aStudent4);
            aListOfStudents.Add(aStudent5);

            /*
            Console.WriteLine(aStudent1.ToString());
            Console.WriteLine(aStudent2.ToString());
            Console.WriteLine(aStudent3.ToString());
            Console.WriteLine(aStudent4.ToString());    
            Console.WriteLine(aStudent5.ToString());
            */

            //This now the preferred code
            foreach(Student aStudent in aListOfStudents)
            {
                Console.WriteLine(aStudent.ToString());
            }

            // This is the old format that you may see online
            /*
            foreach (var s in aListOfStudents)
            {
                Console.WriteLine(s.ToString());
            }
            */
        }
    }
}