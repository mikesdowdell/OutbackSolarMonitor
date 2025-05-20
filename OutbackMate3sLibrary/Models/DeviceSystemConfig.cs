using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OutbackMate3sLibrary.Models
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(SystemConfig));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (SystemConfig)serializer.Deserialize(reader);
    // }


    [XmlRoot(ElementName = "System_Config")]
    public class DeviceSystemConfig
    {

        [XmlElement(ElementName = "Sys_Name")]
        public string SysName { get; set; }

        [XmlElement(ElementName = "Sys_Title")]
        public string SysTitle { get; set; }

        [XmlElement(ElementName = "Installed_By")]
        public object InstalledBy { get; set; }

        [XmlElement(ElementName = "Installer_Name")]
        public object InstallerName { get; set; }

        [XmlElement(ElementName = "Installer_Phone")]
        public object InstallerPhone { get; set; }

        [XmlElement(ElementName = "Installer_Notes")]
        public object InstallerNotes { get; set; }

        [XmlElement(ElementName = "Time_Stamp")]
        public string TimeStamp { get; set; }

        [XmlElement(ElementName = "System")]
        public System System { get; set; }

        [XmlElement(ElementName = "Nominal_Voltage")]
        public int NominalVoltage { get; set; }

        [XmlElement(ElementName = "PV_Size_Watts")]
        public int PVSizeWatts { get; set; }

        [XmlElement(ElementName = "Battery_AH_Capacity")]
        public int BatteryAHCapacity { get; set; }

        [XmlElement(ElementName = "Generator_KW")]
        public int GeneratorKW { get; set; }

        [XmlElement(ElementName = "Max_Inverter_Output_KW")]
        public int MaxInverterOutputKW { get; set; }

        [XmlElement(ElementName = "Max_Charger_Output_KW")]
        public int MaxChargerOutputKW { get; set; }

        [XmlElement(ElementName = "New_Remote")]
        public NewRemote NewRemote { get; set; }

        [XmlElement(ElementName = "Port")]
        public List<Port> Port { get; set; }
    }





    [XmlRoot(ElementName = "System")]
    public class System
    {

        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "Backlight")]
    public class Backlight
    {

        [XmlElement(ElementName = "Red")]
        public int Red { get; set; }

        [XmlElement(ElementName = "Blue")]
        public int Blue { get; set; }

        [XmlElement(ElementName = "Green")]
        public int Green { get; set; }

        [XmlElement(ElementName = "Brightness")]
        public int Brightness { get; set; }

        [XmlElement(ElementName = "Contrast")]
        public int Contrast { get; set; }

        [XmlElement(ElementName = "Mode")]
        public string Mode { get; set; }

        [XmlElement(ElementName = "Timeout")]
        public int Timeout { get; set; }
    }

    [XmlRoot(ElementName = "Display")]
    public class Display
    {

        [XmlElement(ElementName = "Backlight")]
        public Backlight Backlight { get; set; }

        [XmlElement(ElementName = "Contrast")]
        public int Contrast { get; set; }
    }

    [XmlRoot(ElementName = "Network")]
    public class Network
    {

        [XmlElement(ElementName = "DHCP")]
        public string DHCP { get; set; }

        [XmlElement(ElementName = "IP_address")]
        public string IPAddress { get; set; }

        [XmlElement(ElementName = "Netmask")]
        public string Netmask { get; set; }

        [XmlElement(ElementName = "Gateway")]
        public string Gateway { get; set; }

        [XmlElement(ElementName = "DNS_1")]
        public string DNS1 { get; set; }

        [XmlElement(ElementName = "DNS_2")]
        public string DNS2 { get; set; }

        [XmlElement(ElementName = "HTTP_Port")]
        public int HTTPPort { get; set; }

        [XmlElement(ElementName = "FTP_Port")]
        public int FTPPort { get; set; }

        [XmlElement(ElementName = "Telnet_Port")]
        public int TelnetPort { get; set; }

        [XmlElement(ElementName = "Data_Stream_IP")]
        public string DataStreamIP { get; set; }

        [XmlElement(ElementName = "Data_Stream_Port")]
        public int DataStreamPort { get; set; }
    }

    [XmlRoot(ElementName = "Network_Options")]
    public class NetworkOptions
    {

        [XmlElement(ElementName = "OPTICSre")]
        public string OPTICSre { get; set; }

        [XmlElement(ElementName = "OPTICS_Auto_Reboot_Interval")]
        public string OPTICSAutoRebootInterval { get; set; }

        [XmlElement(ElementName = "SunSpec")]
        public string SunSpec { get; set; }

        [XmlElement(ElementName = "SunSpec_Port")]
        public int SunSpecPort { get; set; }

        [XmlElement(ElementName = "Internet_Time")]
        public string InternetTime { get; set; }

        [XmlElement(ElementName = "Time_Zone")]
        public int TimeZone { get; set; }
    }

    [XmlRoot(ElementName = "Global_Charge_Controller_Output_Control")]
    public class GlobalChargeControllerOutputControl
    {

        [XmlElement(ElementName = "Max_Charge_Rate")]
        public int MaxChargeRate { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CC_Float_Coordination")]
    public class CCFloatCoordination
    {

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }
    }

    [XmlRoot(ElementName = "FNDC_Charge_Term_Control")]
    public class FNDCChargeTermControl
    {

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }
    }

    [XmlRoot(ElementName = "FNDC_Sell_Control")]
    public class FNDCSellControl
    {

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }
    }

    [XmlRoot(ElementName = "Multi_Phase_Coordination")]
    public class MultiPhaseCoordination
    {

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }
    }

    [XmlRoot(ElementName = "AC_Coupled_Control")]
    public class ACCoupledControl
    {

        [XmlElement(ElementName = "AUX_Output")]
        public int AUXOutput { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Two_Min_Voltage_Start")]
    public class TwoMinVoltageStart
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Two_Hour_Voltage_Start")]
    public class TwoHourVoltageStart
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Twenty_Four_Hour_Voltage_Start")]
    public class TwentyFourHourVoltageStart
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Weekday")]
    public class Weekday
    {

        [XmlElement(ElementName = "Start_Hour")]
        public int StartHour { get; set; }

        [XmlElement(ElementName = "Start_Min")]
        public int StartMin { get; set; }

        [XmlElement(ElementName = "Stop_Hour")]
        public int StopHour { get; set; }

        [XmlElement(ElementName = "Stop_Min")]
        public int StopMin { get; set; }

        [XmlElement(ElementName = "Use_Hour")]
        public int UseHour { get; set; }

        [XmlElement(ElementName = "Use_Min")]
        public int UseMin { get; set; }

        [XmlElement(ElementName = "Drop_Hour")]
        public int DropHour { get; set; }

        [XmlElement(ElementName = "Drop_Min")]
        public int DropMin { get; set; }
    }

    [XmlRoot(ElementName = "Weekend")]
    public class Weekend
    {

        [XmlElement(ElementName = "Start_Hour")]
        public int StartHour { get; set; }

        [XmlElement(ElementName = "Start_Min")]
        public int StartMin { get; set; }

        [XmlElement(ElementName = "Stop_Hour")]
        public int StopHour { get; set; }

        [XmlElement(ElementName = "Stop_Min")]
        public int StopMin { get; set; }

        [XmlElement(ElementName = "Use_Hour")]
        public int UseHour { get; set; }

        [XmlElement(ElementName = "Use_Min")]
        public int UseMin { get; set; }

        [XmlElement(ElementName = "Drop_Hour")]
        public int DropHour { get; set; }

        [XmlElement(ElementName = "Drop_Min")]
        public int DropMin { get; set; }
    }

    [XmlRoot(ElementName = "Quiet_Time")]
    public class QuietTime
    {

        [XmlElement(ElementName = "Weekday")]
        public Weekday Weekday { get; set; }

        [XmlElement(ElementName = "Weekend")]
        public Weekend Weekend { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Must_Run")]
    public class MustRun
    {

        [XmlElement(ElementName = "Weekday")]
        public Weekday Weekday { get; set; }

        [XmlElement(ElementName = "Weekend")]
        public Weekend Weekend { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Start")]
    public class Start
    {

        [XmlElement(ElementName = "Load_KW")]
        public int LoadKW { get; set; }

        [XmlElement(ElementName = "Delay")]
        public int Delay { get; set; }
    }

    [XmlRoot(ElementName = "Stop")]
    public class Stop
    {

        [XmlElement(ElementName = "Load_KW")]
        public int LoadKW { get; set; }

        [XmlElement(ElementName = "Delay")]
        public int Delay { get; set; }
    }

    [XmlRoot(ElementName = "Load_Start")]
    public class LoadStart
    {

        [XmlElement(ElementName = "Start")]
        public Start Start { get; set; }

        [XmlElement(ElementName = "Stop")]
        public Stop Stop { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SOC_Start")]
    public class SOCStart
    {

        [XmlElement(ElementName = "Start_Percentage")]
        public int StartPercentage { get; set; }

        [XmlElement(ElementName = "Stop_Percentage")]
        public int StopPercentage { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FNDC_Full_Charge")]
    public class FNDCFullCharge
    {

        [XmlElement(ElementName = "Interval")]
        public int Interval { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Generator_Exercise")]
    public class GeneratorExercise
    {

        [XmlElement(ElementName = "Start_Hour")]
        public int StartHour { get; set; }

        [XmlElement(ElementName = "Start_Min")]
        public int StartMin { get; set; }

        [XmlElement(ElementName = "Day")]
        public string Day { get; set; }

        [XmlElement(ElementName = "Period")]
        public int Period { get; set; }

        [XmlElement(ElementName = "Interval")]
        public int Interval { get; set; }

        [XmlElement(ElementName = "Sell_During_Exercise")]
        public string SellDuringExercise { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Advance_Generator_Start")]
    public class AdvanceGeneratorStart
    {

        [XmlElement(ElementName = "Port")]
        public int Port { get; set; }

        [XmlElement(ElementName = "Generator_Type")]
        public string GeneratorType { get; set; }

        [XmlElement(ElementName = "DC_Generator_Absorb_Time")]
        public int DCGeneratorAbsorbTime { get; set; }

        [XmlElement(ElementName = "DC_Generator_Absorb_Voltage")]
        public int DCGeneratorAbsorbVoltage { get; set; }

        [XmlElement(ElementName = "Fault_Time")]
        public int FaultTime { get; set; }

        [XmlElement(ElementName = "Cooldown_Time")]
        public int CooldownTime { get; set; }

        [XmlElement(ElementName = "Warmup_Time")]
        public int WarmupTime { get; set; }

        [XmlElement(ElementName = "AC_Input_Reconnect_Delay")]
        public int ACInputReconnectDelay { get; set; }

        [XmlElement(ElementName = "Two_Min_Voltage_Start")]
        public TwoMinVoltageStart TwoMinVoltageStart { get; set; }

        [XmlElement(ElementName = "Two_Hour_Voltage_Start")]
        public TwoHourVoltageStart TwoHourVoltageStart { get; set; }

        [XmlElement(ElementName = "Twenty_Four_Hour_Voltage_Start")]
        public TwentyFourHourVoltageStart TwentyFourHourVoltageStart { get; set; }

        [XmlElement(ElementName = "Quiet_Time")]
        public QuietTime QuietTime { get; set; }

        [XmlElement(ElementName = "Must_Run")]
        public MustRun MustRun { get; set; }

        [XmlElement(ElementName = "Load_Start")]
        public LoadStart LoadStart { get; set; }

        [XmlElement(ElementName = "SOC_Start")]
        public SOCStart SOCStart { get; set; }

        [XmlElement(ElementName = "FNDC_Full_Charge")]
        public FNDCFullCharge FNDCFullCharge { get; set; }

        [XmlElement(ElementName = "Generator_Exercise")]
        public GeneratorExercise GeneratorExercise { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Grid_Use")]
    public class GridUse
    {

        [XmlElement(ElementName = "Weekday")]
        public Weekday Weekday { get; set; }

        [XmlElement(ElementName = "Weekend")]
        public Weekend Weekend { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Grid_Use_P2")]
    public class GridUseP2
    {

        [XmlElement(ElementName = "Weekday")]
        public Weekday Weekday { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Grid_Use_P3")]
    public class GridUseP3
    {

        [XmlElement(ElementName = "Weekday")]
        public Weekday Weekday { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Low_Voltage_Connect")]
    public class LowVoltageConnect
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlElement(ElementName = "Delay")]
        public int Delay { get; set; }
    }

    [XmlRoot(ElementName = "High_Voltage_Disconnect")]
    public class HighVoltageDisconnect
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlElement(ElementName = "Delay")]
        public int Delay { get; set; }
    }

    [XmlRoot(ElementName = "High_Battery_Transfer")]
    public class HighBatteryTransfer
    {

        [XmlElement(ElementName = "Low_Voltage_Connect")]
        public LowVoltageConnect LowVoltageConnect { get; set; }

        [XmlElement(ElementName = "High_Voltage_Disconnect")]
        public HighVoltageDisconnect HighVoltageDisconnect { get; set; }

        [XmlElement(ElementName = "SOC_Connect_Percentage")]
        public int SOCConnectPercentage { get; set; }

        [XmlElement(ElementName = "SOC_Disconnect_Percentage")]
        public int SOCDisconnectPercentage { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Load_Grid_Transfer")]
    public class LoadGridTransfer
    {

        [XmlElement(ElementName = "Load_Threshold_KW")]
        public int LoadThresholdKW { get; set; }

        [XmlElement(ElementName = "Load_Connect_Delay")]
        public int LoadConnectDelay { get; set; }

        [XmlElement(ElementName = "Load_Disconnect_Delay")]
        public int LoadDisconnectDelay { get; set; }

        [XmlElement(ElementName = "Low_Battery_Connect")]
        public int LowBatteryConnect { get; set; }

        [XmlElement(ElementName = "High_Battery_Disconnect")]
        public int HighBatteryDisconnect { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Grid_Mode_Schedule_1")]
    public class GridModeSchedule1
    {

        [XmlElement(ElementName = "Enable_Hour")]
        public int EnableHour { get; set; }

        [XmlElement(ElementName = "Enable_Min")]
        public int EnableMin { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Grid_Mode_Schedule_2")]
    public class GridModeSchedule2
    {

        [XmlElement(ElementName = "Enable_Hour")]
        public int EnableHour { get; set; }

        [XmlElement(ElementName = "Enable_Min")]
        public int EnableMin { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Grid_Mode_Schedule_3")]
    public class GridModeSchedule3
    {

        [XmlElement(ElementName = "Enable_Hour")]
        public int EnableHour { get; set; }

        [XmlElement(ElementName = "Enable_Min")]
        public int EnableMin { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "New_Remote")]
    public class NewRemote
    {

        [XmlElement(ElementName = "Firmware")]
        public string Firmware { get; set; }

        [XmlElement(ElementName = "Display")]
        public Display Display { get; set; }

        [XmlElement(ElementName = "Button_Beep")]
        public string ButtonBeep { get; set; }

        [XmlElement(ElementName = "Wheel_Click")]
        public string WheelClick { get; set; }

        [XmlElement(ElementName = "Data_Stream_Mode")]
        public string DataStreamMode { get; set; }

        [XmlElement(ElementName = "Serial_Baud")]
        public int SerialBaud { get; set; }

        [XmlElement(ElementName = "SD_CARD_Log_Mode")]
        public string SDCARDLogMode { get; set; }

        [XmlElement(ElementName = "SD_CARD_Log_Interval")]
        public int SDCARDLogInterval { get; set; }

        [XmlElement(ElementName = "Internal_Data_Log_Interval")]
        public int InternalDataLogInterval { get; set; }

        [XmlElement(ElementName = "Network")]
        public Network Network { get; set; }

        [XmlElement(ElementName = "Network_Options")]
        public NetworkOptions NetworkOptions { get; set; }

        [XmlElement(ElementName = "Global_Charge_Controller_Output_Control")]
        public GlobalChargeControllerOutputControl GlobalChargeControllerOutputControl { get; set; }

        [XmlElement(ElementName = "CC_Float_Coordination")]
        public CCFloatCoordination CCFloatCoordination { get; set; }

        [XmlElement(ElementName = "FNDC_Charge_Term_Control")]
        public FNDCChargeTermControl FNDCChargeTermControl { get; set; }

        [XmlElement(ElementName = "FNDC_Sell_Control")]
        public FNDCSellControl FNDCSellControl { get; set; }

        [XmlElement(ElementName = "Multi_Phase_Coordination")]
        public MultiPhaseCoordination MultiPhaseCoordination { get; set; }

        [XmlElement(ElementName = "Low_SOC_Warning_Percentage")]
        public int LowSOCWarningPercentage { get; set; }

        [XmlElement(ElementName = "Low_SOC_Error_Percentage")]
        public int LowSOCErrorPercentage { get; set; }

        [XmlElement(ElementName = "AC_Coupled_Control")]
        public ACCoupledControl ACCoupledControl { get; set; }

        [XmlElement(ElementName = "Advance_Generator_Start")]
        public AdvanceGeneratorStart AdvanceGeneratorStart { get; set; }

        [XmlElement(ElementName = "Grid_Use")]
        public GridUse GridUse { get; set; }

        [XmlElement(ElementName = "Grid_Use_P2")]
        public GridUseP2 GridUseP2 { get; set; }

        [XmlElement(ElementName = "Grid_Use_P3")]
        public GridUseP3 GridUseP3 { get; set; }

        [XmlElement(ElementName = "High_Battery_Transfer")]
        public HighBatteryTransfer HighBatteryTransfer { get; set; }

        [XmlElement(ElementName = "Load_Grid_Transfer")]
        public LoadGridTransfer LoadGridTransfer { get; set; }

        [XmlElement(ElementName = "Grid_Mode_Schedule_1")]
        public GridModeSchedule1 GridModeSchedule1 { get; set; }

        [XmlElement(ElementName = "Grid_Mode_Schedule_2")]
        public GridModeSchedule2 GridModeSchedule2 { get; set; }

        [XmlElement(ElementName = "Grid_Mode_Schedule_3")]
        public GridModeSchedule3 GridModeSchedule3 { get; set; }
    }

    [XmlRoot(ElementName = "Search")]
    public class Search
    {

        [XmlElement(ElementName = "Pulse_Length")]
        public int PulseLength { get; set; }

        [XmlElement(ElementName = "Amps")]
        public int Amps { get; set; }

        [XmlElement(ElementName = "Spacing")]
        public int Spacing { get; set; }
    }

    [XmlRoot(ElementName = "Low_battery")]
    public class LowBattery
    {

        [XmlElement(ElementName = "Cut_Out_Voltage")]
        public int CutOutVoltage { get; set; }

        [XmlElement(ElementName = "Cut_In_Voltage")]
        public int CutInVoltage { get; set; }

        [XmlElement(ElementName = "Delay")]
        public int Delay { get; set; }
    }

    [XmlRoot(ElementName = "High_battery")]
    public class HighBattery
    {

        [XmlElement(ElementName = "Cut_Out_Voltage")]
        public int CutOutVoltage { get; set; }

        [XmlElement(ElementName = "Cut_In_Voltage")]
        public int CutInVoltage { get; set; }

        [XmlElement(ElementName = "Delay")]
        public int Delay { get; set; }
    }

    [XmlRoot(ElementName = "Inverter")]
    public class Inverter
    {

        [XmlElement(ElementName = "Search")]
        public Search Search { get; set; }

        [XmlElement(ElementName = "Low_battery")]
        public LowBattery LowBattery { get; set; }

        [XmlElement(ElementName = "High_battery")]
        public HighBattery HighBattery { get; set; }

        [XmlElement(ElementName = "AC_Output_Voltage")]
        public int ACOutputVoltage { get; set; }

        [XmlElement(ElementName = "AC_Coupled_Mode")]
        public string ACCoupledMode { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Absorb")]
    public class Absorb
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlElement(ElementName = "Time")]
        public int Time { get; set; }

        [XmlElement(ElementName = "End_Amps")]
        public int EndAmps { get; set; }
    }

    [XmlRoot(ElementName = "Float")]
    public class Float
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlElement(ElementName = "Time")]
        public int Time { get; set; }
    }

    [XmlRoot(ElementName = "EQ")]
    public class EQ
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlElement(ElementName = "Time")]
        public int Time { get; set; }

        [XmlElement(ElementName = "Auto_Interval")]
        public int AutoInterval { get; set; }
    }

    [XmlRoot(ElementName = "Re_Float")]
    public class ReFloat
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }
    }

    [XmlRoot(ElementName = "Re_Bulk")]
    public class ReBulk
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }
    }

    [XmlRoot(ElementName = "Charger")]
    public class Charger
    {

        [XmlElement(ElementName = "Absorb")]
        public Absorb Absorb { get; set; }

        [XmlElement(ElementName = "Float")]
        public Float Float { get; set; }

        [XmlElement(ElementName = "EQ")]
        public EQ EQ { get; set; }

        [XmlElement(ElementName = "Re_Float")]
        public ReFloat ReFloat { get; set; }

        [XmlElement(ElementName = "Re_Bulk")]
        public ReBulk ReBulk { get; set; }

        [XmlElement(ElementName = "AC_Charger_Input_Limit")]
        public int ACChargerInputLimit { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "Rebulk_Voltage")]
        public int RebulkVoltage { get; set; }

        [XmlElement(ElementName = "Float_Voltage")]
        public int FloatVoltage { get; set; }

        [XmlElement(ElementName = "Output_Limit")]
        public int OutputLimit { get; set; }
    }

    [XmlRoot(ElementName = "Grid_tie")]
    public class GridTie
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlElement(ElementName = "Window")]
        public string Window { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Mini_Grid")]
    public class MiniGrid
    {

        [XmlElement(ElementName = "LBX_Voltage")]
        public int LBXVoltage { get; set; }

        [XmlElement(ElementName = "LBX_Delay")]
        public int LBXDelay { get; set; }
    }

    [XmlRoot(ElementName = "Grid_Zero")]
    public class GridZero
    {

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlElement(ElementName = "Max_Amps")]
        public int MaxAmps { get; set; }
    }

    [XmlRoot(ElementName = "AC1_input")]
    public class AC1Input
    {

        [XmlElement(ElementName = "Input_type")]
        public string InputType { get; set; }

        [XmlElement(ElementName = "Input_size")]
        public int InputSize { get; set; }

        [XmlElement(ElementName = "Transfer_Delay")]
        public int TransferDelay { get; set; }

        [XmlElement(ElementName = "Maximum_Input_Voltage")]
        public int MaximumInputVoltage { get; set; }

        [XmlElement(ElementName = "Minimum_Input_Voltage")]
        public int MinimumInputVoltage { get; set; }

        [XmlElement(ElementName = "Connect_Delay")]
        public int ConnectDelay { get; set; }
    }

    [XmlRoot(ElementName = "AC2_input")]
    public class AC2Input
    {

        [XmlElement(ElementName = "Input_type")]
        public string InputType { get; set; }

        [XmlElement(ElementName = "Input_size")]
        public int InputSize { get; set; }

        [XmlElement(ElementName = "Transfer_Delay")]
        public int TransferDelay { get; set; }

        [XmlElement(ElementName = "Maximum_Input_Voltage")]
        public int MaximumInputVoltage { get; set; }

        [XmlElement(ElementName = "Minimum_Input_Voltage")]
        public int MinimumInputVoltage { get; set; }

        [XmlElement(ElementName = "Connect_Delay")]
        public int ConnectDelay { get; set; }
    }

    [XmlRoot(ElementName = "Stack")]
    public class Stack
    {

        [XmlElement(ElementName = "Master_Power_Save_Level")]
        public int MasterPowerSaveLevel { get; set; }

        [XmlElement(ElementName = "Slave_Power_Save_Level")]
        public int SlavePowerSaveLevel { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AUX_Output")]
    public class AUXOutput
    {

        [XmlElement(ElementName = "Operation_Mode")]
        public string OperationMode { get; set; }

        [XmlElement(ElementName = "On_Delay")]
        public int OnDelay { get; set; }

        [XmlElement(ElementName = "Off_Delay")]
        public int OffDelay { get; set; }

        [XmlElement(ElementName = "High_Setpoint_Voltage")]
        public int HighSetpointVoltage { get; set; }

        [XmlElement(ElementName = "Low_Setpoint_Voltage")]
        public int LowSetpointVoltage { get; set; }

        [XmlElement(ElementName = "High_Setpoint_AC_Amps")]
        public int HighSetpointACAmps { get; set; }

        [XmlElement(ElementName = "Low_Setpoint_AC_Amps")]
        public int LowSetpointACAmps { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "Polarity")]
        public string Polarity { get; set; }

        [XmlElement(ElementName = "AUX_Error_Low_Batt_Voltage")]
        public int AUXErrorLowBattVoltage { get; set; }

        [XmlElement(ElementName = "AUX_Low_Batt_Disconnect")]
        public AUXLowBattDisconnect AUXLowBattDisconnect { get; set; }

        [XmlElement(ElementName = "AUX_Vent_Fan_Voltage")]
        public int AUXVentFanVoltage { get; set; }

        [XmlElement(ElementName = "AUX_Diversion")]
        public AUXDiversion AUXDiversion { get; set; }

        [XmlElement(ElementName = "AUX_PV_Trigger")]
        public AUXPVTrigger AUXPVTrigger { get; set; }

        [XmlElement(ElementName = "AUX_Nite_Light")]
        public AUXNiteLight AUXNiteLight { get; set; }
    }

    [XmlRoot(ElementName = "Device")]
    public class Device
    {

        [XmlElement(ElementName = "Firmware")]
        public string Firmware { get; set; }

        [XmlElement(ElementName = "Voltage")]
        public int Voltage { get; set; }

        [XmlElement(ElementName = "Type")]
        public List<string> Type { get; set; }

        [XmlElement(ElementName = "Inverter")]
        public Inverter Inverter { get; set; }

        [XmlElement(ElementName = "Charger")]
        public Charger Charger { get; set; }

        [XmlElement(ElementName = "Grid_tie")]
        public GridTie GridTie { get; set; }

        [XmlElement(ElementName = "AC_Input_Select")]
        public string ACInputSelect { get; set; }

        [XmlElement(ElementName = "Mini_Grid")]
        public MiniGrid MiniGrid { get; set; }

        [XmlElement(ElementName = "Grid_Zero")]
        public GridZero GridZero { get; set; }

        [XmlElement(ElementName = "AC1_input")]
        public AC1Input AC1Input { get; set; }

        [XmlElement(ElementName = "AC2_input")]
        public AC2Input AC2Input { get; set; }

        [XmlElement(ElementName = "Stack")]
        public Stack Stack { get; set; }

        [XmlElement(ElementName = "AUX_Output")]
        public AUXOutput AUXOutput { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "Model")]
        public Model Model { get; set; }
    }

    [XmlRoot(ElementName = "Port")]
    public class Port
    {

        [XmlElement(ElementName = "Device")]
        public Device Device { get; set; }

        [XmlAttribute(AttributeName = "Num")]
        public int Num { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Wakeup")]
    public class Wakeup
    {

        [XmlElement(ElementName = "Interval")]
        public int Interval { get; set; }

        [XmlElement(ElementName = "VOC_Change")]
        public int VOCChange { get; set; }
    }

    [XmlRoot(ElementName = "MPPT")]
    public class MPPT
    {

        [XmlElement(ElementName = "Sweep_Mode")]
        public string SweepMode { get; set; }

        [XmlElement(ElementName = "Max_Sweep")]
        public int MaxSweep { get; set; }

        [XmlElement(ElementName = "Upick_Percentage")]
        public int UpickPercentage { get; set; }

        [XmlElement(ElementName = "Restart_Mode")]
        public int RestartMode { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Remote_Temp_Sensor_Comp")]
    public class RemoteTempSensorComp
    {

        [XmlElement(ElementName = "Maximum_RTS_Voltage")]
        public int MaximumRTSVoltage { get; set; }

        [XmlElement(ElementName = "Minimum_RTS_Voltage")]
        public int MinimumRTSVoltage { get; set; }

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AUX_Low_Batt_Disconnect")]
    public class AUXLowBattDisconnect
    {

        [XmlElement(ElementName = "Disconnect_Voltage")]
        public int DisconnectVoltage { get; set; }

        [XmlElement(ElementName = "Disconnect_Delay")]
        public int DisconnectDelay { get; set; }

        [XmlElement(ElementName = "Reconnect_Voltage")]
        public int ReconnectVoltage { get; set; }
    }

    [XmlRoot(ElementName = "AUX_Diversion")]
    public class AUXDiversion
    {

        [XmlElement(ElementName = "Hold_Time")]
        public int HoldTime { get; set; }

        [XmlElement(ElementName = "Delay")]
        public int Delay { get; set; }

        [XmlElement(ElementName = "Relative_Voltage")]
        public int RelativeVoltage { get; set; }

        [XmlElement(ElementName = "Hysteresis_Voltage")]
        public int HysteresisVoltage { get; set; }
    }

    [XmlRoot(ElementName = "AUX_PV_Trigger")]
    public class AUXPVTrigger
    {

        [XmlElement(ElementName = "Trigger_Voltage")]
        public int TriggerVoltage { get; set; }

        [XmlElement(ElementName = "Hold_Time")]
        public int HoldTime { get; set; }
    }

    [XmlRoot(ElementName = "AUX_Nite_Light")]
    public class AUXNiteLight
    {

        [XmlElement(ElementName = "Threshold_Voltage")]
        public int ThresholdVoltage { get; set; }

        [XmlElement(ElementName = "On_Hyst_Time")]
        public int OnHystTime { get; set; }

        [XmlElement(ElementName = "Off_Hyst_Time")]
        public int OffHystTime { get; set; }

        [XmlElement(ElementName = "On_Hours")]
        public int OnHours { get; set; }
    }

    [XmlRoot(ElementName = "Model")]
    public class Model
    {

        [XmlElement(ElementName = "Firmware")]
        public string Firmware { get; set; }

        [XmlElement(ElementName = "Charger")]
        public Charger Charger { get; set; }

        [XmlElement(ElementName = "Wakeup")]
        public Wakeup Wakeup { get; set; }

        [XmlElement(ElementName = "Snooze_Amps")]
        public int SnoozeAmps { get; set; }

        [XmlElement(ElementName = "MPPT")]
        public MPPT MPPT { get; set; }

        [XmlElement(ElementName = "GT_Mode")]
        public string GTMode { get; set; }

        [XmlElement(ElementName = "Remote_Temp_Sensor_Comp")]
        public RemoteTempSensorComp RemoteTempSensorComp { get; set; }

        [XmlElement(ElementName = "AUX_Output")]
        public AUXOutput AUXOutput { get; set; }

        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    


}
