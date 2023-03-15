namespace TugasKuliah
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 142);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Hitung Luas Lingkaran";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 204);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Jari Jari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 142);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 3;
            label3.Text = "Hitung Luas Persegi Panjang";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += inputJariJari;
            // 
            // button3
            // 
            button3.Location = new Point(34, 293);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Hitung";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnHitungLuasLingkaran;
            // 
            // button4
            // 
            button4.Location = new Point(186, 293);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnResetLuasLingkaran;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(505, 182);
            textBox3.Name = "inputPanjang";
            textBox3.Size = new Size(218, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += inputPanjang;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(505, 230);
            textBox4.Name = "inputLebar";
            textBox4.Size = new Size(218, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += inputLebar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(505, 279);
            textBox1.Name = "inputTinggi";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += inputTinggi;
            // 
            // button1
            // 
            button1.Location = new Point(505, 353);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Hitung";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnHitungLuasPersegiPanjang;
            // 
            // button2
            // 
            button2.Location = new Point(629, 353);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnResetInputanPersegiPanjang;
            // 
            // button5
            // 
            button5.Location = new Point(679, 452);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 14;
            button5.Text = "Tutup";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnTutupAplikasi;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 185);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 15;
            label4.Text = "Panjang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 237);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 16;
            label5.Text = "Lebar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 282);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 17;
            label6.Text = "Tinggi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 26);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 18;
            label7.Text = "Nama: Cicilia Riris M";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 62);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 19;
            label8.Text = "Kelas: 1 AS 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}