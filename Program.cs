using System;

namespace CSharpEducation.Practice3
{
    class Program
    {
        static void Main()
        {
            var student = new Student("Mark", 22);
            student.PrintStudentName();
            Console.ReadKey();
        }
    }
}
