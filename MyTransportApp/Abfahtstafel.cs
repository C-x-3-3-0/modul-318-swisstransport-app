using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;

namespace MyTransportApp
{
    public partial class FormAbfahtstafel : Form
    {
        ITransport transport = new Transport();
        public FormAbfahtstafel()
        {
            InitializeComponent();
        }
        //Funktionen von button Suchen
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboStation.Text == "")
            {
                MessageBox.Show("Geben sie eine Station ein");
            }
            
            
            dgvConnectionList.Rows.Clear();
            var list = transport.GetStationBoard(cboStation.Text, cboStation.Text);
            foreach (StationBoard connection in list.Entries)
            {
                dgvConnectionList.Rows.Add(list.Station.Name, connection.To, connection.Stop.Departure);
            }
        }
        //Funktion von Vorschläge biem Eingabe 
        private void cboStation_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                string searchstation = cboStation.Text;
                cboStation.Items.Clear();
                cboStation.SelectionStart = cboStation.Text.Length + 1;
                var stations = transport.GetStations(searchstation);
                foreach (Station station in stations.StationList)
                {
                    cboStation.Items.Add(station.Name);
                }

                if (cboStation.Text.Length >= 2)
                {
                    cboStation.DroppedDown = true;
                    cboStation.Text = searchstation;
                    cboStation.SelectionStart = cboStation.Text.Length + 1;
                }
            }
        }
    }
}
