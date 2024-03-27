namespace Zamanlayicibugfix
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 29);
            label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(24, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 527);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Süreyi Belirtiniz";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Chocolate;
            label10.Location = new Point(137, 216);
            label10.Name = "label10";
            label10.Size = new Size(54, 86);
            label10.TabIndex = 13;
            label10.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Chocolate;
            label9.Location = new Point(167, 191);
            label9.Name = "label9";
            label9.Size = new Size(190, 128);
            label9.TabIndex = 12;
            label9.Text = "00 ";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(292, 506);
            label8.Name = "label8";
            label8.Size = new Size(28, 21);
            label8.TabIndex = 11;
            label8.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 506);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 10;
            label7.Text = "00";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 506);
            label6.Name = "label6";
            label6.Size = new Size(28, 21);
            label6.TabIndex = 9;
            label6.Text = "00";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 506);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 8;
            label5.Text = "220403817";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 503);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 2;
            label4.Text = "00";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Chocolate;
            button3.Location = new Point(34, 447);
            button3.Name = "button3";
            button3.Size = new Size(242, 45);
            button3.TabIndex = 7;
            button3.Text = "BASLAT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(34, 396);
            button2.Name = "button2";
            button2.Size = new Size(242, 45);
            button2.TabIndex = 6;
            button2.Text = "DURDUR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Chocolate;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(0, 191);
            label3.Name = "label3";
            label3.Size = new Size(190, 128);
            label3.TabIndex = 5;
            label3.Text = "00 ";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.Click += label3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(16, 354);
            progressBar1.Maximum = 1000000000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(281, 23);
            progressBar1.TabIndex = 4;
            progressBar1.Click += progressBar1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(16, 107);
            button1.Name = "button1";
            button1.Size = new Size(292, 51);
            button1.TabIndex = 3;
            button1.Text = "BASLAT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(115, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(24, 48);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Dakika";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(366, 575);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MustafaErsanTimer";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private ProgressBar progressBar1;
        private Button button3;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
    }
}