using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Group
    {
        public int Id { get; set; }
        public int Course { get; set; }
        public string Faculty { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
