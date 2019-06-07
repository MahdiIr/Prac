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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            if (!txt_Salary.Equals(string.Empty) && !txt_Salary.Text.Equals(""))
            {
                int salary = int.Parse(txt_Salary.Text.ToString());
                if (salary < 500000)
                {
                    lbl_Result.Text = "0";
                }
                else if (salary >= 500000 && salary < 1000000)
                {
                    lbl_Result.Text = ((salary * 5) / 100).ToString();
                }
                else if (salary >= 1000000 && salary < 2000000)
                {
                    lbl_Result.Text = ((salary * 10) / 100).ToString();
                }
                else if (salary >= 2000000 && salary < 3000000)
                {
                    lbl_Result.Text = ((salary * 15) / 100).ToString();
                }
                else if (salary >= 3000000)
                {
                    lbl_Result.Text = ((salary * 20) / 100).ToString("N0");
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Salary.Text = "";
            txt_Name.Text = "";
        }

        private void Txt_Salary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
