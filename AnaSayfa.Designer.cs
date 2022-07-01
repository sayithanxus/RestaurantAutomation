
namespace RestoranUygulaması
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.tablePnlAna = new DevExpress.Utils.Layout.TablePanel();
            this.tablePnlSag = new DevExpress.Utils.Layout.TablePanel();
            this.ımageSliderAnaSayfa = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.chartControlSon20Siparis = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePnlAna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePnlSag)).BeginInit();
            this.tablePnlSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSliderAnaSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlSon20Siparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePnlAna
            // 
            this.tablePnlAna.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePnlAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePnlAna.Location = new System.Drawing.Point(0, 0);
            this.tablePnlAna.Name = "tablePnlAna";
            this.tablePnlAna.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePnlAna.Size = new System.Drawing.Size(1207, 526);
            this.tablePnlAna.TabIndex = 0;
            // 
            // tablePnlSag
            // 
            this.tablePnlSag.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePnlSag.Controls.Add(this.ımageSliderAnaSayfa);
            this.tablePnlSag.Controls.Add(this.chartControlSon20Siparis);
            this.tablePnlSag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePnlSag.Location = new System.Drawing.Point(0, 0);
            this.tablePnlSag.Name = "tablePnlSag";
            this.tablePnlSag.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePnlSag.Size = new System.Drawing.Size(1207, 526);
            this.tablePnlSag.TabIndex = 1;
            // 
            // ımageSliderAnaSayfa
            // 
            this.ımageSliderAnaSayfa.AnimationTime = 10;
            this.tablePnlSag.SetColumn(this.ımageSliderAnaSayfa, 0);
            this.ımageSliderAnaSayfa.CurrentImageIndex = 0;
            this.ımageSliderAnaSayfa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ımageSliderAnaSayfa.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSliderAnaSayfa.Images"))));
            this.ımageSliderAnaSayfa.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSliderAnaSayfa.Images1"))));
            this.ımageSliderAnaSayfa.Location = new System.Drawing.Point(3, 3);
            this.ımageSliderAnaSayfa.Name = "ımageSliderAnaSayfa";
            this.tablePnlSag.SetRow(this.ımageSliderAnaSayfa, 0);
            this.ımageSliderAnaSayfa.Size = new System.Drawing.Size(626, 520);
            this.ımageSliderAnaSayfa.TabIndex = 2;
            this.ımageSliderAnaSayfa.Text = "ımageSliderAnaSayfa";
            // 
            // chartControlSon20Siparis
            // 
            this.tablePnlSag.SetColumn(this.chartControlSon20Siparis, 1);
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlSon20Siparis.Diagram = xyDiagram1;
            this.chartControlSon20Siparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlSon20Siparis.Location = new System.Drawing.Point(635, 3);
            this.chartControlSon20Siparis.Name = "chartControlSon20Siparis";
            this.tablePnlSag.SetRow(this.chartControlSon20Siparis, 0);
            series1.Name = "Son 20 Sipariş";
            this.chartControlSon20Siparis.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlSon20Siparis.Size = new System.Drawing.Size(569, 520);
            this.chartControlSon20Siparis.TabIndex = 1;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 526);
            this.Controls.Add(this.tablePnlSag);
            this.Controls.Add(this.tablePnlAna);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePnlAna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePnlSag)).EndInit();
            this.tablePnlSag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ımageSliderAnaSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlSon20Siparis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePnlAna;
        private DevExpress.Utils.Layout.TablePanel tablePnlSag;
        private DevExpress.XtraCharts.ChartControl chartControlSon20Siparis;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSliderAnaSayfa;
    }
}