using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_lab2_zad2
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            var stopwatch = new Stopwatch();
           
            stopwatch.Start();
            InitializeComponent();
            stopwatch.Stop();

            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            InitTime.Text = stopwatch.ElapsedMilliseconds.ToString()+"ms";
            if (stopwatch.ElapsedMilliseconds > 70)
            {
                EventLog.WriteEntry("Application", "Inicjalizacja komponetów trwała więcej niż 70ms i wyniosła: "+stopwatch.ElapsedMilliseconds+"ms", EventLogEntryType.Warning);

            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            lcd.Text = currentCalculation;
        }

        private void Btn_Equals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString().Replace("x", "*").ToString().Replace("÷", "/");

            try
            {
                lcd.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = lcd.Text;
            }
            catch (Exception ex)
            {
                lcd.Text = "0";
                currentCalculation = "";
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Reset the calculation and empty the textbox
            lcd.Text = "0";
            currentCalculation = "";
        }

        private void Btn_ClearEntry_Click(object sender, EventArgs e)
        {
            // If the calculation is not empty, remove the last number/operator entered
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }

            // Re-display the calculation onto the screen
            lcd.Text = currentCalculation;
        }


    }
}
