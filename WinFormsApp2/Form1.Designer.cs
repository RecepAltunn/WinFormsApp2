namespace WinFormsApp2
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
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.btnGirisyap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıadı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(287, 60);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(73, 15);
            this.lblkullaniciadi.TabIndex = 0;
            this.lblkullaniciadi.Text = "Kullanıcı Adı";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(287, 108);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(30, 15);
            this.lblsifre.TabIndex = 1;
            this.lblsifre.Text = "Şifre";
            // 
            // btnGirisyap
            // 
            this.btnGirisyap.Location = new System.Drawing.Point(287, 165);
            this.btnGirisyap.Name = "btnGirisyap";
            this.btnGirisyap.Size = new System.Drawing.Size(147, 32);
            this.btnGirisyap.TabIndex = 2;
            this.btnGirisyap.Text = "Giriş Yap";
            this.btnGirisyap.UseVisualStyleBackColor = true;
            this.btnGirisyap.Click += new System.EventHandler(this.btnGirisyap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(287, 136);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(147, 23);
            this.txtSifre.TabIndex = 3;
            // 
            // txtKullanıcıadı
            // 
            this.txtKullanıcıadı.Location = new System.Drawing.Point(287, 78);
            this.txtKullanıcıadı.Name = "txtKullanıcıadı";
            this.txtKullanıcıadı.Size = new System.Drawing.Size(147, 23);
            this.txtKullanıcıadı.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKullanıcıadı);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnGirisyap);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullaniciadi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblkullaniciadi;
        private Label lblsifre;
        private Button btnGirisyap;
        private TextBox txtSifre;
        private TextBox txtKullanıcıadı;
    }
}