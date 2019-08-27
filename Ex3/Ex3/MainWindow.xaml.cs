using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.IO;
using System.Runtime.Serialization;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Microsoft.Win32;
using System.Collections.ObjectModel;

namespace Ex3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> LstPerson { get; set; }
        string connectionString;
        public MainWindow()
        {
            InitializeComponent();
            LstPerson = new ObservableCollection<Student>();
            info.ItemsSource = LstPerson;
            connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed/Denied of Access/Database does not exist");
                    String str;
                    SqlConnection connection2 = new SqlConnection(connectionString);
                    str = "CREATE DATABASE libdb ON PRIMARY " +
                        "(NAME = MyDatabase_Data, " +
                        "FILENAME = 'E:\\лабы\\ООП 4 семестр\\Ex3\\Ex3\\MyDatabaseData.mdf', " +
                        "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                        "LOG ON (NAME = MyDatabase_Log, " +
                        "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
                        "SIZE = 1MB, " +
                        "MAXSIZE = 5MB, " +
                        "FILEGROWTH = 10%)";

                    SqlCommand myCommand = new SqlCommand(str, connection2);
                    try
                    {
                        connection2.Open();
                        myCommand.ExecuteNonQuery();
                    }
                    finally
                    {

                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                bool FlagResult = false;
               connection.Open();
                foreach (Student el in LstPerson)
                {
                    string query = "Insert into Students (Id, Surname, Course) values (" + el.Id +" , '"+ el.Surname + " ' , " + el.Course + ")";
                    SqlCommand com = new SqlCommand(query, connection);
                    try
                    {
                       // connection.Open();
                        if (com.ExecuteNonQuery() == 1)
                        {
                            FlagResult = true;
                           
                        }
                    }
                    catch(Exception ex)
                    { MessageBox.Show(ex.Message); }

                }
                LstPerson.Clear();
            }
            ;
        }
    }
}
