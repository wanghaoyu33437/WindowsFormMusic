using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic
{
    public partial class signup : MetroFramework.Forms.MetroForm
    {
        private Label label2;
        private Label label3;
        private TextBox myname;
        private TextBox mypwd;
        private TextBox rpwd;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MetroFramework.Controls.MetroButton SignUpButton;
        private MetroFramework.Controls.MetroButton CancelButton;
        private Label label1;
        public signup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myname = new System.Windows.Forms.TextBox();
            this.mypwd = new System.Windows.Forms.TextBox();
            this.rpwd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SignUpButton = new MetroFramework.Controls.MetroButton();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(97, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(97, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(97, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // myname
            // 
            this.myname.BackColor = System.Drawing.Color.White;
            this.myname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myname.Location = new System.Drawing.Point(194, 93);
            this.myname.Name = "myname";
            this.myname.Size = new System.Drawing.Size(141, 18);
            this.myname.TabIndex = 3;
            // 
            // mypwd
            // 
            this.mypwd.BackColor = System.Drawing.Color.White;
            this.mypwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mypwd.Location = new System.Drawing.Point(194, 149);
            this.mypwd.Name = "mypwd";
            this.mypwd.PasswordChar = '*';
            this.mypwd.Size = new System.Drawing.Size(141, 18);
            this.mypwd.TabIndex = 4;
            // 
            // rpwd
            // 
            this.rpwd.BackColor = System.Drawing.Color.White;
            this.rpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rpwd.Location = new System.Drawing.Point(194, 208);
            this.rpwd.Name = "rpwd";
            this.rpwd.PasswordChar = '*';
            this.rpwd.Size = new System.Drawing.Size(141, 18);
            this.rpwd.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(59, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(59, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(194, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(194, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(194, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 13;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(194, 275);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 14;
            this.SignUpButton.Text = "注册";
            this.SignUpButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SignUpButton.UseSelectable = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CancelButton.Location = new System.Drawing.Point(319, 275);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "取消";
            this.CancelButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // signup
            // 
            this.ClientSize = new System.Drawing.Size(485, 410);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rpwd);
            this.Controls.Add(this.mypwd);
            this.Controls.Add(this.myname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signup";
            this.Text = "BoseMusicSignUp";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
       

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string name = myname.Text;
            string pwd = mypwd.Text;
            string repwd = rpwd.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            else if (string.IsNullOrEmpty(mypwd.Text))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            else if (!mypwd.Text.Equals(rpwd.Text))
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            else
            {
                BoseMusic mainForm = new BoseMusic();
                mainForm.Show();
                this.Hide();
            }
        }

        //关闭窗口
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BoseMusic mainForm = new BoseMusic();
            mainForm.Show();

        }
    }
}
