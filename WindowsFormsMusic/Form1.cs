using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic
{
    public partial class BoseMusic : MetroFramework.Forms.MetroForm
    {
        public BoseMusic()
        {
          InitializeComponent();
        }
        //登录
        private void Button2_Click(object sender, EventArgs e)
        {
            //获取用户名
            string username = textBox1.Text;
            //获取密码
            string password = textBox2.Text;
            //判断用户名密码是否正确
            if ("x".Equals(username) && "1".Equals(password))
            {
                MessageBox.Show("登录成功！");
                //TODO:新的窗口
                Music music = new Music();
                music.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("账号或密码错误！");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Hide();
        }

        private void BoseMusic_Load(object sender, EventArgs e)
        {

        }

        private void BackPwdbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
