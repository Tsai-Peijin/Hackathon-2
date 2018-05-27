using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_電信費率計算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        
            string time = textBox1.Text;
            int min = int.Parse(time);
            label1.Text = "通話時間：" + time.ToString();
            
            decimal A, B, C;
            A = min * 4 + 350;
            B = min * 3 + 400;
            C = min * 2 + 500;
            if (A < B && A < C)
            {
                label2.Text = "最佳電信：中華電信";
                label3.Text = "月租費：" + A.ToString();
            }
            else if (B < A && B < C)
            {
                label2.Text = "最佳電信：遠傳電信";
                label3.Text = "月租費：" + B.ToString();
            }
            else if (C < A && C < B)
            {
                label2.Text = "最佳電信：台灣大哥大";
                label3.Text = "月租費：" + C.ToString();
            }
            else if (A == C)
            {
                label2.Text = "最佳電信：中華電信，台灣大哥大";
                label3.Text = "月租費：" + A.ToString() + "，" + C.ToString();

            }
            else if (A == B)
            {
                label2.Text = "最佳電信：中華電信，遠傳電信";
                label3.Text = "月租費：" + A.ToString() + "，" + B.ToString();
            }
            else
            {
                label2.Text = "最佳電信：遠傳電信，電信台灣大哥大";
                label3.Text = "月租費：" + B.ToString() + "，" + C.ToString();
            }

        }
    }
}
