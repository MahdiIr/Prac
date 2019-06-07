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
    public partial class SayHello : Form
    {
        public SayHello()
        {
            InitializeComponent();
        }

        private void Btn_Say_Click(object sender, EventArgs e)
        {
            if (!txt_Name.Text.Equals("") || !string.IsNullOrEmpty(txt_Name.Text))
            {
                lbl_Result.Text = "Hello " + txt_Name.Text.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter Your Name");
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
        }

        private void Label_ControlAdded(object sender, ControlEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private new void MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Red;
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
    }
}
