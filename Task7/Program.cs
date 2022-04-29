using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string email;
            string password;
            User user = new User();
            do
            {
                Console.Write("Email:");
                email = Console.ReadLine();
                Console.Write("Password:");
                password = Console.ReadLine();

            } while (!PasswordChecker(password));

            string groupno;
            int StudentLimit;


            Console.WriteLine("1.ShowInfo");
            Console.WriteLine("2.Create new group");
            Console.WriteLine("3. Show all students 2.Get student by id  3.Add student  0.Quit");
            int selector=0;

            do
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        {
                            Console.Write("Fullname:");
                            user.Fullname = Console.ReadLine();
                            Console.Write("Email:");
                            user.Email = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Create new group:");
                            do
                            {
                                Console.WriteLine("Groupno:");
                                groupno = Console.ReadLine();
                                Console.WriteLine("Limit:");
                                StudentLimit = Convert.ToInt32(Console.ReadLine());
                                Group group = new Group(groupno, StudentLimit);
                            } while (!CheckGroupNo(groupno) && CheckLimit(StudentLimit));
                            break;
                        }
                       
                    case 3:
                        {
                            int answer1 = Convert.ToInt32(Console.ReadLine());
                            switch (answer1)
                            {

                               case 1:
                                    {
                                        Group group = new Group("AP204", 7);
                                        foreach (var item in group.GetStudents())
                                        {
                                            item.StudentInfo();
                                        }
                                    }
                                    break;
                                    case 2:
                                    {
                                        Group group = new Group("AP204",7);
                                        int id=Convert.ToInt32(Console.ReadLine());
                                        group.GetStudent(id);

                                        break;
                                    }
                            }
                            return;
                        }
                }


            
            } while (selector==0);
        }
        public static bool PasswordChecker(string password)
        {
            bool hasdigit = false;
            bool hassupper = false;
            bool haslower = false;

            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    hasdigit = true;
                }

                if (char.IsUpper(item))
                {
                    hassupper = true;
                }
                if (char.IsLower(item))
                {
                    haslower = true;
                }
            }
            bool result = hasdigit && hassupper && haslower;
            return result;
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
        public static bool CheckLimit(int limit)
        {
            if (limit > 5 && limit <= 18)
            {
                
                return true;
            }
            return false;
        }

    }
}
