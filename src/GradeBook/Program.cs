using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {   
            var grades = new List<double>() {18.7,82.7,18.4};
            grades.Add(14.8);
            
            var result = 0.0;

            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average is {result:N1}");
            
 
        }
    }
}
