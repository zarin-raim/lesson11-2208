using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicalwork
{
    class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public double GetAvgGrade()
        {
            int countGrades = Grades.Length;
            double summa = 0;
            foreach(var item in Grades)
            {
                summa += item;
            }

            return summa / countGrades;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
