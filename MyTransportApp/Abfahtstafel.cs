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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvConnectionList.Rows.Clear();
            var List = transport.GetStationBoard(cboStation.Text, cboStation.Text);
            foreach (StationBoard connection in List.Entries)
            {
                dgvConnectionList.Rows.Add(List.Station.Name, connection.To, connection.Stop.Departure);
            }
        }

        private void cboStation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cboStation.Items.Clear();
                string SearchStation = cboStation.Text;
                var StationList = transport.GetStations(SearchStation);
                List<string> list = new List<string>();

                foreach (var Station in StationList.StationList)
                {
                    list.Add(Station.Name);
                }

                foreach (var item in list)
                {
                    cboStation.Items.Add(item);
                }
                cboStation.DroppedDown = true;
                cboStation.SelectionStart = cboStation.Text.Length + 1;
            }
        }
    }
}
