using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        string op = null;
        bool isNew = false;
        int first = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void setText(string str)
        {
            display.Text = str;
        }

        private void addText(string str)
        {
            if (!isNew)
            {
                display.Text += str;
                int num = Int32.Parse(display.Text);
                display.Text = num.ToString();
            }
            else
            {
                setText(str);
                isNew = false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            addText("0");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            addText("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            addText("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            addText("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            addText("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            addText("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            addText("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            addText("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            addText("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            addText("9");
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            // "더하기" 선택했다는걸 저장
            op = "합";
            isNew = true;
            first = Int32.Parse(display.Text);
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            op = "빼기";
            isNew = true;
            first = Int32.Parse(display.Text);
        }

        private void btn_mt_Click(object sender, EventArgs e)
        {
            op = "곱하기";
            isNew = true;
            first = Int32.Parse(display.Text);
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            op = "나누기";
            isNew = true;
            first = Int32.Parse(display.Text);
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            int second = Int32.Parse(display.Text);
            isNew = true;
            int result = 0;

            switch (op)
            {
                case "합" :
                    result = first + second;
                    setText("" + result);
                    isNew = true;
                    break;

                case "빼기":
                    result = first - second;
                    setText("" + result);
                    isNew = true;
                    break;

                case "곱하기":
                    result = first * second;
                    setText("" + result);
                    isNew = true;
                    break;

                case "나누기":
                    result = first / second;
                    setText("" + result);
                    isNew = true;
                    break;
            }
        }

        
    }
}
