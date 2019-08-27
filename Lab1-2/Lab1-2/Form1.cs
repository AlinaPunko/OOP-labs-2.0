using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{

    public partial class Form1 : Form
    {
        private List<Student> collection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    Student st = new Student();
                    collection.Sort(0, collection.Count, st);
                    foreach (Student s in collection)
                    {
                        listBox2.Items.Add(s.name + " , " + s.age + " years " );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    collection.Sort();
                    foreach (Student s in collection)
                    {
                        listBox2.Items.Add(s.name + " , " + s.age + " years " );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    var query = from st in collection
                                where st.age <20
                                select st;
                    foreach (Student s in query)
                    {
                        listBox3.Items.Add(s.name + " , " + s.age + " years ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    var query = from st in collection
                                where st.age == 18
                                select st;
                    foreach (Student s in query)
                    {
                        listBox3.Items.Add(s.name + " , " + s.age + " years ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int count;
                if (textBox1.Text == "" || (count = Convert.ToInt32(textBox1.Text)) == 0)
                {
                    MessageBox.Show("collection is empty");
                    this.collection = null;
                }
                else
                {
                    collection = new List<Student>(count);
                    for (int i = 0; i < count; i++)
                    {
                        Student st = new Student();
                        collection.Add(st);
                    }
                    foreach (Student s in collection)
                    {
                        listBox1.Items.Add(s.name + " , " + s.age + " years, ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                        var query = from st in collection
                                    where st.age >18
                                    select st;
                        foreach (Student s in query)
                        {
                            listBox3.Items.Add(s.name + " , " + s.age + " years " );
                        }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
