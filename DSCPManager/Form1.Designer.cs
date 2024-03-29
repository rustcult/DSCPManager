namespace DSCPManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label7 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBox7 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            label12 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            panel4 = new Panel();
            button7 = new Button();
            label15 = new Label();
            textBox10 = new TextBox();
            label16 = new Label();
            panel5 = new Panel();
            button8 = new Button();
            label13 = new Label();
            textBox9 = new TextBox();
            label14 = new Label();
            textBox11 = new TextBox();
            label17 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox7);
            panel1.Location = new Point(36, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 372);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(130, 306);
            button5.Name = "button5";
            button5.Size = new Size(101, 40);
            button5.TabIndex = 17;
            button5.Text = "删除";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(141, 39);
            button4.Name = "button4";
            button4.Size = new Size(90, 25);
            button4.TabIndex = 16;
            button4.Text = "读取全部策略";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(14, 306);
            button3.Name = "button3";
            button3.Size = new Size(101, 40);
            button3.TabIndex = 15;
            button3.Text = "修改";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(14, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(119, 199);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 1;
            label1.Text = "调整DSCP规则";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 199);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 13;
            label7.Text = "DSCP值";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(119, 90);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 147);
            label10.Name = "label10";
            label10.Size = new Size(68, 17);
            label10.TabIndex = 12;
            label10.Text = "规则程序名";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 93);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 10;
            label11.Text = "规则名称";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(119, 144);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(310, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 372);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(72, 259);
            button1.Name = "button1";
            button1.Size = new Size(101, 40);
            button1.TabIndex = 8;
            button1.Text = "创建";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 148);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 6;
            label5.Text = "DSCP值";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 96);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 5;
            label4.Text = "规则程序名";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 42);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 3;
            label3.Text = "规则名称";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 1;
            label2.Text = "创建DSCP规则";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(richTextBox1);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(584, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 372);
            panel3.TabIndex = 9;
            // 
            // button6
            // 
            button6.Location = new Point(79, 306);
            button6.Name = "button6";
            button6.Size = new Size(101, 40);
            button6.TabIndex = 9;
            button6.Text = "批量创建";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(19, 128);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(226, 119);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 108);
            label12.Name = "label12";
            label12.Size = new Size(100, 17);
            label12.TabIndex = 9;
            label12.Text = "搜索到的exe程序";
            // 
            // button2
            // 
            button2.Location = new Point(28, 259);
            button2.Name = "button2";
            button2.Size = new Size(206, 40);
            button2.TabIndex = 8;
            button2.Text = "通过路径扫描应用程序";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 74);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 6;
            label6.Text = "DSCP值";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 39);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 3;
            label8.Text = "前缀";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(116, 33);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "例如APEX-";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 17);
            label9.TabIndex = 1;
            label9.Text = "批量创建DSCP规则";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(textBox10);
            panel4.Controls.Add(label16);
            panel4.Location = new Point(858, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(268, 372);
            panel4.TabIndex = 11;
            // 
            // button7
            // 
            button7.Location = new Point(73, 124);
            button7.Name = "button7";
            button7.Size = new Size(101, 40);
            button7.TabIndex = 9;
            button7.Text = "批量删除";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 39);
            label15.Name = "label15";
            label15.Size = new Size(32, 17);
            label15.TabIndex = 3;
            label15.Text = "前缀";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(116, 33);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "例如APEX-";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(111, 17);
            label16.TabIndex = 1;
            label16.Text = "批量删除DSCP规则";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox11);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(button8);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(textBox9);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(1132, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(268, 372);
            panel5.TabIndex = 12;
            // 
            // button8
            // 
            button8.Location = new Point(72, 176);
            button8.Name = "button8";
            button8.Size = new Size(101, 40);
            button8.TabIndex = 9;
            button8.Text = "批量修改";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 39);
            label13.Name = "label13";
            label13.Size = new Size(32, 17);
            label13.TabIndex = 3;
            label13.Text = "前缀";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(116, 33);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "例如APEX-";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(111, 17);
            label14.TabIndex = 1;
            label14.Text = "批量修改DSCP规则";
            label14.Click += label14_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(116, 90);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(19, 90);
            label17.Name = "label17";
            label17.Size = new Size(51, 17);
            label17.TabIndex = 9;
            label17.Text = "DSCP值";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 450);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "DSCPManager";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private TextBox textBox4;
        private Label label6;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private Button button3;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox8;
        private Label label10;
        private Label label11;
        private TextBox textBox7;
        private Button button4;
        private Button button5;
        private RichTextBox richTextBox1;
        private Label label12;
        private Button button6;
        private Panel panel4;
        private Button button7;
        private Label label15;
        private TextBox textBox10;
        private Label label16;
        private Panel panel5;
        private Button button8;
        private Label label13;
        private TextBox textBox9;
        private Label label14;
        private TextBox textBox11;
        private Label label17;
    }
}
