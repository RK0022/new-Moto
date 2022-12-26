namespace SatisDeneme
{
    partial class giris
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
            this.lgiris = new System.Windows.Forms.Label();
            this.lkullaniciadi = new System.Windows.Forms.Label();
            this.lsifre = new System.Windows.Forms.Label();
            this.tkullaniciadi = new System.Windows.Forms.TextBox();
            this.tsifre = new System.Windows.Forms.TextBox();
            this.bGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lgiris
            // 
            this.lgiris.AutoSize = true;
            this.lgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lgiris.Location = new System.Drawing.Point(35, 35);
            this.lgiris.Name = "lgiris";
            this.lgiris.Size = new System.Drawing.Size(154, 31);
            this.lgiris.TabIndex = 0;
            this.lgiris.Text = "Giriş Ekranı";
            // 
            // lkullaniciadi
            // 
            this.lkullaniciadi.AutoSize = true;
            this.lkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkullaniciadi.Location = new System.Drawing.Point(37, 97);
            this.lkullaniciadi.Name = "lkullaniciadi";
            this.lkullaniciadi.Size = new System.Drawing.Size(118, 24);
            this.lkullaniciadi.TabIndex = 1;
            this.lkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // lsifre
            // 
            this.lsifre.AutoSize = true;
            this.lsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsifre.Location = new System.Drawing.Point(37, 147);
            this.lsifre.Name = "lsifre";
            this.lsifre.Size = new System.Drawing.Size(52, 24);
            this.lsifre.TabIndex = 2;
            this.lsifre.Text = "Şifre:";
            // 
            // tkullaniciadi
            // 
            this.tkullaniciadi.Location = new System.Drawing.Point(191, 102);
            this.tkullaniciadi.Name = "tkullaniciadi";
            this.tkullaniciadi.Size = new System.Drawing.Size(179, 20);
            this.tkullaniciadi.TabIndex = 3;
            // 
            // tsifre
            // 
            this.tsifre.Location = new System.Drawing.Point(191, 147);
            this.tsifre.Name = "tsifre";
            this.tsifre.Size = new System.Drawing.Size(179, 20);
            this.tsifre.TabIndex = 4;
            // 
            // bGirisYap
            // 
            this.bGirisYap.BackColor = System.Drawing.Color.Navy;
            this.bGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGirisYap.Location = new System.Drawing.Point(191, 201);
            this.bGirisYap.Name = "bGirisYap";
            this.bGirisYap.Size = new System.Drawing.Size(117, 36);
            this.bGirisYap.TabIndex = 5;
            this.bGirisYap.Text = "Giriş Yap";
            this.bGirisYap.UseVisualStyleBackColor = false;
            this.bGirisYap.Click += new System.EventHandler(this.bGirisYap_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(432, 322);
            this.Controls.Add(this.bGirisYap);
            this.Controls.Add(this.tsifre);
            this.Controls.Add(this.tkullaniciadi);
            this.Controls.Add(this.lsifre);
            this.Controls.Add(this.lkullaniciadi);
            this.Controls.Add(this.lgiris);
            this.Name = "giris";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgiris;
        private System.Windows.Forms.Label lkullaniciadi;
        private System.Windows.Forms.Label lsifre;
        private System.Windows.Forms.TextBox tkullaniciadi;
        private System.Windows.Forms.TextBox tsifre;
        private System.Windows.Forms.Button bGirisYap;
    }
}