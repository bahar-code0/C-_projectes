using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public bool w;
        int count = 0;
        bool sabt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblclock_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ویستا" + "  " + DateTime.Now.ToString();
        }

        private void پخشسرودToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ایا میخواهید خارج شوید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                this.Close();
        }

        private void mnuhelp_Click(object sender, EventArgs e)
        {
            tabuse.SelectedTab = tblabout;

        }

        private void mnucolor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            tblasle.BackColor = colorDialog1.Color;
            tblaza.BackColor= colorDialog1.Color;
            tblkkala.BackColor = colorDialog1.Color;
            tblabout.BackColor= colorDialog1.Color;
        }

        private void lblback_Click(object sender, EventArgs e)
        {

        }

        private void mnuentry_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            worod frm = new worod();
            frm.Show();

           
        }

        private void mnumanagar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnamek.Text = txtnamek.Text.Trim();
            
            if (txtRePassword.Text != txtPassword.Text)
            {
                MessageBox.Show("تکرار گذرواژه با گذرواژه یکی نیست دوباره تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (txtPassword.TextLength == 0 && txtnamek.TextLength == 0)
                MessageBox.Show("ثبت نشد", "", MessageBoxButtons.OK);

            if (txtRePassword.Text == txtPassword.Text && txtPassword.TextLength != 0)

                MessageBox.Show("ثبت شد", "", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtnamek.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
        }

        private void mnufont_Click(object sender, EventArgs e)
        {
             if (fontDialog1.ShowDialog() == DialogResult.OK)
                tblasle.Font = fontDialog1.Font;
            tblaza.Font = fontDialog1.Font;
            tblkkala.Font = fontDialog1.Font;
            tblabout.Font = fontDialog1.Font;
            txtAddress.Font = fontDialog1.Font;
            txtFirstName.Font = fontDialog1.Font;



        }

        private void tabuse_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"sounds\pop.wav");
            player.Play();
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
          
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"sounds\simple.wav");
            player.Play();
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
        }

        private void mnuremusice_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"sounds\sherize.wav");
            player.Stop();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(char.IsLetter((char)e.KeyCode) || (e.KeyCode == Keys.Back)))
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Enter)
                txtLastName.Focus();

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(char.IsLetter((char)e.KeyCode) || (e.KeyCode == Keys.Back)))
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Enter)
                txtnamek.Focus();
        }

        private void txtnamek_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true)
            {
                if (e.KeyValue == 66 || e.KeyValue == 98)
                    tabuse.SelectedTab = tblasle;
                if (e.KeyValue == 65|| e.KeyValue == 97)
                    tabuse.SelectedTab = tblaza;
                if (e.KeyValue == 75 || e.KeyValue == 107)
                    tabuse.SelectedTab = tblkkala;
                if (e.KeyValue == 68 || e.KeyValue == 100)
                    tabuse.SelectedTab = tblabout;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPassword.TextLength > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;

            if (e.KeyCode == Keys.Enter)
                txtRePassword.Focus();
        }

        private void button24_Click(object sender, EventArgs e)
        {

           
        }

        private void button23_Click(object sender, EventArgs e)
        {
     
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (sabt == true)
                if (MessageBox.Show("شفارشات شما از محصولات مختلف ثبت شود با تعداد" + count, "ثبت نهایی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    MessageBox.Show("سفارش شما با موفقیت ثبت شد", "", MessageBoxButtons.OK);

            if (count == 0)
            {
                count = 0;
                MessageBox.Show("بدون شفارش و یا انصراف دکمه انتخاب را کلیک نکنید", "", MessageBoxButtons.OK);
            }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            count = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabuse.SelectedTab = tblkkala;
        }

        private void tblaza_Click(object sender, EventArgs e)
        {

        }

        private void txtnamek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtAddress.Focus();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comboBox1.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
