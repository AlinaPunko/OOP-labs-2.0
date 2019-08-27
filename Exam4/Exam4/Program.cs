using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{

    abstract class Page{}
    class SkillsPage : Page{}
    class EducationPage : Page{}
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }       
        public abstract void CreatePages();
    }
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
        }
    }
    class Diplom : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Diplom();
            foreach (Document document in documents)
            {
                Console.WriteLine(document.GetType().Name);
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }
}
