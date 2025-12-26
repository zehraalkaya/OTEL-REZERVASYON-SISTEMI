namespace DonemProjesi
{
    partial class Formadmin
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
            button2 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(317, 50);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "YÖNETİCİ";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(29, 310);
            button2.Name = "button2";
            button2.Size = new Size(227, 50);
            button2.TabIndex = 2;
            button2.Text = "Fiyat Belirle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.ForeColor = SystemColors.HighlightText;
            button4.Location = new Point(575, 468);
            button4.Name = "button4";
            button4.Size = new Size(227, 50);
            button4.TabIndex = 4;
            button4.Text = "Çıkış Yap";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 127);
            label2.Name = "label2";
            label2.Size = new Size(83, 40);
            label2.TabIndex = 5;
            label2.Text = "Yeni Fiyat\r\n(Tek Kişilik)";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CadetBlue;
            textBox1.Location = new Point(135, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 27);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 202);
            label3.Name = "label3";
            label3.Size = new Size(84, 40);
            label3.TabIndex = 7;
            label3.Text = "Yeni Fiyat\r\n(Çift Kişilik)\r\n";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.CadetBlue;
            textBox2.Location = new Point(135, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(107, 27);
            textBox2.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.GradientActiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(383, 156);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(583, 204);
            listBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(552, 75);
            button1.Name = "button1";
            button1.Size = new Size(227, 50);
            button1.TabIndex = 10;
            button1.Text = "Rezervasyon Görüntüle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Formadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1020, 557);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Formadmin";
            Text = "FormAdmin";
            Load += Formadmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button4;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
    }
}
