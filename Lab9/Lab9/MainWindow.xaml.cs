using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Context dbcontext = new Context();
        public MainWindow()
        {
            InitializeComponent();
            //LoadStudents();
            ShowStudents();
            ShowGroups();
        }
        private IEnumerable<Student> _students;
        public IEnumerable<Student> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
                this.StudentsResult.AutoGenerateColumns = false;
                this.StudentsResult.DataContext = value;//datasource был
            }
        }
        private IEnumerable<Group> _groups;
        public IEnumerable<Group> Groups
        { 
            get
            {
                return _groups;
            }
            set
            {
                _groups = value;
                this.GroupsResult.AutoGenerateColumns = false;
                this.GroupsResult.DataContext = value;//datasource был
            }
        }
        public void ShowStudents()
        {
            try
            {
                IQueryable<Student> studentsQuery;
                studentsQuery = dbcontext.Students;
                this.Students = studentsQuery.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void ShowGroups()
        {
            try
            {
                IQueryable<Group> groupQuery;
                groupQuery = dbcontext.Groups;
                this.Groups = groupQuery.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SaveStudent_Click(object sender, RoutedEventArgs e)
        {
            
                if (StudentFIO.Text.Length != 0 & StudentDOB.SelectedDate != null /*& StudentGroup.Text.Length != 0*/)
                    dbcontext.Students.Add(new Student() {FIO = StudentFIO.Text, DateOfBirth = (DateTime)StudentDOB.SelectedDate, Group=GetSelectedGroup() });
                dbcontext.SaveChanges();
                ShowStudents();
            
        }

        private void SaveGroup_Click(object sender, RoutedEventArgs e)
        {
            
                dbcontext.Groups.Add(new Group() { Course = Int32.Parse(GroupCourse.Text), Faculty = GroupFaculty.Text });
                dbcontext.SaveChanges();
                ShowGroups();
            
        }
        private Student GetSelectedStudent()
        {
            var row = this.StudentsResult.SelectedItem;//currentrow было вместо колумна
            if (row == null)
            {
                return null;
            }

            var student = (Student)row;//row.DataBoundItem;
            return student;
        }
        private Group GetSelectedGroup()
        {
            var row = this.GroupsResult.SelectedItem;//currentrow было вместо колумна
            if (row == null)
            {
                return null;
            }

            var group = (Group)row;//row.DataBoundItem;
            return group;
        }
        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = this.GetSelectedStudent();
            if (selectedStudent == null)
            {
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить этого студента?", "Подтверждение удаления", MessageBoxButton.OKCancel) != MessageBoxResult.OK)//messageboxresult System.Windows.Forms.DialogResult
            {
                return;
            }

            try
            {
                int studentId = selectedStudent.Id;
                var student = dbcontext.Students.Where(p => p.Id == studentId).FirstOrDefault();
                dbcontext.Students.Remove(student);
                dbcontext.SaveChanges();
                ShowStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При удалении объекта произошла ошибка!\n {0}", ex.Message);
            }
        }
        private void DeleteGroup_Click(object sender, RoutedEventArgs e)
        {
            var selectedGroup = this.GetSelectedGroup();
            if (selectedGroup == null)
            {
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить эту группу?", "Подтверждение удаления", MessageBoxButton.OKCancel) != MessageBoxResult.OK)//messageboxresult System.Windows.Forms.DialogResult
            {
                return;
            }

            try
            {
                int GroupId = selectedGroup.Id;
                var Group = dbcontext.Groups.Where(p => p.Id == GroupId).FirstOrDefault();
                dbcontext.Groups.Remove(Group);
                dbcontext.SaveChanges();
                ShowGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При удалении объекта произошла ошибка!\n {0}", ex.Message);
            }
        }

        private void ChangeGroup_Click(object sender, RoutedEventArgs e)
        {
            var selectedGroup = this.GetSelectedGroup();
            if (selectedGroup == null)
            {
                return;
            }

            try
            {
                int GroupId = selectedGroup.Id;
                var Group = dbcontext.Groups.Where(p => p.Id == GroupId).FirstOrDefault();
                if (GroupFaculty.Text.Length != 0)
                    Group.Faculty = GroupFaculty.Text;
                if (GroupCourse.Text.Length != 0)
                    Group.Course = Int32.Parse(GroupCourse.Text);
                //dbcontext.Students.
                dbcontext.SaveChanges();
                ShowGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При изменении объекта произошла ошибка!\n {0}", ex.Message);
            }
        }
        private void ChangeStudent_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = this.GetSelectedStudent();
            if (selectedStudent == null)
            {
                return;
            }

            try
            {
                int studentId = selectedStudent.Id;
                var student = dbcontext.Students.Where(p => p.Id == studentId).FirstOrDefault();
                if (StudentFIO.Text.Length != 0)
                    student.FIO = StudentFIO.Text;
                if (StudentDOB.Text.Length != 0)
                    student.DateOfBirth = (DateTime)StudentDOB.SelectedDate;
                //dbcontext.Students.
                dbcontext.SaveChanges();
                ShowStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При изменении объекта произошла ошибка!\n {0}", ex.Message);
            }
        }
    }
}
