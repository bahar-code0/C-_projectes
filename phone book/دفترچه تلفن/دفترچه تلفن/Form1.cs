using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace دفترچه_تلفن
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtaddress.Focus();
            string str = String.Format("{0}\t|{1}\t|{2}\t|{3}\r\n",txtname.Text,txtlname.Text,txtphone.Text,txtaddress.Text);
            listBox1.Items.Add(str);
            File.AppendAllText("ContactList.txt", str);
            txtaddress.Clear();
            txtphone.Clear();
            txtlname.Clear();
            txtname.Clear();
            txtphone.Focus();

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
