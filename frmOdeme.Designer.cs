
namespace RestoranUygulaması
{
    partial class frmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            this.pnlGridCntrl = new System.Windows.Forms.Panel();
            this.grdControlOdeme = new DevExpress.XtraGrid.GridControl();
            this.dgvOdeme = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.flowLytOdemeSagTaraf = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelNakit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKart = new DevExpress.XtraEditors.SimpleButton();
            this.lblKart = new System.Windows.Forms.Label();
            this.flowLytNakit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNakit = new DevExpress.XtraEditors.SimpleButton();
            this.lblNakit = new System.Windows.Forms.Label();
            this.flowLytSecimiDegistir = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSecimiDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnOde = new DevExpress.XtraEditors.SimpleButton();
            this.tableLytOdemeEkran = new System.Windows.Forms.TableLayoutPanel();
            this.tableLytOdemeEkran2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLytMasalarUstBilgi = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLytMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGridCntrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flowLytOdemeSagTaraf.SuspendLayout();
            this.flowLayoutPanelNakit.SuspendLayout();
            this.flowLytNakit.SuspendLayout();
            this.flowLytSecimiDegistir.SuspendLayout();
            this.tableLytOdemeEkran.SuspendLayout();
            this.tableLytOdemeEkran2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGridCntrl
            // 
            this.pnlGridCntrl.Controls.Add(this.grdControlOdeme);
            this.pnlGridCntrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCntrl.Location = new System.Drawing.Point(3, 3);
            this.pnlGridCntrl.Name = "pnlGridCntrl";
            this.pnlGridCntrl.Size = new System.Drawing.Size(765, 656);
            this.pnlGridCntrl.TabIndex = 0;
            // 
            // grdControlOdeme
            // 
            this.grdControlOdeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlOdeme.Location = new System.Drawing.Point(0, 0);
            this.grdControlOdeme.MainView = this.dgvOdeme;
            this.grdControlOdeme.Name = "grdControlOdeme";
            this.grdControlOdeme.Size = new System.Drawing.Size(765, 656);
            this.grdControlOdeme.TabIndex = 4;
            this.grdControlOdeme.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvOdeme,
            this.gridView1});
            // 
            // dgvOdeme
            // 
            this.dgvOdeme.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Red;
            this.dgvOdeme.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvOdeme.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvOdeme.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray;
            this.dgvOdeme.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgvOdeme.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvOdeme.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgvOdeme.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvOdeme.Appearance.Row.BackColor2 = System.Drawing.Color.Red;
            this.dgvOdeme.Appearance.Row.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvOdeme.Appearance.Row.Options.UseBackColor = true;
            this.dgvOdeme.Appearance.Row.Options.UseFont = true;
            this.dgvOdeme.GridControl = this.grdControlOdeme;
            this.dgvOdeme.Name = "dgvOdeme";
            this.dgvOdeme.OptionsView.ShowGroupPanel = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdControlOdeme;
            this.gridView1.Name = "gridView1";
            // 
            // flowLytOdemeSagTaraf
            // 
            this.flowLytOdemeSagTaraf.Controls.Add(this.flowLayoutPanelNakit);
            this.flowLytOdemeSagTaraf.Controls.Add(this.flowLytNakit);
            this.flowLytOdemeSagTaraf.Controls.Add(this.flowLytSecimiDegistir);
            this.flowLytOdemeSagTaraf.Controls.Add(this.btnOde);
            this.flowLytOdemeSagTaraf.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLytOdemeSagTaraf.Location = new System.Drawing.Point(774, 3);
            this.flowLytOdemeSagTaraf.Name = "flowLytOdemeSagTaraf";
            this.flowLytOdemeSagTaraf.Size = new System.Drawing.Size(488, 643);
            this.flowLytOdemeSagTaraf.TabIndex = 1;
            // 
            // flowLayoutPanelNakit
            // 
            this.flowLayoutPanelNakit.Controls.Add(this.btnKart);
            this.flowLayoutPanelNakit.Controls.Add(this.lblKart);
            this.flowLayoutPanelNakit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelNakit.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelNakit.Name = "flowLayoutPanelNakit";
            this.flowLayoutPanelNakit.Size = new System.Drawing.Size(217, 100);
            this.flowLayoutPanelNakit.TabIndex = 33;
            // 
            // btnKart
            // 
            this.btnKart.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKart.Appearance.BackColor2 = System.Drawing.Color.Aqua;
            this.btnKart.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKart.Appearance.Options.UseBackColor = true;
            this.btnKart.Appearance.Options.UseFont = true;
            this.btnKart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKart.ImageOptions.SvgImage")));
            this.btnKart.Location = new System.Drawing.Point(3, 3);
            this.btnKart.Name = "btnKart";
            this.btnKart.Size = new System.Drawing.Size(205, 62);
            this.btnKart.TabIndex = 33;
            this.btnKart.Text = "Kartla Öde";
            this.btnKart.Click += new System.EventHandler(this.btnKart_Click);
            // 
            // lblKart
            // 
            this.lblKart.AutoSize = true;
            this.lblKart.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKart.ForeColor = System.Drawing.Color.IndianRed;
            this.lblKart.Location = new System.Drawing.Point(214, 0);
            this.lblKart.Name = "lblKart";
            this.lblKart.Size = new System.Drawing.Size(0, 36);
            this.lblKart.TabIndex = 32;
            // 
            // flowLytNakit
            // 
            this.flowLytNakit.Controls.Add(this.btnNakit);
            this.flowLytNakit.Controls.Add(this.lblNakit);
            this.flowLytNakit.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLytNakit.Location = new System.Drawing.Point(3, 109);
            this.flowLytNakit.Name = "flowLytNakit";
            this.flowLytNakit.Size = new System.Drawing.Size(217, 119);
            this.flowLytNakit.TabIndex = 34;
            // 
            // btnNakit
            // 
            this.btnNakit.Appearance.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNakit.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNakit.Appearance.Options.UseBackColor = true;
            this.btnNakit.Appearance.Options.UseFont = true;
            this.btnNakit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNakit.ImageOptions.SvgImage")));
            this.btnNakit.Location = new System.Drawing.Point(3, 3);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(208, 64);
            this.btnNakit.TabIndex = 30;
            this.btnNakit.Text = "Nakit Öde";
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblNakit.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNakit.Location = new System.Drawing.Point(3, 70);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(0, 36);
            this.lblNakit.TabIndex = 28;
            // 
            // flowLytSecimiDegistir
            // 
            this.flowLytSecimiDegistir.Controls.Add(this.btnSecimiDegistir);
            this.flowLytSecimiDegistir.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLytSecimiDegistir.Location = new System.Drawing.Point(3, 234);
            this.flowLytSecimiDegistir.Name = "flowLytSecimiDegistir";
            this.flowLytSecimiDegistir.Size = new System.Drawing.Size(217, 119);
            this.flowLytSecimiDegistir.TabIndex = 35;
            // 
            // btnSecimiDegistir
            // 
            this.btnSecimiDegistir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSecimiDegistir.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecimiDegistir.Appearance.Options.UseBackColor = true;
            this.btnSecimiDegistir.Appearance.Options.UseFont = true;
            this.btnSecimiDegistir.Enabled = false;
            this.btnSecimiDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSecimiDegistir.ImageOptions.Image")));
            this.btnSecimiDegistir.Location = new System.Drawing.Point(3, 3);
            this.btnSecimiDegistir.Name = "btnSecimiDegistir";
            this.btnSecimiDegistir.Size = new System.Drawing.Size(214, 78);
            this.btnSecimiDegistir.TabIndex = 0;
            this.btnSecimiDegistir.Text = "Seçimi Değiştir";
            this.btnSecimiDegistir.Click += new System.EventHandler(this.btnSecimiDegistir_Click);
            // 
            // btnOde
            // 
            this.btnOde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOde.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOde.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOde.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Appearance.Options.UseBackColor = true;
            this.btnOde.Appearance.Options.UseFont = true;
            this.btnOde.Enabled = false;
            this.btnOde.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOde.ImageOptions.SvgImage")));
            this.btnOde.Location = new System.Drawing.Point(3, 359);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(217, 80);
            this.btnOde.TabIndex = 27;
            this.btnOde.Text = "ÖDE";
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // tableLytOdemeEkran
            // 
            this.tableLytOdemeEkran.ColumnCount = 2;
            this.tableLytOdemeEkran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.94862F));
            this.tableLytOdemeEkran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.05138F));
            this.tableLytOdemeEkran.Controls.Add(this.pnlGridCntrl, 0, 0);
            this.tableLytOdemeEkran.Controls.Add(this.flowLytOdemeSagTaraf, 1, 0);
            this.tableLytOdemeEkran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLytOdemeEkran.Location = new System.Drawing.Point(0, 0);
            this.tableLytOdemeEkran.Name = "tableLytOdemeEkran";
            this.tableLytOdemeEkran.RowCount = 1;
            this.tableLytOdemeEkran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.30801F));
            this.tableLytOdemeEkran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.69198F));
            this.tableLytOdemeEkran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 474F));
            this.tableLytOdemeEkran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 474F));
            this.tableLytOdemeEkran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 474F));
            this.tableLytOdemeEkran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 474F));
            this.tableLytOdemeEkran.Size = new System.Drawing.Size(1265, 662);
            this.tableLytOdemeEkran.TabIndex = 2;
            this.tableLytOdemeEkran.Visible = false;
            // 
            // tableLytOdemeEkran2
            // 
            this.tableLytOdemeEkran2.ColumnCount = 1;
            this.tableLytOdemeEkran2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLytOdemeEkran2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLytOdemeEkran2.Controls.Add(this.flowLytMasalarUstBilgi, 0, 0);
            this.tableLytOdemeEkran2.Controls.Add(this.flowLytMasalar, 0, 1);
            this.tableLytOdemeEkran2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLytOdemeEkran2.Location = new System.Drawing.Point(0, 0);
            this.tableLytOdemeEkran2.Name = "tableLytOdemeEkran2";
            this.tableLytOdemeEkran2.RowCount = 2;
            this.tableLytOdemeEkran2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.52897F));
            this.tableLytOdemeEkran2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.47103F));
            this.tableLytOdemeEkran2.Size = new System.Drawing.Size(1265, 662);
            this.tableLytOdemeEkran2.TabIndex = 1;
            // 
            // flowLytMasalarUstBilgi
            // 
            this.flowLytMasalarUstBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLytMasalarUstBilgi.Location = new System.Drawing.Point(3, 3);
            this.flowLytMasalarUstBilgi.Name = "flowLytMasalarUstBilgi";
            this.flowLytMasalarUstBilgi.Size = new System.Drawing.Size(1259, 129);
            this.flowLytMasalarUstBilgi.TabIndex = 0;
            // 
            // flowLytMasalar
            // 
            this.flowLytMasalar.AutoScroll = true;
            this.flowLytMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLytMasalar.Location = new System.Drawing.Point(3, 138);
            this.flowLytMasalar.Name = "flowLytMasalar";
            this.flowLytMasalar.Size = new System.Drawing.Size(1259, 521);
            this.flowLytMasalar.TabIndex = 1;
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 662);
            this.Controls.Add(this.tableLytOdemeEkran);
            this.Controls.Add(this.tableLytOdemeEkran2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOdeme";
            this.Text = "Ödeme Yap";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            this.pnlGridCntrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flowLytOdemeSagTaraf.ResumeLayout(false);
            this.flowLayoutPanelNakit.ResumeLayout(false);
            this.flowLayoutPanelNakit.PerformLayout();
            this.flowLytNakit.ResumeLayout(false);
            this.flowLytNakit.PerformLayout();
            this.flowLytSecimiDegistir.ResumeLayout(false);
            this.tableLytOdemeEkran.ResumeLayout(false);
            this.tableLytOdemeEkran2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlGridCntrl;
        private DevExpress.XtraGrid.GridControl grdControlOdeme;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvOdeme;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLytOdemeSagTaraf;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNakit;
        private DevExpress.XtraEditors.SimpleButton btnKart;
        private System.Windows.Forms.Label lblKart;
        private System.Windows.Forms.FlowLayoutPanel flowLytNakit;
        private DevExpress.XtraEditors.SimpleButton btnNakit;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.FlowLayoutPanel flowLytSecimiDegistir;
        private DevExpress.XtraEditors.SimpleButton btnOde;
        private System.Windows.Forms.TableLayoutPanel tableLytOdemeEkran;
        private DevExpress.XtraEditors.SimpleButton btnSecimiDegistir;
        private System.Windows.Forms.TableLayoutPanel tableLytOdemeEkran2;
        private System.Windows.Forms.FlowLayoutPanel flowLytMasalarUstBilgi;
        private System.Windows.Forms.FlowLayoutPanel flowLytMasalar;
    }
}