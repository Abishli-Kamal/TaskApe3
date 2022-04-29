using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    internal class Student
    {
        public int Id { get; }
        private int _id = 0;
        public string Fullname { get; set; }
        public int Point
        {
            get { return Point; }
            set
            {
                if (value < 0)
                {
                    Point = value;
                }
            }
        }

        public Student(string fullname, int point)
        {
            Id = ++_id;
            Fullname = fullname;
            Point = point;
        }

      

        public void StudentInfo()
        {
            Console.WriteLine($"Fullname:{Fullname} Point{Point}");
        }
    }
}
