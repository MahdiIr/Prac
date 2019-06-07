using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Calculator : Form
    {

        char op;
        int a, b;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txt_Result.Text += btn.Text;
        }

        private void Btn_ClearOne_Click(object sender, EventArgs e)
        {
            txt_Result.Text = txt_Result.Text.Substring(0, txt_Result.Text.Length - 1);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Result.Text = "";
        }

        private void Btn_PanelSwitch_Click(object sender, EventArgs e)
        {
            p_Calc.Enabled = !p_Calc.Enabled;
        }

        private void Operator(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.op = btn.Text.ToCharArray()[0];
            a = int.Parse(txt_Result.Text);
            txt_Result.Text = "";
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            b = int.Parse(txt_Result.Text);
            txt_Result.Text = "";
            switch (op)
            {
                case '-':
                    {
                        txt_Result.Text = (a - b).ToString();
                        break;
                    }
                case '+':
                    {
                        txt_Result.Text = (a + b).ToString();
                        break;
                    }
                case '*':
                    {
                        txt_Result.Text = (a * b).ToString();
                        break;
                    }
                case '/':
                    {
                        txt_Result.Text = (a / b).ToString();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
