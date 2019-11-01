using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)//아이디,비밀번호설정 참,거짓 결말도출
        {
            if (textBox1.Text == "hansol" && textBox2.Text == "1234")
            {
                MessageBox.Show("로그인에 성공하였습니다");
                Form4 t = new Form4();
                t.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인에 실패하였습니다");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
