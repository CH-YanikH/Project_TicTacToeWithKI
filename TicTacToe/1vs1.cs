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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Zähler_Runde = 0;                // Rundenzähler initialisieren
        public int Zähler_Gewinne_O = 0;            // Zähler der Gewinne von O initialisieren
        public int Zähler_Gewinne_X = 0;            // Zähler der Gewinne von X initialisieren
        public string[] Spielfeld = new string[9];  // Array zum Wiederspiegelung des Spielfelds initialisieren



        public void Überprüfung() // nach jedem Spielzug wird überprüft, ob X oder O gewonnen hat
        {
            if (Spielfeld[0] == "X" && Spielfeld[1] == "X" && Spielfeld[2] == "X")
            {
                Zähler_Gewinne_X = Zähler_Gewinne_X + 1;                // Gewinnzähler von X um 1 erhöhen
                label_GewinneX.Text = Zähler_Gewinne_X.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[0] == "O" && Spielfeld[1] == "O" && Spielfeld[2] == "O")
            {
                Zähler_Gewinne_O = Zähler_Gewinne_O + 1;                // Gewinnzähler von O um 1 erhöhen
                label_GewinneO.Text = Zähler_Gewinne_O.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }

            else if (Spielfeld[3] == "X" && Spielfeld[4] == "X" && Spielfeld[5] == "X")
            {
                Zähler_Gewinne_X = Zähler_Gewinne_X + 1;                // Gewinnzähler von X um 1 erhöhen
                label_GewinneX.Text = Zähler_Gewinne_X.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[3] == "O" && Spielfeld[4] == "O" && Spielfeld[5] == "O")
            {
                Zähler_Gewinne_O = Zähler_Gewinne_O + 1;                // Gewinnzähler von O um 1 erhöhen
                label_GewinneO.Text = Zähler_Gewinne_O.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }

            else if (Spielfeld[6] == "X" && Spielfeld[7] == "X" && Spielfeld[8] == "X")
            {
                Zähler_Gewinne_X = Zähler_Gewinne_X + 1;                // Gewinnzähler von X um 1 erhöhen
                label_GewinneX.Text = Zähler_Gewinne_X.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[6] == "O" && Spielfeld[7] == "O" && Spielfeld[8] == "O")
            {
                Zähler_Gewinne_O = Zähler_Gewinne_O + 1;                // Gewinnzähler von O um 1 erhöhen
                label_GewinneO.Text = Zähler_Gewinne_O.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }

            else if (Spielfeld[0] == "X" && Spielfeld[3] == "X" && Spielfeld[6] == "X")
            {
                Zähler_Gewinne_X = Zähler_Gewinne_X + 1;                // Gewinnzähler von X um 1 erhöhen
                label_GewinneX.Text = Zähler_Gewinne_X.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[0] == "O" && Spielfeld[3] == "O" && Spielfeld[6] == "O")
            {
                Zähler_Gewinne_O = Zähler_Gewinne_O + 1;                // Gewinnzähler von O um 1 erhöhen
                label_GewinneO.Text = Zähler_Gewinne_O.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }

            else if (Spielfeld[1] == "X" && Spielfeld[4] == "X" && Spielfeld[7] == "X")
            {
                Zähler_Gewinne_X = Zähler_Gewinne_X + 1;                // Gewinnzähler von X um 1 erhöhen
                label_GewinneX.Text = Zähler_Gewinne_X.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[1] == "O" && Spielfeld[4] == "O" && Spielfeld[7] == "O")
            {
                Zähler_Gewinne_O = Zähler_Gewinne_O + 1;                // Gewinnzähler von O um 1 erhöhen
                label_GewinneO.Text = Zähler_Gewinne_O.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }

            else if (Spielfeld[2] == "X" && Spielfeld[5] == "X" && Spielfeld[8] == "X")
            {
                Zähler_Gewinne_X = Zähler_Gewinne_X + 1;                // Gewinnzähler von X um 1 erhöhen
                label_GewinneX.Text = Zähler_Gewinne_X.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[2] == "O" && Spielfeld[5] == "O" && Spielfeld[8] == "O")
            {
                Zähler_Gewinne_O = Zähler_Gewinne_O + 1;                // Gewinnzähler von O um 1 erhöhen
                label_GewinneO.Text = Zähler_Gewinne_O.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }

            else if (Spielfeld[0] == "X" && Spielfeld[4] == "X" && Spielfeld[8] == "X")
            {
                Zähler_Gewinne_X = Zähler_Gewinne_X + 1;                // Gewinnzähler von X um 1 erhöhen
                label_GewinneX.Text = Zähler_Gewinne_X.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[0] == "O" && Spielfeld[4] == "O" && Spielfeld[8] == "O")
            {
                Zähler_Gewinne_O = Zähler_Gewinne_O + 1;                // Gewinnzähler von O um 1 erhöhen
                label_GewinneO.Text = Zähler_Gewinne_O.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[2] == "X" && Spielfeld[4] == "X" && Spielfeld[6] == "X")
            {
                Zähler_Gewinne_X = Zähler_Gewinne_X + 1;                // Gewinnzähler von X um 1 erhöhen
                label_GewinneX.Text = Zähler_Gewinne_X.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Spielfeld[2] == "O" && Spielfeld[4] == "O" && Spielfeld[6] == "O")
            {
                Zähler_Gewinne_O = Zähler_Gewinne_O + 1;                // Gewinnzähler von O um 1 erhöhen
                label_GewinneO.Text = Zähler_Gewinne_O.ToString();      // Neuen Gewinnzähler auf GUI anzeigen
                Rundenende();                                           // Public Void Rundenende ausführen   
            }
            else if (Zähler_Runde >= 9)
            {
                Rundenende();                                           // Public Void Rundenende auführen
            }
            // wenn kein Gewinn oder kein Spielzug mehr möglich passiert nichts und das Programm läuft weiter
        }

        public void Rundenende()
        {
            // Bei Rundenende werden alle Buttons deaktiviert und unsichtbar
            button_A1.Visible = false;
            button_A2.Visible = false;
            button_A3.Visible = false;
            button_B1.Visible = false;
            button_B2.Visible = false;
            button_B3.Visible = false;
            button_C1.Visible = false;
            button_C2.Visible = false;
            button_C3.Visible = false;
            button_A1.Enabled = false;
            button_A2.Enabled = false;
            button_A3.Enabled = false;
            button_B1.Enabled = false;
            button_B2.Enabled = false;
            button_B3.Enabled = false;
            button_C1.Enabled = false;
            button_C2.Enabled = false;
            button_C3.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Alle PictureBoxen auf dem 3x3 Spielfeld werden geladen
            picturebox_A1_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_A1_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
            picturebox_A2_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_A2_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
            picturebox_A3_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_A3_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
            picturebox_B1_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_B1_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
            picturebox_B2_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_B2_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
            picturebox_B3_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_B3_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
            picturebox_C1_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_C1_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
            picturebox_C2_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_C2_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
            picturebox_C3_O.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_C3_X.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");

            // Alle PictureBoxen für die Gewinnanzeige werden geladen
            pictureBox_GewinneO.Image = Image.FromFile(@"..\..\..\Bilder\Kreis.png");
            pictureBox_GewinneX.Image = Image.FromFile(@"..\..\..\Bilder\Kreuz.png");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button_A1_Click(object sender, EventArgs e)
        {
            button_A1.Enabled = false; // Button deaktivieren
            button_A1.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_A1_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[0] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_A1_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[0] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button_A2_Click(object sender, EventArgs e)
        {
            button_A2.Enabled = false; // Button deaktivieren
            button_A2.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_A2_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[1] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_A2_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[1] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button_A3_Click(object sender, EventArgs e)
        {
            button_A3.Enabled = false; // Button deaktivieren
            button_A3.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_A3_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[2] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_A3_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[2] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button_B1_Click(object sender, EventArgs e)
        {
            button_B1.Enabled = false; // Button deaktivieren
            button_B1.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_B1_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[3] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_B1_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[3] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button_B2_Click(object sender, EventArgs e)
        {
            button_B2.Enabled = false; // Button deaktivieren
            button_B2.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_B2_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[4] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_B2_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[4] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button_B3_Click(object sender, EventArgs e)
        {
            button_B3.Enabled = false; // Button deaktivieren
            button_B3.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_B3_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[5] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_B3_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[5] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button_C1_Click(object sender, EventArgs e)
        {
            button_C1.Enabled = false; // Button deaktivieren
            button_C1.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_C1_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[6] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_C1_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[6] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button_C2_Click(object sender, EventArgs e)
        {
            button_C2.Enabled = false; // Button deaktivieren
            button_C2.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_C2_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[7] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_C2_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[7] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button_C3_Click(object sender, EventArgs e)
        {
            button_C3.Enabled = false; // Button deaktivieren
            button_C3.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            // Wenn Zähler gerade ...
            if (Zähler_Runde % 2 == 0)
            {
                picturebox_C3_O.Visible = true; // ... wird Bild mit Kreis sichtbar
                Spielfeld[8] = "O"; // Spielzug wird im Array gespeichert
            }

            // Wenn Zähler ungerade ...
            else
            {
                pictureBox_C3_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
                Spielfeld[8] = "X"; // Spielzug wird im Array gespeichert
            }
            Überprüfung(); // Public Void Überprüfung wird ausgeführt
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hauptmenü öffnen
            Mainmenu f = new Mainmenu();
            f.Show();
            // dieses Fenster schliessen
            this.Hide();
        }

        private void label_GewinneX_Click(object sender, EventArgs e)
        {

        }

        private void butten_NeuesSpiel_Click(object sender, EventArgs e)
        {
            Zähler_Runde = 0; // Rundenzähler zurücksetzen
            Spielfeld = new string[] { "", "", "", "", "", "", "", "", "" }; // Spielfeldarray zurücksetzen

            // Alle Buttons auf dem Spielfeld sicht- und benutzbar machen
            button_A1.Visible = true;
            button_A1.Enabled = true;
            button_A2.Visible = true;
            button_A2.Enabled = true;
            button_A3.Visible = true;
            button_A3.Enabled = true;
            button_B1.Visible = true;
            button_B1.Enabled = true;
            button_B2.Visible = true;
            button_B2.Enabled = true;
            button_B3.Visible = true;
            button_B3.Enabled = true;
            button_C1.Visible = true;
            button_C1.Enabled = true;
            button_C2.Visible = true;
            button_C2.Enabled = true;
            button_C3.Visible = true;
            button_C3.Enabled = true;

            // Alle PictureBoxen auf dem Spielfeld unsichtbar machen
            picturebox_A1_O.Visible = false;
            pictureBox_A1_X.Visible = false;
            picturebox_A2_O.Visible = false;
            pictureBox_A2_X.Visible = false;
            picturebox_A3_O.Visible = false;
            pictureBox_A3_X.Visible = false;
            picturebox_B1_O.Visible = false;
            pictureBox_B1_X.Visible = false;
            picturebox_B2_O.Visible = false;
            pictureBox_B2_X.Visible = false;
            picturebox_B3_O.Visible = false;
            pictureBox_B3_X.Visible = false;
            picturebox_C1_O.Visible = false;
            pictureBox_C1_X.Visible = false;
            picturebox_C2_O.Visible = false;
            pictureBox_C2_X.Visible = false;
            picturebox_C3_O.Visible = false;
            pictureBox_C3_X.Visible = false;
        }

        private void pictureBox_A3_X_Click(object sender, EventArgs e)
        {

        }
    }
}
