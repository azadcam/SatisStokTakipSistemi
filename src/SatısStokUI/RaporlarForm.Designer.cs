namespace SatisStokUI
{
    partial class RaporlarForm
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
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Günlük Satış");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Ürün Bazlı Ciro");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Aylık ciro", new System.Windows.Forms.TreeNode[] {
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Satış Ve Ciro", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Kritik Stok");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Depo Doluluk");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Üretimdeki Ürünler");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Stok Ve Üretim", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("En İyi Müşteriler");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Yeni Müşteriler");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Müşteri", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Gelir - Gider");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Karlılık");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Finansal Raporlar ", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlPageSatisCiro = new System.Windows.Forms.Panel();
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.chartSatis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChartHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.dgvSatis = new System.Windows.Forms.DataGridView();
            this.pnlDvgHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tblKpi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKpiCiro = new System.Windows.Forms.Panel();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            this.pnlKpiSatis = new System.Windows.Forms.Panel();
            this.lblSatisDeger = new System.Windows.Forms.Label();
            this.lblstok = new System.Windows.Forms.Label();
            this.pnlKpiStok = new System.Windows.Forms.Panel();
            this.lblStokDeger = new System.Windows.Forms.Label();
            this.lblKritikStokUretim = new System.Windows.Forms.Label();
            this.pnlPageMusteri = new System.Windows.Forms.Panel();
            this.pnlMusteriTop = new System.Windows.Forms.Panel();
            this.pnlKartAktifMusteri = new System.Windows.Forms.Panel();
            this.lblToplamMusteriDeger = new System.Windows.Forms.Label();
            this.lblToplamMusteriBaslik = new System.Windows.Forms.Label();
            this.pnlKartTopMusteri = new System.Windows.Forms.Panel();
            this.lblEnIyiMusteriDeger = new System.Windows.Forms.Label();
            this.lblEnIyiMusteriBaslik = new System.Windows.Forms.Label();
            this.pnlKartToplamCiro = new System.Windows.Forms.Panel();
            this.lblToplamCiroDeger = new System.Windows.Forms.Label();
            this.lblToplamCiroBaslik = new System.Windows.Forms.Label();
            this.pnlMusteriBody = new System.Windows.Forms.Panel();
            this.scMusteri = new System.Windows.Forms.SplitContainer();
            this.chartMusteri = new System.Windows.Forms.Panel();
            this.chartMusterii = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvMusteri = new System.Windows.Forms.DataGridView();
            this.pnlPageStokUretim = new System.Windows.Forms.Panel();
            this.scStok = new System.Windows.Forms.SplitContainer();
            this.pnlChartStok = new System.Windows.Forms.Panel();
            this.chartStok = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTableStok = new System.Windows.Forms.Panel();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToplamUrunDeger = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblToplamStokDeger = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKritikStokDeger = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlPageFinans = new System.Windows.Forms.Panel();
            this.scFinans = new System.Windows.Forms.SplitContainer();
            this.pnlChartFinans = new System.Windows.Forms.Panel();
            this.chartFinans = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTableFinans = new System.Windows.Forms.Panel();
            this.dgvFinans = new System.Windows.Forms.DataGridView();
            this.pnlFinansTop = new System.Windows.Forms.Panel();
            this.pnlKartKar = new System.Windows.Forms.Panel();
            this.lblNetKarDeger = new System.Windows.Forms.Label();
            this.lblNetKar = new System.Windows.Forms.Label();
            this.pnlKartGider = new System.Windows.Forms.Panel();
            this.lblToplamGiderDeger = new System.Windows.Forms.Label();
            this.lblToplamGider = new System.Windows.Forms.Label();
            this.pnlKartGelir = new System.Windows.Forms.Panel();
            this.lblToplamGelirDeger = new System.Windows.Forms.Label();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlPageSatisCiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatis)).BeginInit();
            this.pnlChartHeader.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).BeginInit();
            this.pnlDvgHeader.SuspendLayout();
            this.tblKpi.SuspendLayout();
            this.pnlKpiCiro.SuspendLayout();
            this.pnlKpiSatis.SuspendLayout();
            this.pnlKpiStok.SuspendLayout();
            this.pnlPageMusteri.SuspendLayout();
            this.pnlMusteriTop.SuspendLayout();
            this.pnlKartAktifMusteri.SuspendLayout();
            this.pnlKartTopMusteri.SuspendLayout();
            this.pnlKartToplamCiro.SuspendLayout();
            this.pnlMusteriBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMusteri)).BeginInit();
            this.scMusteri.Panel1.SuspendLayout();
            this.scMusteri.Panel2.SuspendLayout();
            this.scMusteri.SuspendLayout();
            this.chartMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMusterii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).BeginInit();
            this.pnlPageStokUretim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scStok)).BeginInit();
            this.scStok.Panel1.SuspendLayout();
            this.scStok.Panel2.SuspendLayout();
            this.scStok.SuspendLayout();
            this.pnlChartStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStok)).BeginInit();
            this.pnlTableStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPageFinans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scFinans)).BeginInit();
            this.scFinans.Panel1.SuspendLayout();
            this.scFinans.Panel2.SuspendLayout();
            this.scFinans.SuspendLayout();
            this.pnlChartFinans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFinans)).BeginInit();
            this.pnlTableFinans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinans)).BeginInit();
            this.pnlFinansTop.SuspendLayout();
            this.pnlKartKar.SuspendLayout();
            this.pnlKartGider.SuspendLayout();
            this.pnlKartGelir.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1453, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DimGray;
            this.pnlMenu.Controls.Add(this.tvMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 706);
            this.pnlMenu.TabIndex = 5;
            this.pnlMenu.UseWaitCursor = true;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.DimGray;
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tvMenu.ForeColor = System.Drawing.Color.White;
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.Indent = 15;
            this.tvMenu.ItemHeight = 32;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            treeNode29.Name = "Node3";
            treeNode29.Text = "Günlük Satış";
            treeNode30.Name = "Node5";
            treeNode30.Text = "Ürün Bazlı Ciro";
            treeNode31.Name = "Node4";
            treeNode31.Text = "Aylık ciro";
            treeNode32.Name = "Node1";
            treeNode32.Text = "Satış Ve Ciro";
            treeNode33.Name = "Node6";
            treeNode33.Text = "Kritik Stok";
            treeNode34.Name = "Node7";
            treeNode34.Text = "Depo Doluluk";
            treeNode35.Name = "Node8";
            treeNode35.Text = "Üretimdeki Ürünler";
            treeNode36.Name = "Node2";
            treeNode36.Text = "Stok Ve Üretim";
            treeNode37.Name = "Node10";
            treeNode37.Text = "En İyi Müşteriler";
            treeNode38.Name = "Node12";
            treeNode38.Text = "Yeni Müşteriler";
            treeNode39.Name = "Node9";
            treeNode39.Text = "Müşteri";
            treeNode40.Name = "Node14";
            treeNode40.Text = "Gelir - Gider";
            treeNode41.Name = "Node15";
            treeNode41.Text = "Karlılık";
            treeNode42.Name = "Node13";
            treeNode42.Text = "Finansal Raporlar ";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode36,
            treeNode39,
            treeNode42});
            this.tvMenu.ShowLines = false;
            this.tvMenu.ShowRootLines = false;
            this.tvMenu.Size = new System.Drawing.Size(200, 706);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.UseWaitCursor = true;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlBody);
            this.pnlContent.Controls.Add(this.pnlFilter);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1280, 706);
            this.pnlContent.TabIndex = 6;
            this.pnlContent.UseWaitCursor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBody.Controls.Add(this.pnlPageMusteri);
            this.pnlBody.Controls.Add(this.pnlPageFinans);
            this.pnlBody.Controls.Add(this.pnlPageSatisCiro);
            this.pnlBody.Controls.Add(this.pnlPageStokUretim);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 155);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1280, 551);
            this.pnlBody.TabIndex = 2;
            this.pnlBody.UseWaitCursor = true;
            // 
            // pnlPageSatisCiro
            // 
            this.pnlPageSatisCiro.Controls.Add(this.splMain);
            this.pnlPageSatisCiro.Controls.Add(this.tblKpi);
            this.pnlPageSatisCiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPageSatisCiro.Location = new System.Drawing.Point(0, 0);
            this.pnlPageSatisCiro.Name = "pnlPageSatisCiro";
            this.pnlPageSatisCiro.Size = new System.Drawing.Size(1280, 551);
            this.pnlPageSatisCiro.TabIndex = 1;
            this.pnlPageSatisCiro.UseWaitCursor = true;
            this.pnlPageSatisCiro.Visible = false;
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.Location = new System.Drawing.Point(0, 100);
            this.splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.pnlChart);
            this.splMain.Panel1.UseWaitCursor = true;
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.pnlTable);
            this.splMain.Panel2.UseWaitCursor = true;
            this.splMain.Size = new System.Drawing.Size(1280, 451);
            this.splMain.SplitterDistance = 777;
            this.splMain.TabIndex = 2;
            this.splMain.UseWaitCursor = true;
            // 
            // pnlChart
            // 
            this.pnlChart.Controls.Add(this.chartSatis);
            this.pnlChart.Controls.Add(this.pnlChartHeader);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(0, 0);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Padding = new System.Windows.Forms.Padding(10);
            this.pnlChart.Size = new System.Drawing.Size(777, 451);
            this.pnlChart.TabIndex = 0;
            this.pnlChart.UseWaitCursor = true;
            // 
            // chartSatis
            // 
            chartArea9.Name = "ChartArea1";
            this.chartSatis.ChartAreas.Add(chartArea9);
            this.chartSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.chartSatis.Legends.Add(legend9);
            this.chartSatis.Location = new System.Drawing.Point(10, 55);
            this.chartSatis.Name = "chartSatis";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartSatis.Series.Add(series9);
            this.chartSatis.Size = new System.Drawing.Size(757, 386);
            this.chartSatis.TabIndex = 2;
            this.chartSatis.Text = "chart1";
            this.chartSatis.UseWaitCursor = true;
            // 
            // pnlChartHeader
            // 
            this.pnlChartHeader.Controls.Add(this.label5);
            this.pnlChartHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChartHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlChartHeader.Name = "pnlChartHeader";
            this.pnlChartHeader.Size = new System.Drawing.Size(757, 45);
            this.pnlChartHeader.TabIndex = 1;
            this.pnlChartHeader.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(240, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grafik";
            this.label5.UseWaitCursor = true;
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.dgvSatis);
            this.pnlTable.Controls.Add(this.pnlDvgHeader);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTable.Location = new System.Drawing.Point(0, 0);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTable.Size = new System.Drawing.Size(499, 451);
            this.pnlTable.TabIndex = 0;
            this.pnlTable.UseWaitCursor = true;
            // 
            // dgvSatis
            // 
            this.dgvSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSatis.Location = new System.Drawing.Point(10, 55);
            this.dgvSatis.Name = "dgvSatis";
            this.dgvSatis.RowHeadersWidth = 51;
            this.dgvSatis.RowTemplate.Height = 24;
            this.dgvSatis.Size = new System.Drawing.Size(479, 386);
            this.dgvSatis.TabIndex = 2;
            this.dgvSatis.UseWaitCursor = true;
            // 
            // pnlDvgHeader
            // 
            this.pnlDvgHeader.Controls.Add(this.label6);
            this.pnlDvgHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDvgHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlDvgHeader.Name = "pnlDvgHeader";
            this.pnlDvgHeader.Size = new System.Drawing.Size(479, 45);
            this.pnlDvgHeader.TabIndex = 1;
            this.pnlDvgHeader.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(151, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Detay Liste";
            this.label6.UseWaitCursor = true;
            // 
            // tblKpi
            // 
            this.tblKpi.ColumnCount = 3;
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblKpi.Controls.Add(this.pnlKpiCiro, 0, 0);
            this.tblKpi.Controls.Add(this.pnlKpiSatis, 1, 0);
            this.tblKpi.Controls.Add(this.pnlKpiStok, 2, 0);
            this.tblKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblKpi.Location = new System.Drawing.Point(0, 0);
            this.tblKpi.Name = "tblKpi";
            this.tblKpi.RowCount = 1;
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKpi.Size = new System.Drawing.Size(1280, 100);
            this.tblKpi.TabIndex = 1;
            this.tblKpi.UseWaitCursor = true;
            // 
            // pnlKpiCiro
            // 
            this.pnlKpiCiro.BackColor = System.Drawing.Color.Teal;
            this.pnlKpiCiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiCiro.Controls.Add(this.lblUrunAdet);
            this.pnlKpiCiro.Controls.Add(this.lblToplamUrun);
            this.pnlKpiCiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiCiro.Location = new System.Drawing.Point(10, 10);
            this.pnlKpiCiro.Margin = new System.Windows.Forms.Padding(10);
            this.pnlKpiCiro.Name = "pnlKpiCiro";
            this.pnlKpiCiro.Padding = new System.Windows.Forms.Padding(5);
            this.pnlKpiCiro.Size = new System.Drawing.Size(402, 80);
            this.pnlKpiCiro.TabIndex = 0;
            this.pnlKpiCiro.UseWaitCursor = true;
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunAdet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdet.ForeColor = System.Drawing.Color.White;
            this.lblUrunAdet.Location = new System.Drawing.Point(151, 34);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(63, 23);
            this.lblUrunAdet.TabIndex = 1;
            this.lblUrunAdet.Text = "0.00 TL";
            this.lblUrunAdet.UseWaitCursor = true;
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamUrun.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUrun.ForeColor = System.Drawing.Color.White;
            this.lblToplamUrun.Location = new System.Drawing.Point(24, 34);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(101, 23);
            this.lblToplamUrun.TabIndex = 0;
            this.lblToplamUrun.Text = "Toplam Ciro";
            this.lblToplamUrun.UseWaitCursor = true;
            // 
            // pnlKpiSatis
            // 
            this.pnlKpiSatis.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlKpiSatis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiSatis.Controls.Add(this.lblSatisDeger);
            this.pnlKpiSatis.Controls.Add(this.lblstok);
            this.pnlKpiSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiSatis.Location = new System.Drawing.Point(432, 10);
            this.pnlKpiSatis.Margin = new System.Windows.Forms.Padding(10);
            this.pnlKpiSatis.Name = "pnlKpiSatis";
            this.pnlKpiSatis.Padding = new System.Windows.Forms.Padding(5);
            this.pnlKpiSatis.Size = new System.Drawing.Size(402, 80);
            this.pnlKpiSatis.TabIndex = 1;
            this.pnlKpiSatis.UseWaitCursor = true;
            // 
            // lblSatisDeger
            // 
            this.lblSatisDeger.AutoSize = true;
            this.lblSatisDeger.BackColor = System.Drawing.Color.Transparent;
            this.lblSatisDeger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisDeger.ForeColor = System.Drawing.Color.White;
            this.lblSatisDeger.Location = new System.Drawing.Point(171, 34);
            this.lblSatisDeger.Name = "lblSatisDeger";
            this.lblSatisDeger.Size = new System.Drawing.Size(67, 23);
            this.lblSatisDeger.TabIndex = 1;
            this.lblSatisDeger.Text = "0  Ürün";
            this.lblSatisDeger.UseWaitCursor = true;
            // 
            // lblstok
            // 
            this.lblstok.AutoSize = true;
            this.lblstok.BackColor = System.Drawing.Color.Transparent;
            this.lblstok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstok.ForeColor = System.Drawing.Color.White;
            this.lblstok.Location = new System.Drawing.Point(35, 34);
            this.lblstok.Name = "lblstok";
            this.lblstok.Size = new System.Drawing.Size(105, 23);
            this.lblstok.TabIndex = 0;
            this.lblstok.Text = "Toplam Satış";
            this.lblstok.UseWaitCursor = true;
            // 
            // pnlKpiStok
            // 
            this.pnlKpiStok.BackColor = System.Drawing.Color.IndianRed;
            this.pnlKpiStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiStok.Controls.Add(this.lblStokDeger);
            this.pnlKpiStok.Controls.Add(this.lblKritikStokUretim);
            this.pnlKpiStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiStok.Location = new System.Drawing.Point(854, 10);
            this.pnlKpiStok.Margin = new System.Windows.Forms.Padding(10);
            this.pnlKpiStok.Name = "pnlKpiStok";
            this.pnlKpiStok.Padding = new System.Windows.Forms.Padding(5);
            this.pnlKpiStok.Size = new System.Drawing.Size(416, 80);
            this.pnlKpiStok.TabIndex = 2;
            this.pnlKpiStok.UseWaitCursor = true;
            // 
            // lblStokDeger
            // 
            this.lblStokDeger.AutoSize = true;
            this.lblStokDeger.BackColor = System.Drawing.Color.Transparent;
            this.lblStokDeger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokDeger.ForeColor = System.Drawing.Color.White;
            this.lblStokDeger.Location = new System.Drawing.Point(133, 34);
            this.lblStokDeger.Name = "lblStokDeger";
            this.lblStokDeger.Size = new System.Drawing.Size(62, 23);
            this.lblStokDeger.TabIndex = 1;
            this.lblStokDeger.Text = "0 Ürün";
            this.lblStokDeger.UseWaitCursor = true;
            // 
            // lblKritikStokUretim
            // 
            this.lblKritikStokUretim.AutoSize = true;
            this.lblKritikStokUretim.BackColor = System.Drawing.Color.Transparent;
            this.lblKritikStokUretim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKritikStokUretim.ForeColor = System.Drawing.Color.White;
            this.lblKritikStokUretim.Location = new System.Drawing.Point(38, 34);
            this.lblKritikStokUretim.Name = "lblKritikStokUretim";
            this.lblKritikStokUretim.Size = new System.Drawing.Size(85, 23);
            this.lblKritikStokUretim.TabIndex = 0;
            this.lblKritikStokUretim.Text = "Kritik Stok";
            this.lblKritikStokUretim.UseWaitCursor = true;
            // 
            // pnlPageMusteri
            // 
            this.pnlPageMusteri.Controls.Add(this.pnlMusteriTop);
            this.pnlPageMusteri.Controls.Add(this.pnlMusteriBody);
            this.pnlPageMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPageMusteri.Location = new System.Drawing.Point(0, 0);
            this.pnlPageMusteri.Name = "pnlPageMusteri";
            this.pnlPageMusteri.Size = new System.Drawing.Size(1280, 551);
            this.pnlPageMusteri.TabIndex = 5;
            this.pnlPageMusteri.UseWaitCursor = true;
            this.pnlPageMusteri.Visible = false;
            // 
            // pnlMusteriTop
            // 
            this.pnlMusteriTop.Controls.Add(this.pnlKartAktifMusteri);
            this.pnlMusteriTop.Controls.Add(this.pnlKartTopMusteri);
            this.pnlMusteriTop.Controls.Add(this.pnlKartToplamCiro);
            this.pnlMusteriTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMusteriTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMusteriTop.Name = "pnlMusteriTop";
            this.pnlMusteriTop.Size = new System.Drawing.Size(1280, 100);
            this.pnlMusteriTop.TabIndex = 1;
            this.pnlMusteriTop.UseWaitCursor = true;
            // 
            // pnlKartAktifMusteri
            // 
            this.pnlKartAktifMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlKartAktifMusteri.Controls.Add(this.lblToplamMusteriDeger);
            this.pnlKartAktifMusteri.Controls.Add(this.lblToplamMusteriBaslik);
            this.pnlKartAktifMusteri.Location = new System.Drawing.Point(695, 9);
            this.pnlKartAktifMusteri.Name = "pnlKartAktifMusteri";
            this.pnlKartAktifMusteri.Size = new System.Drawing.Size(240, 81);
            this.pnlKartAktifMusteri.TabIndex = 2;
            this.pnlKartAktifMusteri.UseWaitCursor = true;
            // 
            // lblToplamMusteriDeger
            // 
            this.lblToplamMusteriDeger.AutoSize = true;
            this.lblToplamMusteriDeger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamMusteriDeger.ForeColor = System.Drawing.Color.White;
            this.lblToplamMusteriDeger.Location = new System.Drawing.Point(170, 38);
            this.lblToplamMusteriDeger.Name = "lblToplamMusteriDeger";
            this.lblToplamMusteriDeger.Size = new System.Drawing.Size(19, 23);
            this.lblToplamMusteriDeger.TabIndex = 1;
            this.lblToplamMusteriDeger.Text = "0";
            this.lblToplamMusteriDeger.UseWaitCursor = true;
            this.lblToplamMusteriDeger.Click += new System.EventHandler(this.lblAktifMusteriDeger_Click);
            // 
            // lblToplamMusteriBaslik
            // 
            this.lblToplamMusteriBaslik.AutoSize = true;
            this.lblToplamMusteriBaslik.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamMusteriBaslik.ForeColor = System.Drawing.Color.White;
            this.lblToplamMusteriBaslik.Location = new System.Drawing.Point(3, 38);
            this.lblToplamMusteriBaslik.Name = "lblToplamMusteriBaslik";
            this.lblToplamMusteriBaslik.Size = new System.Drawing.Size(127, 23);
            this.lblToplamMusteriBaslik.TabIndex = 0;
            this.lblToplamMusteriBaslik.Text = "Toplam Müşteri";
            this.lblToplamMusteriBaslik.UseWaitCursor = true;
            this.lblToplamMusteriBaslik.Click += new System.EventHandler(this.lblAktifMusteriBaslik_Click);
            // 
            // pnlKartTopMusteri
            // 
            this.pnlKartTopMusteri.BackColor = System.Drawing.Color.Turquoise;
            this.pnlKartTopMusteri.Controls.Add(this.lblEnIyiMusteriDeger);
            this.pnlKartTopMusteri.Controls.Add(this.lblEnIyiMusteriBaslik);
            this.pnlKartTopMusteri.Location = new System.Drawing.Point(13, 9);
            this.pnlKartTopMusteri.Name = "pnlKartTopMusteri";
            this.pnlKartTopMusteri.Size = new System.Drawing.Size(260, 81);
            this.pnlKartTopMusteri.TabIndex = 1;
            this.pnlKartTopMusteri.UseWaitCursor = true;
            // 
            // lblEnIyiMusteriDeger
            // 
            this.lblEnIyiMusteriDeger.AutoSize = true;
            this.lblEnIyiMusteriDeger.ForeColor = System.Drawing.Color.White;
            this.lblEnIyiMusteriDeger.Location = new System.Drawing.Point(164, 38);
            this.lblEnIyiMusteriDeger.Name = "lblEnIyiMusteriDeger";
            this.lblEnIyiMusteriDeger.Size = new System.Drawing.Size(11, 16);
            this.lblEnIyiMusteriDeger.TabIndex = 1;
            this.lblEnIyiMusteriDeger.Text = "-";
            this.lblEnIyiMusteriDeger.UseWaitCursor = true;
            this.lblEnIyiMusteriDeger.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblEnIyiMusteriBaslik
            // 
            this.lblEnIyiMusteriBaslik.AutoSize = true;
            this.lblEnIyiMusteriBaslik.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnIyiMusteriBaslik.ForeColor = System.Drawing.Color.White;
            this.lblEnIyiMusteriBaslik.Location = new System.Drawing.Point(3, 31);
            this.lblEnIyiMusteriBaslik.Name = "lblEnIyiMusteriBaslik";
            this.lblEnIyiMusteriBaslik.Size = new System.Drawing.Size(113, 23);
            this.lblEnIyiMusteriBaslik.TabIndex = 0;
            this.lblEnIyiMusteriBaslik.Text = "En İyi Müşteri";
            this.lblEnIyiMusteriBaslik.UseWaitCursor = true;
            // 
            // pnlKartToplamCiro
            // 
            this.pnlKartToplamCiro.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlKartToplamCiro.Controls.Add(this.lblToplamCiroDeger);
            this.pnlKartToplamCiro.Controls.Add(this.lblToplamCiroBaslik);
            this.pnlKartToplamCiro.Location = new System.Drawing.Point(336, 10);
            this.pnlKartToplamCiro.Name = "pnlKartToplamCiro";
            this.pnlKartToplamCiro.Size = new System.Drawing.Size(263, 81);
            this.pnlKartToplamCiro.TabIndex = 1;
            this.pnlKartToplamCiro.UseWaitCursor = true;
            // 
            // lblToplamCiroDeger
            // 
            this.lblToplamCiroDeger.AutoSize = true;
            this.lblToplamCiroDeger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCiroDeger.ForeColor = System.Drawing.Color.White;
            this.lblToplamCiroDeger.Location = new System.Drawing.Point(117, 37);
            this.lblToplamCiroDeger.Name = "lblToplamCiroDeger";
            this.lblToplamCiroDeger.Size = new System.Drawing.Size(41, 23);
            this.lblToplamCiroDeger.TabIndex = 1;
            this.lblToplamCiroDeger.Text = "0 TL";
            this.lblToplamCiroDeger.UseWaitCursor = true;
            // 
            // lblToplamCiroBaslik
            // 
            this.lblToplamCiroBaslik.AutoSize = true;
            this.lblToplamCiroBaslik.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCiroBaslik.ForeColor = System.Drawing.Color.White;
            this.lblToplamCiroBaslik.Location = new System.Drawing.Point(10, 37);
            this.lblToplamCiroBaslik.Name = "lblToplamCiroBaslik";
            this.lblToplamCiroBaslik.Size = new System.Drawing.Size(101, 23);
            this.lblToplamCiroBaslik.TabIndex = 0;
            this.lblToplamCiroBaslik.Text = "Toplam Ciro";
            this.lblToplamCiroBaslik.UseWaitCursor = true;
            // 
            // pnlMusteriBody
            // 
            this.pnlMusteriBody.Controls.Add(this.scMusteri);
            this.pnlMusteriBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMusteriBody.Location = new System.Drawing.Point(0, 0);
            this.pnlMusteriBody.Name = "pnlMusteriBody";
            this.pnlMusteriBody.Size = new System.Drawing.Size(1280, 551);
            this.pnlMusteriBody.TabIndex = 1;
            this.pnlMusteriBody.UseWaitCursor = true;
            // 
            // scMusteri
            // 
            this.scMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMusteri.Location = new System.Drawing.Point(0, 0);
            this.scMusteri.Name = "scMusteri";
            // 
            // scMusteri.Panel1
            // 
            this.scMusteri.Panel1.Controls.Add(this.chartMusteri);
            this.scMusteri.Panel1.UseWaitCursor = true;
            this.scMusteri.Panel1MinSize = 500;
            // 
            // scMusteri.Panel2
            // 
            this.scMusteri.Panel2.Controls.Add(this.dgvMusteri);
            this.scMusteri.Panel2.UseWaitCursor = true;
            this.scMusteri.Panel2MinSize = 500;
            this.scMusteri.Size = new System.Drawing.Size(1280, 551);
            this.scMusteri.SplitterDistance = 647;
            this.scMusteri.TabIndex = 1;
            this.scMusteri.UseWaitCursor = true;
            // 
            // chartMusteri
            // 
            this.chartMusteri.Controls.Add(this.chartMusterii);
            this.chartMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMusteri.Location = new System.Drawing.Point(0, 0);
            this.chartMusteri.Name = "chartMusteri";
            this.chartMusteri.Size = new System.Drawing.Size(647, 551);
            this.chartMusteri.TabIndex = 1;
            this.chartMusteri.UseWaitCursor = true;
            // 
            // chartMusterii
            // 
            chartArea10.Name = "ChartArea1";
            this.chartMusterii.ChartAreas.Add(chartArea10);
            this.chartMusterii.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chartMusterii.Legends.Add(legend10);
            this.chartMusterii.Location = new System.Drawing.Point(0, 0);
            this.chartMusterii.Name = "chartMusterii";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartMusterii.Series.Add(series10);
            this.chartMusterii.Size = new System.Drawing.Size(647, 551);
            this.chartMusterii.TabIndex = 0;
            this.chartMusterii.Text = "chart1";
            this.chartMusterii.UseWaitCursor = true;
            // 
            // dgvMusteri
            // 
            this.dgvMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteri.Location = new System.Drawing.Point(0, 0);
            this.dgvMusteri.Name = "dgvMusteri";
            this.dgvMusteri.ReadOnly = true;
            this.dgvMusteri.RowHeadersWidth = 51;
            this.dgvMusteri.RowTemplate.Height = 24;
            this.dgvMusteri.Size = new System.Drawing.Size(629, 551);
            this.dgvMusteri.TabIndex = 1;
            this.dgvMusteri.UseWaitCursor = true;
            // 
            // pnlPageStokUretim
            // 
            this.pnlPageStokUretim.Controls.Add(this.scStok);
            this.pnlPageStokUretim.Controls.Add(this.tableLayoutPanel1);
            this.pnlPageStokUretim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPageStokUretim.Location = new System.Drawing.Point(0, 0);
            this.pnlPageStokUretim.Name = "pnlPageStokUretim";
            this.pnlPageStokUretim.Size = new System.Drawing.Size(1280, 551);
            this.pnlPageStokUretim.TabIndex = 4;
            this.pnlPageStokUretim.UseWaitCursor = true;
            this.pnlPageStokUretim.Visible = false;
            // 
            // scStok
            // 
            this.scStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scStok.Location = new System.Drawing.Point(0, 100);
            this.scStok.Name = "scStok";
            // 
            // scStok.Panel1
            // 
            this.scStok.Panel1.Controls.Add(this.pnlChartStok);
            this.scStok.Panel1.UseWaitCursor = true;
            this.scStok.Panel1MinSize = 500;
            // 
            // scStok.Panel2
            // 
            this.scStok.Panel2.Controls.Add(this.pnlTableStok);
            this.scStok.Panel2.UseWaitCursor = true;
            this.scStok.Panel2MinSize = 500;
            this.scStok.Size = new System.Drawing.Size(1280, 451);
            this.scStok.SplitterDistance = 650;
            this.scStok.TabIndex = 3;
            this.scStok.UseWaitCursor = true;
            // 
            // pnlChartStok
            // 
            this.pnlChartStok.Controls.Add(this.chartStok);
            this.pnlChartStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartStok.Location = new System.Drawing.Point(0, 0);
            this.pnlChartStok.Name = "pnlChartStok";
            this.pnlChartStok.Size = new System.Drawing.Size(650, 451);
            this.pnlChartStok.TabIndex = 0;
            this.pnlChartStok.UseWaitCursor = true;
            // 
            // chartStok
            // 
            chartArea11.Name = "ChartArea1";
            this.chartStok.ChartAreas.Add(chartArea11);
            this.chartStok.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Name = "Legend1";
            this.chartStok.Legends.Add(legend11);
            this.chartStok.Location = new System.Drawing.Point(0, 0);
            this.chartStok.Name = "chartStok";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartStok.Series.Add(series11);
            this.chartStok.Size = new System.Drawing.Size(650, 451);
            this.chartStok.TabIndex = 0;
            this.chartStok.Text = "chart1";
            this.chartStok.UseWaitCursor = true;
            // 
            // pnlTableStok
            // 
            this.pnlTableStok.Controls.Add(this.dgvStok);
            this.pnlTableStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableStok.Location = new System.Drawing.Point(0, 0);
            this.pnlTableStok.Name = "pnlTableStok";
            this.pnlTableStok.Size = new System.Drawing.Size(626, 451);
            this.pnlTableStok.TabIndex = 0;
            this.pnlTableStok.UseWaitCursor = true;
            // 
            // dgvStok
            // 
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStok.Location = new System.Drawing.Point(0, 0);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.RowHeadersWidth = 51;
            this.dgvStok.RowTemplate.Height = 24;
            this.dgvStok.Size = new System.Drawing.Size(626, 451);
            this.dgvStok.TabIndex = 0;
            this.dgvStok.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblToplamUrunDeger);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(402, 80);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // lblToplamUrunDeger
            // 
            this.lblToplamUrunDeger.AutoSize = true;
            this.lblToplamUrunDeger.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamUrunDeger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUrunDeger.ForeColor = System.Drawing.Color.White;
            this.lblToplamUrunDeger.Location = new System.Drawing.Point(151, 34);
            this.lblToplamUrunDeger.Name = "lblToplamUrunDeger";
            this.lblToplamUrunDeger.Size = new System.Drawing.Size(62, 23);
            this.lblToplamUrunDeger.TabIndex = 1;
            this.lblToplamUrunDeger.Text = "0 Ürün";
            this.lblToplamUrunDeger.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Toplam Ürün";
            this.label8.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblToplamStokDeger);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(432, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(402, 80);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // lblToplamStokDeger
            // 
            this.lblToplamStokDeger.AutoSize = true;
            this.lblToplamStokDeger.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamStokDeger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamStokDeger.ForeColor = System.Drawing.Color.White;
            this.lblToplamStokDeger.Location = new System.Drawing.Point(171, 34);
            this.lblToplamStokDeger.Name = "lblToplamStokDeger";
            this.lblToplamStokDeger.Size = new System.Drawing.Size(60, 23);
            this.lblToplamStokDeger.TabIndex = 1;
            this.lblToplamStokDeger.Text = "0 Adet";
            this.lblToplamStokDeger.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(35, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Toplam Stok";
            this.label10.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblKritikStokDeger);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(854, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(416, 80);
            this.panel3.TabIndex = 2;
            this.panel3.UseWaitCursor = true;
            // 
            // lblKritikStokDeger
            // 
            this.lblKritikStokDeger.AutoSize = true;
            this.lblKritikStokDeger.BackColor = System.Drawing.Color.Transparent;
            this.lblKritikStokDeger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKritikStokDeger.ForeColor = System.Drawing.Color.White;
            this.lblKritikStokDeger.Location = new System.Drawing.Point(133, 34);
            this.lblKritikStokDeger.Name = "lblKritikStokDeger";
            this.lblKritikStokDeger.Size = new System.Drawing.Size(62, 23);
            this.lblKritikStokDeger.TabIndex = 1;
            this.lblKritikStokDeger.Text = "0 Ürün";
            this.lblKritikStokDeger.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(38, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Kritik Stok";
            this.label12.UseWaitCursor = true;
            // 
            // pnlPageFinans
            // 
            this.pnlPageFinans.Controls.Add(this.scFinans);
            this.pnlPageFinans.Controls.Add(this.pnlFinansTop);
            this.pnlPageFinans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPageFinans.Location = new System.Drawing.Point(0, 0);
            this.pnlPageFinans.Name = "pnlPageFinans";
            this.pnlPageFinans.Size = new System.Drawing.Size(1280, 551);
            this.pnlPageFinans.TabIndex = 6;
            this.pnlPageFinans.UseWaitCursor = true;
            // 
            // scFinans
            // 
            this.scFinans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFinans.Location = new System.Drawing.Point(0, 100);
            this.scFinans.Name = "scFinans";
            // 
            // scFinans.Panel1
            // 
            this.scFinans.Panel1.Controls.Add(this.pnlChartFinans);
            this.scFinans.Panel1.UseWaitCursor = true;
            this.scFinans.Panel1MinSize = 400;
            // 
            // scFinans.Panel2
            // 
            this.scFinans.Panel2.Controls.Add(this.pnlTableFinans);
            this.scFinans.Panel2.UseWaitCursor = true;
            this.scFinans.Panel2MinSize = 400;
            this.scFinans.Size = new System.Drawing.Size(1280, 451);
            this.scFinans.SplitterDistance = 650;
            this.scFinans.TabIndex = 1;
            this.scFinans.UseWaitCursor = true;
            // 
            // pnlChartFinans
            // 
            this.pnlChartFinans.Controls.Add(this.chartFinans);
            this.pnlChartFinans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartFinans.Location = new System.Drawing.Point(0, 0);
            this.pnlChartFinans.Name = "pnlChartFinans";
            this.pnlChartFinans.Size = new System.Drawing.Size(650, 451);
            this.pnlChartFinans.TabIndex = 0;
            this.pnlChartFinans.UseWaitCursor = true;
            // 
            // chartFinans
            // 
            chartArea12.Name = "ChartArea1";
            this.chartFinans.ChartAreas.Add(chartArea12);
            this.chartFinans.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.Name = "Legend1";
            this.chartFinans.Legends.Add(legend12);
            this.chartFinans.Location = new System.Drawing.Point(0, 0);
            this.chartFinans.Name = "chartFinans";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartFinans.Series.Add(series12);
            this.chartFinans.Size = new System.Drawing.Size(650, 451);
            this.chartFinans.TabIndex = 0;
            this.chartFinans.Text = "chart1";
            this.chartFinans.UseWaitCursor = true;
            // 
            // pnlTableFinans
            // 
            this.pnlTableFinans.Controls.Add(this.dgvFinans);
            this.pnlTableFinans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableFinans.Location = new System.Drawing.Point(0, 0);
            this.pnlTableFinans.Name = "pnlTableFinans";
            this.pnlTableFinans.Size = new System.Drawing.Size(626, 451);
            this.pnlTableFinans.TabIndex = 0;
            this.pnlTableFinans.UseWaitCursor = true;
            // 
            // dgvFinans
            // 
            this.dgvFinans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinans.Location = new System.Drawing.Point(0, 0);
            this.dgvFinans.Name = "dgvFinans";
            this.dgvFinans.ReadOnly = true;
            this.dgvFinans.RowHeadersWidth = 51;
            this.dgvFinans.RowTemplate.Height = 24;
            this.dgvFinans.Size = new System.Drawing.Size(626, 451);
            this.dgvFinans.TabIndex = 0;
            this.dgvFinans.UseWaitCursor = true;
            // 
            // pnlFinansTop
            // 
            this.pnlFinansTop.Controls.Add(this.pnlKartKar);
            this.pnlFinansTop.Controls.Add(this.pnlKartGider);
            this.pnlFinansTop.Controls.Add(this.pnlKartGelir);
            this.pnlFinansTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFinansTop.Location = new System.Drawing.Point(0, 0);
            this.pnlFinansTop.Name = "pnlFinansTop";
            this.pnlFinansTop.Size = new System.Drawing.Size(1280, 100);
            this.pnlFinansTop.TabIndex = 0;
            this.pnlFinansTop.UseWaitCursor = true;
            // 
            // pnlKartKar
            // 
            this.pnlKartKar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlKartKar.Controls.Add(this.lblNetKarDeger);
            this.pnlKartKar.Controls.Add(this.lblNetKar);
            this.pnlKartKar.Location = new System.Drawing.Point(888, 16);
            this.pnlKartKar.Name = "pnlKartKar";
            this.pnlKartKar.Size = new System.Drawing.Size(256, 75);
            this.pnlKartKar.TabIndex = 2;
            this.pnlKartKar.UseWaitCursor = true;
            // 
            // lblNetKarDeger
            // 
            this.lblNetKarDeger.AutoSize = true;
            this.lblNetKarDeger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetKarDeger.ForeColor = System.Drawing.Color.White;
            this.lblNetKarDeger.Location = new System.Drawing.Point(153, 20);
            this.lblNetKarDeger.Name = "lblNetKarDeger";
            this.lblNetKarDeger.Size = new System.Drawing.Size(63, 23);
            this.lblNetKarDeger.TabIndex = 1;
            this.lblNetKarDeger.Text = "0,00 TL";
            this.lblNetKarDeger.UseWaitCursor = true;
            // 
            // lblNetKar
            // 
            this.lblNetKar.AutoSize = true;
            this.lblNetKar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetKar.ForeColor = System.Drawing.Color.White;
            this.lblNetKar.Location = new System.Drawing.Point(33, 20);
            this.lblNetKar.Name = "lblNetKar";
            this.lblNetKar.Size = new System.Drawing.Size(68, 23);
            this.lblNetKar.TabIndex = 0;
            this.lblNetKar.Text = "Net Kar";
            this.lblNetKar.UseWaitCursor = true;
            // 
            // pnlKartGider
            // 
            this.pnlKartGider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlKartGider.Controls.Add(this.lblToplamGiderDeger);
            this.pnlKartGider.Controls.Add(this.lblToplamGider);
            this.pnlKartGider.Location = new System.Drawing.Point(512, 13);
            this.pnlKartGider.Name = "pnlKartGider";
            this.pnlKartGider.Size = new System.Drawing.Size(256, 75);
            this.pnlKartGider.TabIndex = 1;
            this.pnlKartGider.UseWaitCursor = true;
            // 
            // lblToplamGiderDeger
            // 
            this.lblToplamGiderDeger.AutoSize = true;
            this.lblToplamGiderDeger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGiderDeger.ForeColor = System.Drawing.Color.White;
            this.lblToplamGiderDeger.Location = new System.Drawing.Point(153, 20);
            this.lblToplamGiderDeger.Name = "lblToplamGiderDeger";
            this.lblToplamGiderDeger.Size = new System.Drawing.Size(63, 23);
            this.lblToplamGiderDeger.TabIndex = 1;
            this.lblToplamGiderDeger.Text = "0,00 TL";
            this.lblToplamGiderDeger.UseWaitCursor = true;
            // 
            // lblToplamGider
            // 
            this.lblToplamGider.AutoSize = true;
            this.lblToplamGider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGider.ForeColor = System.Drawing.Color.White;
            this.lblToplamGider.Location = new System.Drawing.Point(33, 20);
            this.lblToplamGider.Name = "lblToplamGider";
            this.lblToplamGider.Size = new System.Drawing.Size(111, 23);
            this.lblToplamGider.TabIndex = 0;
            this.lblToplamGider.Text = "Toplam Gider";
            this.lblToplamGider.UseWaitCursor = true;
            // 
            // pnlKartGelir
            // 
            this.pnlKartGelir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlKartGelir.Controls.Add(this.lblToplamGelirDeger);
            this.pnlKartGelir.Controls.Add(this.lblToplamGelir);
            this.pnlKartGelir.Location = new System.Drawing.Point(39, 6);
            this.pnlKartGelir.Name = "pnlKartGelir";
            this.pnlKartGelir.Size = new System.Drawing.Size(256, 75);
            this.pnlKartGelir.TabIndex = 0;
            this.pnlKartGelir.UseWaitCursor = true;
            // 
            // lblToplamGelirDeger
            // 
            this.lblToplamGelirDeger.AutoSize = true;
            this.lblToplamGelirDeger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGelirDeger.ForeColor = System.Drawing.Color.White;
            this.lblToplamGelirDeger.Location = new System.Drawing.Point(153, 20);
            this.lblToplamGelirDeger.Name = "lblToplamGelirDeger";
            this.lblToplamGelirDeger.Size = new System.Drawing.Size(63, 23);
            this.lblToplamGelirDeger.TabIndex = 1;
            this.lblToplamGelirDeger.Text = "0,00 TL";
            this.lblToplamGelirDeger.UseWaitCursor = true;
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGelir.ForeColor = System.Drawing.Color.White;
            this.lblToplamGelir.Location = new System.Drawing.Point(33, 20);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(105, 23);
            this.lblToplamGelir.TabIndex = 0;
            this.lblToplamGelir.Text = "Toplam Gelir";
            this.lblToplamGelir.UseWaitCursor = true;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.Silver;
            this.pnlFilter.Controls.Add(this.btnFiltrele);
            this.pnlFilter.Controls.Add(this.dtBitis);
            this.pnlFilter.Controls.Add(this.dtBaslangıc);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.cmbKategori);
            this.pnlFilter.Controls.Add(this.cmbSube);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 100);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1280, 55);
            this.pnlFilter.TabIndex = 1;
            this.pnlFilter.UseWaitCursor = true;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.LightBlue;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrele.ForeColor = System.Drawing.Color.White;
            this.btnFiltrele.Location = new System.Drawing.Point(875, 12);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrele.TabIndex = 8;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.UseWaitCursor = true;
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(695, 13);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(147, 22);
            this.dtBitis.TabIndex = 7;
            this.dtBitis.UseWaitCursor = true;
            // 
            // dtBaslangıc
            // 
            this.dtBaslangıc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangıc.Location = new System.Drawing.Point(482, 13);
            this.dtBaslangıc.Name = "dtBaslangıc";
            this.dtBaslangıc.Size = new System.Drawing.Size(137, 22);
            this.dtBaslangıc.TabIndex = 6;
            this.dtBaslangıc.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(646, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bitiş";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(409, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlangıç";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori";
            this.label2.UseWaitCursor = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(282, 15);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.UseWaitCursor = true;
            // 
            // cmbSube
            // 
            this.cmbSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSube.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbSube.FormattingEnabled = true;
            this.cmbSube.Location = new System.Drawing.Point(92, 11);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.Size = new System.Drawing.Size(121, 24);
            this.cmbSube.TabIndex = 1;
            this.cmbSube.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube";
            this.label1.UseWaitCursor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DarkGray;
            this.pnlHeader.Controls.Add(this.lblBaslik);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 100);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.UseWaitCursor = true;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(421, 26);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(128, 31);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "RAPORLAR";
            this.lblBaslik.UseWaitCursor = true;
            // 
            // RaporlarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1480, 706);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaporlarForm";
            this.Text = "Finansal Raporlar";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlPageSatisCiro.ResumeLayout(false);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSatis)).EndInit();
            this.pnlChartHeader.ResumeLayout(false);
            this.pnlChartHeader.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).EndInit();
            this.pnlDvgHeader.ResumeLayout(false);
            this.pnlDvgHeader.PerformLayout();
            this.tblKpi.ResumeLayout(false);
            this.pnlKpiCiro.ResumeLayout(false);
            this.pnlKpiCiro.PerformLayout();
            this.pnlKpiSatis.ResumeLayout(false);
            this.pnlKpiSatis.PerformLayout();
            this.pnlKpiStok.ResumeLayout(false);
            this.pnlKpiStok.PerformLayout();
            this.pnlPageMusteri.ResumeLayout(false);
            this.pnlMusteriTop.ResumeLayout(false);
            this.pnlKartAktifMusteri.ResumeLayout(false);
            this.pnlKartAktifMusteri.PerformLayout();
            this.pnlKartTopMusteri.ResumeLayout(false);
            this.pnlKartTopMusteri.PerformLayout();
            this.pnlKartToplamCiro.ResumeLayout(false);
            this.pnlKartToplamCiro.PerformLayout();
            this.pnlMusteriBody.ResumeLayout(false);
            this.scMusteri.Panel1.ResumeLayout(false);
            this.scMusteri.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMusteri)).EndInit();
            this.scMusteri.ResumeLayout(false);
            this.chartMusteri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMusterii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).EndInit();
            this.pnlPageStokUretim.ResumeLayout(false);
            this.scStok.Panel1.ResumeLayout(false);
            this.scStok.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scStok)).EndInit();
            this.scStok.ResumeLayout(false);
            this.pnlChartStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStok)).EndInit();
            this.pnlTableStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlPageFinans.ResumeLayout(false);
            this.scFinans.Panel1.ResumeLayout(false);
            this.scFinans.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFinans)).EndInit();
            this.scFinans.ResumeLayout(false);
            this.pnlChartFinans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFinans)).EndInit();
            this.pnlTableFinans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinans)).EndInit();
            this.pnlFinansTop.ResumeLayout(false);
            this.pnlKartKar.ResumeLayout(false);
            this.pnlKartKar.PerformLayout();
            this.pnlKartGider.ResumeLayout(false);
            this.pnlKartGider.PerformLayout();
            this.pnlKartGelir.ResumeLayout(false);
            this.pnlKartGelir.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbSube;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangıc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlPageSatisCiro;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tblKpi;
        private System.Windows.Forms.Panel pnlKpiCiro;
        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Panel pnlKpiSatis;
        private System.Windows.Forms.Label lblSatisDeger;
        private System.Windows.Forms.Label lblstok;
        private System.Windows.Forms.Panel pnlKpiStok;
        private System.Windows.Forms.Label lblStokDeger;
        private System.Windows.Forms.Label lblKritikStokUretim;
        private System.Windows.Forms.Panel pnlPageMusteri;
        private System.Windows.Forms.Panel pnlPageStokUretim;
        private System.Windows.Forms.Panel pnlPageFinans;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToplamUrunDeger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblToplamStokDeger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblKritikStokDeger;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SplitContainer scMusteri;
        private System.Windows.Forms.Panel pnlMusteriTop;
        private System.Windows.Forms.Panel pnlMusteriBody;
        private System.Windows.Forms.Panel chartMusteri;
        private System.Windows.Forms.DataGridView dgvMusteri;
        private System.Windows.Forms.Panel pnlKartAktifMusteri;
        private System.Windows.Forms.Label lblToplamMusteriDeger;
        private System.Windows.Forms.Label lblToplamMusteriBaslik;
        private System.Windows.Forms.Panel pnlKartTopMusteri;
        private System.Windows.Forms.Label lblEnIyiMusteriDeger;
        private System.Windows.Forms.Label lblEnIyiMusteriBaslik;
        private System.Windows.Forms.Panel pnlKartToplamCiro;
        private System.Windows.Forms.Label lblToplamCiroDeger;
        private System.Windows.Forms.Label lblToplamCiroBaslik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMusterii;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatis;
        private System.Windows.Forms.Panel pnlChartHeader;
        private System.Windows.Forms.DataGridView dgvSatis;
        private System.Windows.Forms.Panel pnlDvgHeader;
        private System.Windows.Forms.SplitContainer scStok;
        private System.Windows.Forms.Panel pnlChartStok;
        private System.Windows.Forms.Panel pnlTableStok;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStok;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.Panel pnlFinansTop;
        private System.Windows.Forms.Panel pnlKartKar;
        private System.Windows.Forms.Label lblNetKarDeger;
        private System.Windows.Forms.Label lblNetKar;
        private System.Windows.Forms.Panel pnlKartGider;
        private System.Windows.Forms.Label lblToplamGiderDeger;
        private System.Windows.Forms.Label lblToplamGider;
        private System.Windows.Forms.Panel pnlKartGelir;
        private System.Windows.Forms.Label lblToplamGelirDeger;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.SplitContainer scFinans;
        private System.Windows.Forms.Panel pnlChartFinans;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFinans;
        private System.Windows.Forms.Panel pnlTableFinans;
        private System.Windows.Forms.DataGridView dgvFinans;
    }
}