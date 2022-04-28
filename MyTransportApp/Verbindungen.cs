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
        ITransport transport = new Transport();
        public FormVerbindungen()
        {
            InitializeComponent();
        }

        private void FormVerbindungen_Load(object sender, EventArgs e)
        {
            tbxTime.Text = DateTime.Now.ToString("HH:mm");

        }
        private void btnReverse_Click(object sender, EventArgs e)
        {
            string Station1 = cboStartstation.Text;
            cboStartstation.Text = cboEndstation.Text;
            cboEndstation.Text = Station1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvConnectionList.Rows.Clear();
            var List = transport.GetConnections(cboStartstation.Text, cboEndstation.Text);
            foreach (Connection connection in List.ConnectionList)
            {
                
                dgvConnectionList.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure, connection.To.Arrival, connection.From.Platform, connection.To.Platform, connection.Duration);
            }
           
        }

        private void cboStartstation_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                string Startstation = cboStartstation.Text;
                cboStartstation.Items.Clear();
                cboStartstation.SelectionStart = cboStartstation.Text.Length + 1;
                var Stations = transport.GetStations(Startstation);
                foreach (Station station in Stations.StationList)
                {
                    cboStartstation.Items.Add(station.Name);
                }

                if (cboStartstation.Text.Length >= 2)
                {
                    cboStartstation.DroppedDown = true;
                    cboStartstation.Text = Startstation;
                    cboStartstation.SelectionStart = cboStartstation.Text.Length + 1;
                }               
            }

        }

        private void cboEndstation_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                string Endstation = cboEndstation.Text;
                cboEndstation.Items.Clear();
                cboEndstation.SelectionStart = cboEndstation.Text.Length + 1;
                var Stations = transport.GetStations(Endstation);
                foreach (Station station in Stations.StationList)
                {
                    cboEndstation.Items.Add(station.Name);
                }

                if (cboEndstation.Text.Length >= 2)
                {
                    cboEndstation.DroppedDown = true;
                    cboEndstation.Text = Endstation;
                    cboEndstation.SelectionStart = cboEndstation.Text.Length + 1;
                }
            }
        }
    }
}
