namespace kalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        public string Bufor1;
        public string Bufor2;

        public int number1;
        public int number2;
        public int wynik = 0;

        public bool flaga = false;
        public bool czy_bufor_pusty = true;

        public int dzialanie; // dodawanie = 1, odejmowanie = 2, dzielenie = 3, mnożenie = 4

        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button10 = new Button();
            button11 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button4 = new Button();
            button5 = new Button();
            button9 = new Button();
            button12 = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(button2, 0, 2);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 1);
            tableLayoutPanel1.Controls.Add(button7, 1, 2);
            tableLayoutPanel1.Controls.Add(button8, 1, 3);
            tableLayoutPanel1.Controls.Add(button10, 2, 1);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(button13, 3, 1);
            tableLayoutPanel1.Controls.Add(button14, 3, 2);
            tableLayoutPanel1.Controls.Add(button15, 3, 3);
            tableLayoutPanel1.Controls.Add(button16, 2, 3);
            tableLayoutPanel1.Controls.Add(button4, 0, 4);
            tableLayoutPanel1.Controls.Add(button5, 1, 4);
            tableLayoutPanel1.Controls.Add(button9, 2, 4);
            tableLayoutPanel1.Controls.Add(button12, 3, 4);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button10
            // 
            resources.ApplyResources(button10, "button10");
            button10.Name = "button10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // button11
            // 
            resources.ApplyResources(button11, "button11");
            button11.Name = "button11";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_Click;
            // 
            // button13
            // 
            resources.ApplyResources(button13, "button13");
            button13.Name = "button13";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_Click;
            // 
            // button14
            // 
            resources.ApplyResources(button14, "button14");
            button14.Name = "button14";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_Click;
            // 
            // button15
            // 
            resources.ApplyResources(button15, "button15");
            button15.Name = "button15";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button_Click;
            // 
            // button16
            // 
            resources.ApplyResources(button16, "button16");
            button16.Name = "button16";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button_Click;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button9
            // 
            resources.ApplyResources(button9, "button9");
            button9.Name = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button12
            // 
            resources.ApplyResources(button12, "button12");
            button12.Name = "button12";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            tableLayoutPanel1.SetColumnSpan(textBox1, 4);
            textBox1.Name = "textBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button11;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button4;
        private Button button5;
        private Button button9;
        private Button button12;
        private TextBox textBox1;
    }
}
