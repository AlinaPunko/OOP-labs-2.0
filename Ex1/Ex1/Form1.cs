using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            int count = random.Next(25);
            for (int i = 0; i < count; i++)
                Indexes.Items.Add(i.ToString());
            for (int i = 0; i < count; i++)
                Numbers.Items.Add(random.Next(100).ToString());
        }
        private void Search_Click(object sender, EventArgs e)
        {
            var max = Numbers.Items.Cast<ListViewItem>().Max(x => int.Parse(x.SubItems[0].Text));
    //        var index= Numbers.Items.Cast<ListViewItem>().Select((value, indexx) => new { Value = value, Index = indexx })
    //.Aggregate((a, b) => (Convert.ToInt32(a) > Convert.ToInt32(b)) ? a : b)
    //.Index;
            Max.Text = max.ToString();
            //Index.Text = index.ToString();
            for (int i = 0; i < Numbers.Items.Count; i++)
            {
                if (Numbers.Items[i].Text == max.ToString())
                    Index.Text = i.ToString();
            }
        }
    }
}
