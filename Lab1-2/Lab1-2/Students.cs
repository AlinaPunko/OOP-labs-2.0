using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Lab1_2
{
    public class Student : IComparable<Student>, IComparer<Student>
    {
        public short age;
        public string name;
        private string[] options_of_names = new string[10]
        {
            "Andrei", "Alena", "Yaroslav", "Bogdan", "Anna", "Anastasiya", "Maksim", "Vadim", "Polina", "Diana"
        };

        public Student()
        {
            Random random = new Random();
            this.age = (short)random.Next(17, 25);
            Thread.Sleep(10);
            this.name = options_of_names[random.Next(0, 10)];
            Thread.Sleep(10);
        }

        public int Compare(Student st1, Student st2)
        {
            return st2.CompareTo(st1);
        }

        public int CompareTo(Student student)
        {
            if (student == null)
            {
                return 1;
            }
            else
            {
                if (this.age > student.age)
                {
                    return 1;
                }
                else if (this.age < student.age)
                {
                    return -1;
                }
                    else
                    {
                        return this.name.CompareTo(student.name);
                    }
                
            }
        }
    }
}
