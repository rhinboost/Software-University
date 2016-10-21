using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                string[] studentProps = Console.ReadLine().Split();
                string name = studentProps[0];

                students[i] = new Student();
                students[i].Grades = new List<double>();
                students[i].Name = name;

                double[] grades = studentProps.Skip(1).Select(double.Parse).ToArray();

                for (int j = 0; j < grades.Length; j++)
                {
                    students[i].Grades.Add(grades[j]);

                    if (j == grades.Length - 1)
                    {
                        students[i].AverageGrade = students[i].Grades.Average();
                    }
                }

            }


            students = students.Where(s => s.AverageGrade >= 5).OrderBy(s=>s.Name).ThenByDescending(s=>s.AverageGrade).ToArray();


            for (int i = 0; i < students.Length; i++)
            {

               Console.WriteLine($"{students[i].Name} -> {students[i].AverageGrade:f2}");

            }

            Console.ReadKey();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }

    }
}
