using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        const int   // 음료수의 가격 초기화
            intCOKE = 500,
            intDIET = 600,
            intCIDER = 500,
            intPEPSI = 400,
            intDEW = 500,
            intPOCARI = 600,
            intDEMI = 500,
            intALOE = 600,
            intGETO = 700,
            intMANGO = 600,
            intSUNNY = 400,
            intBONG = 500;

        //음료 이름 배열
        string[] each_item_name = new string[12]
            {"코카콜라",
            "다이어트콜라",
            "칠성사이다",
            "펩시콜라",
            "마운틴듀",
            "포카리",
            "데미소다",
            "알로에",
            "게토레이",
            "망고",
            "써니텐",
            "봉봉"};

        // 최다판매 음료 가격 및 갯수 배열
        int[] each_item_count = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] each_item_price = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        
        int itemprice = 0,
            inputmoney = 0,
            quantity = 0,
            time = 0,
            changemoney = 0,
            totalprice=0;
        
        // Form2에 넘겨주기 위해 변수 선언
        string currentitemname;
        int currentitemprice, currentitemquantity;
            
        int time0810 = 0,
            time1012 = 0,
            time1214 = 0,
            time1416 = 0,
            time1618 = 0,
            timeafter = 0;

        
        /////////////////////////
        //////// TAB1////////////
        /////////////////////////
        public Form1()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("주문 하시겠습니까?", "주문확인", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    inputmoney = Int32.Parse(inputMoneyTbox.Text);
                    quantity = Int32.Parse(quantityTbox.Text);


                    //라디오 버튼별로 itemprice에 가격 * 수량 집어넣기
                    if (b_cokeRbutton.Checked)
                    {
                        itemprice = intCOKE * quantity;     // 선택된 음료가격과 수량을 곱해 판매액 산정
                        totalprice += itemprice;            // 총 판매량 표시 위해 판매액 누적
                        each_item_count[0] += quantity;     // 아이템별 판매수량 누적
                        each_item_price[0] += itemprice;    // 아이템별 판매액 누적
                        currentitemname = each_item_name[0];// 폼2에 선택된 아이템의 이름을 넘겨주기 위해 저장
                        currentitemquantity = quantity;     //           "           수량을    "
                        currentitemprice = itemprice;       //           "           가격을    " 
                    }
                    else if (b_dietRbutton.Checked)
                    {
                        itemprice = intDIET * quantity;
                        totalprice += itemprice;
                        each_item_count[1] += quantity;
                        each_item_price[1] += itemprice;
                        currentitemname = each_item_name[1];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_ciderRbutton.Checked)
                    {
                        itemprice = intCIDER * quantity;
                        totalprice += itemprice;
                        each_item_count[2] += quantity;
                        each_item_price[2] += itemprice;
                        currentitemname = each_item_name[2];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_pepsiRbutton.Checked)
                    {
                        itemprice = intPEPSI * quantity;
                        totalprice += itemprice;
                        each_item_count[3] += quantity;
                        each_item_price[3] += itemprice;
                        currentitemname = each_item_name[3];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_dewRbutton.Checked)
                    {
                        itemprice = intDEW * quantity;
                        totalprice += itemprice;
                        each_item_count[4] += quantity;
                        each_item_price[4] += itemprice;
                        currentitemname = each_item_name[4];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_pocariRbutton.Checked)
                    {
                        itemprice = intPOCARI * quantity;
                        totalprice += itemprice;
                        each_item_count[5] += quantity;
                        each_item_price[5] += itemprice;
                        currentitemname = each_item_name[5];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_demiRbutton.Checked)
                    {
                        itemprice = intDEMI * quantity;
                        totalprice += itemprice;
                        each_item_count[6] += quantity;
                        each_item_price[6] += itemprice;
                        currentitemname = each_item_name[6];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_aloeRbutton.Checked)
                    {
                        itemprice = intALOE * quantity;
                        totalprice += itemprice;
                        each_item_count[7] += quantity;
                        each_item_price[7] += itemprice;
                        currentitemname = each_item_name[7];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_getoRbutton.Checked)
                    {
                        itemprice = intGETO * quantity;
                        totalprice += itemprice;
                        each_item_count[8] += quantity;
                        each_item_price[8] += itemprice;
                        currentitemname = each_item_name[8];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_mangoRbutton.Checked)
                    {
                        itemprice = intMANGO * quantity;
                        totalprice += itemprice;
                        each_item_count[9] += quantity;
                        each_item_price[9] += itemprice;
                        currentitemname = each_item_name[9];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_sunnyRbutton.Checked)
                    {
                        itemprice = intSUNNY * quantity;
                        totalprice += itemprice;
                        each_item_count[10] += quantity;
                        each_item_price[10] += itemprice;
                        currentitemname = each_item_name[10];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }
                    else if (b_bongRbutton.Checked)
                    {
                        itemprice = intBONG * quantity;
                        totalprice += itemprice;
                        each_item_count[11] += quantity;
                        each_item_price[11] += itemprice;
                        currentitemname = each_item_name[11];
                        currentitemquantity = quantity;
                        currentitemprice = itemprice;
                    }

                    //잔돈 계산
                    changemoney = (inputmoney + changemoney) - itemprice;
                    if (changemoney < 0)
                    {
                        MessageBox.Show("잔액 오류입니다.", "잔액 오류", MessageBoxButtons.OK);
                        this.Close();
                    }
                    changeMoneyLabel.Text = changemoney.ToString();


                    // 판매된 시간 계산
                    time = Int32.Parse(timeTbox.Text);
                    if (time >= 0 && time <= 24)
                    {
                        if (time <= 8 || time > 18) timeafter += quantity;
                        else if (time > 8 && time <= 10) time0810 += quantity;
                        else if (time > 10 && time <= 12) time1012 += quantity;
                        else if (time > 12 && time <= 14) time1214 += quantity;
                        else if (time > 14 && time <= 16) time1416 += quantity;
                        else if (time > 16 && time <= 18) time1618 += quantity;
                    }
                    else
                    {
                        MessageBox.Show("시간은 0~24 까지만 입력 가능합니다.", "오류", MessageBoxButtons.OK);
                        this.Close();
                    }


                    // 화면초기화
                    inputMoneyTbox.Text = "";
                    quantityTbox.Text = "";
                    timeTbox.Text = "";
                    inputMoneyTbox.Focus();

                    //폼2 호출함
                    Form2 f2 = new Form2(currentitemname, currentitemquantity, currentitemprice);
                    f2.Show();


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "잘못된 값을 입력하였습니다.", MessageBoxButtons.OK);
                }


            }
        }


        // 잔돈반환 및 종료시
        void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("남은 잔돈 " + changemoney.ToString() + "을 반환합니다.", "잔돈반환", MessageBoxButtons.OK);
            this.Close();
        }



        //////////////////////////
        //////// TAB2 ///////////
        /////////////////////////
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string best="";
            int bestprice=0;
            totalpriceLabel.Text = totalprice.ToString();

            // 1일 판매량 출력
            b_cokeLabel.Text = each_item_count[0] + "개 / " + each_item_price[0] + "원";
            b_dietLabel.Text = each_item_count[1] + "개 / " + each_item_price[1] + "원";
            b_ciderLabel.Text = each_item_count[2] + "개 / " + each_item_price[2] + "원";
            b_pepsiLabel.Text = each_item_count[3] + "개 / " + each_item_price[3] + "원";
            b_dewLabel.Text = each_item_count[4] + "개 / " + each_item_price[4] + "원";
            b_pocariLabel.Text = each_item_count[5] + "개 / " + each_item_price[5] + "원";
            b_demiLabel.Text = each_item_count[6] + "개 / " + each_item_price[6] + "원";
            b_aloeLabel.Text = each_item_count[7] + "개 / " + each_item_price[7] + "원";
            b_getoLabel.Text = each_item_count[8] + "개 / " + each_item_price[8] + "원";
            b_mangoLabel.Text = each_item_count[9] + "개 / " + each_item_price[9] + "원";
            b_sunnyLabel.Text = each_item_count[10] + "개 / " + each_item_price[10] + "원";
            b_bongLabel.Text = each_item_count[11] + "개 / " + each_item_price[11] + "원";

            
            // 매출현황 (최다판매 음료 및 총 매출액)

            best = each_item_name[0];
            bestprice = each_item_price[0];

            for(int i=1; i<12; i++)
            {
                if (bestprice < each_item_price[i])
                {
                    best = each_item_name[i];
                    bestprice = each_item_price[i];
                }
            }
            bestoneLabel.Text = best;
            bestonepriceLabel.Text = bestprice.ToString();

            // 시간별 판매현황
            timeafterLabel.Text = timeafter.ToString();
            time0810Label.Text = time0810.ToString();
            time1012Label.Text = time1012.ToString();
            time1214Label.Text = time1214.ToString();
            time1416Label.Text = time1416.ToString();
            time1618Label.Text = time1618.ToString();

        }


        // TAB2 화면 클리어
        private void clearButton_Click(object sender, EventArgs e)
        {
            b_cokeLabel.Text = "";
            b_dietLabel.Text = "";
            b_ciderLabel.Text = "";
            b_pepsiLabel.Text = "";
            b_dewLabel.Text = "";
            b_pocariLabel.Text = "";
            b_demiLabel.Text = "";
            b_aloeLabel.Text = "";
            b_getoLabel.Text = "";
            b_mangoLabel.Text = "";
            b_sunnyLabel.Text = "";
            b_bongLabel.Text = "";
            totalpriceLabel.Text = "";
            bestoneLabel.Text = "";
            bestonepriceLabel.Text = "";
            timeafterLabel.Text = "";
            time0810Label.Text = "";
            time1012Label.Text = "";
            time1214Label.Text = "";
            time1416Label.Text = "";
            time1618Label.Text = "";
        }


        ////////////////////////////////
        ///////////TAB3/////////////////
        ////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            
            Graphics g = Graphics.FromHwnd(showPanel.Handle);

            g.Clear(Color.Khaki);

            Brush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b, 2);
            g.DrawLine(p, 20, 410, 530, 410);
            g.DrawLine(p, 20, 10, 20, 410);
            g.DrawLine(p, 530, 10, 530, 410);


            //라벨 출력
            g.DrawString("코카콜라", new Font("Arial", 8), b, 20, 420);
            g.DrawString("D콜라", new Font("Arial", 8), b, 75, 420);
            g.DrawString("칠성", new Font("Arial", 8), b, 115, 420);
            g.DrawString("펩시", new Font("Arial", 8), b, 145, 420);
            g.DrawString("마운틴듀", new Font("Arial", 8), b, 175, 420);
            g.DrawString("포카리", new Font("Arial", 8), b, 230, 420);
            g.DrawString("데미소다", new Font("Arial", 8), b, 275, 420);
            g.DrawString("알로에", new Font("Arial", 8), b, 330, 420);
            g.DrawString("게토레이", new Font("Arial", 8), b, 375, 420);
            g.DrawString("망고", new Font("Arial", 8), b, 430, 420);
            g.DrawString("써니텐", new Font("Arial", 8), b, 460, 420);
            g.DrawString("봉봉", new Font("Arial", 8), b, 500, 420);
         

            StringFormat sf = new StringFormat();
            sf.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString("갯 수", new Font("Arial", 8), b, 2, 10, sf);


            Brush b1 = new SolidBrush(Color.Red);
            Pen p1 = new Pen(b1, 5);


            //판매된 아이템을 그래프화 출력
            g.DrawLine(p1, 47, 410, 47, 410 - each_item_count[0] * 2);
            g.DrawLine(p1, 90, 410, 90, 410 - each_item_count[1] * 2);
            g.DrawLine(p1, 129, 410, 129, 410 - each_item_count[2] * 2);
            g.DrawLine(p1, 158, 410, 158, 410 - each_item_count[3] * 2);
            g.DrawLine(p1, 200, 410, 200, 410 - each_item_count[4] * 2);
            g.DrawLine(p1, 252, 410, 252, 410 - each_item_count[5] * 2);
            g.DrawLine(p1, 301, 410, 301, 410 - each_item_count[6] * 2);
            g.DrawLine(p1, 351, 410, 351, 410 - each_item_count[7] * 2);
            g.DrawLine(p1, 401, 410, 401, 410 - each_item_count[8] * 2);
            g.DrawLine(p1, 445, 410, 445, 410 - each_item_count[9] * 2);
            g.DrawLine(p1, 482, 410, 482, 410 - each_item_count[10] * 2);
            g.DrawLine(p1, 517, 410, 517, 410 - each_item_count[11] * 2);
            

            //그래프 상단에 X개 표시함
            g.DrawString(each_item_count[0].ToString() + "개", new Font("Arial", 8), b, 40, 395 - each_item_count[0] * 2);
            g.DrawString(each_item_count[1].ToString() + "개", new Font("Arial", 8), b, 83, 395 - each_item_count[1] * 2);
            g.DrawString(each_item_count[2].ToString() + "개", new Font("Arial", 8), b, 122, 395 - each_item_count[2] * 2);
            g.DrawString(each_item_count[3].ToString() + "개", new Font("Arial", 8), b, 151, 395 - each_item_count[3] * 2);
            g.DrawString(each_item_count[4].ToString() + "개", new Font("Arial", 8), b, 193, 395 - each_item_count[4] * 2);
            g.DrawString(each_item_count[5].ToString() + "개", new Font("Arial", 8), b, 245, 395 - each_item_count[5] * 2);
            g.DrawString(each_item_count[6].ToString() + "개", new Font("Arial", 8), b, 294, 395 - each_item_count[6] * 2);
            g.DrawString(each_item_count[7].ToString() + "개", new Font("Arial", 8), b, 344, 395 - each_item_count[7] * 2);
            g.DrawString(each_item_count[8].ToString() + "개", new Font("Arial", 8), b, 394, 395 - each_item_count[8] * 2);
            g.DrawString(each_item_count[9].ToString() + "개", new Font("Arial", 8), b, 441, 395 - each_item_count[9] * 2);
            g.DrawString(each_item_count[10].ToString() + "개", new Font("Arial", 8), b, 475, 395 - each_item_count[10] * 2);
            g.DrawString(each_item_count[11].ToString() + "개", new Font("Arial", 8), b, 510, 395 - each_item_count[11] * 2);
        }
    }
}