using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {   
            
            var book = new Book("class1");
            book.AddGrade(89.1);
            book.AddGrade(65.8);
            book.AddGrade(80.4);
            book.AddGrade(100.0);
            book.GetStatistics();
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The average is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}")
 
        }
    }
}
