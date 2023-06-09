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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Spiel gegen AI öffnen
            _1vsAI f = new _1vsAI();
            f.Show();
            // dieses Fenster schliessen
            this.Hide();
        }

        private void button_1vs1_Click(object sender, EventArgs e)
        {   
            // Spiel Spieler gegen Spieler öffnen
            Form1 f = new Form1();
            f.Show();
            // dieses Fenster schliessen
            this.Hide();
        }

        private void button_CloseApplication_Click(object sender, EventArgs e)
        {
            // Programm beenden
            System.Environment.Exit(0);
        }

        private void button_Developers_Click(object sender, EventArgs e)
        {
            // Entwickeler Fenster öffnen
            Developers f = new Developers();
            f.Show();
            // dieses Fenster schliessen
            this.Hide();
        }
    }
}
