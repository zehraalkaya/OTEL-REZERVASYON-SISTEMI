namespace DonemProjesi
{
    partial class FormMusteri
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxad = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(314, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "HOŞGELDİNİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 93);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 155);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 212);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Çıkış Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 269);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 4;
            label5.Text = "İletişim Numarası";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 334);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 5;
            label6.Text = "Oda Tipi";
            // 
            // textBoxad
            // 
            textBoxad.BackColor = SystemColors.ScrollBar;
            textBoxad.Location = new Point(194, 86);
            textBoxad.Name = "textBoxad";
            textBoxad.Size = new Size(144, 27);
            textBoxad.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(185, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(190, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(190, 212);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(148, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tek Kişilik", "Çift Kişilik" });
            comboBox1.Location = new Point(185, 326);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 28);
            comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(31, 399);
            button1.Name = "button1";
            button1.Size = new Size(101, 39);
            button1.TabIndex = 11;
            button1.Text = "Fİyat Öğren";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(194, 408);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 12;
            label7.Text = "Fiyat=.....";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(53, 464);
            button2.Name = "button2";
            button2.Size = new Size(226, 56);
            button2.TabIndex = 13;
            button2.Text = "Rezervasyonu Kaydet";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(501, 119);
            button3.Name = "button3";
            button3.Size = new Size(226, 56);
            button3.TabIndex = 14;
            button3.Text = "Rezervasyonlarım";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.GradientActiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(491, 210);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(505, 144);
            listBox1.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.ForeColor = SystemColors.HighlightText;
            button4.Location = new Point(501, 440);
            button4.Name = "button4";
            button4.Size = new Size(226, 56);
            button4.TabIndex = 16;
            button4.Text = "Çıkış Yap";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FormMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 548);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBoxad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMusteri";
            Text = "FormMusteri";
            Load += FormMusteri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxad;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label7;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Button button4;
    }
}
