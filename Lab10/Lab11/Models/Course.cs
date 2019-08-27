using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Models
{
    class Course
    {
        public string Title { get; set; }
        public string Lector { get; set; }
        public int Left { get; set; }
        public int ListenersMax { get; set; }
        public int Hours { get; set; }
        public Course(string title, string lector, int listeners, int hours, int listenersMax)
        {
            this.Title = title;
            this.Lector = lector;
            this.Left = listeners;
            this.Hours = hours;
            this.ListenersMax = listenersMax;
        }
    }
}
