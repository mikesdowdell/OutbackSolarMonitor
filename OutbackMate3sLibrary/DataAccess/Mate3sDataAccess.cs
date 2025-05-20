using OutbackMate3sLibrary.Models;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace OutbackMate3sLibrary.DataAccess
{
    public class Mate3sDataAccess
    {
        public static async Task<DeviceStatus> GetDeviceStatusData(string host)
        {
            DeviceStatus devStatusData = new DeviceStatus();
            string statusUrl = $"http://{host}/Dev_status.cgi?&Port=0";
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync(statusUrl);
                    var devstatusRoot = JsonSerializer.Deserialize<DeviceStatusRoot>(response); // Corrected type usage
                    devStatusData = devstatusRoot?.devstatus; // Safely access the sys_battery property
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching device status: {ex.Message}");
            }
            return devStatusData;
        }


        public static async Task<DeviceSystemConfig> GetConfigData(string host)
        {
            DeviceSystemConfig deviceSystemConfig = new DeviceSystemConfig();
            string xmlConfigUrl = $"http://{host}/CONFIG.XML";
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync(xmlConfigUrl);


                    // using System.Xml.Serialization;
                    XmlSerializer serializer = new XmlSerializer(typeof(DeviceSystemConfig));
                    using (StringReader reader = new StringReader(response))
                    {
                        deviceSystemConfig = (DeviceSystemConfig)serializer.Deserialize(reader);
                     }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching device system config: {ex.Message}");    
            }
            return deviceSystemConfig;
        }



        public static async Task<SysBattery> GetBatteryData(string host)
        {
            SysBattery sysBatteryData = new SysBattery();
            string batteryUrl = $"http://{host}/Dev_batt.cgi";
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync(batteryUrl);
                    var sysBatteryRoot = JsonSerializer.Deserialize<SysBatteryRoot>(response); // Corrected type usage
                    sysBatteryData = sysBatteryRoot?.sys_battery; // Safely access the sys_battery property
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching battery data: {ex.Message}");
            }
            return sysBatteryData;
        }






    }
}
