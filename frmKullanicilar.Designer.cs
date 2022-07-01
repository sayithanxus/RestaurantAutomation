
namespace RestoranUygulaması
{
    partial class frmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControlKullanici = new DevExpress.XtraGrid.GridControl();
            this.gridKullanicilar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.flowLytSag = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLytAd = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGridControl = new System.Windows.Forms.Panel();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.flowLytSoyad = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSag = new System.Windows.Forms.Panel();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.flowLytKulAD = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSagAlt = new System.Windows.Forms.Panel();
            this.lblKulAd = new DevExpress.XtraEditors.LabelControl();
            this.txtKulAd = new System.Windows.Forms.TextBox();
            this.flowLytSifre = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSagAlt2 = new System.Windows.Forms.Panel();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.flowLytButonlar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSagAlt3 = new System.Windows.Forms.Panel();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar)).BeginInit();
            this.flowLytSag.SuspendLayout();
            this.flowLytAd.SuspendLayout();
            this.flowLytSoyad.SuspendLayout();
            this.flowLytKulAD.SuspendLayout();
            this.flowLytSifre.SuspendLayout();
            this.flowLytButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlKullanici, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLytSag, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1137, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControlKullanici
            // 
            this.gridControlKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKullanici.Location = new System.Drawing.Point(3, 3);
            this.gridControlKullanici.MainView = this.gridKullanicilar;
            this.gridControlKullanici.Name = "gridControlKullanici";
            this.gridControlKullanici.Size = new System.Drawing.Size(562, 565);
            this.gridControlKullanici.TabIndex = 4;
            this.gridControlKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKullanicilar});
            // 
            // gridKullanicilar
            // 
            this.gridKullanicilar.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridKullanicilar.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridKullanicilar.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridKullanicilar.Appearance.Row.BackColor2 = System.Drawing.Color.Red;
            this.gridKullanicilar.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridKullanicilar.Appearance.Row.Options.UseBackColor = true;
            this.gridKullanicilar.Appearance.Row.Options.UseFont = true;
            this.gridKullanicilar.GridControl = this.gridControlKullanici;
            this.gridKullanicilar.Name = "gridKullanicilar";
            this.gridKullanicilar.OptionsView.ShowGroupPanel = false;
            this.gridKullanicilar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridKullanicilar_FocusedRowChanged);
            // 
            // flowLytSag
            // 
            this.flowLytSag.Controls.Add(this.flowLytAd);
            this.flowLytSag.Controls.Add(this.flowLytSoyad);
            this.flowLytSag.Controls.Add(this.flowLytKulAD);
            this.flowLytSag.Controls.Add(this.flowLytSifre);
            this.flowLytSag.Controls.Add(this.flowLytButonlar);
            this.flowLytSag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLytSag.Location = new System.Drawing.Point(571, 3);
            this.flowLytSag.Name = "flowLytSag";
            this.flowLytSag.Size = new System.Drawing.Size(563, 565);
            this.flowLytSag.TabIndex = 5;
            // 
            // flowLytAd
            // 
            this.flowLytAd.Controls.Add(this.pnlGridControl);
            this.flowLytAd.Controls.Add(this.lblAd);
            this.flowLytAd.Controls.Add(this.txtAd);
            this.flowLytAd.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLytAd.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLytAd.Location = new System.Drawing.Point(3, 3);
            this.flowLytAd.Name = "flowLytAd";
            this.flowLytAd.Size = new System.Drawing.Size(563, 79);
            this.flowLytAd.TabIndex = 6;
            // 
            // pnlGridControl
            // 
            this.pnlGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridControl.Location = new System.Drawing.Point(3, 3);
            this.pnlGridControl.Name = "pnlGridControl";
            this.pnlGridControl.Size = new System.Drawing.Size(0, 100);
            this.pnlGridControl.TabIndex = 0;
            // 
            // lblAd
            // 
            this.lblAd.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Appearance.Options.UseFont = true;
            this.lblAd.Location = new System.Drawing.Point(9, 3);
            this.lblAd.Name = "lblAd";
            this.lblAd.Padding = new System.Windows.Forms.Padding(10, 30, 50, 20);
            this.lblAd.Size = new System.Drawing.Size(89, 72);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "AD";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(231, 30);
            this.txtAd.Margin = new System.Windows.Forms.Padding(130, 30, 10, 10);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(124, 22);
            this.txtAd.TabIndex = 2;
            // 
            // flowLytSoyad
            // 
            this.flowLytSoyad.Controls.Add(this.pnlSag);
            this.flowLytSoyad.Controls.Add(this.lblSoyad);
            this.flowLytSoyad.Controls.Add(this.txtSoyad);
            this.flowLytSoyad.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLytSoyad.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLytSoyad.Location = new System.Drawing.Point(3, 88);
            this.flowLytSoyad.Name = "flowLytSoyad";
            this.flowLytSoyad.Size = new System.Drawing.Size(563, 71);
            this.flowLytSoyad.TabIndex = 7;
            // 
            // pnlSag
            // 
            this.pnlSag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSag.Location = new System.Drawing.Point(3, 3);
            this.pnlSag.Name = "pnlSag";
            this.pnlSag.Size = new System.Drawing.Size(0, 100);
            this.pnlSag.TabIndex = 0;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSoyad.Appearance.Options.UseFont = true;
            this.lblSoyad.Location = new System.Drawing.Point(9, 3);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Padding = new System.Windows.Forms.Padding(10, 30, 50, 10);
            this.lblSoyad.Size = new System.Drawing.Size(130, 62);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "SOYAD";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(232, 30);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(90, 30, 10, 10);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(123, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // flowLytKulAD
            // 
            this.flowLytKulAD.Controls.Add(this.pnlSagAlt);
            this.flowLytKulAD.Controls.Add(this.lblKulAd);
            this.flowLytKulAD.Controls.Add(this.txtKulAd);
            this.flowLytKulAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLytKulAD.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLytKulAD.Location = new System.Drawing.Point(3, 165);
            this.flowLytKulAD.Name = "flowLytKulAD";
            this.flowLytKulAD.Size = new System.Drawing.Size(563, 70);
            this.flowLytKulAD.TabIndex = 8;
            // 
            // pnlSagAlt
            // 
            this.pnlSagAlt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSagAlt.Location = new System.Drawing.Point(3, 3);
            this.pnlSagAlt.Name = "pnlSagAlt";
            this.pnlSagAlt.Size = new System.Drawing.Size(0, 100);
            this.pnlSagAlt.TabIndex = 0;
            // 
            // lblKulAd
            // 
            this.lblKulAd.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblKulAd.Appearance.Options.UseFont = true;
            this.lblKulAd.Location = new System.Drawing.Point(9, 3);
            this.lblKulAd.Name = "lblKulAd";
            this.lblKulAd.Padding = new System.Windows.Forms.Padding(10, 30, 50, 10);
            this.lblKulAd.Size = new System.Drawing.Size(218, 62);
            this.lblKulAd.TabIndex = 3;
            this.lblKulAd.Text = "KULLANICI ADI";
            // 
            // txtKulAd
            // 
            this.txtKulAd.Location = new System.Drawing.Point(230, 30);
            this.txtKulAd.Margin = new System.Windows.Forms.Padding(0, 30, 10, 10);
            this.txtKulAd.Name = "txtKulAd";
            this.txtKulAd.Size = new System.Drawing.Size(125, 22);
            this.txtKulAd.TabIndex = 4;
            // 
            // flowLytSifre
            // 
            this.flowLytSifre.Controls.Add(this.pnlSagAlt2);
            this.flowLytSifre.Controls.Add(this.lblSifre);
            this.flowLytSifre.Controls.Add(this.txtSifre);
            this.flowLytSifre.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLytSifre.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLytSifre.Location = new System.Drawing.Point(3, 241);
            this.flowLytSifre.Name = "flowLytSifre";
            this.flowLytSifre.Size = new System.Drawing.Size(563, 62);
            this.flowLytSifre.TabIndex = 9;
            // 
            // pnlSagAlt2
            // 
            this.pnlSagAlt2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSagAlt2.Location = new System.Drawing.Point(3, 3);
            this.pnlSagAlt2.Name = "pnlSagAlt2";
            this.pnlSagAlt2.Size = new System.Drawing.Size(0, 100);
            this.pnlSagAlt2.TabIndex = 0;
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Location = new System.Drawing.Point(9, 3);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Padding = new System.Windows.Forms.Padding(10, 30, 50, 10);
            this.lblSifre.Size = new System.Drawing.Size(121, 62);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "ŞİFRE";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(233, 30);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(100, 30, 10, 10);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(122, 22);
            this.txtSifre.TabIndex = 3;
            // 
            // flowLytButonlar
            // 
            this.flowLytButonlar.Controls.Add(this.pnlSagAlt3);
            this.flowLytButonlar.Controls.Add(this.btnEkle);
            this.flowLytButonlar.Controls.Add(this.btnGuncelle);
            this.flowLytButonlar.Controls.Add(this.btnSil);
            this.flowLytButonlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLytButonlar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLytButonlar.Location = new System.Drawing.Point(3, 309);
            this.flowLytButonlar.Name = "flowLytButonlar";
            this.flowLytButonlar.Size = new System.Drawing.Size(563, 66);
            this.flowLytButonlar.TabIndex = 10;
            // 
            // pnlSagAlt3
            // 
            this.pnlSagAlt3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSagAlt3.Location = new System.Drawing.Point(3, 3);
            this.pnlSagAlt3.Name = "pnlSagAlt3";
            this.pnlSagAlt3.Size = new System.Drawing.Size(0, 100);
            this.pnlSagAlt3.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.Navy;
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEkle.ImageOptions.SvgImage")));
            this.btnEkle.Location = new System.Drawing.Point(9, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 63);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Location = new System.Drawing.Point(171, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(184, 63);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(361, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 63);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKullanicilar";
            this.Text = "Mevcut Kullanicilar";
            this.Load += new System.EventHandler(this.frmKullanicilar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar)).EndInit();
            this.flowLytSag.ResumeLayout(false);
            this.flowLytAd.ResumeLayout(false);
            this.flowLytAd.PerformLayout();
            this.flowLytSoyad.ResumeLayout(false);
            this.flowLytSoyad.PerformLayout();
            this.flowLytKulAD.ResumeLayout(false);
            this.flowLytKulAD.PerformLayout();
            this.flowLytSifre.ResumeLayout(false);
            this.flowLytSifre.PerformLayout();
            this.flowLytButonlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControlKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKullanicilar;
        private System.Windows.Forms.FlowLayoutPanel flowLytSag;
        private System.Windows.Forms.FlowLayoutPanel flowLytAd;
        private System.Windows.Forms.Panel pnlGridControl;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private System.Windows.Forms.FlowLayoutPanel flowLytSoyad;
        private System.Windows.Forms.Panel pnlSag;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private System.Windows.Forms.FlowLayoutPanel flowLytKulAD;
        private System.Windows.Forms.Panel pnlSagAlt;
        private DevExpress.XtraEditors.LabelControl lblKulAd;
        private System.Windows.Forms.FlowLayoutPanel flowLytSifre;
        private System.Windows.Forms.Panel pnlSagAlt2;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private System.Windows.Forms.FlowLayoutPanel flowLytButonlar;
        private System.Windows.Forms.Panel pnlSagAlt3;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKulAd;
        private System.Windows.Forms.TextBox txtSifre;
    }
}