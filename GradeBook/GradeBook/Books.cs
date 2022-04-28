using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Books
    {
        public Books(String name)
        {
            grades = new List<double>();  
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public List<double> grades;
        public string name;
        private double average = 0;
        private double lowest = 120, highest, number;

        public void ShowStatistic()
        {
            for (int i = 0; i < this.grades.Count; ++i)
            {
                Console.WriteLine(this.grades[i]);
            }

            Console.WriteLine("Calculating....\n");

            for (int i = 0; i < this.grades.Count; ++i)
            {
                highest = Math.Max(this.grades[i], highest);
                lowest = Math.Min(this.grades[i], lowest);
                average += this.grades[i];
            }

            average = average / this.grades.Count;
            Console.WriteLine("Lowest" + lowest);
            Console.WriteLine("Highest" + highest);
            Console.WriteLine("Average" + average);

        }

    }
}
