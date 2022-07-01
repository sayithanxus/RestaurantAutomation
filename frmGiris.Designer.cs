
namespace RestoranUygulaması
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblRestoranBaslik = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.chckbxSifreKontrol = new System.Windows.Forms.CheckBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKulAd = new System.Windows.Forms.Label();
            this.txtkadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.pnlGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGiris
            // 
            this.pnlGiris.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGiris.AutoScroll = true;
            this.pnlGiris.BackColor = System.Drawing.Color.Transparent;
            this.pnlGiris.Controls.Add(this.btnIptal);
            this.pnlGiris.Controls.Add(this.lblRestoranBaslik);
            this.pnlGiris.Controls.Add(this.btngiris);
            this.pnlGiris.Controls.Add(this.chckbxSifreKontrol);
            this.pnlGiris.Controls.Add(this.lblSifre);
            this.pnlGiris.Controls.Add(this.lblKulAd);
            this.pnlGiris.Controls.Add(this.txtkadi);
            this.pnlGiris.Controls.Add(this.txtsifre);
            this.pnlGiris.Location = new System.Drawing.Point(14, 21);
            this.pnlGiris.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(470, 602);
            this.pnlGiris.TabIndex = 2;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(145, 511);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(158, 62);
            this.btnIptal.TabIndex = 16;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblRestoranBaslik
            // 
            this.lblRestoranBaslik.AutoSize = true;
            this.lblRestoranBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblRestoranBaslik.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRestoranBaslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestoranBaslik.Location = new System.Drawing.Point(71, 48);
            this.lblRestoranBaslik.Name = "lblRestoranBaslik";
            this.lblRestoranBaslik.Size = new System.Drawing.Size(318, 48);
            this.lblRestoranBaslik.TabIndex = 15;
            this.lblRestoranBaslik.Text = "Bekiroğlu Restaurant";
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.SeaGreen;
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngiris.Location = new System.Drawing.Point(145, 425);
            this.btngiris.Margin = new System.Windows.Forms.Padding(4);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(158, 62);
            this.btngiris.TabIndex = 11;
            this.btngiris.Text = "GİRİŞ YAP";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // chckbxSifreKontrol
            // 
            this.chckbxSifreKontrol.AutoSize = true;
            this.chckbxSifreKontrol.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.chckbxSifreKontrol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chckbxSifreKontrol.Location = new System.Drawing.Point(79, 370);
            this.chckbxSifreKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.chckbxSifreKontrol.Name = "chckbxSifreKontrol";
            this.chckbxSifreKontrol.Size = new System.Drawing.Size(220, 24);
            this.chckbxSifreKontrol.TabIndex = 14;
            this.chckbxSifreKontrol.Text = "Şifreyi Göster/Gizle";
            this.chckbxSifreKontrol.UseVisualStyleBackColor = true;
            this.chckbxSifreKontrol.CheckedChanged += new System.EventHandler(this.chckbxSifreKontrol_CheckedChanged);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSifre.Location = new System.Drawing.Point(75, 268);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(73, 20);
            this.lblSifre.TabIndex = 13;
            this.lblSifre.Text = "ŞİFRE:";
            // 
            // lblKulAd
            // 
            this.lblKulAd.AutoSize = true;
            this.lblKulAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKulAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKulAd.Location = new System.Drawing.Point(75, 152);
            this.lblKulAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKulAd.Name = "lblKulAd";
            this.lblKulAd.Size = new System.Drawing.Size(164, 20);
            this.lblKulAd.TabIndex = 12;
            this.lblKulAd.Text = "KULLANICI ADI:";
            // 
            // txtkadi
            // 
            this.txtkadi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkadi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtkadi.Location = new System.Drawing.Point(79, 191);
            this.txtkadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtkadi.Name = "txtkadi";
            this.txtkadi.Size = new System.Drawing.Size(320, 28);
            this.txtkadi.TabIndex = 9;
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsifre.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtsifre.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtsifre.Location = new System.Drawing.Point(79, 296);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(320, 28);
            this.txtsifre.TabIndex = 10;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 645);
            this.Controls.Add(this.pnlGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblRestoranBaslik;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.CheckBox chckbxSifreKontrol;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKulAd;
        private System.Windows.Forms.TextBox txtkadi;
        private System.Windows.Forms.TextBox txtsifre;
    }
}