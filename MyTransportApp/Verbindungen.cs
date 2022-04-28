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
            
            if (e.KeyData == Keys.Enter)
            {   
                cboStartstation.Items.Clear();
                string Startstation = cboStartstation.Text;
                var Stationlist = transport.GetStations(Startstation);
                List<string> list = new List<string>();
                foreach (var Station in Stationlist.StationList)
                {
                    list.Add(Station.Name);
                }

                foreach (var item in list)
                {
                    cboStartstation.Items.Add(item);
                }
                cboStartstation.DroppedDown = true; 
                cboStartstation.SelectionStart = cboStartstation.Text.Length + 1;


            }
            //else
            //{
            //    while (cboStartstation.Items.Count >= 1)
            //        cboStartstation.Items.RemoveAt(0);
            //}
        }

        private void cboEndstation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cboEndstation.Items.Clear ();
                string Endstation = cboEndstation.Text;
                var StationList = transport.GetStations(Endstation);
                List<string> list = new List<string>();

                foreach (var Station in StationList.StationList)
                {
                    list.Add(Station.Name);
                }

                foreach (var item in list)
                {
                    cboEndstation.Items.Add (item);
                }
                cboEndstation.DroppedDown= true;
                cboStartstation.SelectionStart = cboStartstation.Text.Length + 1;
            }
        }
    }
}
