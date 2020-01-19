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
            
            var result = 0.0;

            foreach(var number in book)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average is {result:N1}");
            
 
        }
    }
}
