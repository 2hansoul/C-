using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form4 : Form
    {
        string drink;
        int a = 10, b = 5, c = 10, d = 11, f = 2;

        public Form4()
        {
            InitializeComponent();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (drink == "코카콜라")
            {
                a--;
                textBox1.Text = a.ToString();
            }
            if (drink == "사이다")
            {
                b--;
                textBox2.Text = b.ToString();
            }
            if (drink == "펩시")
            {
                c--;
                textBox3.Text = c.ToString();
            }
            if (drink == "알로에")
            {
                d--;
                textBox6.Text = d.ToString();
            }
            if (drink == "망고")
            {
                f--;
                textBox7.Text = f.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (drink == "코카콜라")//조건에 맞으면 증가
            {
                a++;
                textBox1.Text = a.ToString();
            }
            if(drink=="사이다")
            {
                b++;
                textBox2.Text = b.ToString();
            }
            if (drink == "펩시")
            {
                c++;
                textBox3.Text = c.ToString();
            }
            if (drink == "알로에")
            {
                d++;
                textBox6.Text = d.ToString();
            }
            if (drink == "망고")
            {
                f++;
                textBox7.Text = f.ToString();
            }


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick_1(object sender, MouseEventArgs e)//드링크입력할 리스트뷰 생성
        {
            drink = listView1.FocusedItem.SubItems[0].Text;
        }
    }
}
    

