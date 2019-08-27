using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Student
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual Group Group { get; set; }

    }
}
