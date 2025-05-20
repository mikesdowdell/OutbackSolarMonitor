using OutbackMate3sLibrary.Models;
using OutbackMate3sLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OutbackSolarMonitor.Properties;
using System.Configuration;

namespace OutbackSolarMonitor
{
    public partial class Form1 : Form
    {
        private Timer updateTimer;
        private bool inSettings = false;
        private bool graphToday = true;
        private double systemCapacity = 0;
        List<PortInfo> dataBindings = new List<PortInfo>();
        DeviceSystemConfig deviceSystemConfig = new DeviceSystemConfig();


        public Form1()
        {
            InitializeComponent();

            // Initialize timer
            updateTimer = new Timer();
            Mate3sHostTextBox.Text = ConfigurationManager.AppSettings["Mate3sHost"];
            PollingFrequencyTextBox.Text = ConfigurationManager.AppSettings["PollingFrequencySeconds"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentTimeLabel.Text = DateTime.Now.ToString();
            GraphPeriodTextBox.Text = DateTime.Now.ToString("MM/dd/yyy"); ; // Default to 1 hour 
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
            _ = LoadInitialData();
        }

        private async Task LoadInitialData()
        {
            if (Mate3sHostTextBox.Text != "")
            {
                deviceSystemConfig = await OutbackMate3sService.GetConfigData(Mate3sHostTextBox.Text);

                PopulateMate3sConfigTab(deviceSystemConfig);

                systemCapacity = deviceSystemConfig.PVSizeWatts * .001;
                updateTimer.Interval = Int32.Parse(PollingFrequencyTextBox.Text) * 1000; // Convert seconds to milliseconds
                updateTimer.Tick += UpdateTimer_Tick;

                dataBindings = OutbackMate3sService.ReadDevicePortDataFile(DateTime.Now);
                dataGridView1.DataSource = dataBindings;
                dataGridView1.Refresh();
                await RefreshData();

            }
            else
            {
                MessageBox.Show("You must first enter the Host for your Mate3s in Settings");
                tabControl1.SelectTab(SettingsTab);
                inSettings = true;
            }
        }

        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Method to execute every 5 seconds
            // Example: Refresh system status
            CurrentTimeLabel.Text = DateTime.Now.ToString();
            await RefreshData();

        }
    

        private async Task RefreshData()
        {
            // Method to execute every 5 seconds
            // Refresh system status
            if (Mate3sHostTextBox.Text != "")
            {
                ConnectionStatusLabel.ForeColor = Color.Orange;
                ConnectionStatusLabel.Text = "Connecting...";
                DeviceStatus deviceStatus = await OutbackMate3sService.PollNewDeviceData(Mate3sHostTextBox.Text);

                if (deviceStatus.Gateway_Type != null)
                {
                    updateTimer.Start();
                    ConnectionStatusLabel.ForeColor = Color.Green;
                    ConnectionStatusLabel.Text = "Connected";

                    foreach (PortInfo portInfo in deviceStatus.ports)
                    {
                        portInfo.Gateway_Type = deviceStatus.Gateway_Type;
                        portInfo.Sys_Time = deviceStatus.Sys_Time;
                        portInfo.Sys_Batt_V = deviceStatus.Sys_Batt_V;
                        portInfo.Timestamp = OutbackMate3sService.SysTime2DateTime(portInfo.Sys_Time);
                        dataBindings.Add(portInfo);
                    }

                    dataGridView1.Refresh();
                    Application.DoEvents();

                    if (graphToday)
                    {
                        DrawChart(DateTime.Now);
                    }


                    SysBatteryVoltageLabel.Text = deviceStatus.Sys_Batt_V.ToString() + "V";
                    SysInputACVoltageLabel.Text = deviceStatus.ports[0].VAC1_in_L2.ToString() + "VAC";
                    SysInputACHzLabel.Text = deviceStatus.ports[0].Type.ToString();

                    SystemCapacityLabel.Text = String.Format("Capacity {0}kW", systemCapacity.ToString());

                    double buyingWattage = (deviceStatus.ports[0].Buy_I_L2 * deviceStatus.ports[0].VAC1_in_L2) * .001;
                    SysInputWattageLabel.Text = (Math.Round(buyingWattage, digits: 2)).ToString() + "kW";
                    SysInputWattageBigLabel.Text = (Math.Round(buyingWattage, digits: 2)).ToString() + "kW";

                    double generatingWattage = (deviceStatus.ports[0].Chg_I_L2 * deviceStatus.ports[0].VAC2_in_L2) * .001;
                    GenInputWattageLabel.Text = (Math.Round(generatingWattage, digits: 2)).ToString() + "kW";
                    GenInputWattageBigLabel.Text = (Math.Round(generatingWattage, digits: 2)).ToString() + "kW";


                    double loadWattage = (deviceStatus.ports[0].Inv_I_L2 * deviceStatus.ports[0].VAC_out_L2) * .001;
                    SysLoadWattageLabel.Text = (Math.Round(loadWattage, digits: 2)).ToString() + "kW";
                    SysLoadWattageBigLabel.Text = (Math.Round(loadWattage, digits: 2)).ToString() + "kW";

                    BatteryLoadWattageLabel.Text = Math.Round(loadWattage - buyingWattage, digits: 2).ToString() + "kW";

                    double solarWattage1 = ((deviceStatus.ports[1].Out_I ?? 0) * deviceStatus.ports[0].Batt_V) * .001;
                    double solarWattage2 = ((deviceStatus.ports[2].Out_I ?? 0) * deviceStatus.ports[0].Batt_V) * .001;
                    double solarWattageTotal = solarWattage1 + solarWattage2;
                    SolarProducingWattageLabel.Text = (Math.Round(solarWattageTotal, digits: 2)).ToString() + "kW";
                    SolarProducingWattageBigLabel.Text = (Math.Round(solarWattageTotal, digits: 2)).ToString() + "kW";
                    SolarProducingWattageBigLabel2.Text = (Math.Round(solarWattageTotal, digits: 2)).ToString();


                    DrawDoughnutChart((Math.Round(solarWattageTotal, digits: 2)));

                    if (buyingWattage > 0)
                    {
                        SystemStatusBigLabel.Text = "BUYING";
                        SystemStatusBigLabel.ForeColor = Color.Red;
                        SysInputWattageLabel.ForeColor = Color.Red;
                    }
                    else if (solarWattageTotal > loadWattage)
                    {
                        SystemStatusBigLabel.Text = "PRODUCING";
                        SystemStatusBigLabel.ForeColor = Color.ForestGreen;
                        SysInputWattageLabel.ForeColor = Color.Gray;
                    }
                    else if (solarWattageTotal < loadWattage)
                    {
                        SystemStatusBigLabel.Text = "CONSUMING";
                        SystemStatusBigLabel.ForeColor = Color.Gray;
                        SysInputWattageLabel.ForeColor = Color.Gray;
                    }
                    else
                    {
                        SystemStatusBigLabel.Text = "IDLE";
                        SystemStatusBigLabel.ForeColor = Color.Gray;
                        SysInputWattageLabel.ForeColor = Color.Gray;
                    }
                }
                else
                {
                    ConnectionStatusLabel.Text = "Can't Connect";
                    ConnectionStatusLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                updateTimer.Stop();
            }
        }


        private void DrawDoughnutChart(double wattage)
        {
            var _currDateTime = DateTime.Now;

            var objChart = chart2.ChartAreas[0];

            //Set Y Axis Properties
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = systemCapacity;
            //objChart.AxisX.Maximum= 1;


            chart2.Series.Clear();
            string device = "kW";
            chart2.Series.Add(device);
            chart2.Series[device].ChartArea = "ChartArea1";
            chart2.Series[device].ChartType = SeriesChartType.Doughnut;
            chart2.Series[device].Color = Color.Green;
            chart2.Series[device].BackSecondaryColor = Color.Gray;
            //adding data


            double maxWattage = 6;
            double remainingWattage = maxWattage - wattage;

            chart2.Series[device]["PieStartAngle"] = "270";
            chart2.Series[device].Points.AddXY(1, remainingWattage);
            chart2.Series[device].Points[0].Color = Color.Gray;
            chart2.Series[device].Points.AddXY(2, wattage);
            chart2.Series[device].Points[1].Color = Color.Green;
        }



        private void DrawChart(DateTime graphDate)
        {
            var _currDateTime = graphDate;

            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = DateTimeIntervalType.Hours;
            objChart.AxisX.LabelStyle.Format = "HH";

            objChart.AxisX.Interval = 1;
            objChart.AxisX.Minimum = new DateTime(_currDateTime.Year, _currDateTime.Month, _currDateTime.Day, 0, 0, 0).AddHours(-1).ToOADate();
            objChart.AxisX.Maximum = new DateTime(_currDateTime.Year, _currDateTime.Month, _currDateTime.Day, 23, 0, 0).ToOADate();

            //Set Y Axis Properties
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = systemCapacity;


            objChart.AxisY2.MajorGrid.Enabled = false;
            objChart.AxisY2.Enabled = AxisEnabled.True;
            objChart.AxisY2.IsStartedFromZero = objChart.AxisY.IsStartedFromZero;
            objChart.AxisY2.Minimum = 0;
            objChart.AxisY2.Maximum = 60;


            //objChart.AxisY.Interval = 50;

            chart1.Series.Clear();

            DevicePayload devicePayload = OutbackMate3sService.GetChartStatistics(graphDate);

            foreach (string thisDevice in devicePayload.DistinctChartSeriesList)
            {
                chart1.Series.Add(thisDevice);
            }
            chart1.Series.Add("Grid");
            chart1.Series.Add("Battery");


            foreach (DevicePortData thisDevice in devicePayload.DevicePortDataList)
            {
                string device = thisDevice.Device;

                //chart1.Series[thisDevice].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart1.Series[device].ChartArea = "ChartArea1";
                chart1.Series[device].ChartType = SeriesChartType.Column;
                chart1.Series[device].YAxisType = AxisType.Primary;
                chart1.Series[device].XValueType = ChartValueType.DateTime;
                chart1.Series[device].YValueType = ChartValueType.Int32;
                chart1.Series[device].ToolTip = device + " #VALY kW";
                chart1.Series[device].Points.AddXY(thisDevice.Timestamp, thisDevice.OutputKillowatts);
                if (device == "CC")
                {
                    chart1.Series[device].Color = Color.Green;
                }
                else
                {
                    chart1.Series["Grid"].ChartArea = "ChartArea1";
                    chart1.Series["Grid"].ChartType = SeriesChartType.Column;
                    chart1.Series["Grid"].YAxisType = AxisType.Primary;
                    chart1.Series["Grid"].XValueType = ChartValueType.DateTime;
                    chart1.Series["Grid"].YValueType = ChartValueType.Int32;
                    chart1.Series["Grid"].ToolTip = device + " #VALY kW";
                    chart1.Series["Grid"].Points.AddXY(thisDevice.Timestamp, thisDevice.InputKillowatts);
                    chart1.Series["Grid"].Color = Color.Red;
                }



            }

            foreach (DevicePortData thisDevice in devicePayload.DevicePortDataList)
            {
                string device = "Battery";

                //chart1.Series[thisDevice].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart1.Series[device].ChartArea = "ChartArea1";
                chart1.Series[device].ChartType = SeriesChartType.Line;
                chart1.Series[device].YAxisType = AxisType.Secondary;
                chart1.Series[device].YValuesPerPoint = 2;
                chart1.Series[device].XValueType = ChartValueType.DateTime;
                chart1.Series[device].YValueType = ChartValueType.Int32;
                chart1.Series[device].ToolTip = device + " #VALY V";
                chart1.Series[device].BorderWidth = 3;
                chart1.Series[device].Color = Color.Green;
                //adding data
                chart1.Series[device].Points.AddXY(thisDevice.Timestamp, thisDevice.Voltage);

            }


        }

        public void PopulateMate3sConfigTab(DeviceSystemConfig deviceSystemConfig)
        {
            Mate3sConfigRichTextBox.DeselectAll();

            //Header
            Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
            Mate3sConfigRichTextBox.AppendText(Environment.NewLine + deviceSystemConfig.SysTitle + ":");
            Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
            Mate3sConfigRichTextBox.AppendText("\t\t" + deviceSystemConfig.SysName);

            //PV Size Watts
            Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
            Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "PV Size Watts:");
            Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
            Mate3sConfigRichTextBox.AppendText("\t\t" + deviceSystemConfig.PVSizeWatts.ToString());

            //Battery AH Capacity
            Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
            Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "Battery AH Capacity:");
            Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
            Mate3sConfigRichTextBox.AppendText("\t\t" + deviceSystemConfig.BatteryAHCapacity.ToString());

            //Nominal Voltage
            Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
            Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "Nominal Voltage:");
            Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
            Mate3sConfigRichTextBox.AppendText("\t\t" + deviceSystemConfig.NominalVoltage.ToString());

            Mate3sConfigRichTextBox.AppendText(Environment.NewLine);
            Mate3sConfigRichTextBox.AppendText(Environment.NewLine);

            foreach (var port in deviceSystemConfig.Port)
            {
                //Device Type:
                Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
                Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "Port:");
                Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
                Mate3sConfigRichTextBox.AppendText("\t\t\t\t" + port.Num);
                if (port.Device.Model != null)
                {
                    //Charge Controller

                    //Device Type:
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
                    Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "Device Type:");
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
                    Mate3sConfigRichTextBox.AppendText("\t\t\t" + port.Device.Model.Type);

                    //Device Type:
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
                    Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "MPPT Mode:");
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
                    Mate3sConfigRichTextBox.AppendText("\t\t\t" + port.Device.Model.MPPT.Mode);


                }
                else
                {
                    // Inverter
                    
                    //Device Type:
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
                    Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "Device Type:");
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
                    Mate3sConfigRichTextBox.AppendText("\t\t\t" + port.Device.Type[0]);

                    //Device Stack Mode:
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
                    Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "Device Stack Mode:");
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
                    Mate3sConfigRichTextBox.AppendText("\t\t" + port.Device.Stack.Mode);

                    //Device Stack Mode:
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Bold);
                    Mate3sConfigRichTextBox.AppendText(Environment.NewLine + "Input Type:");
                    Mate3sConfigRichTextBox.SelectionFont = new Font(Mate3sConfigRichTextBox.SelectionFont, FontStyle.Regular);
                    Mate3sConfigRichTextBox.AppendText("\t\t\t" + port.Device.AC1Input.InputType);


                    Mate3sConfigRichTextBox.SelectionIndent = 0;
                }

                Mate3sConfigRichTextBox.AppendText(Environment.NewLine);
            }

            Mate3sConfigRichTextBox.AppendText(Environment.NewLine);

        }




        public void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (inSettings)
            {
                inSettings = false;

                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                config.AppSettings.Settings.Remove("Mate3sHost");
                config.AppSettings.Settings.Add("Mate3sHost", Mate3sHostTextBox.Text);

                config.AppSettings.Settings.Remove("PollingFrequencySeconds");
                config.AppSettings.Settings.Add("PollingFrequencySeconds", PollingFrequencyTextBox.Text);

                config.Save(ConfigurationSaveMode.Modified);


                _ = LoadInitialData();
            }
            else if (current.Text == "Settings")
            {
                inSettings = true;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            
            
            DateTime previousDate = DateTime.Parse(GraphPeriodTextBox.Text);
            GraphPeriodTextBox.Text = previousDate.AddDays(-1).ToString("MM/dd/yyyy");
            if (previousDate.AddDays(-1).ToString("MM/dd/yyyy") != DateTime.Now.ToString("MM/dd/yyyy"))
            {
                graphToday = false;
            }
            else
            {
                graphToday = true;
            }
            DrawChart(previousDate.AddDays(-1));
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            graphToday = false;
            DateTime nextDate = DateTime.Parse(GraphPeriodTextBox.Text);
            GraphPeriodTextBox.Text = nextDate.AddDays(+1).ToString("MM/dd/yyyy");
            if (nextDate.AddDays(+1).ToString("MM/dd/yyyy") != DateTime.Now.ToString("MM/dd/yyyy"))
            {
                graphToday = false;
            }
            else
            {
                graphToday = true;
            }
            DrawChart(nextDate.AddDays(+1));
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            graphToday = true;
            DateTime currentDate = DateTime.Now;
            GraphPeriodTextBox.Text = currentDate.ToString("MM/dd/yyyy");

            DrawChart(currentDate);
        }
    }
}
