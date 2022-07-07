
namespace RestoranUygulaması
{
    partial class frmBelliTarihCiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBelliTarihCiro));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlSagTaraf = new System.Windows.Forms.Panel();
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.dtmpckrDate = new System.Windows.Forms.DateTimePicker();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chrtKarHesaplayici = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSagTaraf.SuspendLayout();
            this.pnlBilgi.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtKarHesaplayici)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSagTaraf
            // 
            this.pnlSagTaraf.BackColor = System.Drawing.Color.Transparent;
            this.pnlSagTaraf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSagTaraf.BackgroundImage")));
            this.pnlSagTaraf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSagTaraf.Controls.Add(this.pnlBilgi);
            this.pnlSagTaraf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSagTaraf.Location = new System.Drawing.Point(693, 3);
            this.pnlSagTaraf.Name = "pnlSagTaraf";
            this.pnlSagTaraf.Size = new System.Drawing.Size(472, 504);
            this.pnlSagTaraf.TabIndex = 1;
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBilgi.BackColor = System.Drawing.Color.Azure;
            this.pnlBilgi.Controls.Add(this.btnAra);
            this.pnlBilgi.Controls.Add(this.dtmpckrDate);
            this.pnlBilgi.Controls.Add(this.lblBilgi);
            this.pnlBilgi.Location = new System.Drawing.Point(76, 109);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(348, 224);
            this.pnlBilgi.TabIndex = 7;
            // 
            // dtmpckrDate
            // 
            this.dtmpckrDate.Location = new System.Drawing.Point(7, 113);
            this.dtmpckrDate.Name = "dtmpckrDate";
            this.dtmpckrDate.Size = new System.Drawing.Size(216, 22);
            this.dtmpckrDate.TabIndex = 7;
            this.dtmpckrDate.Value = new System.DateTime(2022, 7, 1, 0, 0, 0, 0);
            // 
            // lblBilgi
            // 
            this.lblBilgi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(3, 16);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(315, 81);
            this.lblBilgi.TabIndex = 3;
            this.lblBilgi.Text = "Belli bir tarihteki toplam ciroyu hesaplamak için lütfen tarih seçip butona basın" +
    "ız.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.09511F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90489F));
            this.tableLayoutPanel1.Controls.Add(this.pnlSagTaraf, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chrtKarHesaplayici, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 510);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // chrtKarHesaplayici
            // 
            this.chrtKarHesaplayici.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chrtKarHesaplayici.ChartAreas.Add(chartArea1);
            this.chrtKarHesaplayici.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chrtKarHesaplayici.Legends.Add(legend1);
            this.chrtKarHesaplayici.Location = new System.Drawing.Point(3, 3);
            this.chrtKarHesaplayici.Name = "chrtKarHesaplayici";
            this.chrtKarHesaplayici.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Gun Sonu";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chrtKarHesaplayici.Series.Add(series1);
            this.chrtKarHesaplayici.Size = new System.Drawing.Size(684, 504);
            this.chrtKarHesaplayici.TabIndex = 0;
            this.chrtKarHesaplayici.Text = "chrtKarHesaplayici";
            // 
            // btnAra
            // 
            this.btnAra.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnAra.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Appearance.Options.UseBackColor = true;
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.AppearanceHovered.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAra.AppearanceHovered.Font = new System.Drawing.Font("Verdana", 11.8F, System.Drawing.FontStyle.Bold);
            this.btnAra.AppearanceHovered.Options.UseBackColor = true;
            this.btnAra.AppearanceHovered.Options.UseFont = true;
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(7, 157);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(118, 47);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "ARA";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmBelliTarihCiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBelliTarihCiro";
            this.Text = "Belli Tarihte Günlük Kazanç";
            this.Load += new System.EventHandler(this.frmBelliTarihCiro_Load);
            this.pnlSagTaraf.ResumeLayout(false);
            this.pnlBilgi.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtKarHesaplayici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSagTaraf;
        private System.Windows.Forms.Panel pnlBilgi;
        private System.Windows.Forms.DateTimePicker dtmpckrDate;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtKarHesaplayici;
        private DevExpress.XtraEditors.SimpleButton btnAra;
    }
}