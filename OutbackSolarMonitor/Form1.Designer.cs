namespace OutbackSolarMonitor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DashboardTab = new System.Windows.Forms.TabPage();
            this.SolarProducingWattageBigLabel2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.SystemStatusBigLabel = new System.Windows.Forms.Label();
            this.GenInputWattageBigLabel = new System.Windows.Forms.Label();
            this.SysLoadWattageBigLabel = new System.Windows.Forms.Label();
            this.SysInputWattageBigLabel = new System.Windows.Forms.Label();
            this.SolarProducingWattageBigLabel = new System.Windows.Forms.Label();
            this.GenInputWattageLabel = new System.Windows.Forms.Label();
            this.SolarProducingWattageLabel = new System.Windows.Forms.Label();
            this.BatteryLoadWattageLabel = new System.Windows.Forms.Label();
            this.SysLoadWattageLabel = new System.Windows.Forms.Label();
            this.SysInputWattageLabel = new System.Windows.Forms.Label();
            this.SysInputACHzLabel = new System.Windows.Forms.Label();
            this.SysInputACVoltageLabel = new System.Windows.Forms.Label();
            this.SysBatteryVoltageLabel = new System.Windows.Forms.Label();
            this.DataTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_I_L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chg_I_L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy_I_L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell_I_L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAC1_in_L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAC2_in_L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAC_out_L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC_Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batt_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out_kWh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out_AH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aux_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.Mate3sHostTextBox = new System.Windows.Forms.TextBox();
            this.Mate3sHostLabel = new System.Windows.Forms.Label();
            this.SystemCapacityLabel = new System.Windows.Forms.Label();
            this.dashboardBox = new System.Windows.Forms.PictureBox();
            this.PollingFrequencyLabel = new System.Windows.Forms.Label();
            this.PollingFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.PollingFrequencySecondsLabel = new System.Windows.Forms.Label();
            this.Mate3sConfigTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Mate3sConfigRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GraphPeriodTextBox = new System.Windows.Forms.TextBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TodayButton = new System.Windows.Forms.Button();
            this.gatewayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysBattVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.DashboardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.DataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBox)).BeginInit();
            this.Mate3sConfigTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portInfoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DashboardTab);
            this.tabControl1.Controls.Add(this.Mate3sConfigTab);
            this.tabControl1.Controls.Add(this.DataTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 610);
            this.tabControl1.TabIndex = 15;
            // 
            // DashboardTab
            // 
            this.DashboardTab.Controls.Add(this.TodayButton);
            this.DashboardTab.Controls.Add(this.comboBox1);
            this.DashboardTab.Controls.Add(this.NextButton);
            this.DashboardTab.Controls.Add(this.PreviousButton);
            this.DashboardTab.Controls.Add(this.GraphPeriodTextBox);
            this.DashboardTab.Controls.Add(this.SystemCapacityLabel);
            this.DashboardTab.Controls.Add(this.SolarProducingWattageBigLabel2);
            this.DashboardTab.Controls.Add(this.chart2);
            this.DashboardTab.Controls.Add(this.CurrentTimeLabel);
            this.DashboardTab.Controls.Add(this.chart1);
            this.DashboardTab.Controls.Add(this.ConnectionStatusLabel);
            this.DashboardTab.Controls.Add(this.SystemStatusBigLabel);
            this.DashboardTab.Controls.Add(this.GenInputWattageBigLabel);
            this.DashboardTab.Controls.Add(this.SysLoadWattageBigLabel);
            this.DashboardTab.Controls.Add(this.SysInputWattageBigLabel);
            this.DashboardTab.Controls.Add(this.SolarProducingWattageBigLabel);
            this.DashboardTab.Controls.Add(this.GenInputWattageLabel);
            this.DashboardTab.Controls.Add(this.SolarProducingWattageLabel);
            this.DashboardTab.Controls.Add(this.BatteryLoadWattageLabel);
            this.DashboardTab.Controls.Add(this.SysLoadWattageLabel);
            this.DashboardTab.Controls.Add(this.SysInputWattageLabel);
            this.DashboardTab.Controls.Add(this.SysInputACHzLabel);
            this.DashboardTab.Controls.Add(this.SysInputACVoltageLabel);
            this.DashboardTab.Controls.Add(this.SysBatteryVoltageLabel);
            this.DashboardTab.Controls.Add(this.dashboardBox);
            this.DashboardTab.Location = new System.Drawing.Point(4, 25);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.DashboardTab.Size = new System.Drawing.Size(1016, 581);
            this.DashboardTab.TabIndex = 0;
            this.DashboardTab.Text = "Dashboard";
            this.DashboardTab.UseVisualStyleBackColor = true;
            // 
            // SolarProducingWattageBigLabel2
            // 
            this.SolarProducingWattageBigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.SolarProducingWattageBigLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolarProducingWattageBigLabel2.Location = new System.Drawing.Point(101, 126);
            this.SolarProducingWattageBigLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.SolarProducingWattageBigLabel2.Name = "SolarProducingWattageBigLabel2";
            this.SolarProducingWattageBigLabel2.Size = new System.Drawing.Size(61, 26);
            this.SolarProducingWattageBigLabel2.TabIndex = 34;
            this.SolarProducingWattageBigLabel2.Text = "0";
            this.SolarProducingWattageBigLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Location = new System.Drawing.Point(23, 49);
            this.chart2.Name = "chart2";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Transparent;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(216, 180);
            this.chart2.TabIndex = 33;
            this.chart2.Text = "chart2";
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(154, 16);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(72, 17);
            this.CurrentTimeLabel.TabIndex = 32;
            this.CurrentTimeLabel.Text = "00:00:00";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 299);
            this.chart1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1016, 296);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(448, 16);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(115, 17);
            this.ConnectionStatusLabel.TabIndex = 30;
            this.ConnectionStatusLabel.Text = "Not Connected";
            // 
            // SystemStatusBigLabel
            // 
            this.SystemStatusBigLabel.AutoSize = true;
            this.SystemStatusBigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemStatusBigLabel.Location = new System.Drawing.Point(255, 62);
            this.SystemStatusBigLabel.Name = "SystemStatusBigLabel";
            this.SystemStatusBigLabel.Size = new System.Drawing.Size(55, 44);
            this.SystemStatusBigLabel.TabIndex = 29;
            this.SystemStatusBigLabel.Text = "...";
            // 
            // GenInputWattageBigLabel
            // 
            this.GenInputWattageBigLabel.AutoSize = true;
            this.GenInputWattageBigLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenInputWattageBigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenInputWattageBigLabel.Location = new System.Drawing.Point(405, 209);
            this.GenInputWattageBigLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GenInputWattageBigLabel.Name = "GenInputWattageBigLabel";
            this.GenInputWattageBigLabel.Size = new System.Drawing.Size(71, 31);
            this.GenInputWattageBigLabel.TabIndex = 27;
            this.GenInputWattageBigLabel.Text = "0kW";
            // 
            // SysLoadWattageBigLabel
            // 
            this.SysLoadWattageBigLabel.AutoSize = true;
            this.SysLoadWattageBigLabel.BackColor = System.Drawing.Color.Transparent;
            this.SysLoadWattageBigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysLoadWattageBigLabel.Location = new System.Drawing.Point(405, 175);
            this.SysLoadWattageBigLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SysLoadWattageBigLabel.Name = "SysLoadWattageBigLabel";
            this.SysLoadWattageBigLabel.Size = new System.Drawing.Size(71, 31);
            this.SysLoadWattageBigLabel.TabIndex = 26;
            this.SysLoadWattageBigLabel.Text = "0kW";
            // 
            // SysInputWattageBigLabel
            // 
            this.SysInputWattageBigLabel.AutoSize = true;
            this.SysInputWattageBigLabel.BackColor = System.Drawing.Color.Transparent;
            this.SysInputWattageBigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysInputWattageBigLabel.ForeColor = System.Drawing.Color.Red;
            this.SysInputWattageBigLabel.Location = new System.Drawing.Point(405, 141);
            this.SysInputWattageBigLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SysInputWattageBigLabel.Name = "SysInputWattageBigLabel";
            this.SysInputWattageBigLabel.Size = new System.Drawing.Size(71, 31);
            this.SysInputWattageBigLabel.TabIndex = 25;
            this.SysInputWattageBigLabel.Text = "0kW";
            // 
            // SolarProducingWattageBigLabel
            // 
            this.SolarProducingWattageBigLabel.AutoSize = true;
            this.SolarProducingWattageBigLabel.BackColor = System.Drawing.Color.Transparent;
            this.SolarProducingWattageBigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolarProducingWattageBigLabel.Location = new System.Drawing.Point(405, 107);
            this.SolarProducingWattageBigLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SolarProducingWattageBigLabel.Name = "SolarProducingWattageBigLabel";
            this.SolarProducingWattageBigLabel.Size = new System.Drawing.Size(71, 31);
            this.SolarProducingWattageBigLabel.TabIndex = 24;
            this.SolarProducingWattageBigLabel.Text = "0kW";
            // 
            // GenInputWattageLabel
            // 
            this.GenInputWattageLabel.AutoSize = true;
            this.GenInputWattageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.GenInputWattageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenInputWattageLabel.Location = new System.Drawing.Point(874, 214);
            this.GenInputWattageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GenInputWattageLabel.Name = "GenInputWattageLabel";
            this.GenInputWattageLabel.Size = new System.Drawing.Size(34, 15);
            this.GenInputWattageLabel.TabIndex = 23;
            this.GenInputWattageLabel.Text = "0kW";
            // 
            // SolarProducingWattageLabel
            // 
            this.SolarProducingWattageLabel.AutoSize = true;
            this.SolarProducingWattageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SolarProducingWattageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolarProducingWattageLabel.Location = new System.Drawing.Point(689, 140);
            this.SolarProducingWattageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SolarProducingWattageLabel.Name = "SolarProducingWattageLabel";
            this.SolarProducingWattageLabel.Size = new System.Drawing.Size(34, 15);
            this.SolarProducingWattageLabel.TabIndex = 22;
            this.SolarProducingWattageLabel.Text = "0kW";
            // 
            // BatteryLoadWattageLabel
            // 
            this.BatteryLoadWattageLabel.AutoSize = true;
            this.BatteryLoadWattageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.BatteryLoadWattageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryLoadWattageLabel.Location = new System.Drawing.Point(783, 140);
            this.BatteryLoadWattageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BatteryLoadWattageLabel.Name = "BatteryLoadWattageLabel";
            this.BatteryLoadWattageLabel.Size = new System.Drawing.Size(34, 15);
            this.BatteryLoadWattageLabel.TabIndex = 21;
            this.BatteryLoadWattageLabel.Text = "0kW";
            // 
            // SysLoadWattageLabel
            // 
            this.SysLoadWattageLabel.AutoSize = true;
            this.SysLoadWattageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SysLoadWattageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysLoadWattageLabel.Location = new System.Drawing.Point(874, 107);
            this.SysLoadWattageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SysLoadWattageLabel.Name = "SysLoadWattageLabel";
            this.SysLoadWattageLabel.Size = new System.Drawing.Size(34, 15);
            this.SysLoadWattageLabel.TabIndex = 20;
            this.SysLoadWattageLabel.Text = "0kW";
            // 
            // SysInputWattageLabel
            // 
            this.SysInputWattageLabel.AutoSize = true;
            this.SysInputWattageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SysInputWattageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysInputWattageLabel.Location = new System.Drawing.Point(883, 166);
            this.SysInputWattageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SysInputWattageLabel.Name = "SysInputWattageLabel";
            this.SysInputWattageLabel.Size = new System.Drawing.Size(34, 15);
            this.SysInputWattageLabel.TabIndex = 19;
            this.SysInputWattageLabel.Text = "0kW";
            // 
            // SysInputACHzLabel
            // 
            this.SysInputACHzLabel.AutoSize = true;
            this.SysInputACHzLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SysInputACHzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysInputACHzLabel.Location = new System.Drawing.Point(950, 202);
            this.SysInputACHzLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SysInputACHzLabel.Name = "SysInputACHzLabel";
            this.SysInputACHzLabel.Size = new System.Drawing.Size(21, 15);
            this.SysInputACHzLabel.TabIndex = 18;
            this.SysInputACHzLabel.Text = "0v";
            // 
            // SysInputACVoltageLabel
            // 
            this.SysInputACVoltageLabel.AutoSize = true;
            this.SysInputACVoltageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SysInputACVoltageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysInputACVoltageLabel.Location = new System.Drawing.Point(940, 187);
            this.SysInputACVoltageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SysInputACVoltageLabel.Name = "SysInputACVoltageLabel";
            this.SysInputACVoltageLabel.Size = new System.Drawing.Size(21, 15);
            this.SysInputACVoltageLabel.TabIndex = 17;
            this.SysInputACVoltageLabel.Text = "0v";
            // 
            // SysBatteryVoltageLabel
            // 
            this.SysBatteryVoltageLabel.AutoSize = true;
            this.SysBatteryVoltageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SysBatteryVoltageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysBatteryVoltageLabel.Location = new System.Drawing.Point(750, 229);
            this.SysBatteryVoltageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SysBatteryVoltageLabel.Name = "SysBatteryVoltageLabel";
            this.SysBatteryVoltageLabel.Size = new System.Drawing.Size(21, 15);
            this.SysBatteryVoltageLabel.TabIndex = 16;
            this.SysBatteryVoltageLabel.Text = "0v";
            // 
            // DataTab
            // 
            this.DataTab.Controls.Add(this.dataGridView1);
            this.DataTab.Location = new System.Drawing.Point(4, 25);
            this.DataTab.Name = "DataTab";
            this.DataTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataTab.Size = new System.Drawing.Size(1016, 564);
            this.DataTab.TabIndex = 2;
            this.DataTab.Text = "Data";
            this.DataTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gatewayTypeDataGridViewTextBoxColumn,
            this.sysTimeDataGridViewTextBoxColumn,
            this.sysBattVDataGridViewTextBoxColumn,
            this.Port,
            this.Dev,
            this.Type,
            this.Inv_I_L2,
            this.Chg_I_L2,
            this.Buy_I_L2,
            this.Sell_I_L2,
            this.VAC1_in_L2,
            this.VAC2_in_L2,
            this.VAC_out_L2,
            this.AC_Input,
            this.Batt_V,
            this.AC_mode,
            this.INV_mode,
            this.AUX,
            this.Out_I,
            this.In_I,
            this.In_V,
            this.Out_kWh,
            this.Out_AH,
            this.CC_mode,
            this.Aux_mode,
            this.Timestamp});
            this.dataGridView1.DataSource = this.portInfoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // Port
            // 
            this.Port.DataPropertyName = "Port";
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 63;
            // 
            // Dev
            // 
            this.Dev.DataPropertyName = "Dev";
            this.Dev.HeaderText = "Dev";
            this.Dev.Name = "Dev";
            this.Dev.ReadOnly = true;
            this.Dev.Width = 61;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 69;
            // 
            // Inv_I_L2
            // 
            this.Inv_I_L2.DataPropertyName = "Inv_I_L2";
            this.Inv_I_L2.HeaderText = "Inv_I_L2";
            this.Inv_I_L2.Name = "Inv_I_L2";
            this.Inv_I_L2.ReadOnly = true;
            this.Inv_I_L2.Width = 94;
            // 
            // Chg_I_L2
            // 
            this.Chg_I_L2.DataPropertyName = "Chg_I_L2";
            this.Chg_I_L2.HeaderText = "Chg_I_L2";
            this.Chg_I_L2.Name = "Chg_I_L2";
            this.Chg_I_L2.ReadOnly = true;
            this.Chg_I_L2.Width = 101;
            // 
            // Buy_I_L2
            // 
            this.Buy_I_L2.DataPropertyName = "Buy_I_L2";
            this.Buy_I_L2.HeaderText = "Buy_I_L2";
            this.Buy_I_L2.Name = "Buy_I_L2";
            this.Buy_I_L2.ReadOnly = true;
            // 
            // Sell_I_L2
            // 
            this.Sell_I_L2.DataPropertyName = "Sell_I_L2";
            this.Sell_I_L2.HeaderText = "Sell_I_L2";
            this.Sell_I_L2.Name = "Sell_I_L2";
            this.Sell_I_L2.ReadOnly = true;
            // 
            // VAC1_in_L2
            // 
            this.VAC1_in_L2.DataPropertyName = "VAC1_in_L2";
            this.VAC1_in_L2.HeaderText = "VAC1_in_L2";
            this.VAC1_in_L2.Name = "VAC1_in_L2";
            this.VAC1_in_L2.ReadOnly = true;
            this.VAC1_in_L2.Width = 121;
            // 
            // VAC2_in_L2
            // 
            this.VAC2_in_L2.DataPropertyName = "VAC2_in_L2";
            this.VAC2_in_L2.HeaderText = "VAC2_in_L2";
            this.VAC2_in_L2.Name = "VAC2_in_L2";
            this.VAC2_in_L2.ReadOnly = true;
            this.VAC2_in_L2.Width = 121;
            // 
            // VAC_out_L2
            // 
            this.VAC_out_L2.DataPropertyName = "VAC_out_L2";
            this.VAC_out_L2.HeaderText = "VAC_out_L2";
            this.VAC_out_L2.Name = "VAC_out_L2";
            this.VAC_out_L2.ReadOnly = true;
            this.VAC_out_L2.Width = 122;
            // 
            // AC_Input
            // 
            this.AC_Input.DataPropertyName = "AC_Input";
            this.AC_Input.HeaderText = "AC_Input";
            this.AC_Input.Name = "AC_Input";
            this.AC_Input.ReadOnly = true;
            this.AC_Input.Width = 98;
            // 
            // Batt_V
            // 
            this.Batt_V.DataPropertyName = "Batt_V";
            this.Batt_V.HeaderText = "Batt_V";
            this.Batt_V.Name = "Batt_V";
            this.Batt_V.ReadOnly = true;
            this.Batt_V.Width = 81;
            // 
            // AC_mode
            // 
            this.AC_mode.DataPropertyName = "AC_mode";
            this.AC_mode.HeaderText = "AC_mode";
            this.AC_mode.Name = "AC_mode";
            this.AC_mode.ReadOnly = true;
            this.AC_mode.Width = 101;
            // 
            // INV_mode
            // 
            this.INV_mode.DataPropertyName = "INV_mode";
            this.INV_mode.HeaderText = "INV_mode";
            this.INV_mode.Name = "INV_mode";
            this.INV_mode.ReadOnly = true;
            this.INV_mode.Width = 106;
            // 
            // AUX
            // 
            this.AUX.DataPropertyName = "AUX";
            this.AUX.HeaderText = "AUX";
            this.AUX.Name = "AUX";
            this.AUX.ReadOnly = true;
            this.AUX.Width = 64;
            // 
            // Out_I
            // 
            this.Out_I.DataPropertyName = "Out_I";
            this.Out_I.HeaderText = "Out_I";
            this.Out_I.Name = "Out_I";
            this.Out_I.ReadOnly = true;
            this.Out_I.Width = 72;
            // 
            // In_I
            // 
            this.In_I.DataPropertyName = "In_I";
            this.In_I.HeaderText = "In_I";
            this.In_I.Name = "In_I";
            this.In_I.ReadOnly = true;
            this.In_I.Width = 59;
            // 
            // In_V
            // 
            this.In_V.DataPropertyName = "In_V";
            this.In_V.HeaderText = "In_V";
            this.In_V.Name = "In_V";
            this.In_V.ReadOnly = true;
            this.In_V.Width = 65;
            // 
            // Out_kWh
            // 
            this.Out_kWh.DataPropertyName = "Out_kWh";
            this.Out_kWh.HeaderText = "Out_kWh";
            this.Out_kWh.Name = "Out_kWh";
            this.Out_kWh.ReadOnly = true;
            this.Out_kWh.Width = 99;
            // 
            // Out_AH
            // 
            this.Out_AH.DataPropertyName = "Out_AH";
            this.Out_AH.HeaderText = "Out_AH";
            this.Out_AH.Name = "Out_AH";
            this.Out_AH.ReadOnly = true;
            this.Out_AH.Width = 89;
            // 
            // CC_mode
            // 
            this.CC_mode.DataPropertyName = "CC_mode";
            this.CC_mode.HeaderText = "CC_mode";
            this.CC_mode.Name = "CC_mode";
            this.CC_mode.ReadOnly = true;
            this.CC_mode.Width = 101;
            // 
            // Aux_mode
            // 
            this.Aux_mode.DataPropertyName = "Aux_mode";
            this.Aux_mode.HeaderText = "Aux_mode";
            this.Aux_mode.Name = "Aux_mode";
            this.Aux_mode.ReadOnly = true;
            this.Aux_mode.Width = 107;
            // 
            // Timestamp
            // 
            this.Timestamp.DataPropertyName = "Timestamp";
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            this.Timestamp.Width = 111;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.label1);
            this.SettingsTab.Controls.Add(this.PollingFrequencySecondsLabel);
            this.SettingsTab.Controls.Add(this.PollingFrequencyTextBox);
            this.SettingsTab.Controls.Add(this.PollingFrequencyLabel);
            this.SettingsTab.Controls.Add(this.Mate3sHostTextBox);
            this.SettingsTab.Controls.Add(this.Mate3sHostLabel);
            this.SettingsTab.Location = new System.Drawing.Point(4, 25);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(1016, 564);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // Mate3sHostTextBox
            // 
            this.Mate3sHostTextBox.Location = new System.Drawing.Point(181, 15);
            this.Mate3sHostTextBox.Name = "Mate3sHostTextBox";
            this.Mate3sHostTextBox.Size = new System.Drawing.Size(426, 23);
            this.Mate3sHostTextBox.TabIndex = 1;
            // 
            // Mate3sHostLabel
            // 
            this.Mate3sHostLabel.AutoSize = true;
            this.Mate3sHostLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Mate3sHostLabel.Location = new System.Drawing.Point(8, 18);
            this.Mate3sHostLabel.Name = "Mate3sHostLabel";
            this.Mate3sHostLabel.Size = new System.Drawing.Size(117, 17);
            this.Mate3sHostLabel.TabIndex = 0;
            this.Mate3sHostLabel.Text = "Mate3s Host/IP";
            // 
            // SystemCapacityLabel
            // 
            this.SystemCapacityLabel.AutoSize = true;
            this.SystemCapacityLabel.ForeColor = System.Drawing.Color.Gray;
            this.SystemCapacityLabel.Location = new System.Drawing.Point(36, 232);
            this.SystemCapacityLabel.Name = "SystemCapacityLabel";
            this.SystemCapacityLabel.Size = new System.Drawing.Size(70, 17);
            this.SystemCapacityLabel.TabIndex = 35;
            this.SystemCapacityLabel.Text = "Capacity";
            // 
            // dashboardBox
            // 
            this.dashboardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardBox.Image = global::OutbackSolarMonitor.Properties.Resources.dashboard;
            this.dashboardBox.Location = new System.Drawing.Point(0, 0);
            this.dashboardBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dashboardBox.Name = "dashboardBox";
            this.dashboardBox.Size = new System.Drawing.Size(1016, 266);
            this.dashboardBox.TabIndex = 15;
            this.dashboardBox.TabStop = false;
            // 
            // PollingFrequencyLabel
            // 
            this.PollingFrequencyLabel.AutoSize = true;
            this.PollingFrequencyLabel.ForeColor = System.Drawing.Color.Black;
            this.PollingFrequencyLabel.Location = new System.Drawing.Point(6, 48);
            this.PollingFrequencyLabel.Name = "PollingFrequencyLabel";
            this.PollingFrequencyLabel.Size = new System.Drawing.Size(138, 17);
            this.PollingFrequencyLabel.TabIndex = 2;
            this.PollingFrequencyLabel.Text = "Polling Frequency";
            // 
            // PollingFrequencyTextBox
            // 
            this.PollingFrequencyTextBox.Location = new System.Drawing.Point(181, 45);
            this.PollingFrequencyTextBox.Name = "PollingFrequencyTextBox";
            this.PollingFrequencyTextBox.Size = new System.Drawing.Size(39, 23);
            this.PollingFrequencyTextBox.TabIndex = 3;
            this.PollingFrequencyTextBox.Text = "15";
            // 
            // PollingFrequencySecondsLabel
            // 
            this.PollingFrequencySecondsLabel.AutoSize = true;
            this.PollingFrequencySecondsLabel.ForeColor = System.Drawing.Color.Black;
            this.PollingFrequencySecondsLabel.Location = new System.Drawing.Point(226, 48);
            this.PollingFrequencySecondsLabel.Name = "PollingFrequencySecondsLabel";
            this.PollingFrequencySecondsLabel.Size = new System.Drawing.Size(70, 17);
            this.PollingFrequencySecondsLabel.TabIndex = 4;
            this.PollingFrequencySecondsLabel.Text = "Seconds";
            // 
            // Mate3sConfigTab
            // 
            this.Mate3sConfigTab.Controls.Add(this.Mate3sConfigRichTextBox);
            this.Mate3sConfigTab.Location = new System.Drawing.Point(4, 25);
            this.Mate3sConfigTab.Name = "Mate3sConfigTab";
            this.Mate3sConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.Mate3sConfigTab.Size = new System.Drawing.Size(1016, 564);
            this.Mate3sConfigTab.TabIndex = 3;
            this.Mate3sConfigTab.Text = "Mate3s Config";
            this.Mate3sConfigTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(613, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ip, Hostname, or FQDN. (eg. 192.168.15.1:80)";
            // 
            // Mate3sConfigRichTextBox
            // 
            this.Mate3sConfigRichTextBox.Location = new System.Drawing.Point(7, 7);
            this.Mate3sConfigRichTextBox.Name = "Mate3sConfigRichTextBox";
            this.Mate3sConfigRichTextBox.Size = new System.Drawing.Size(1001, 551);
            this.Mate3sConfigRichTextBox.TabIndex = 0;
            this.Mate3sConfigRichTextBox.Text = "";
            // 
            // GraphPeriodTextBox
            // 
            this.GraphPeriodTextBox.Location = new System.Drawing.Point(209, 270);
            this.GraphPeriodTextBox.Name = "GraphPeriodTextBox";
            this.GraphPeriodTextBox.Size = new System.Drawing.Size(88, 23);
            this.GraphPeriodTextBox.TabIndex = 36;
            // 
            // PreviousButton
            // 
            this.PreviousButton.ForeColor = System.Drawing.Color.Black;
            this.PreviousButton.Location = new System.Drawing.Point(179, 270);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(24, 23);
            this.PreviousButton.TabIndex = 37;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.ForeColor = System.Drawing.Color.Black;
            this.NextButton.Location = new System.Drawing.Point(303, 270);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(24, 23);
            this.NextButton.TabIndex = 38;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.Text = "The Day Of";
            // 
            // TodayButton
            // 
            this.TodayButton.ForeColor = System.Drawing.Color.Black;
            this.TodayButton.Location = new System.Drawing.Point(333, 270);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(75, 23);
            this.TodayButton.TabIndex = 40;
            this.TodayButton.Text = "Today";
            this.TodayButton.UseVisualStyleBackColor = true;
            this.TodayButton.Click += new System.EventHandler(this.TodayButton_Click);
            // 
            // gatewayTypeDataGridViewTextBoxColumn
            // 
            this.gatewayTypeDataGridViewTextBoxColumn.DataPropertyName = "Gateway_Type";
            this.gatewayTypeDataGridViewTextBoxColumn.HeaderText = "Gateway_Type";
            this.gatewayTypeDataGridViewTextBoxColumn.Name = "gatewayTypeDataGridViewTextBoxColumn";
            this.gatewayTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gatewayTypeDataGridViewTextBoxColumn.Width = 140;
            // 
            // sysTimeDataGridViewTextBoxColumn
            // 
            this.sysTimeDataGridViewTextBoxColumn.DataPropertyName = "Sys_Time";
            this.sysTimeDataGridViewTextBoxColumn.HeaderText = "Sys_Time";
            this.sysTimeDataGridViewTextBoxColumn.Name = "sysTimeDataGridViewTextBoxColumn";
            this.sysTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sysTimeDataGridViewTextBoxColumn.Width = 103;
            // 
            // sysBattVDataGridViewTextBoxColumn
            // 
            this.sysBattVDataGridViewTextBoxColumn.DataPropertyName = "Sys_Batt_V";
            this.sysBattVDataGridViewTextBoxColumn.HeaderText = "Sys_Batt_V";
            this.sysBattVDataGridViewTextBoxColumn.Name = "sysBattVDataGridViewTextBoxColumn";
            this.sysBattVDataGridViewTextBoxColumn.ReadOnly = true;
            this.sysBattVDataGridViewTextBoxColumn.Width = 116;
            // 
            // portInfoBindingSource2
            // 
            this.portInfoBindingSource2.DataSource = typeof(OutbackMate3sLibrary.Models.PortInfo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 623);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Outback Solar Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.DashboardTab.ResumeLayout(false);
            this.DashboardTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.DataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBox)).EndInit();
            this.Mate3sConfigTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portInfoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DashboardTab;
        private System.Windows.Forms.Label SystemStatusBigLabel;
        private System.Windows.Forms.Label GenInputWattageBigLabel;
        private System.Windows.Forms.Label SysLoadWattageBigLabel;
        private System.Windows.Forms.Label SysInputWattageBigLabel;
        private System.Windows.Forms.Label SolarProducingWattageBigLabel;
        private System.Windows.Forms.Label GenInputWattageLabel;
        private System.Windows.Forms.Label SolarProducingWattageLabel;
        private System.Windows.Forms.Label BatteryLoadWattageLabel;
        private System.Windows.Forms.Label SysLoadWattageLabel;
        private System.Windows.Forms.Label SysInputWattageLabel;
        private System.Windows.Forms.Label SysInputACHzLabel;
        private System.Windows.Forms.Label SysInputACVoltageLabel;
        private System.Windows.Forms.Label SysBatteryVoltageLabel;
        private System.Windows.Forms.PictureBox dashboardBox;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Label Mate3sHostLabel;
        private System.Windows.Forms.TextBox Mate3sHostTextBox;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage DataTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatewayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysBattVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_I_L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chg_I_L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy_I_L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell_I_L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAC1_in_L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAC2_in_L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAC_out_L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC_Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batt_V;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out_I;
        private System.Windows.Forms.DataGridViewTextBoxColumn In_I;
        private System.Windows.Forms.DataGridViewTextBoxColumn In_V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out_kWh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out_AH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aux_mode;
        private System.Windows.Forms.BindingSource portInfoBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.Label SolarProducingWattageBigLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label SystemCapacityLabel;
        private System.Windows.Forms.Label PollingFrequencySecondsLabel;
        private System.Windows.Forms.TextBox PollingFrequencyTextBox;
        private System.Windows.Forms.Label PollingFrequencyLabel;
        private System.Windows.Forms.TabPage Mate3sConfigTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Mate3sConfigRichTextBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.TextBox GraphPeriodTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button TodayButton;
    }
}

