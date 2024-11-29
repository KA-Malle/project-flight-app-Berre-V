using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FlightApp
{
    public partial class FormFlightApp : Form
    {
        public FormFlightApp()
        {
            InitializeComponent();
        }

        /*
         * Naam: Berre Verelst
         * Klas: 6 ADB
         */

        // Globale variabelen
        private List<string[]> _flightsList = new List<string[]>();
        private List<string[]> _filteredList = new List<string[]>();

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void auteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berre Verelst", "Auteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declaratie
            string volledigeLijn;
            string[] vlucht;
            string departure_id, departure, arrivel_id, arrivel_city, max_capacity, actual_capacity, date_of_flight, average_flight, type_of_flight;

            // Instellen van het dialoogvenster Openen
            OpenFileDialog dlgOpen = new OpenFileDialog();
            // Eigenschappen instellen
            dlgOpen.Title = "Openen";
            dlgOpen.FileName = "";
            dlgOpen.DefaultExt = ".txt";
            dlgOpen.InitialDirectory = Application.StartupPath;
            dlgOpen.Filter = "Tekstbestanden (.txt)|*.txt|Alle bestanden(*.*)|*.*";

            // Dialoogvenster tonen en de keuze opvangen
            DialogResult resultaat = dlgOpen.ShowDialog();

            // Kijken of de gebruiker "openen" (ok) geklikt heeft.
            if (resultaat == DialogResult.OK)
            {

                // We lezen het bestand in.
                using (StreamReader streamLees = new StreamReader(dlgOpen.FileName))
                {
                    // Zolang het bestand lijnen heeft en we de cursor (peek) kunnen plaatsen...
                    while (streamLees.Peek() != -1)
                    {
                        volledigeLijn = streamLees.ReadLine();
                        vlucht = volledigeLijn.Split(';');

                        // We voegen deze 1D array toe aan de List
                        _flightsList;

                    }// while
                } // using

                // Layout maken en Label vullen
                LayoutMaken(_productenList);
                UpdateLabel(_productenList.Count);

            } // if
        }
    }
}
