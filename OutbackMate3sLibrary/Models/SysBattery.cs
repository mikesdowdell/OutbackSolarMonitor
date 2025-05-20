using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutbackMate3sLibrary.Models
{
    public class SysBatteryRoot
    {
        public SysBattery sys_battery { get; set; }
    }

    public class SysBattery
    {
        public double today_min_batt { get; set; }
        public int today_min_batt_time { get; set; }
        public double today_max_batt { get; set; }
        public int today_max_batt_time { get; set; }
        public double sys_min_batt { get; set; }
        public int sys_min_batt_time { get; set; }
        public double sys_max_batt { get; set; }
        public int sys_max_batt_time { get; set; }
    }
}
