using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutbackMate3sLibrary.Models
{
    public class DevicePayload
    {
        public string Gateway_Type { get; set; }
        public double Mate3sVoltage { get; set; }
        public List<DevicePortData> DevicePortDataList { get; set; }
        public List<string> DistinctChartSeriesList { get; set; }
    }
    
    public class DevicePortData
    {
        public int Port { get; set; }
        public string Device { get; set; }
        public DateTime Timestamp { get; set; }
        public double Voltage { get; set; }
        public double OutputKillowatts { get; set; }
        public double InputKillowatts { get; set; }

        public object this[string propertyName]
        {
            get { return GetType().GetProperty(propertyName).GetValue(this, null); }
            set { GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

        public static DevicePortData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            DevicePortData devicePortData = new DevicePortData();
            devicePortData.Port = Convert.ToInt32(values[0]);
            devicePortData.Device = values[1];
            devicePortData.Timestamp = Convert.ToDateTime(values[2]);
            devicePortData.Voltage = Convert.ToDouble(values[3]);
            devicePortData.OutputKillowatts = Convert.ToDouble(values[4]);
            devicePortData.InputKillowatts = Convert.ToDouble(values[5]);
            return devicePortData;
        }
    }
}
