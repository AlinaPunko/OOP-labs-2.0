using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lab2
{
    [MetadataType(typeof(Form2))]
    public partial class Form2 : Form
    {
        public Form2(List<Deposite> list)
        {
            InitializeComponent();
            this.list = list;
        }

        public string type = String.Empty;
        public string surname = String.Empty;
        public string name = String.Empty;
        public string secondname = String.Empty;
        public int balance = -1;
        [Range(0, 1000000, ErrorMessage = "Недопустимый номер счёта")]
        public int number = -1;
        private List<Deposite> list;
        public List<Deposite> search_result = new List<Deposite>();

        public Form2()
        {
            InitializeComponent();
        }

        private void GoToDefault()
        {
            this.type = this.name = this.surname =this.secondname = String.Empty;
            this.balance = this.number = -1;
            this.Number_textBox.BackColor = Color.White;
            this.Balance_textBox.BackColor = Color.White;
            this.Surname_textBox.BackColor = Color.White;
            this.Name_textBox.BackColor = Color.White;
            this.SecondName_textBox.BackColor = Color.White;
            this.Type_Listbox.BackColor = Color.White;
            this.search = true;
        }

        

        private void Type_Listbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void Company_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void Capacity_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private bool search = true;

        private void Search(IEnumerable<Deposite> list)
        {
            try
            {
                Regex text = new Regex("[A-zА-я]{2,30}");
                SearchResult_List.Items.Clear();
                bool wasCheck = false;
                List<Deposite> query = new List<Deposite>(list.Count<Deposite>());
                if (!this.type.Equals(String.Empty))
                {
                    wasCheck = true;
                    var result = from deposite in list
                                 where deposite.type == this.type
                                 select deposite;
                    if (result.Count<Deposite>() == 0)
                    {
                        this.search = false;
                    }
                    else
                    {
                        foreach (Deposite a in result)
                        {
                            query.Add(a);
                        }
                    }
                }
                if (!this.secondname.Equals(String.Empty) && !this.surname.Equals(String.Empty) && !this.name.Equals(String.Empty) && this.search )
                {
                    var result = from deposite in list
                                 where deposite.owner.name == this.name & deposite.owner.secondname == this.secondname & deposite.owner.surname == this.secondname
                                 select deposite;
                    wasCheck = true;
                    if (result.Count<Deposite>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Deposite>(result.Count<Deposite>());
                        foreach (Deposite a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                            }
                        }
                    }
                }
                if (this.balance != -1 && this.search)
                {
                    var result = from deposite in wasCheck ? query : list
                                 where deposite.balance == this.balance
                                 select deposite;
                    wasCheck = true;
                    if (result.Count<Deposite>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Deposite>(result.Count<Deposite>());
                        foreach (Deposite a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                            }
                        }

                    }
                }
                if (this.number != -1 && this.search)
                {
                    var result = from deposite in wasCheck ? query : list
                                 where deposite.number == this.number
                                 select deposite;
                    wasCheck = true;
                    if (result.Count<Deposite>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Deposite>(result.Count<Deposite>());
                        foreach (Deposite a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                            }
                        }
                    }
                }
                if (query.Count != 0 && this.search)
                {
                    foreach (Deposite a in query)
                    {
                        this.SearchResult_List.Items.Add(a);
                    }
                    this.search_result = query;
                }
                else
                {
                    MessageBox.Show("no matches found");
                }
                this.GoToDefault();
                query.Clear();
            }
            catch
            {
                MessageBox.Show("Test");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Search_button_Click_1(object sender, EventArgs e)
        {
            this.SearchResult_List.Items.Clear();
            try
            {
                bool flag = false;
                if (!this.SecondName_textBox.Text.Equals(String.Empty) && !this.Name_textBox.Text.Equals(String.Empty) && !this.Surname_textBox.Text.Equals(String.Empty))
                {
                    this.name = this.Name_textBox.Text;
                    this.surname = this.Surname_textBox.Text;
                    this.secondname = this.SecondName_textBox.Text;
                    flag = true;
                }
                if (!this.Type_Listbox.Text.Equals(String.Empty))
                {
                    flag = true;
                    this.type = this.Type_Listbox.Text;
                }
                int bal;
                int num;
                if (!this.Balance_textBox.Text.Equals(String.Empty) && (bal = Convert.ToInt32(this.Balance_textBox.Text)) > -1)
                {
                    flag = true;
                    this.balance = bal;
                }
                if (!this.Number_textBox.Text.Equals(String.Empty) && (num = Convert.ToInt32(this.Number_textBox.Text)) > -1)
                {
                    flag = true;
                    this.number = num;
                }
                if (!flag)
                {
                    this.Number_textBox.BackColor = Color.Red;
                    this.Balance_textBox.BackColor = Color.Red;
                    this.Surname_textBox.BackColor = Color.Red;
                    this.Name_textBox.BackColor = Color.Red;
                    this.SecondName_textBox.BackColor = Color.Red;
                    this.Type_Listbox.BackColor = Color.Red;
                    MessageBox.Show("no criteries for search");
                    return;
                }

                this.Search(this.list);
                this.GoToDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Clear_button_Click_1(object sender, EventArgs e)
        {
            this.Type_Listbox.Text = String.Empty;
            this.Number_textBox.Text = String.Empty;
            this.Balance_textBox.Text = String.Empty;
            this.SecondName_textBox.Text = String.Empty;
            this.SearchResult_List.Items.Clear();
        }

        private void Number_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
