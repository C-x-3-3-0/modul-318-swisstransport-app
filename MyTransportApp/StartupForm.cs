using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }
        //Funktionen von Button Verbindungen 
        private void btnVerbindungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form verbindungen = new FormVerbindungen();
            verbindungen.ShowDialog();

            this.Show();
        }
        //Funktionen von Button Abfahrtstafel
        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form abfahrtstafel = new FormAbfahtstafel();
            abfahrtstafel.ShowDialog();
            this.Show();
        }
        //Funktionen von Button Stationen in meiner Nähe
        private void btnStationen_Click(object sender, EventArgs e)
        {
            const string message = "Noch im Entwicklung, bald online zu Verfügung";
            var result = MessageBox.Show(message);
        }
    }
}
