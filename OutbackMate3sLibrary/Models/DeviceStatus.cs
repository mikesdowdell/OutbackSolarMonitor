using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutbackMate3sLibrary.Models
{
    // 

    public class DeviceStatusRoot
    {
        public DeviceStatus devstatus { get; set; }
    }

    public class DeviceStatus
    {
        public string Gateway_Type { get; set; }
        public int Sys_Time { get; set; }
        public double Sys_Batt_V { get; set; }
        public List<PortInfo> ports { get; set; } // Renamed property to avoid conflict
    }

    public class PortInfo // Renamed class to avoid conflict with property name
    {
        public string Gateway_Type { get; set; }
        public int Sys_Time { get; set; }
        public double Sys_Batt_V { get; set; }


        public int Port { get; set; }
        public string Dev { get; set; }
        public string Type { get; set; }
        public int Inv_I_L2 { get; set; }
        public int Chg_I_L2 { get; set; }
        public int Buy_I_L2 { get; set; }
        public int Sell_I_L2 { get; set; }
        public int VAC1_in_L2 { get; set; }
        public int VAC2_in_L2 { get; set; }
        public int VAC_out_L2 { get; set; }
        public string AC_Input { get; set; }
        public double Batt_V { get; set; }
        public string AC_mode { get; set; }
        public string INV_mode { get; set; }
        public List<string> Warn { get; set; }
        public List<string> Error { get; set; }
        public string AUX { get; set; }
        public double? Out_I { get; set; }
        public int? In_I { get; set; }
        public double? In_V { get; set; }
        public double? Out_kWh { get; set; }
        public int? Out_AH { get; set; }
        public string CC_mode { get; set; }
        public string Aux_mode { get; set; }

        public DateTime Timestamp { get; set; }

        public object this[string propertyName]
        {
            get { return GetType().GetProperty(propertyName).GetValue(this, null); }
            set { GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }


        public static PortInfo FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            PortInfo portInfo = new PortInfo();

            portInfo.Gateway_Type = values[0];
            portInfo.Sys_Time = Convert.ToInt32(values[1]);
            portInfo.Sys_Batt_V = Convert.ToDouble(values[2]);
            portInfo.Port = Convert.ToInt32(values[3]);
            portInfo.Dev = values[4];
            portInfo.Type = values[5];
            portInfo.Inv_I_L2 = Convert.ToInt32(values[6]);
            portInfo.Chg_I_L2 = Convert.ToInt32(values[7]);
            portInfo.Buy_I_L2 = Convert.ToInt32(values[8]);
            portInfo.Sell_I_L2 = Convert.ToInt32(values[9]);
            portInfo.VAC1_in_L2 = Convert.ToInt32(values[10]);
            portInfo.VAC2_in_L2 = Convert.ToInt32(values[11]);
            portInfo.VAC_out_L2 = Convert.ToInt32(values[12]);
            portInfo.AC_Input = values[13];
            portInfo.Batt_V = Convert.ToDouble(values[14]);
            portInfo.AC_mode = values[15];
            portInfo.INV_mode = values[16];
            portInfo.AUX = values[17];

            if (double.TryParse(values[18], out double outI))
                portInfo.Out_I = outI;
            else
                portInfo.Out_I = null;

            if (int.TryParse(values[19], out int inI))
                portInfo.In_I = inI;
            else
                portInfo.In_I = null;

            if (double.TryParse(values[20], out double inV))
                portInfo.In_V = inV;
            else
                portInfo.In_V = null;

            if (double.TryParse(values[21], out double outKWh))
                portInfo.Out_kWh = outKWh;
            else
                portInfo.Out_kWh = null;

            if (int.TryParse(values[22], out int outAH))
                portInfo.Out_AH = outAH;
            else
                portInfo.Out_AH = null;

            portInfo.CC_mode = values[23];
            portInfo.Aux_mode = values[24];
            portInfo.Timestamp = DateTime.Parse(values[25]);
            return portInfo;
        }
    }
}