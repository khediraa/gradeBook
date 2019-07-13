using System;
using System.Collections.Generic;

namespace GradeBook {
    public class Book
    {
       private string name;
       private List<double> grades;

        public Book(string name) {
            this.name = name;
            grades = new List<double>();
        }
        public void AddGrade(double v)
        {
            grades.Add(v);
        }

        public Statistics GetStats() {
            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach(var grade in grades) {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }
    }
}