using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My Book");
            book.AddGrade(89.1);
            book.AddGrade(29.9);
            book.AddGrade(56.3);

            var stats = book.GetStats();

            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");

        }
    }
}
