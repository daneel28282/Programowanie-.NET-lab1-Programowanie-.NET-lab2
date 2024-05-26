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

namespace WF_lab2_zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcClick(object sender, EventArgs e)
        {
            try
            {
                double dzielna = double.Parse(textBoxDzielna.Text);
                double dzielnik = double.Parse(textBoxDzielnik.Text);

                if (dzielnik == 0)
                {
                    throw new DivideByZeroException("Nie można dzielić przez zero!");
                }

                double wynik = dzielna / dzielnik;
                textBoxWynik.Text = wynik.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wprowadzono nieprawidłowe dane! Wprować liczbę", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EventLog.WriteEntry("Application", "Wystąpił błąd: Wprowadzono nieprawidłowe dane! ", EventLogEntryType.Warning);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Dzielenie przez zero jest niedozwolone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EventLog.WriteEntry("Application", "Wystąpił błąd: Próba dzielenia Przez zero! ", EventLogEntryType.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił nieoczekiwany błąd: {ex.Message}", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EventLog.WriteEntry("Application", "Wystąpił nieoczekiwany błąd: " + ex.Message, EventLogEntryType.Error);
                Application.Restart(); // restart
            }
        }

    }
}
