using OutbackMate3sLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OutbackMate3sLibrary.BusinessLogic
{
    public class OutbackMate3sService
    {
        private static string _host;

        public OutbackMate3sService(string host)
        {
            _host = host;
        }



        /// <summary>
        /// Retrieves Host Device Status Data from the Outback Mate3s
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        private static async Task<DeviceStatus> GetDeviceStatusData(string host)
        {
            return await DataAccess.Mate3sDataAccess.GetDeviceStatusData(host); 
        }


        /// <summary>
        /// Gets latest device port data
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public static async Task<DeviceStatus> PollNewDeviceData(string host)
        {
            DeviceStatus deviceStatus = await GetDeviceStatusData(host);
            try
            {
                WriteDevicePortDataFile(deviceStatus);
            }
            catch
            {

            }
            
            return deviceStatus;
        }

        public static DevicePayload GetChartStatistics(DateTime graphDate)
        {
            DevicePayload devicePayload = new DevicePayload();
            List<DevicePortData> devicePortDataList = new List<DevicePortData>();
            List<PortInfo> portInfoList = ReadDevicePortDataFile(graphDate);

            if (portInfoList != null)
            {
                foreach (PortInfo portInfo in portInfoList)
                {
                    DevicePortData devicePortData = new DevicePortData();
                    devicePortData.Port = portInfo.Port;
                    devicePortData.Device = portInfo.Dev;
                    devicePortData.Timestamp = SysTime2DateTime(portInfo.Sys_Time);
                    devicePortData.Voltage = portInfo.Sys_Batt_V;

                    switch (portInfo.Dev)
                    {
                        case "FX":
                            devicePortData.OutputKillowatts = (portInfo.Inv_I_L2 * portInfo.VAC_out_L2) * .001;
                            devicePortData.InputKillowatts = (portInfo.Buy_I_L2 * portInfo.VAC1_in_L2) * .001;
                            break;
                        case "FXR":
                            devicePortData.OutputKillowatts = (portInfo.Inv_I_L2 * portInfo.VAC_out_L2) * .001;
                            devicePortData.InputKillowatts = (portInfo.Buy_I_L2 * portInfo.VAC1_in_L2) * .001;
                            break;
                        case "GS":
                            devicePortData.OutputKillowatts = (portInfo.Inv_I_L2 * portInfo.VAC_out_L2) * .001;
                            devicePortData.InputKillowatts = (portInfo.Buy_I_L2 * portInfo.VAC1_in_L2) * .001;
                            break;
                        case "GSS":
                            devicePortData.OutputKillowatts = (portInfo.Inv_I_L2 * portInfo.VAC_out_L2) * .001;
                            devicePortData.InputKillowatts = (portInfo.Buy_I_L2 * portInfo.VAC1_in_L2) * .001;
                            break;
                        case "CC":
                            devicePortData.OutputKillowatts = ((portInfo.Out_I ?? 0) * portInfo.Batt_V) * .001;
                            break;
                    }
                    devicePortDataList.Add(devicePortData);
                }

            }


            List<string> distinctChartSeriesList = new List<string>();
            IEnumerable<string> distinctPortData = devicePortDataList.Select(o => o.Device).Distinct();
            foreach (var thisDevice in distinctPortData)
            {
                distinctChartSeriesList.Add(thisDevice);
            }

            //distinctChartSeriesList.Add("Solar Total");
            //distinctChartSeriesList.Add("Load Total");

            //List<DevicePortData> dgList = dataGridView1.DataSource as List<DevicePortData>;

            var byPortDeviceResult = devicePortDataList.GroupBy(x => new { x.Port, x.Device, x.Timestamp.Hour })
                                 .Select(x => new
                                 {
                                     Port = x.Key.Port,
                                     Device = x.Key.Device,
                                     Timestamp = graphDate.Date.Add(new TimeSpan(x.Key.Hour, 0, 0)), //new DateTime(DateTime.Now(), x.Key.Hour),
                                     OutputKillowatts = x.Average(z => z.OutputKillowatts),
                                     InputKillowatts = x.Average(z => z.InputKillowatts),
                                     Voltage = x.Average(z => z.Voltage)
                                 });


            var summarizedResult = byPortDeviceResult.GroupBy(x => new { x.Device, x.Timestamp.Hour })
                                 .Select(x => new
                                 {
                                     Device = x.Key.Device,
                                     Timestamp = graphDate.Date.Add(new TimeSpan(x.Key.Hour, 0, 0)), //new DateTime(DateTime.Now(), x.Key.Hour),
                                     OutputKillowatts = x.Sum(z => z.OutputKillowatts),
                                     InputKillowatts = x.Sum(z => z.InputKillowatts),
                                     Voltage = x.Average(z => z.Voltage)
                                 });

            List<DevicePortData> summarizedDevicePortDataList = new List<DevicePortData>();
            foreach (var item in summarizedResult)
            {
                DevicePortData devicePortData = new DevicePortData
                {
                    Device = item.Device,
                    Timestamp = item.Timestamp,
                    OutputKillowatts = item.OutputKillowatts,
                    InputKillowatts = item.InputKillowatts,
                    Voltage = item.Voltage
                };
                summarizedDevicePortDataList.Add(devicePortData);
            }





            devicePayload.DistinctChartSeriesList = distinctChartSeriesList;
            devicePayload.DevicePortDataList = summarizedDevicePortDataList;

            return devicePayload;
        }





        /// <summary>
        /// Gets latest device port data
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public static async Task<DevicePayload> PollNewDeviceData2(string host)
        {
            DevicePayload devicePayload = new DevicePayload();
            List<DevicePortData> devicePortDataList = new List<DevicePortData>();
            DeviceStatus systemStatus = await GetDeviceStatusData(host);
            if (systemStatus.Gateway_Type != null)
            {
                foreach (PortInfo portInfo in systemStatus.ports)
                {
                    DevicePortData devicePortData = new DevicePortData();
                    devicePortData.Port = portInfo.Port;
                    devicePortData.Device = portInfo.Dev;
                    devicePortData.Timestamp = DateTime.Now;
                    devicePortData.Voltage = systemStatus.Sys_Batt_V;

                    switch (portInfo.Dev)
                    {
                        case "FXR":
                            devicePortData.OutputKillowatts = (portInfo.Inv_I_L2 * systemStatus.ports[0].VAC_out_L2) * .001;
                            devicePortData.InputKillowatts = (portInfo.Buy_I_L2 * systemStatus.ports[0].VAC2_in_L2) * .001;
                            break;
                        case "CC":
                            devicePortData.OutputKillowatts = ((portInfo.Out_I ?? 0) * systemStatus.ports[0].Batt_V) * .001;
                            break;
                    }
                    devicePortDataList.Add(devicePortData);
                }

            }
            devicePayload.Gateway_Type = systemStatus.Gateway_Type;
            devicePayload.Mate3sVoltage = systemStatus.Sys_Batt_V;
            devicePayload.DevicePortDataList = devicePortDataList;

            return devicePayload;
        }


        public static void WriteDevicePortDataFile(DeviceStatus deviceStatus)
        {
            var csv = new StringBuilder();
            if (deviceStatus.Gateway_Type != null)
            {
                foreach (PortInfo data in deviceStatus.ports)
                {
                    var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24}, {25}",
                        deviceStatus.Gateway_Type,
                        deviceStatus.Sys_Time,
                        deviceStatus.Sys_Batt_V,
                        data.Port,
                        data.Dev,
                        data.Type,
                        data.Inv_I_L2,
                        data.Chg_I_L2,
                        data.Buy_I_L2,
                        data.Sell_I_L2,
                        data.VAC1_in_L2,
                        data.VAC2_in_L2,
                        data.VAC_out_L2,
                        data.AC_Input,
                        data.Batt_V,
                        data.AC_mode,
                        data.INV_mode,
                        //public List<string> portInfo.Warn { get; set; }
                        //public List<string> portInfo.Error { get; set; }
                        data.AUX,
                        data.Out_I,
                        data.In_I,
                        data.In_V,
                        data.Out_kWh,
                        data.Out_AH,
                        data.CC_mode,
                        data.Aux_mode,
                        SysTime2DateTime(deviceStatus.Sys_Time)
                        );
                    csv.AppendLine(newLine);
                }
                DateTime dt = DateTime.Now;
                string filePath = string.Format("Data/{0}-{1}-{2}-DevicePortData.csv", dt.Year, dt.Month, dt.Day);
                System.IO.Directory.CreateDirectory("Data");
                File.AppendAllText(filePath, csv.ToString());
            }
        }


        public static List<PortInfo> ReadDevicePortDataFile(DateTime graphDate)
        {
            List<PortInfo> devicePortDataList = new List<PortInfo>();
            DateTime dt = graphDate;
            string filePath = string.Format("Data/{0}-{1}-{2}-DevicePortData.csv", dt.Year, dt.Month, dt.Day);
            try
            {
                devicePortDataList = File.ReadAllLines(filePath)
                                           .Skip(0)
                                           .Select(v => PortInfo.FromCsv(v))
                                           .ToList();
            }
            catch (Exception ex)
            {
                var foo = ex.Message;
            }

            return devicePortDataList;
        }


        public static DateTime SysTime2DateTime(int sysTime)
        {
            DateTime dt = new DateTime(1970, 1, 1).AddSeconds(sysTime);
            DateTime ut = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
            DateTime lt = ut.ToLocalTime();
            return lt;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public static async Task<SysBattery> GetBatteryData(string host)
        {
            return await DataAccess.Mate3sDataAccess.GetBatteryData(host);
        }

        //static string configUrl = $"http://{serverIp}/CONFIG.XML";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public static async Task<DeviceSystemConfig> GetConfigData(string host)
        {
            return await DataAccess.Mate3sDataAccess.GetConfigData(host);
        }
    }
}
