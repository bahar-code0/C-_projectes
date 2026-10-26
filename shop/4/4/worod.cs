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
    public partial class worod : Form
    {

        
        public worod()
        {
            InitializeComponent();
        }

        private void rdoseller_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int passwordlengh = txtpassword.TextLength;
            if (passwordlengh < 4)
                if (MessageBox.Show("تعداد کاراکتر های رمز کمتر از4کاراکتر است", "خطا", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Retry)
                    txtpassword.Clear();

            if (txtname.Text == "بهاره" && txtpassword.Text == "1234" && rdocheck.Checked)
            {
                
                this.Hide();
                Form1 frm2 = new Form1();
                frm2.Show();
                frm2.tabuse.SelectedTab = frm2.tblkkala;
                frm2.panel1.Visible = true;
                
                this.Close();

            }
            else
                MessageBox.Show("در این سایت فعلا فقط میتوانید به عنوان مدیر وارد شوید ویا ممکن است خطا به علت نامعتبر بودن نام کاربری ویا گذرواژه باشد", "خطا"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            rdocheck.Refresh();
        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshow.Checked == true)
                txtpassword.PasswordChar = '\0';
            else
                txtpassword.PasswordChar = '*';
        }

        private void worod_Load(object sender, EventArgs e)
        {
            this.Text = "ویستا" + "  " + DateTime.Now.ToString();
        }

        private void btnchoos_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                picimag.ImageLocation = openFileDialog1.FileName;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
