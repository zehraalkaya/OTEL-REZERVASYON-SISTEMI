
namespace DonemProjesi
{
    partial class FormGiris
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnGiris = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(286, 54);
            label1.Name = "label1";
            label1.Size = new Size(423, 48);
            label1.TabIndex = 0;
            label1.Text = "ALKAYA OTEL REZERVASYON SİSTEMİNE\r\n                    HOŞGELDİNİZ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(240, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "  Kullanıcı Adı";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(240, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(416, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "  Şifre";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = SystemColors.HotTrack;
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGiris.ForeColor = SystemColors.Info;
            btnGiris.Location = new Point(240, 309);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(423, 68);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(240, 439);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Robot Değilim";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(920, 517);
            Controls.Add(checkBox1);
            Controls.Add(btnGiris);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormGiris";
            Text = "FormGiris";
            Load += FormGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnGiris;
        private EventHandler button1_Click;
        private CheckBox checkBox1;
    }
}
