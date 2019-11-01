using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form2 : Form
    {

        //Form2에서는 이벤트핸들러에 의해 이벤트가 발생되는 것이 아니므로 Form2 호출시 값이 
        //즉각 화면에 출력됨
        public Form2(string name,int quantity, int price)
        {
            InitializeComponent();
            bnameLabel.Text = name;
            bquantityLabel.Text = quantity.ToString();
            bpriceLabel.Text = price.ToString();
        }

        // '계속주문하기'버튼을 클릭하면 현재 창을 닫고 주문화면으로 돌아감
        private void keepgoingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}