using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Deposite> list_of_deposites = new List< Deposite > ();

        public List<Deposite> search_result = new List< Deposite > ();
        public List<Deposite> sort_result = new List< Deposite > ();
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex1 = new Regex("[A-Z]|[А-Я]|[a-z]|[а-я]{1,20}");
                Regex regex2 = new Regex("[0-9]{1,20}");
                if (this.Surname.Text.Equals("") || this.NameOfOwner.Text.Equals("") || this.SecondName.Text.Equals("") ||
                    this.Passport.Text.Equals("") || this.NumberOfDeposite.Text.Equals("") ||  this.Balance.Text.Equals("")
                    ||(this.SMSTrue.Checked == false && this.SMSFalse.Checked == false))
                {
                    MessageBox.Show("information isn't found");
                }
                else if(!regex1.IsMatch(this.NameOfOwner.Text)|| !regex1.IsMatch(this.Surname.Text) || 
                    !regex1.IsMatch(this.SecondName.Text)|| !regex2.IsMatch(this.Balance.Text)||
                    !regex2.IsMatch(this.NumberOfDeposite.Text)|| !regex2.IsMatch(this.Passport.Text))
                {
                    MessageBox.Show("wrong format");
                }
                else
                {
                    Owner owner = new Owner(
                        this.NameOfOwner.Text,
                        this.Surname.Text,
                        this.SecondName.Text,
                        this.DateOfBirth.Text,
                        Convert.ToInt32(this.Passport.Text)
                        );
                    Deposite deposite = new Deposite(
                        Convert.ToInt32(this.NumberOfDeposite.Text),
                        this.TypeOfDeposite.Text,
                        Convert.ToDouble(this.Balance.Text),
                        this.DateOfStart.Text,
                        this.SMSTrue.Checked==true?true:false,
                        this.HasInternet.Checked == true ? true: false,
                        owner);
                    list_of_deposites.Add(deposite);
                    this.deposites_list.Items.Add(deposite);
                    if (list_of_deposites.Count != 0)
                    {
                        using (FileStream fs = new FileStream(
                        "E:\\лабы\\ООП 4 семестр\\Lab2\\serialization.xml",
                        FileMode.OpenOrCreate))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Deposite>));
                            xmlSerializer.Serialize(fs, list_of_deposites);
                        }
                    }
                    
                }

                          
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
            
        }

        private void SecondName_Load(object sender, EventArgs e)
        {

        }

        private void ReadFromFile_Click(object sender, EventArgs e)
        {
            try
            {

                List<Deposite> lst;
                using (FileStream fs = new FileStream("E:\\лабы\\ООП 4 семестр\\Lab2\\serialization.xml", FileMode.OpenOrCreate))
                {

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Deposite>));
                    lst = (List<Deposite>)xmlSerializer.Deserialize(fs);
                }
                if (lst.Count != 0)
                {
                    foreach (Deposite a in lst)
                    {
                        list_of_deposites.Add(a);
                        this.read_from_file.Items.Add(a);
                    }
                }
                else
                {
                    MessageBox.Show("collection is empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            this.StatusLabel.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }
        private void Passport_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This product is made by Alina Punko.\n Lab2 Version 2.0 \n All rights reserved. \nBSTU 2019", "Info");
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(list_of_deposites);

            form2.ShowDialog();
            if (form2.search_result != null)
            {
                this.search_result = form2.search_result;
            }
        }

        private void typeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var result = from a in this.list_of_deposites
                         orderby a.type.Length
                         select a;
            this.deposites_list.Items.Clear();
            foreach (Deposite d in result)
            {
                this.search_result.Add(d);
                this.read_from_file.Items.Add(d);
            }
            
        }

        private void dateOfopeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = from a in this.list_of_deposites
                         orderby a.date
                         select a;
            this.read_from_file.Items.Clear();
            this.search_result.Clear();
            foreach (Deposite d in result)
            {
                this.search_result.Add(d);
                this.read_from_file.Items.Add(d);
            }

        }

        private void resultOfSearchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (search_result.Count != 0)
            {
                using (FileStream fs = new FileStream("E:\\лабы\\ООП 4 семестр\\Lab2\\search.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Deposite>));
                    xmlSerializer.Serialize(fs, search_result);
                }
            }
        }

        private void resultOfSortToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sort_result.Count != 0)
            {
                using (FileStream fs = new FileStream("E:\\лабы\\ООП 4 семестр\\Lab2\\sort.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Deposite>));
                    xmlSerializer.Serialize(fs, sort_result);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Surname.Clear();
            this.NameOfOwner.Clear();
            this.SecondName.Clear();
            this.Balance.Clear();
            this.NumberOfDeposite.Clear();
            this.Passport.Clear();
            this.TypeOfDeposite.Text=String.Empty;
            this.HasInternet.Checked = false;
            this.SMSFalse.Checked = this.SMSTrue.Checked =false;
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
