namespace Lab_4
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(546, 247);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(602, 57);
            button1.TabIndex = 0;
            button1.Text = "Add Value to Array";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 247);
            textBox1.Margin = new Padding(6, 7, 6, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 43);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(546, 318);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(602, 57);
            button2.TabIndex = 2;
            button2.Text = "Sum of All Elements in Array";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(546, 390);
            button3.Margin = new Padding(6, 7, 6, 7);
            button3.Name = "button3";
            button3.Size = new Size(602, 57);
            button3.TabIndex = 3;
            button3.Text = "Largest Integer in Array Using Max Function";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(546, 461);
            button4.Margin = new Padding(6, 7, 6, 7);
            button4.Name = "button4";
            button4.Size = new Size(602, 57);
            button4.TabIndex = 4;
            button4.Text = "Avg of All Odd Numbers Using oddAvg Function ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(546, 533);
            button5.Margin = new Padding(6, 7, 6, 7);
            button5.Name = "button5";
            button5.Size = new Size(602, 57);
            button5.TabIndex = 5;
            button5.Text = "Reverse Output of Input Array Using Reverse Function ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(546, 604);
            button6.Margin = new Padding(6, 7, 6, 7);
            button6.Name = "button6";
            button6.Size = new Size(602, 57);
            button6.TabIndex = 6;
            button6.Text = "Take Function";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 696);
            textBox2.Margin = new Padding(6, 7, 6, 7);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1683, 43);
            textBox2.TabIndex = 7;
//            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(234, 607);
            textBox3.Margin = new Padding(6, 7, 6, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 43);
            textBox3.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 187);
            label1.Name = "label1";
            label1.Size = new Size(397, 37);
            label1.TabIndex = 9;
            label1.Text = "Add Values To Array Here ↓↓↓ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(102, 553);
            label2.Name = "label2";
            label2.Size = new Size(427, 37);
            label2.TabIndex = 10;
            label2.Text = "Add The Value To Take Here ↓↓↓ ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2069, 1401);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
    }
}