using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Developers : Form
    {
        public Developers()
        {
            InitializeComponent();
        }

        private async void Developers_Load(object sender, EventArgs e)
        {
            int Delay = 1000;               // Verzögerungswert definieren und initialisieren
            await Task.Delay(Delay);        // Verzögerung von Anzahl Millisekunden im Delay
            label_Theo.Visible = true;      // Label von Theo Schneide anzeigen
            await Task.Delay(Delay);        // Verzögerung von Anzahl Millisekunden im Delay
            label_Yanik.Visible = true;     // Label von Yanik Howald anzeigen
            await Task.Delay(Delay);        // Verzögerung von Anzahl Millisekunden im Delay
            label_Chester.Visible = true;   // Label von Chester Neuhaus anzeigen
            await Task.Delay(Delay);        // Verzögerung von Anzahl Millisekunden im Delay
            label_Aaron.Visible = true;     // Label von Aaron Seiffert anzeigen
            await Task.Delay(Delay);        // Verzögerung von Anzahl Millisekunden im Delay
            label_Thanks.Visible = true;    // Label mit Bedanken fürs Spielen anzeigen
            await Task.Delay(Delay);        // Verzögerung von Anzahl Millisekunden im Delay
            button_mainmenu.Visible = true; // Knopf zum Zurückkehren ins Hauptmenü anzeigen
        }

        private void button_mainmenu_Click(object sender, EventArgs e)
        {
            // Hauptmenü Fenster öffnen
            Mainmenu f = new Mainmenu();
            f.Show();
            // dieses Fenster schliessen
            this.Hide();
        }
    }
}
