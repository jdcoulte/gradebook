using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if(grade <=100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
 
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;

            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(var index = 0; index < grades.Count; index += 1) 
            {
                result.High = Math.Max(result.High, grades[index]);
                result.Low = Math.Min(result.Low, grades[index]);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades;
        public string Name;
    }
}