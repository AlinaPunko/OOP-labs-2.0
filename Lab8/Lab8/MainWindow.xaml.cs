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

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectOwners = "SELECT Passport[Паспорт], Name[Имя], Surname[Фамилия], Second_name[Отчество], Date_of_birth[Дата рождения], Photo[Фото] From Owners";
        string selectDeposites = "SELECT Number[Номер], Type[Тип], Balance[Баланс], Date[Дата открытия], Owner[Владелец] FROM Deposites";
        DataTable ownerData = new DataTable();
        DataTable depositeData = new DataTable();
        DataTable searchData = new DataTable();
        string connectionString;
        internal string PathImage { get; set; }

        public MainWindow()
        {
            InitializeComponent();
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
                        "FILENAME = 'E:\\лабы\\ООП 4 семестр\\Lab8\\Lab8\\MyDatabaseData.mdf', " +
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
            GetDeposites();
            GetOwners();
        }

        private void GetOwners()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapterOwner = new SqlDataAdapter(selectOwners, connection);
                adapterOwner.Fill(ownerData);
                OwnerGrid.ItemsSource = ownerData.DefaultView;
                OwnerGrid.UpdateLayout();
                ownerData = new DataTable();
            }
        }
        private void GetSearch(int parm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapterSearch = new SqlDataAdapter("SELECT * FROM Deposites WHERE Owner = " + Int32.Parse(SearchText.Text), connection);
                adapterSearch.Fill(searchData);
                Result.ItemsSource = searchData.DefaultView;
                Result.UpdateLayout();
                searchData = new DataTable();
            }
        }

        private void GetDeposites()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter adapterDeposite = new SqlDataAdapter(selectDeposites, connection);
                adapterDeposite.Fill(depositeData);
                DepositesGrid.ItemsSource = depositeData.DefaultView;
                DepositesGrid.UpdateLayout();
                depositeData = new DataTable();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("Insert_Deposite", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter number = new SqlParameter("@Number", SqlDbType.Int);
                        number.Value = Int32.Parse( Deposite_Number.Text);
                        cmd.Parameters.Add(number);

                        SqlParameter type = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
                        type.Value = Deposite_Type.SelectedItem.ToString();
                        cmd.Parameters.Add(type);

                        SqlParameter balance = new SqlParameter("@Balance", SqlDbType.Int);
                        balance.Value = Int32.Parse( Balance.Text);
                        cmd.Parameters.Add(balance);

                        SqlParameter data = new SqlParameter("@Date", SqlDbType.Date);
                        data.Value = Deposite_Date.SelectedDate.Value.ToString();
                        cmd.Parameters.Add(data);


                        SqlParameter internet = new SqlParameter("@HasInternet", SqlDbType.Bit);
                        internet.Value = ((bool)isInternet.IsChecked ? 1: 0);
                        cmd.Parameters.Add(internet);

                        SqlParameter sms = new SqlParameter("@HasSMS", SqlDbType.Bit);
                        sms.Value = ((bool)isSMS.IsChecked ? 1 : 0);
                        cmd.Parameters.Add(sms);


                        SqlCommand cmdowner = connection.CreateCommand();
                        cmdowner.CommandText = $"SELECT Passport FROM Owners WHERE Passport =" + Deposite_owner.Text+ " ;";
                        string tokenowner = cmdowner.ExecuteScalar().ToString();

                        if (tokenowner != null)
                        {
                            SqlParameter owner = new SqlParameter("@Owner ", SqlDbType.Int);
                            owner.Value = tokenowner;
                            cmd.Parameters.Add(owner);
                            cmd.ExecuteNonQuery();
                            GetDeposites();
                        }
                        else MessageBox.Show("Производитель не найден");
                    }
                }
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private bool ValidateForm()
        {
            string msgerror = "";
            bool er = false;
            if (Deposite_owner.Text == String.Empty)
            {
                er = true;
                msgerror += "Введите владельца\n";
            }
            if (!Deposite_Number.Text.All(char.IsDigit))
            {
                er = true;
                msgerror += "Неверный формат номера\n";
            }
            if (!Balance.Text.All(char.IsDigit))
            {
                er = true;
                msgerror += "Неверный формат баланса\n";
            }
            if (er)
            {
                MessageBox.Show(msgerror);
                return false;
            }
            return true;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("Insert_Owner", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter passport = new SqlParameter("@Passport", SqlDbType.Int);
                    passport.Value = Int32.Parse(Owner_Passport.Text);
                    cmd.Parameters.Add(passport);


                    SqlParameter name = new SqlParameter("@Name", SqlDbType.NVarChar, 20);
                    name.Value = Owner_Name.Text;
                    cmd.Parameters.Add(name);


                    SqlParameter surname = new SqlParameter("@Surname", SqlDbType.NVarChar, 20);
                    surname.Value = Owner_Surname.Text;
                    cmd.Parameters.Add(surname);


                    SqlParameter secondname = new SqlParameter("@Second_name", SqlDbType.NVarChar, 20);
                    secondname.Value = Owner_SecondName.Text;
                    cmd.Parameters.Add(secondname);


                    SqlParameter dateofbirth = new SqlParameter("@Date_of_birth", SqlDbType.Date);
                    dateofbirth.Value = Owner_DoB.SelectedDate.Value;
                    cmd.Parameters.Add(dateofbirth);

                    SqlParameter image = new SqlParameter("@Photo", SqlDbType.NVarChar);
                    image.Value = pathLabel.Content;
                    cmd.Parameters.Add(image);

                    cmd.ExecuteNonQuery();
                }
            }
            GetOwners();
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (Deposite_owner.Text != String.Empty)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = null;
                    SqlCommand command = connection.CreateCommand();
                    try
                    {
                        string tokenDeposite;

                        if (Deposite_owner.Text == String.Empty)
                        {
                            MessageBox.Show("Rollback");
                            return;
                        }
                        else
                        {
                            SqlCommand cmdDeposite = connection.CreateCommand();
                            cmdDeposite.CommandText = $"SELECT Number FROM Deposites WHERE Owner = " + Deposite_owner.Text + ";";
                            tokenDeposite = cmdDeposite.ExecuteScalar().ToString();
                            if (tokenDeposite == String.Empty)
                            {
                                MessageBox.Show("Вклады не найдены");
                                return;
                            }
                        }
                        transaction = connection.BeginTransaction();
                        command.Transaction = transaction;
                        string updateRequest = "UPDATE Deposites SET";

                        if (Balance.Text != String.Empty )
                        {
                            updateRequest += $" Balance =" + Int32.Parse(Balance.Text) + "";
                        }


                        //if (updateRequest[updateRequest.Length - 1] == ',')
                        //{
                        //    updateRequest = updateRequest.Substring(0, updateRequest.Length - 1);
                        //}
                        else
                        {
                            command.Transaction.Rollback();
                            return;
                        }
                        updateRequest += $" WHERE Number =" + tokenDeposite;
                        command.CommandText = updateRequest;
                        command.ExecuteNonQuery();
                        transaction.Commit();
                        GetDeposites();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
            else MessageBox.Show("Введите владельца ");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (Deposite_Number.Text != String.Empty)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = $"DELETE FROM Deposites WHERE Number = " + Int32.Parse(Deposite_Number.Text) + "; ";
                    cmd.ExecuteScalar();
                    GetDeposites();
                }
            }
            else MessageBox.Show("Введите номер вклада");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Img Files (*.img)|*.img|Png Files (*.png)|*.png";
            if (ofd.ShowDialog() == true)
            {
                pathLabel.Content = ofd.FileName;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (DepositesGrid.SelectedIndex == -1) DepositesGrid.SelectedIndex = 0;
            else if (DepositesGrid.Items.Count != DepositesGrid.SelectedIndex + 1)
            {
                DepositesGrid.SelectedIndex++;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (DepositesGrid.SelectedIndex == -1) DepositesGrid.SelectedIndex = 0;
            else if (DepositesGrid.SelectedIndex != 0)
            {
                DepositesGrid.SelectedIndex--;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                var dg = OwnerGrid.SelectedItem as DataRowView;
                cmd.CommandText = $"SELECT Photo FROM Owners WHERE Name like '%{(string)dg.Row.ItemArray[1]}%';";
                PathImage = cmd.ExecuteScalar().ToString();
                new OwnerImage(this).Show();
            }
        }

        private void AuthorGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = $"DELETE TOP (1) FROM Owners;";
                    cmd.ExecuteNonQuery();
                    GetOwners();
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
        private void Search(object sender, RoutedEventArgs e)
        {

            if (SearchText.Text != String.Empty)
                GetSearch(Int32.Parse( SearchText.Text));
        }
        private void SearchText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}




