
namespace RestoranUygulaması
{
    partial class frmMasaListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaListele));
            this.tableLytAlt = new System.Windows.Forms.TableLayoutPanel();
            this.flowLytSag = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMasaNum = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.lblMasaAktifPasif = new System.Windows.Forms.Label();
            this.txtMasaDurum = new System.Windows.Forms.TextBox();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSipariseKapat = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutBilgi = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelToplamSiparisSay = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlToplamSiparis = new System.Windows.Forms.Panel();
            this.lblTplmSiparis = new System.Windows.Forms.Label();
            this.lblDoluMasaSayisi = new System.Windows.Forms.Label();
            this.pnlDoluMasa = new System.Windows.Forms.Panel();
            this.lblDoluMasa = new System.Windows.Forms.Label();
            this.lblTplmSprsSayisi = new System.Windows.Forms.Label();
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.lblBgDarkGray = new System.Windows.Forms.Label();
            this.lblSiparisKapalı = new System.Windows.Forms.Label();
            this.lblMasaDL = new System.Windows.Forms.Label();
            this.lblMasaBS = new System.Windows.Forms.Label();
            this.lblMasaBos = new System.Windows.Forms.Label();
            this.lblMasaDolu = new System.Windows.Forms.Label();
            this.tableLytAna = new System.Windows.Forms.TableLayoutPanel();
            this.tableLytAlt.SuspendLayout();
            this.flowLytSag.SuspendLayout();
            this.flowLayoutBilgi.SuspendLayout();
            this.flowLayoutPanelToplamSiparisSay.SuspendLayout();
            this.pnlToplamSiparis.SuspendLayout();
            this.pnlDoluMasa.SuspendLayout();
            this.pnlBilgi.SuspendLayout();
            this.tableLytAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLytAlt
            // 
            this.tableLytAlt.ColumnCount = 2;
            this.tableLytAlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.20255F));
            this.tableLytAlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.79745F));
            this.tableLytAlt.Controls.Add(this.flowLytSag, 0, 0);
            this.tableLytAlt.Controls.Add(this.flowLayoutMasalar, 0, 0);
            this.tableLytAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLytAlt.Location = new System.Drawing.Point(3, 140);
            this.tableLytAlt.Name = "tableLytAlt";
            this.tableLytAlt.RowCount = 1;
            this.tableLytAlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.40211F));
            this.tableLytAlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.59789F));
            this.tableLytAlt.Size = new System.Drawing.Size(943, 542);
            this.tableLytAlt.TabIndex = 1;
            // 
            // flowLytSag
            // 
            this.flowLytSag.Controls.Add(this.lblMasaNum);
            this.flowLytSag.Controls.Add(this.txtMasa);
            this.flowLytSag.Controls.Add(this.lblMasaAktifPasif);
            this.flowLytSag.Controls.Add(this.txtMasaDurum);
            this.flowLytSag.Controls.Add(this.btnEkle);
            this.flowLytSag.Controls.Add(this.btnGuncelle);
            this.flowLytSag.Controls.Add(this.btnSipariseKapat);
            this.flowLytSag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLytSag.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLytSag.Location = new System.Drawing.Point(599, 3);
            this.flowLytSag.Name = "flowLytSag";
            this.flowLytSag.Size = new System.Drawing.Size(341, 536);
            this.flowLytSag.TabIndex = 4;
            // 
            // lblMasaNum
            // 
            this.lblMasaNum.AutoSize = true;
            this.lblMasaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNum.Location = new System.Drawing.Point(10, 10);
            this.lblMasaNum.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblMasaNum.Name = "lblMasaNum";
            this.lblMasaNum.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblMasaNum.Size = new System.Drawing.Size(105, 35);
            this.lblMasaNum.TabIndex = 51;
            this.lblMasaNum.Text = "Masa No:";
            // 
            // txtMasa
            // 
            this.txtMasa.BackColor = System.Drawing.SystemColors.Info;
            this.txtMasa.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMasa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasa.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMasa.Location = new System.Drawing.Point(3, 48);
            this.txtMasa.Multiline = true;
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(202, 42);
            this.txtMasa.TabIndex = 47;
            this.txtMasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMasaAktifPasif
            // 
            this.lblMasaAktifPasif.AutoSize = true;
            this.lblMasaAktifPasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaAktifPasif.Location = new System.Drawing.Point(3, 93);
            this.lblMasaAktifPasif.Name = "lblMasaAktifPasif";
            this.lblMasaAktifPasif.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblMasaAktifPasif.Size = new System.Drawing.Size(273, 70);
            this.lblMasaAktifPasif.TabIndex = 52;
            this.lblMasaAktifPasif.Text = "Masa Aktif/Pasif (1:Aktif -- 0:Pasif):";
            // 
            // txtMasaDurum
            // 
            this.txtMasaDurum.BackColor = System.Drawing.SystemColors.Info;
            this.txtMasaDurum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaDurum.Location = new System.Drawing.Point(10, 166);
            this.txtMasaDurum.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtMasaDurum.Multiline = true;
            this.txtMasaDurum.Name = "txtMasaDurum";
            this.txtMasaDurum.Size = new System.Drawing.Size(195, 36);
            this.txtMasaDurum.TabIndex = 53;
            this.txtMasaDurum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEkle.ImageOptions.SvgImage")));
            this.btnEkle.Location = new System.Drawing.Point(10, 208);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(238, 55);
            this.btnEkle.TabIndex = 48;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.Tan;
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Location = new System.Drawing.Point(10, 269);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(238, 55);
            this.btnGuncelle.TabIndex = 49;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSipariseKapat
            // 
            this.btnSipariseKapat.Appearance.BackColor = System.Drawing.Color.Indigo;
            this.btnSipariseKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSipariseKapat.Appearance.Options.UseBackColor = true;
            this.btnSipariseKapat.Appearance.Options.UseFont = true;
            this.btnSipariseKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSipariseKapat.ImageOptions.SvgImage")));
            this.btnSipariseKapat.Location = new System.Drawing.Point(10, 330);
            this.btnSipariseKapat.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnSipariseKapat.Name = "btnSipariseKapat";
            this.btnSipariseKapat.Size = new System.Drawing.Size(238, 55);
            this.btnSipariseKapat.TabIndex = 50;
            this.btnSipariseKapat.Text = "SİPARİŞE KAPAT";
            this.btnSipariseKapat.Click += new System.EventHandler(this.btnSipariseKapat_Click);
            // 
            // flowLayoutMasalar
            // 
            this.flowLayoutMasalar.AutoScroll = true;
            this.flowLayoutMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMasalar.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutMasalar.Name = "flowLayoutMasalar";
            this.flowLayoutMasalar.Size = new System.Drawing.Size(590, 536);
            this.flowLayoutMasalar.TabIndex = 3;
            // 
            // flowLayoutBilgi
            // 
            this.flowLayoutBilgi.AutoScroll = true;
            this.flowLayoutBilgi.Controls.Add(this.flowLayoutPanelToplamSiparisSay);
            this.flowLayoutBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutBilgi.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutBilgi.Name = "flowLayoutBilgi";
            this.flowLayoutBilgi.Size = new System.Drawing.Size(943, 131);
            this.flowLayoutBilgi.TabIndex = 0;
            // 
            // flowLayoutPanelToplamSiparisSay
            // 
            this.flowLayoutPanelToplamSiparisSay.AutoSize = true;
            this.flowLayoutPanelToplamSiparisSay.Controls.Add(this.pnlToplamSiparis);
            this.flowLayoutPanelToplamSiparisSay.Controls.Add(this.pnlDoluMasa);
            this.flowLayoutPanelToplamSiparisSay.Controls.Add(this.pnlBilgi);
            this.flowLayoutPanelToplamSiparisSay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelToplamSiparisSay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelToplamSiparisSay.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelToplamSiparisSay.Name = "flowLayoutPanelToplamSiparisSay";
            this.flowLayoutPanelToplamSiparisSay.Size = new System.Drawing.Size(875, 78);
            this.flowLayoutPanelToplamSiparisSay.TabIndex = 3;
            // 
            // pnlToplamSiparis
            // 
            this.pnlToplamSiparis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlToplamSiparis.Controls.Add(this.lblTplmSiparis);
            this.pnlToplamSiparis.Controls.Add(this.lblDoluMasaSayisi);
            this.pnlToplamSiparis.Location = new System.Drawing.Point(3, 3);
            this.pnlToplamSiparis.Name = "pnlToplamSiparis";
            this.pnlToplamSiparis.Size = new System.Drawing.Size(306, 72);
            this.pnlToplamSiparis.TabIndex = 0;
            // 
            // lblTplmSiparis
            // 
            this.lblTplmSiparis.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTplmSiparis.ForeColor = System.Drawing.Color.Red;
            this.lblTplmSiparis.Location = new System.Drawing.Point(3, 23);
            this.lblTplmSiparis.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTplmSiparis.Name = "lblTplmSiparis";
            this.lblTplmSiparis.Size = new System.Drawing.Size(222, 28);
            this.lblTplmSiparis.TabIndex = 15;
            this.lblTplmSiparis.Text = "Toplam Sipariş Sayısı:";
            // 
            // lblDoluMasaSayisi
            // 
            this.lblDoluMasaSayisi.AutoSize = true;
            this.lblDoluMasaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoluMasaSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblDoluMasaSayisi.Location = new System.Drawing.Point(236, 26);
            this.lblDoluMasaSayisi.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblDoluMasaSayisi.Name = "lblDoluMasaSayisi";
            this.lblDoluMasaSayisi.Size = new System.Drawing.Size(0, 25);
            this.lblDoluMasaSayisi.TabIndex = 2;
            // 
            // pnlDoluMasa
            // 
            this.pnlDoluMasa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlDoluMasa.Controls.Add(this.lblDoluMasa);
            this.pnlDoluMasa.Controls.Add(this.lblTplmSprsSayisi);
            this.pnlDoluMasa.Location = new System.Drawing.Point(315, 3);
            this.pnlDoluMasa.Name = "pnlDoluMasa";
            this.pnlDoluMasa.Size = new System.Drawing.Size(262, 72);
            this.pnlDoluMasa.TabIndex = 1;
            // 
            // lblDoluMasa
            // 
            this.lblDoluMasa.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoluMasa.ForeColor = System.Drawing.Color.Red;
            this.lblDoluMasa.Location = new System.Drawing.Point(3, 23);
            this.lblDoluMasa.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblDoluMasa.Name = "lblDoluMasa";
            this.lblDoluMasa.Size = new System.Drawing.Size(178, 28);
            this.lblDoluMasa.TabIndex = 16;
            this.lblDoluMasa.Text = "Dolu Masa Sayısı:";
            // 
            // lblTplmSprsSayisi
            // 
            this.lblTplmSprsSayisi.AutoSize = true;
            this.lblTplmSprsSayisi.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTplmSprsSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblTplmSprsSayisi.Location = new System.Drawing.Point(208, 26);
            this.lblTplmSprsSayisi.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblTplmSprsSayisi.Name = "lblTplmSprsSayisi";
            this.lblTplmSprsSayisi.Size = new System.Drawing.Size(0, 22);
            this.lblTplmSprsSayisi.TabIndex = 18;
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlBilgi.Controls.Add(this.lblBgDarkGray);
            this.pnlBilgi.Controls.Add(this.lblSiparisKapalı);
            this.pnlBilgi.Controls.Add(this.lblMasaDL);
            this.pnlBilgi.Controls.Add(this.lblMasaBS);
            this.pnlBilgi.Controls.Add(this.lblMasaBos);
            this.pnlBilgi.Controls.Add(this.lblMasaDolu);
            this.pnlBilgi.Location = new System.Drawing.Point(583, 3);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(289, 72);
            this.pnlBilgi.TabIndex = 2;
            // 
            // lblBgDarkGray
            // 
            this.lblBgDarkGray.AutoSize = true;
            this.lblBgDarkGray.BackColor = System.Drawing.Color.DarkGray;
            this.lblBgDarkGray.ForeColor = System.Drawing.Color.White;
            this.lblBgDarkGray.Location = new System.Drawing.Point(150, 38);
            this.lblBgDarkGray.Name = "lblBgDarkGray";
            this.lblBgDarkGray.Size = new System.Drawing.Size(17, 17);
            this.lblBgDarkGray.TabIndex = 5;
            this.lblBgDarkGray.Text = "X";
            // 
            // lblSiparisKapalı
            // 
            this.lblSiparisKapalı.AutoSize = true;
            this.lblSiparisKapalı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisKapalı.Location = new System.Drawing.Point(4, 35);
            this.lblSiparisKapalı.Name = "lblSiparisKapalı";
            this.lblSiparisKapalı.Size = new System.Drawing.Size(131, 20);
            this.lblSiparisKapalı.TabIndex = 4;
            this.lblSiparisKapalı.Text = "Siparişe Kapalı :";
            // 
            // lblMasaDL
            // 
            this.lblMasaDL.AutoSize = true;
            this.lblMasaDL.BackColor = System.Drawing.Color.DarkGreen;
            this.lblMasaDL.ForeColor = System.Drawing.Color.White;
            this.lblMasaDL.Location = new System.Drawing.Point(244, 7);
            this.lblMasaDL.Name = "lblMasaDL";
            this.lblMasaDL.Size = new System.Drawing.Size(17, 17);
            this.lblMasaDL.TabIndex = 3;
            this.lblMasaDL.Text = "X";
            // 
            // lblMasaBS
            // 
            this.lblMasaBS.AutoSize = true;
            this.lblMasaBS.BackColor = System.Drawing.Color.DarkRed;
            this.lblMasaBS.ForeColor = System.Drawing.Color.White;
            this.lblMasaBS.Location = new System.Drawing.Point(118, 7);
            this.lblMasaBS.Name = "lblMasaBS";
            this.lblMasaBS.Size = new System.Drawing.Size(17, 17);
            this.lblMasaBS.TabIndex = 2;
            this.lblMasaBS.Text = "X";
            // 
            // lblMasaBos
            // 
            this.lblMasaBos.AutoSize = true;
            this.lblMasaBos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaBos.Location = new System.Drawing.Point(140, 4);
            this.lblMasaBos.Name = "lblMasaBos";
            this.lblMasaBos.Size = new System.Drawing.Size(95, 20);
            this.lblMasaBos.TabIndex = 1;
            this.lblMasaBos.Text = "Masa Boş :";
            // 
            // lblMasaDolu
            // 
            this.lblMasaDolu.AutoSize = true;
            this.lblMasaDolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaDolu.Location = new System.Drawing.Point(4, 4);
            this.lblMasaDolu.Name = "lblMasaDolu";
            this.lblMasaDolu.Size = new System.Drawing.Size(100, 20);
            this.lblMasaDolu.TabIndex = 0;
            this.lblMasaDolu.Text = "Masa Dolu :";
            // 
            // tableLytAna
            // 
            this.tableLytAna.ColumnCount = 1;
            this.tableLytAna.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLytAna.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLytAna.Controls.Add(this.flowLayoutBilgi, 0, 0);
            this.tableLytAna.Controls.Add(this.tableLytAlt, 0, 1);
            this.tableLytAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLytAna.Location = new System.Drawing.Point(0, 0);
            this.tableLytAna.Name = "tableLytAna";
            this.tableLytAna.RowCount = 2;
            this.tableLytAna.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLytAna.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLytAna.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLytAna.Size = new System.Drawing.Size(949, 685);
            this.tableLytAna.TabIndex = 1;
            // 
            // frmMasaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 685);
            this.Controls.Add(this.tableLytAna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMasaListele";
            this.Text = "Masalar";
            this.Load += new System.EventHandler(this.frmMasaListele_Load);
            this.tableLytAlt.ResumeLayout(false);
            this.flowLytSag.ResumeLayout(false);
            this.flowLytSag.PerformLayout();
            this.flowLayoutBilgi.ResumeLayout(false);
            this.flowLayoutBilgi.PerformLayout();
            this.flowLayoutPanelToplamSiparisSay.ResumeLayout(false);
            this.pnlToplamSiparis.ResumeLayout(false);
            this.pnlToplamSiparis.PerformLayout();
            this.pnlDoluMasa.ResumeLayout(false);
            this.pnlDoluMasa.PerformLayout();
            this.pnlBilgi.ResumeLayout(false);
            this.pnlBilgi.PerformLayout();
            this.tableLytAna.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLytAlt;
        private System.Windows.Forms.FlowLayoutPanel flowLytSag;
        private System.Windows.Forms.Label lblMasaNum;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label lblMasaAktifPasif;
        private System.Windows.Forms.TextBox txtMasaDurum;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSipariseKapat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMasalar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBilgi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelToplamSiparisSay;
        private System.Windows.Forms.Panel pnlToplamSiparis;
        private System.Windows.Forms.Label lblTplmSiparis;
        private System.Windows.Forms.Label lblDoluMasaSayisi;
        private System.Windows.Forms.Panel pnlDoluMasa;
        private System.Windows.Forms.Label lblDoluMasa;
        private System.Windows.Forms.Label lblTplmSprsSayisi;
        private System.Windows.Forms.Panel pnlBilgi;
        private System.Windows.Forms.Label lblBgDarkGray;
        private System.Windows.Forms.Label lblSiparisKapalı;
        private System.Windows.Forms.Label lblMasaDL;
        private System.Windows.Forms.Label lblMasaBS;
        private System.Windows.Forms.Label lblMasaBos;
        private System.Windows.Forms.Label lblMasaDolu;
        private System.Windows.Forms.TableLayoutPanel tableLytAna;
    }
}