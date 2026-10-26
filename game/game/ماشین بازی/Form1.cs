using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ماشین_بازی
{
    public partial class Form1 : Form
    {
        bool p;
        Label[] lbl = new Label[100];
        public Form1()
        {
            InitializeComponent();
        }
   
        int i = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    picgat.Top -= 5;
                    break;
                case Keys.Down:
                   picgat.Top += 5;
                    break;

                case Keys.Space:
                    i++;
                    lbl[i] = new Label();
                    lbl[i].Left = picgat.Right;
                    lbl[i].Top = picgat.Height / 2 + picgat.Top+10;
                    lbl[i].AutoSize = false;
                    lbl[i].Height = 5;
                    lbl[i].Width = 5;
                    lbl[i].Text = "";
                    lbl[i].BackColor = Color.Yellow;
                    this.Controls.Add(lbl[i]);
                    timer2.Enabled = true;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text =(int.Parse( label2.Text) - 1).ToString();
            if (label2.Text == "0" && label1.Text != "0")
            {
                timer1.Enabled = false;
                timer3.Enabled = false;

                if (MessageBox.Show("برنده شدی" + "امتیاز" + label1.Text, "پیام", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    label1.Text = "0";
                    label2.Text = "30";
                    timer1.Enabled = true;
                    timer3.Enabled = true;
                }
                else
                    Application.Exit();
             

            }
            if (label2.Text == "0" && label1.Text == "0")
            {
                timer1.Enabled = false;
                timer3.Enabled = false;

           
                if (MessageBox.Show("باختی(っ °Д °;)っ", "پیام", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    label1.Text = "0";
                    label2.Text = "30";
                    timer1.Enabled = true;
                    timer3.Enabled = true;
                }
                else
                    Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer3.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int k = 1; k <= i; k++)
            {
                lbl[k].Left += 5;
                if (picsafena.Bounds.IntersectsWith(lbl[k].Bounds))
                {
                    label1.Text = (int.Parse(label1.Text) + 1).ToString();
                    for (int j = 1; j <= i; j++)
                        this.Controls.Remove(lbl[j]);
                    i = 0;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int y = this.Height - picsafena.Height;
            int x = this.Width / 2;
            int z = this.Width - picsafena.Width;
            picsafena.Left = rnd.Next(x, z);
            picsafena.Top = rnd.Next(0,y);
        }

        private void picre_Click(object sender, EventArgs e)
        {
            p = true;
        }
    }
}
