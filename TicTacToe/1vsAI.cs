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
    public partial class _1vsAI : Form
    {
        public _1vsAI()
        {
            InitializeComponent();
        }

        private void button_Hauptmenü_Click(object sender, EventArgs e)
        {
            // Hauptmenu öffnen
            Mainmenu f = new Mainmenu();
            f.Show();
            this.Hide(); // dieses Fenster schliessen
        }

        public int Zähler_Runde = 0;                // Rundenzähler initialisieren
        public bool Runde_Beenden = false;
        public int Zähler_Gewinne_O = 0;            // Zähler der Gewinne von O initialisieren
        public int Zähler_Gewinne_X = 0;            // Zähler der Gewinne von X initialisieren
        public string[] Spielfeld = new string[9];  // Array zum Wiederspiegelung des Spielfelds initialisieren
        public int zufallKI = 0;                    // Variabel zum Bestimmen eines zufälligen Feldes für die KI wird initialisiert

        public void Überprüfung() 
        {
            // nach jedem Spielzug wird überprüft, ob X oder O die Runde gewonnen hat
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
            // Wenn niemand gewonnen hat, aber alle Felder belegt sind, ...
        }

        public void KI()
        {
            // Überprüfung, ob die Runde schon zu Ende ist
            if (Runde_Beenden == false)
            {
                // Offensive Spielstrategie
                // Jedes Mal wird überprüft, ob bereits irgendwo zwei Kreise in einer Reihe sind und das 3. Feld nicht blockiert ist.
                // Wenn dem so ist, wird das Feld belegt und ein Kreis angezeigt
                if (Spielfeld[0] == "O" && Spielfeld[1] == "O" && Spielfeld[2] == "")
                {
                    Spielfeld[2] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_A3.Enabled = false;      // Knopf wird deaktiviert
                    button_A3.Visible = false;      // Knopf wird unsichtbar
                    picturebox_A3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "O" && Spielfeld[1] == "" && Spielfeld[2] == "O")
                {
                    Spielfeld[1] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_A2.Enabled = false;      // Knopf wird deaktiviert
                    button_A2.Visible = false;      // Knopf wird unsichtbar
                    picturebox_A2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "" && Spielfeld[1] == "O" && Spielfeld[2] == "O")
                {
                    Spielfeld[0] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_A1.Enabled = false;      // Knopf wird deaktiviert
                    button_A1.Visible = false;      // Knopf wird unsichtbar
                    picturebox_A1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[3] == "O" && Spielfeld[4] == "O" && Spielfeld[5] == "")
                {
                    Spielfeld[5] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_B3.Enabled = false;      // Knopf wird deaktiviert
                    button_B3.Visible = false;      // Knopf wird unsichtbar
                    picturebox_B3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[3] == "O" && Spielfeld[4] == "" && Spielfeld[5] == "O")
                {
                    Spielfeld[4] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_B2.Enabled = false;      // Knopf wird deaktiviert
                    button_B2.Visible = false;      // Knopf wird unsichtbar
                    picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[3] == "" && Spielfeld[4] == "O" && Spielfeld[5] == "O")
                {
                    Spielfeld[3] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_B1.Enabled = false;      // Knopf wird deaktiviert
                    button_B1.Visible = false;      // Knopf wird unsichtbar
                    picturebox_B1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[6] == "O" && Spielfeld[7] == "O" && Spielfeld[8] == "")
                {
                    Spielfeld[8] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_C3.Enabled = false;      // Knopf wird deaktiviert
                    button_C3.Visible = false;      // Knopf wird unsichtbar
                    picturebox_C3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[6] == "O" && Spielfeld[7] == "" && Spielfeld[8] == "O")
                {
                    Spielfeld[7] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_C2.Enabled = false;      // Knopf wird deaktiviert
                    button_C2.Visible = false;      // Knopf wird unsichtbar
                    picturebox_C2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[6] == "" && Spielfeld[7] == "O" && Spielfeld[8] == "O")
                {
                    Spielfeld[6] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_C1.Enabled = false;      // Knopf wird deaktiviert
                    button_C1.Visible = false;      // Knopf wird unsichtbar
                    picturebox_C1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "O" && Spielfeld[3] == "O" && Spielfeld[6] == "")
                {
                    Spielfeld[6] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_C1.Enabled = false;      // Knopf wird deaktiviert
                    button_C1.Visible = false;      // Knopf wird unsichtbar
                    picturebox_C1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "O" && Spielfeld[3] == "" && Spielfeld[6] == "O")
                {
                    Spielfeld[3] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_B1.Enabled = false;      // Knopf wird deaktiviert
                    button_B1.Visible = false;      // Knopf wird unsichtbar
                    picturebox_B1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "" && Spielfeld[3] == "O" && Spielfeld[6] == "O")
                {
                    Spielfeld[0] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_A1.Enabled = false;      // Knopf wird deaktiviert
                    button_A1.Visible = false;      // Knopf wird unsichtbar
                    picturebox_A1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[1] == "O" && Spielfeld[4] == "O" && Spielfeld[7] == "")
                {
                    Spielfeld[7] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_C2.Enabled = false;      // Knopf wird deaktiviert
                    button_C2.Visible = false;      // Knopf wird unsichtbar
                    picturebox_C2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[1] == "O" && Spielfeld[4] == "" && Spielfeld[7] == "O")
                {
                    Spielfeld[4] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_B2.Enabled = false;      // Knopf wird deaktiviert
                    button_B2.Visible = false;      // Knopf wird unsichtbar
                    picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[1] == "" && Spielfeld[4] == "O" && Spielfeld[7] == "O")
                {
                    Spielfeld[1] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_A2.Enabled = false;      // Knopf wird deaktiviert
                    button_A2.Visible = false;      // Knopf wird unsichtbar
                    picturebox_A2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[2] == "O" && Spielfeld[5] == "O" && Spielfeld[8] == "")
                {
                    Spielfeld[8] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_C3.Enabled = false;      // Knopf wird deaktiviert
                    button_C3.Visible = false;      // Knopf wird unsichtbar
                    picturebox_C3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[2] == "O" && Spielfeld[5] == "" && Spielfeld[8] == "O")
                {
                    Spielfeld[5] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_B3.Enabled = false;      // Knopf wird deaktiviert
                    button_B3.Visible = false;      // Knopf wird unsichtbar
                    picturebox_B3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[2] == "" && Spielfeld[5] == "O" && Spielfeld[8] == "O")
                {
                    Spielfeld[2] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_A3.Enabled = false;      // Knopf wird deaktiviert
                    button_A3.Visible = false;      // Knopf wird unsichtbar
                    picturebox_A3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "O" && Spielfeld[4] == "O" && Spielfeld[8] == "")
                {
                    Spielfeld[8] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_C3.Enabled = false;      // Knopf wird deaktiviert
                    button_C3.Visible = false;      // Knopf wird unsichtbar
                    picturebox_C3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "O" && Spielfeld[4] == "" && Spielfeld[8] == "O")
                {
                    Spielfeld[4] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_B2.Enabled = false;      // Knopf wird deaktiviert
                    button_B2.Visible = false;      // Knopf wird unsichtbar
                    picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "" && Spielfeld[4] == "O" && Spielfeld[8] == "O")
                {
                    Spielfeld[0] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_A1.Enabled = false;      // Knopf wird deaktiviert
                    button_A1.Visible = false;      // Knopf wird unsichtbar
                    picturebox_A1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[2] == "O" && Spielfeld[4] == "O" && Spielfeld[6] == "")
                {
                    Spielfeld[6] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_C1.Enabled = false;      // Knopf wird deaktiviert
                    button_C1.Visible = false;      // Knopf wird unsichtbar
                    picturebox_C1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[2] == "O" && Spielfeld[4] == "" && Spielfeld[6] == "O")
                {
                    Spielfeld[4] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_B2.Enabled = false;      // Knopf wird deaktiviert
                    button_B2.Visible = false;      // Knopf wird unsichtbar
                    picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[2] == "" && Spielfeld[4] == "O" && Spielfeld[6] == "O")
                {
                    Spielfeld[2] = "O";             // fehlendes Feld für Gewinn wird im Array belegt
                    button_A3.Enabled = false;      // Knopf wird deaktiviert
                    button_A3.Visible = false;      // Knopf wird unsichtbar
                    picturebox_A3_O.Visible = true; // Kreis wird sichtbar
                }

                // Defensive Spielstrategie:
                // Nachdem ein sofortiger Gewinn für O ausgeschlossen ist, wir überprüft, ob der Gegner 2 in einer Reihe hat und das 3. Feld noch frei ist.
                // Wenn dem so ist, wird das Feld besetzt und ein Kreis angezeigt.
                else if (Spielfeld[0] == "X" && Spielfeld[1] == "X" && Spielfeld[2] == "")
                {
                    Spielfeld[2] = "O";             // Feld wird im Array belegt
                    button_A3.Enabled = false;      // Button wird deaktiviert
                    button_A3.Visible = false;      // Button wird unsichtbar
                    picturebox_A3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "X" && Spielfeld[2] == "X" && Spielfeld[1] == "")
                {
                    Spielfeld[1] = "O";             // Feld wird im Array belegt
                    button_A2.Enabled = false;      // Button wird deaktiviert
                    button_A2.Visible = false;      // Button wird unsichtbar
                    picturebox_A2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[1] == "X" && Spielfeld[2] == "X" && Spielfeld[0] == "")
                {
                    Spielfeld[0] = "O";             // Feld wird im Array belegt
                    button_A1.Enabled = false;      // Button wird deaktiviert
                    button_A1.Visible = false;      // Button wird unsichtbar
                    picturebox_A1_O.Visible = true; // Kreis wird sichtbar
                }

                else if (Spielfeld[3] == "X" && Spielfeld[4] == "X" && Spielfeld[5] == "")
                {
                    Spielfeld[5] = "O";             // Feld wird im Array belegt
                    button_B3.Enabled = false;      // Button wird deaktiviert
                    button_B3.Visible = false;      // Button wird unsichtbar
                    picturebox_B3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[4] == "X" && Spielfeld[5] == "X" && Spielfeld[3] == "")
                {
                    Spielfeld[3] = "O";             // Feld wird im Array belegt
                    button_B1.Enabled = false;      // Button wird deaktiviert
                    button_B1.Visible = false;      // Button wird unsichtbar
                    picturebox_B1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[3] == "X" && Spielfeld[5] == "X" && Spielfeld[4] == "")
                {
                    Spielfeld[4] = "O";             // Feld wird im Array belegt
                    button_B2.Enabled = false;      // Button wird deaktiviert
                    button_B2.Visible = false;      // Button wird unsichtbar
                    picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                }

                else if (Spielfeld[6] == "X" && Spielfeld[7] == "X" && Spielfeld[8] == "")
                {
                    Spielfeld[8] = "O";             // Feld wird im Array belegt
                    button_C3.Enabled = false;      // Button wird deaktiviert
                    button_C3.Visible = false;      // Button wird unsichtbar
                    picturebox_C3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[7] == "X" && Spielfeld[8] == "X" && Spielfeld[6] == "")
                {
                    Spielfeld[6] = "O";             // Feld wird im Array belegt
                    button_C1.Enabled = false;      // Button wird deaktiviert
                    button_C1.Visible = false;      // Button wird unsichtbar
                    picturebox_C1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[6] == "X" && Spielfeld[8] == "X" && Spielfeld[7] == "")
                {
                    Spielfeld[7] = "O";             // Feld wird im Array belegt
                    button_C2.Enabled = false;      // Button wird deaktiviert
                    button_C2.Visible = false;      // Button wird unsichtbar
                    picturebox_C2_O.Visible = true; // Kreis wird sichtbar
                }

                else if (Spielfeld[0] == "X" && Spielfeld[3] == "X" && Spielfeld[6] == "")
                {
                    Spielfeld[6] = "O";             // Feld wird im Array belegt
                    button_C1.Enabled = false;      // Button wird deaktiviert
                    button_C1.Visible = false;      // Button wird unsichtbar
                    picturebox_C1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "X" && Spielfeld[6] == "X" && Spielfeld[3] == "")
                {
                    Spielfeld[3] = "O";             // Feld wird im Array belegt
                    button_B1.Enabled = false;      // Button wird deaktiviert
                    button_B1.Visible = false;      // Button wird unsichtbar
                    picturebox_B1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[3] == "X" && Spielfeld[6] == "X" && Spielfeld[0] == "")
                {
                    Spielfeld[0] = "O";             // Feld wird im Array belegt
                    button_A1.Enabled = false;      // Button wird deaktiviert
                    button_A1.Visible = false;      // Button wird unsichtbar
                    picturebox_A1_O.Visible = true; // Kreis wird sichtbar
                }

                else if (Spielfeld[1] == "X" && Spielfeld[4] == "X" && Spielfeld[7] == "")
                {
                    Spielfeld[7] = "O";             // Feld wird im Array belegt
                    button_C2.Enabled = false;      // Button wird deaktiviert
                    button_C2.Visible = false;      // Button wird unsichtbar
                    picturebox_C2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[1] == "X" && Spielfeld[7] == "X" && Spielfeld[4] == "")
                {
                    Spielfeld[4] = "O";             // Feld wird im Array belegt
                    button_B2.Enabled = false;      // Button wird deaktiviert
                    button_B2.Visible = false;      // Button wird unsichtbar
                    picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[4] == "X" && Spielfeld[7] == "X" && Spielfeld[1] == "")
                {
                    Spielfeld[1] = "O";             // Feld wird im Array belegt
                    button_A2.Enabled = false;      // Button wird deaktiviert
                    button_A2.Visible = false;      // Button wird unsichtbar
                    picturebox_A2_O.Visible = true; // Kreis wird sichtbar
                }

                else if (Spielfeld[2] == "X" && Spielfeld[5] == "X" && Spielfeld[8] == "")
                {
                    Spielfeld[8] = "O";             // Feld wird im Array belegt
                    button_C3.Enabled = false;      // Button wird deaktiviert
                    button_C3.Visible = false;      // Button wird unsichtbar
                    picturebox_C3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[2] == "X" && Spielfeld[8] == "X" && Spielfeld[5] == "")
                {
                    Spielfeld[5] = "O";             // Feld wird im Array belegt
                    button_B3.Enabled = false;      // Button wird deaktiviert
                    button_B3.Visible = false;      // Button wird unsichtbar
                    picturebox_B3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[8] == "X" && Spielfeld[5] == "X" && Spielfeld[2] == "")
                {
                    Spielfeld[2] = "O";             // Feld wird im Array belegt
                    button_A3.Enabled = false;      // Button wird deaktiviert
                    button_A3.Visible = false;      // Button wird unsichtbar
                    picturebox_A3_O.Visible = true; // Kreis wird sichtbar
                }

                else if (Spielfeld[0] == "X" && Spielfeld[4] == "X" && Spielfeld[8] == "")
                {
                    Spielfeld[8] = "O";             // Feld wird im Array belegt
                    button_C3.Enabled = false;      // Button wird deaktiviert
                    button_C3.Visible = false;      // Button wird unsichtbar
                    picturebox_C3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[0] == "X" && Spielfeld[8] == "X" && Spielfeld[4] == "")
                {
                    Spielfeld[4] = "O";             // Feld wird im Array belegt
                    button_B2.Enabled = false;      // Button wird deaktiviert
                    button_B2.Visible = false;      // Button wird unsichtbar
                    picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[4] == "X" && Spielfeld[8] == "X" && Spielfeld[0] == "")
                {
                    Spielfeld[0] = "O";             // Feld wird im Array belegt
                    button_A1.Enabled = false;      // Button wird deaktiviert
                    button_A1.Visible = false;      // Button wird unsichtbar
                    picturebox_A1_O.Visible = true; // Kreis wird sichtbar
                }

                else if (Spielfeld[2] == "X" && Spielfeld[4] == "X" && Spielfeld[6] == "")
                {
                    Spielfeld[6] = "O";             // Feld wird im Array belegt
                    button_C1.Enabled = false;      // Button wird deaktiviert
                    button_C1.Visible = false;      // Button wird unsichtbar
                    picturebox_C1_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[4] == "X" && Spielfeld[6] == "X" && Spielfeld[2] == "")
                {
                    Spielfeld[2] = "O";             // Feld wird im Array belegt
                    button_A3.Enabled = false;      // Button wird deaktiviert
                    button_A3.Visible = false;      // Button wird unsichtbar
                    picturebox_A3_O.Visible = true; // Kreis wird sichtbar
                }
                else if (Spielfeld[2] == "X" && Spielfeld[6] == "X" && Spielfeld[4] == "")
                {
                    Spielfeld[4] = "O";             // Feld wird im Array belegt
                    button_B2.Enabled = false;      // Button wird deaktiviert
                    button_B2.Visible = false;      // Button wird unsichtbar
                    picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                }
                // Wenn weder O noch X 2 Zeichen und ein freies Feld in einer Reihe haben ...
                else
                {
                    // wird überprüft, ob noch ein Spielfeld frei ist ...
                    if (Spielfeld[0] == "" || Spielfeld[1] == "" || Spielfeld[2] == "" || Spielfeld[3] == "" || Spielfeld[4] == "" || Spielfeld[5] == "" || Spielfeld[6] == "" || Spielfeld[7] == "" || Spielfeld[8] == "")
                    {
                        // ... und wenn ja wird zufällig ein Feld belegt
                        do
                        {
                            Random zufall = new Random(); // zufällige Zahl wird initialisiert
                            zufallKI = zufall.Next(0, 8); // zufällige Zahl zwischen 0 und 8 wird bestimmt
                        }
                        while (Spielfeld[zufallKI] == "X" || Spielfeld[zufallKI] == "O"); // Ist das Feld besetzt, so startet die Schleife von Neuem

                        Spielfeld[zufallKI] = "O"; // bestimmes Feld wird im Array belegt

                        // Knöpfe werden deaktiviert und unsichtbar gemacht und ein Kreis wird eingeblendet
                        if (zufallKI == 0)
                        {
                            button_A1.Enabled = false;      // Knopf wird deaktiviert
                            button_A1.Visible = false;      // Knopf wird unsichtbar
                            picturebox_A1_O.Visible = true; // Kreis wird sichtbar
                        }
                        else if (zufallKI == 1)
                        {
                            button_A2.Enabled = false;      // Knopf wird deaktiviert
                            button_A2.Visible = false;      // Knopf wird unsichtbar
                            picturebox_A2_O.Visible = true; // Kreis wird sichtbar
                        }
                        else if (zufallKI == 2)
                        {
                            button_A3.Enabled = false;      // Knopf wird deaktiviert
                            button_A3.Visible = false;      // Knopf wird unsichtbar
                            picturebox_A3_O.Visible = true; // Kreis wird sichtbar
                        }
                        else if (zufallKI == 3)
                        {
                            button_B1.Enabled = false;      // Knopf wird deaktiviert
                            button_B1.Visible = false;      // Knopf wird unsichtbar
                            picturebox_B1_O.Visible = true; // Kreis wird sichtbar
                        }
                        else if (zufallKI == 4)
                        {
                            button_B2.Enabled = false;      // Knopf wird deaktiviert
                            button_B2.Visible = false;      // Knopf wird unsichtbar
                            picturebox_B2_O.Visible = true; // Kreis wird sichtbar
                        }
                        else if (zufallKI == 5)
                        {
                            button_B3.Enabled = false;      // Knopf wird deaktiviert
                            button_B3.Visible = false;      // Knopf wird unsichtbar
                            picturebox_B3_O.Visible = true; // Kreis wird sichtbar
                        }
                        else if (zufallKI == 6)
                        {
                            button_C1.Enabled = false;      // Knopf wird deaktiviert
                            button_C1.Visible = false;      // Knopf wird unsichtbar
                            picturebox_C1_O.Visible = true; // Kreis wird sichtbar
                        }
                        else if (zufallKI == 7)
                        {
                            button_C2.Enabled = false;      // Knopf wird deaktiviert
                            button_C2.Visible = false;      // Knopf wird unsichtbar
                            picturebox_C2_O.Visible = true; // Kreis wird sichtbar
                        }
                        else if (zufallKI == 8)
                        {
                            button_C3.Enabled = false;      // Knopf wird deaktiviert
                            button_C3.Visible = false;      // Knopf wird unsichtbar
                            picturebox_C3_O.Visible = true; // Kreis wird sichtbar
                        }
                    }
                }

                Überprüfung(); /// Public Voiid Überprüfung wird ausgeführt
            }
        }

        public void Rundenende()
        {
            // Bei Rundenende werden alle Buttons deaktiviert und unsichtbar
            Runde_Beenden = true;
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

        private void button_A1_Click_1(object sender, EventArgs e)
        {
            button_A1.Enabled = false; // Button deaktivieren
            button_A1.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_A1_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[0] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
            Überprüfung(); // Public Voiid Überprüfung wird ausgeführt
        }

        private void button_A2_Click_1(object sender, EventArgs e)
        {
            button_A2.Enabled = false; // Button deaktivieren
            button_A2.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_A2_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[1] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
        }

        private void button_A3_Click_1(object sender, EventArgs e)
        {
            button_A3.Enabled = false; // Button deaktivieren
            button_A3.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_A3_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[2] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
        }

        private void button_B1_Click_1(object sender, EventArgs e)
        {
            button_B1.Enabled = false; // Button deaktivieren
            button_B1.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_B1_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[3] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
        }

        private void button_B2_Click_1(object sender, EventArgs e)
        {
            button_B2.Enabled = false; // Button deaktivieren
            button_B2.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_B2_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[4] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
        }

        private void button_B3_Click_1(object sender, EventArgs e)
        {
            button_B3.Enabled = false; // Button deaktivieren
            button_B3.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_B3_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[5] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
        }

        private void button_C1_Click_1(object sender, EventArgs e)
        {
            button_C1.Enabled = false; // Button deaktivieren
            button_C1.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_C1_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[6] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
        }

        private void button_C2_Click_1(object sender, EventArgs e)
        {
            button_C2.Enabled = false; // Button deaktivieren
            button_C2.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_C2_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[7] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
        }

        private void button_C3_Click_1(object sender, EventArgs e)
        {
            button_C3.Enabled = false; // Button deaktivieren
            button_C3.Visible = false; // Button wird unsichtbar
            Zähler_Runde++; // Zähler wird erhöht

            pictureBox_C3_X.Visible = true; // ... wird Bild mit Kreuz sichtbar
            Spielfeld[8] = "X"; // Spielzug wird im Array gespeichert

            Überprüfung(); // Public Void Überprüfung wird ausgeführt
            KI(); // Public Void AI wird ausgeführt
        }

        private void _1vsAI_Load_1(object sender, EventArgs e)
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

        private void button_NeuesSpiel_Click(object sender, EventArgs e)
        {
            Zähler_Runde = 0; // Rundenzähler zurücksetzen
            Runde_Beenden = false; // Gewinn zurücksetzen
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

        private void label_GewinneX_Click_1(object sender, EventArgs e)
        {

        }
    }
}
