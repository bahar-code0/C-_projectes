namespace _4
{
    partial class worod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdobuyer = new System.Windows.Forms.RadioButton();
            this.rdoseller = new System.Windows.Forms.RadioButton();
            this.rdocheck = new System.Windows.Forms.RadioButton();
            this.btnchoos = new System.Windows.Forms.Button();
            this.chkshow = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picimag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picimag)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(184, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 43);
            this.button2.TabIndex = 25;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 24;
            this.button1.Text = "ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdobuyer
            // 
            this.rdobuyer.AutoSize = true;
            this.rdobuyer.Location = new System.Drawing.Point(279, 322);
            this.rdobuyer.Margin = new System.Windows.Forms.Padding(4);
            this.rdobuyer.Name = "rdobuyer";
            this.rdobuyer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdobuyer.Size = new System.Drawing.Size(62, 21);
            this.rdobuyer.TabIndex = 23;
            this.rdobuyer.TabStop = true;
            this.rdobuyer.Text = "خریدار";
            this.rdobuyer.UseVisualStyleBackColor = true;
            // 
            // rdoseller
            // 
            this.rdoseller.AutoSize = true;
            this.rdoseller.Location = new System.Drawing.Point(167, 322);
            this.rdoseller.Margin = new System.Windows.Forms.Padding(4);
            this.rdoseller.Name = "rdoseller";
            this.rdoseller.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoseller.Size = new System.Drawing.Size(80, 21);
            this.rdoseller.TabIndex = 22;
            this.rdoseller.TabStop = true;
            this.rdoseller.Text = "بازدید کننده";
            this.rdoseller.UseVisualStyleBackColor = true;
            this.rdoseller.CheckedChanged += new System.EventHandler(this.rdoseller_CheckedChanged);
            // 
            // rdocheck
            // 
            this.rdocheck.AutoSize = true;
            this.rdocheck.Location = new System.Drawing.Point(380, 322);
            this.rdocheck.Margin = new System.Windows.Forms.Padding(4);
            this.rdocheck.Name = "rdocheck";
            this.rdocheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdocheck.Size = new System.Drawing.Size(49, 21);
            this.rdocheck.TabIndex = 21;
            this.rdocheck.TabStop = true;
            this.rdocheck.Text = "مدیر";
            this.rdocheck.UseVisualStyleBackColor = true;
            // 
            // btnchoos
            // 
            this.btnchoos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnchoos.ForeColor = System.Drawing.Color.White;
            this.btnchoos.Location = new System.Drawing.Point(489, 306);
            this.btnchoos.Margin = new System.Windows.Forms.Padding(4);
            this.btnchoos.Name = "btnchoos";
            this.btnchoos.Size = new System.Drawing.Size(132, 38);
            this.btnchoos.TabIndex = 20;
            this.btnchoos.Text = "انتخاب عکس";
            this.btnchoos.UseVisualStyleBackColor = false;
            this.btnchoos.Click += new System.EventHandler(this.btnchoos_Click);
            // 
            // chkshow
            // 
            this.chkshow.AutoSize = true;
            this.chkshow.Location = new System.Drawing.Point(203, 283);
            this.chkshow.Margin = new System.Windows.Forms.Padding(4);
            this.chkshow.Name = "chkshow";
            this.chkshow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkshow.Size = new System.Drawing.Size(98, 21);
            this.chkshow.TabIndex = 19;
            this.chkshow.Text = "نمایش گذرواژه";
            this.chkshow.UseVisualStyleBackColor = true;
            this.chkshow.CheckedChanged += new System.EventHandler(this.chkshow_CheckedChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(199, 239);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpassword.Size = new System.Drawing.Size(233, 36);
            this.txtpassword.TabIndex = 17;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(199, 162);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(233, 36);
            this.txtname.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "رمز عبور:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "نام کاربر:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(178, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(256, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "ورود به سایت ویستا";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picimag
            // 
            this.picimag.Location = new System.Drawing.Point(473, 140);
            this.picimag.Margin = new System.Windows.Forms.Padding(4);
            this.picimag.Name = "picimag";
            this.picimag.Size = new System.Drawing.Size(164, 160);
            this.picimag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimag.TabIndex = 18;
            this.picimag.TabStop = false;
            // 
            // worod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdobuyer);
            this.Controls.Add(this.rdoseller);
            this.Controls.Add(this.rdocheck);
            this.Controls.Add(this.btnchoos);
            this.Controls.Add(this.chkshow);
            this.Controls.Add(this.picimag);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "worod";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "worod";
            this.Load += new System.EventHandler(this.worod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdobuyer;
        private System.Windows.Forms.RadioButton rdoseller;
        private System.Windows.Forms.RadioButton rdocheck;
        private System.Windows.Forms.Button btnchoos;
        private System.Windows.Forms.CheckBox chkshow;
        private System.Windows.Forms.PictureBox picimag;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}