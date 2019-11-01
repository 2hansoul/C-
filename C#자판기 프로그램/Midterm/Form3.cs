using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void 메뉴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            t.Show();

        }

        private void 메뉴삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
