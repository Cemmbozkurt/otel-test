using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Books book1 = new Books("Class Records!");
            book1.AddGrade(90.2);
            book1.AddGrade(100);
            book1.AddGrade(90);
            book1.AddGrade(100);
            book1.ShowStatistic();

            var input = Console.ReadLine();
 


        }
    }
}
