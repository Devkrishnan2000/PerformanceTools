using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenHardwareMonitor.Hardware;

namespace Performance_Tools.Usercontrol
{
    /// <summary>
    /// Interaction logic for CPU.xaml
    /// This class is responsible for displaying the cpu and gpu temperature adn clock and system information
    /// </summary>
    public partial class CPU : UserControl
    {
        private  System.Timers.Timer _timer;
        public CPU()
        {
            InitializeComponent();
            
            getryzenadjinfo();
          
        }

      
        public async Task getryzenadjinfo()
        {
            _timer = new System.Timers.Timer(1500); // change this value to increase/decrease freq of clockspd and temp updation
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _timer.Enabled = true;
            Process process = new Process();
            var output = new List<string>();
            await Task.Run(() => {       
                process.StartInfo.FileName = @"ryzenadj.exe";
                process.StartInfo.Arguments = "--info";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();    // it executes ryzenadj.exe with argument --info which displays systeminfo in a tabular format

                while (process.StandardOutput.Peek() > -1)
                {
                    // whole output of ryzenadj is stored in list called output
                    output.Add(process.StandardOutput.ReadLine());  
                }
            });
           
           
            foreach (string val in output)
            {
                // from output we get lot of values but we need to filter out certain values what i did was
                // to check line by line if any of the following parameters where present eg CPU family and store the value directly
                // to label cpufam

                if (val.Contains("CPU Family"))
                {
                    cpufam.Content = val;
                }
                if (val.Contains("Version: v"))
                {
                    ver.Content = "RyzenAdj " + val;
                }
                //here the value STAPM LIMIT in the output was in this format like ' STAPM LIMIT   | 25.000 '
                //there were garbage characters and white spaces so i only needed 25.00 from that string
                //so i used substring to carefully set then numerical value 
                //dont worry the start index and ending index of the substring are same for other items since the output was in the form of table 
                
                if (val.Contains("STAPM LIMIT"))
                {
                    string valf = val.Substring(23, 11);
                    stapm.Content = "STAPM LIMIT : " + valf.Replace(" ", "");

                }
                if (val.Contains("THM LIMIT CORE"))
                {
                    string valf = val.Substring(23, 11);
                    temp.Content = "TEMP LIMIT : " + valf.Replace(" ", "");
                }

            }

        }

        //the code bellow here will execute every 1.5 seconds
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            try
            {
                // the  temeprature values are stored to object of hardwareinfo
                hardwareInfo hardwareInfo = GetSystemInfo();
                this.Dispatcher.BeginInvoke(new Action(() =>
                {                     
                    // since tempgaugeCPU, clockspdGPU are ui elements and cant be executed on another thread  
                    // using dispatcher only those ui elements are executed here
                    // DO NOT execute anything other than UI changes here

                      tempgaugeCPU.Value = hardwareInfo.CPUTemp; 
                     ClockspdCPU.Content = hardwareInfo.CPUClockspeed + " MHz";
                    tempgaugeGPU.Value = hardwareInfo.GPUTemp;
                    ClockspdGPU.Content = hardwareInfo.GPUClockspeed + " MHz";
                }));

            }
            catch(NullReferenceException)
            {

            }
             
        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }

            public void VisitHardware(IHardware hardware)
            {
                try
                {
                    hardware.Update();
                }
                catch(NullReferenceException)
                { }
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }

            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        // bellow funreturns an object of hardwareinfo which contains temperatures and clock speed of GPU and CPU
        static hardwareInfo GetSystemInfo( )
        {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            hardwareInfo info = new hardwareInfo();
            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            info.CPUTemp = (int)computer.Hardware[i].Sensors[j].Value;
                          
                        }
                        if(computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock)
                        {
                            info.CPUClockspeed = (int)computer.Hardware[i].Sensors[j].Value;
                        }
                          
                    }
                }
                if(computer.Hardware[i].HardwareType == HardwareType.GpuAti || computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            info.GPUTemp = (int)computer.Hardware[i].Sensors[j].Value;

                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock)
                        {
                            info.GPUClockspeed = (int)computer.Hardware[i].Sensors[j].Value;
                        }

                        //  Console.WriteLine(computer.Hardware[i].Sensors[j].Name + ":" + computer.Hardware[i].Sensors[j].Value.ToString() + "\r");
                    }
                }
            }
            computer.Close();
            return info;
        }

        // the object of the bellow class contains the CPU temperature cpu clockspeed and GPU temp;
        public class hardwareInfo
        {
            int clockspeedCPU;
            int tempCPU;
            int clockspeedGPU;
            int tempGPU;

            public int CPUTemp
            {
                get { return tempCPU; }
                set { tempCPU = value; }
            }

            public int CPUClockspeed
            {
                get { return clockspeedCPU;}
                set { clockspeedCPU = value; }
            }

            public int GPUTemp
            {
                get { return tempGPU; }
                set { tempGPU = value;}
            }

            public int GPUClockspeed
            {
                get { return clockspeedGPU; }
                set { clockspeedGPU = value;}
            }


        }


    }
}
