namespace WinFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtilksayi = new System.Windows.Forms.TextBox();
            this.txtikincisayi = new System.Windows.Forms.TextBox();
            this.btbToplama = new System.Windows.Forms.Button();
            this.btnCıkarma = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtilksayi
            // 
            this.txtilksayi.Location = new System.Drawing.Point(118, 48);
            this.txtilksayi.Name = "txtilksayi";
            this.txtilksayi.Size = new System.Drawing.Size(168, 23);
            this.txtilksayi.TabIndex = 0;
            // 
            // txtikincisayi
            // 
            this.txtikincisayi.Location = new System.Drawing.Point(118, 91);
            this.txtikincisayi.Name = "txtikincisayi";
            this.txtikincisayi.Size = new System.Drawing.Size(168, 23);
            this.txtikincisayi.TabIndex = 1;
            // 
            // btbToplama
            // 
            this.btbToplama.Location = new System.Drawing.Point(118, 138);
            this.btbToplama.Name = "btbToplama";
            this.btbToplama.Size = new System.Drawing.Size(75, 23);
            this.btbToplama.TabIndex = 2;
            this.btbToplama.Text = "Toplama";
            this.btbToplama.UseVisualStyleBackColor = true;
            this.btbToplama.Click += new System.EventHandler(this.btbToplama_Click);
            // 
            // btnCıkarma
            // 
            this.btnCıkarma.Location = new System.Drawing.Point(211, 138);
            this.btnCıkarma.Name = "btnCıkarma";
            this.btnCıkarma.Size = new System.Drawing.Size(75, 23);
            this.btnCıkarma.TabIndex = 3;
            this.btnCıkarma.Text = "Çıkarma";
            this.btnCıkarma.UseVisualStyleBackColor = true;
            this.btnCıkarma.Click += new System.EventHandler(this.btnCıkarma_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(118, 183);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(75, 23);
            this.btnCarpma.TabIndex = 4;
            this.btnCarpma.Text = "Çarpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(211, 183);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(75, 23);
            this.btnBolme.TabIndex = 5;
            this.btnBolme.Text = "Bölme";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSonuc.Location = new System.Drawing.Point(187, 226);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(27, 32);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 292);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCıkarma);
            this.Controls.Add(this.btbToplama);
            this.Controls.Add(this.txtikincisayi);
            this.Controls.Add(this.txtilksayi);
            this.Name = "Form2";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtilksayi;
        private TextBox txtikincisayi;
        private Button btbToplama;
        private Button btnCıkarma;
        private Button btnCarpma;
        private Button btnBolme;
        private Label lblSonuc;
    }
}