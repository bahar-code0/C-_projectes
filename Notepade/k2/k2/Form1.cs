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

namespace k2
{
    public partial class Form1 : Form
    {
        string document = "";
        bool save = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                save = true;
                document = saveFileDialog1.FileName;
                File.WriteAllText(document, txtnot.Text);
            }
               
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    document = saveFileDialog1.FileName;
                    File.WriteAllText(document, txtnot.Text);
                }
                save = true;
            }

           else
            {
                
                File.AppendAllText(document, txtnot.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if (MessageBox.Show("ایا میخواهید فایل ذخیره شود؟", "خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        document = saveFileDialog1.FileName;
                        File.WriteAllText(document, txtnot.Text);
                     
                    }
                    save = true;
                }

               
            }
            else
            this.Close();     
                    
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if (MessageBox.Show("ایا میخواهید فایل ذخیره شود؟", "خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        document = saveFileDialog1.FileName;
                        File.WriteAllText(document, txtnot.Text);

                    }
                    save = true;

                }

               
                   
            }
            else
                txtnot.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (save == false)
            {
                if (MessageBox.Show("ایا میخواهید فایل ذخیره شود؟", "خطا", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        document = saveFileDialog1.FileName;
                        File.WriteAllText(document, txtnot.Text);

                    }
                    save = true;
                }

               
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    document = openFileDialog1.FileName;
                    txtnot.Text = File.ReadAllText(document);

                }
            }
        }
    }
}
