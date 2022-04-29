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
    public partial class FormVerbindungen : Form
    {
        //Verbindung von ITransport
        ITransport transport = new Transport();
        public FormVerbindungen()
        {
            InitializeComponent();
        }
        //Funktion von button Reverse
        private void btnReverse_Click(object sender, EventArgs e)
        {
            string station1 = cboStartstation.Text;
            cboStartstation.Text = cboEndstation.Text;
            cboEndstation.Text = station1;
        }
        //Funktion von button Suchen 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvConnectionList.Rows.Clear();
            var List = transport.GetConnections(cboStartstation.Text, cboEndstation.Text, dtpVerbindungen.Value , dtptime.Value);
            foreach (Connection connection in List.ConnectionList)
            {
                
                dgvConnectionList.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure, connection.To.Arrival, connection.From.Platform, connection.To.Platform, connection.Duration);
            }
           
        }
        //Funktion von Vorschläge beim Texteingabe beim ersten Suchfeld
        private void cboStartstation_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                string startstation = cboStartstation.Text;
                cboStartstation.Items.Clear();
                cboStartstation.SelectionStart = cboStartstation.Text.Length + 1;
                var stations = transport.GetStations(startstation);
                foreach (Station station in stations.StationList)
                {
                    cboStartstation.Items.Add(station.Name);
                }

                if (cboStartstation.Text.Length >= 2)
                {
                    cboStartstation.DroppedDown = true;
                    cboStartstation.Text = startstation;
                    cboStartstation.SelectionStart = cboStartstation.Text.Length + 1;
                }               
            }

        }
        //Funktion von Vorschläge beim Texteingabe beim zweiten Suchfeld
        private void cboEndstation_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                string endstation = cboEndstation.Text;
                cboEndstation.Items.Clear();
                cboEndstation.SelectionStart = cboEndstation.Text.Length + 1;
                var stations = transport.GetStations(endstation);
                foreach (Station station in stations.StationList)
                {
                    cboEndstation.Items.Add(station.Name);
                }

                if (cboEndstation.Text.Length >= 2)
                {
                    cboEndstation.DroppedDown = true;
                    cboEndstation.Text = endstation;
                    cboEndstation.SelectionStart = cboEndstation.Text.Length + 1;
                }
            }
        }
    }
}
