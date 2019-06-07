namespace Practice
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.p_Calc = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.btn_Mines = new System.Windows.Forms.Button();
            this.btn_Divetion = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_PanelSwitch = new System.Windows.Forms.Button();
            this.btn_ClearOne = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.p_Calc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Result
            // 
            this.txt_Result.Enabled = false;
            this.txt_Result.Location = new System.Drawing.Point(13, 14);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(434, 26);
            this.txt_Result.TabIndex = 0;
            // 
            // p_Calc
            // 
            this.p_Calc.Controls.Add(this.button15);
            this.p_Calc.Controls.Add(this.btn_Mines);
            this.p_Calc.Controls.Add(this.btn_Divetion);
            this.p_Calc.Controls.Add(this.btn_Multiply);
            this.p_Calc.Controls.Add(this.btn_Plus);
            this.p_Calc.Controls.Add(this.btn_Equal);
            this.p_Calc.Controls.Add(this.button9);
            this.p_Calc.Controls.Add(this.button8);
            this.p_Calc.Controls.Add(this.button7);
            this.p_Calc.Controls.Add(this.button6);
            this.p_Calc.Controls.Add(this.button5);
            this.p_Calc.Controls.Add(this.button4);
            this.p_Calc.Controls.Add(this.button3);
            this.p_Calc.Controls.Add(this.button2);
            this.p_Calc.Controls.Add(this.button1);
            this.p_Calc.Location = new System.Drawing.Point(13, 61);
            this.p_Calc.Name = "p_Calc";
            this.p_Calc.Size = new System.Drawing.Size(324, 168);
            this.p_Calc.TabIndex = 16;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(266, 13);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(48, 141);
            this.button15.TabIndex = 30;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Numbers);
            // 
            // btn_Mines
            // 
            this.btn_Mines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mines.Location = new System.Drawing.Point(236, 13);
            this.btn_Mines.Name = "btn_Mines";
            this.btn_Mines.Size = new System.Drawing.Size(24, 43);
            this.btn_Mines.TabIndex = 29;
            this.btn_Mines.Text = "-";
            this.btn_Mines.UseVisualStyleBackColor = true;
            this.btn_Mines.Click += new System.EventHandler(this.Operator);
            // 
            // btn_Divetion
            // 
            this.btn_Divetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Divetion.Location = new System.Drawing.Point(212, 111);
            this.btn_Divetion.Name = "btn_Divetion";
            this.btn_Divetion.Size = new System.Drawing.Size(48, 43);
            this.btn_Divetion.TabIndex = 28;
            this.btn_Divetion.Text = "/";
            this.btn_Divetion.UseVisualStyleBackColor = true;
            this.btn_Divetion.Click += new System.EventHandler(this.Operator);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiply.Location = new System.Drawing.Point(212, 62);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(48, 43);
            this.btn_Multiply.TabIndex = 27;
            this.btn_Multiply.Text = "*";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            this.btn_Multiply.Click += new System.EventHandler(this.Operator);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plus.Location = new System.Drawing.Point(212, 13);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(24, 43);
            this.btn_Plus.TabIndex = 26;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.Operator);
            // 
            // btn_Equal
            // 
            this.btn_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Equal.Location = new System.Drawing.Point(175, 13);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(31, 141);
            this.btn_Equal.TabIndex = 25;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = true;
            this.btn_Equal.Click += new System.EventHandler(this.Btn_Equal_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(67, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 43);
            this.button9.TabIndex = 24;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Numbers);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(13, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 43);
            this.button8.TabIndex = 23;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Numbers);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(121, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 43);
            this.button7.TabIndex = 22;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Numbers);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(121, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 43);
            this.button6.TabIndex = 21;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Numbers);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(13, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 43);
            this.button5.TabIndex = 20;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Numbers);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(121, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 43);
            this.button4.TabIndex = 19;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Numbers);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(67, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 43);
            this.button3.TabIndex = 18;
            this.button3.Text = "5";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Numbers);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(67, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Numbers);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Numbers);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_PanelSwitch);
            this.panel2.Controls.Add(this.btn_ClearOne);
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Location = new System.Drawing.Point(343, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 168);
            this.panel2.TabIndex = 17;
            // 
            // btn_PanelSwitch
            // 
            this.btn_PanelSwitch.Location = new System.Drawing.Point(6, 90);
            this.btn_PanelSwitch.Name = "btn_PanelSwitch";
            this.btn_PanelSwitch.Size = new System.Drawing.Size(90, 32);
            this.btn_PanelSwitch.TabIndex = 2;
            this.btn_PanelSwitch.Text = "ON\\OFF";
            this.btn_PanelSwitch.UseVisualStyleBackColor = true;
            this.btn_PanelSwitch.Click += new System.EventHandler(this.Btn_PanelSwitch_Click);
            // 
            // btn_ClearOne
            // 
            this.btn_ClearOne.Location = new System.Drawing.Point(12, 51);
            this.btn_ClearOne.Name = "btn_ClearOne";
            this.btn_ClearOne.Size = new System.Drawing.Size(75, 32);
            this.btn_ClearOne.TabIndex = 1;
            this.btn_ClearOne.Text = "<-------";
            this.btn_ClearOne.UseVisualStyleBackColor = true;
            this.btn_ClearOne.Click += new System.EventHandler(this.Btn_ClearOne_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(12, 13);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 32);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 241);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.p_Calc);
            this.Controls.Add(this.txt_Result);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.p_Calc.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Panel p_Calc;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btn_Mines;
        private System.Windows.Forms.Button btn_Divetion;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_PanelSwitch;
        private System.Windows.Forms.Button btn_ClearOne;
        private System.Windows.Forms.Button btn_Clear;
    }
}