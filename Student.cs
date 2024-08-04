using System;

namespace CSharpEducation.Practice3
{
    internal class Student
    {
        private int Age { get; set; }
        private string Name { get; set; }
        private double AverageScore { get; set; }

        public double GetAverageScore(){ return AverageScore; }

        public void SetAverageScore(double averageScore)
        {
            if(averageScore >= 5 && averageScore <= 0)
                this.AverageScore = averageScore;
        }
        public void RenameStudent(Student student)
        {
            student.Name = "Аноним";
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintStudentName(){
            Console.WriteLine($"name: {Name}, age: {Age}, _averageScore: {AverageScore}" );
        }
    }
}