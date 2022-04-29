using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    internal class Group
    {

        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        private string _groupNo;
        private int stlimit;
        public int StudentLimit
        {
            get { return stlimit; }
            set
            {
                if (StudentLimit >= 5 && StudentLimit <= 18)
                {
                    stlimit = value;
                }
            }
        }
        private Student[] Students = new Student[0];
        public int Number { get; set; }

        public Student[] GetStudents()
        {
            return Students;
        }

        public Group(string grupno, int slimit)
        {
            GroupNo = grupno;
            StudentLimit = slimit;
        }
        public static bool CheckGroupNo(string groupno)
        {

            if (groupno.Length == 5)
            {
                bool hasdigit = false;
                bool hassupper = false;

                foreach (var item in groupno)
                {
                    if (char.IsDigit(item))
                    {
                        hasdigit = true;
                    }

                    if (char.IsUpper(item))
                    {
                        hassupper = true;
                    }

                }
                bool result = hasdigit && hassupper;
                return result;
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if (Students.Length==StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }

        }
        public string GetStudent (int ? id)
        {
            foreach (var item in Students)
            {
                if (id==item.Id)
                {
                    return item.ToString();
                }
            }
            return id.ToString(); 
        }
        public Student[] GetAllStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine(item);
            }
            return Students;
        }
    }
}




