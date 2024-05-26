using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab2_zad3
{
    public partial class Form1 : Form
    {

        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private PerformanceCounter diskCounter;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicjalizacja liczników
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            // Uruchomienie odświeżania danych co sekundę
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Odczytanie wartości liczników
            float cpuUsage = cpuCounter.NextValue();
            float availableRAM = ramCounter.NextValue();

            label_CPU.Text = cpuUsage + " %";
            label_RAM.Text = availableRAM + " MB";
 

            // Zapisanie zdarzenia do dziennika zdarzeń
            if (cpuUsage > 10)
            {
                ZapiszDoDziennikaZdarzen("Przekroczenie progu zużycia CPU: " + cpuUsage.ToString() + "%");
            }

            if (availableRAM < 18000)
            {
                ZapiszDoDziennikaZdarzen("Za mało dostępnej pamięci RAM: " + availableRAM.ToString() + " MB");
            }
        }

        private void ZapiszDoDziennikaZdarzen(string message)
        {
            //EventLog.WriteEntry("Application", message, EventLogEntryType.Warning);
            EventLog evtLog = new EventLog();
            evtLog.Source = "Application";
            evtLog.WriteEntry(message, EventLogEntryType.Warning,101,1);
        }

    }
}
