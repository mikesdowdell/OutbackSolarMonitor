using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutbackMate3sLibrary.Models
{
    public class GraphSummary
    {
        public DateTime TimeStamp { get; set; }
        public string SolarProductionAverage { get; set; }
        public string InverterProductionAverage { get; set; }
        public string GeneratorProductionAverage { get; set; }
        public string GridConsumptionAverage { get; set; }
        public string VoltageAverage { get; set; }
    }
}
