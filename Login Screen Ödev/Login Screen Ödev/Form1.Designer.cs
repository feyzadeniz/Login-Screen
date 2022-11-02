namespace Login_Screen_Ödev
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
            this.textBox_kullanici = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.label_kullanici = new System.Windows.Forms.Label();
            this.label_sifre = new System.Windows.Forms.Label();
            this.linkLabel_sifre = new System.Windows.Forms.LinkLabel();
            this.button_giris = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_kullanici
            // 
            this.textBox_kullanici.Location = new System.Drawing.Point(41, 58);
            this.textBox_kullanici.Name = "textBox_kullanici";
            this.textBox_kullanici.Size = new System.Drawing.Size(163, 23);
            this.textBox_kullanici.TabIndex = 0;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(41, 133);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(163, 23);
            this.textBox_sifre.TabIndex = 1;
            // 
            // label_kullanici
            // 
            this.label_kullanici.AutoSize = true;
            this.label_kullanici.BackColor = System.Drawing.Color.Gray;
            this.label_kullanici.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_kullanici.Location = new System.Drawing.Point(41, 38);
            this.label_kullanici.Name = "label_kullanici";
            this.label_kullanici.Size = new System.Drawing.Size(78, 17);
            this.label_kullanici.TabIndex = 2;
            this.label_kullanici.Text = "Kullanıcı Adı";
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.BackColor = System.Drawing.Color.Gray;
            this.label_sifre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_sifre.Location = new System.Drawing.Point(41, 113);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(34, 17);
            this.label_sifre.TabIndex = 3;
            this.label_sifre.Text = "Şifre";
            // 
            // linkLabel_sifre
            // 
            this.linkLabel_sifre.AutoSize = true;
            this.linkLabel_sifre.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_sifre.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_sifre.Location = new System.Drawing.Point(138, 159);
            this.linkLabel_sifre.Name = "linkLabel_sifre";
            this.linkLabel_sifre.Size = new System.Drawing.Size(68, 12);
            this.linkLabel_sifre.TabIndex = 4;
            this.linkLabel_sifre.TabStop = true;
            this.linkLabel_sifre.Text = "şifremi unuttum";
            this.linkLabel_sifre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_sifre_LinkClicked);
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_giris.Location = new System.Drawing.Point(79, 249);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(88, 28);
            this.button_giris.TabIndex = 5;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(189, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "şifreyi göster";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(247, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.linkLabel_sifre);
            this.Controls.Add(this.label_sifre);
            this.Controls.Add(this.label_kullanici);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.textBox_kullanici);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_kullanici;
        private TextBox textBox_sifre;
        private Label label_kullanici;
        private Label label_sifre;
        private LinkLabel linkLabel_sifre;
        private Button button_giris;
        private CheckBox checkBox1;
        private Label label1;
    }
}