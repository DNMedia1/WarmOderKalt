using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WarmOderKalt
{
    public partial class Form1 : Form
    {
        private int targetNumber; // Zielzahl
        private int maxNumber = 100; // Standardbereich
        private int attemptCount; // Anzahl der Versuche
        private List<(string Name, int Attempts, string Mode)> highscores = new List<(string Name, int Attempts, string Mode)>(); // Highscore-Liste

        private readonly string highscorePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WarmOderKalt");
        private readonly string highscoreFile = "highscores.txt";

        public Form1()
        {
            InitializeComponent();
            LoadHighscores();
            StartGame();
        }

        private void StartGame()
        {
            // Initialisiere das Spiel
            attemptCount = 0;
            targetNumber = new Random().Next(1, maxNumber + 1);

            // Aktualisiere den Bereichstext basierend auf dem Modus
            lblResult.Text = $"Ich habe eine Zahl zwischen 1 und {maxNumber} ausgewählt. Rate jetzt!";

            // Setze die Benutzeroberfläche zurück
            txtGuess.Clear();
            txtGuess.Focus();
            btnSubmit.Enabled = true;

            // Zeige die Highscores an
            DisplayHighscores();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Verarbeite die Eingabe
            if (int.TryParse(txtGuess.Text, out int guess))
            {
                if (guess < 1 || guess > maxNumber)
                {
                    lblResult.Text = $"Bitte eine Zahl zwischen 1 und {maxNumber} eingeben.";
                    return;
                }

                attemptCount++;

                if (guess == targetNumber)
                {
                    lblResult.Text = $"Hot! Richtig! Sie haben die Zahl {targetNumber} in {attemptCount} Versuchen erraten.";
                    btnSubmit.Enabled = false; // Eingabe blockieren, bis Neustart erfolgt

                    // Highscore aktualisieren
                    UpdateHighscores();
                }
                else if (Math.Abs(targetNumber - guess) <= 10)
                {
                    lblResult.Text = "Warm! Sie liegen nahe dran.";
                }
                else
                {
                    lblResult.Text = "Cold! Sie sind weit weg.";
                }
            }
            else
            {
                lblResult.Text = "Bitte eine gültige Zahl eingeben.";
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Neustart: Setze das Spiel vollständig zurück
            StartGame();
        }

        private void ChkHardmode_CheckedChanged(object sender, EventArgs e)

        {
            // Passe den Zahlenbereich an, wenn Hardmode aktiviert wird
            if (chkHardmode.Checked)
            {
                maxNumber = 1000;
                lblResult.Text = "Hardmode aktiviert! Rate eine Zahl zwischen 1 und 1000.";
            }
            else
            {
                maxNumber = 100;
                lblResult.Text = "Hardmode deaktiviert! Rate eine Zahl zwischen 1 und 100.";
            }

            // Starte das Spiel neu
            StartGame();
        }

        private void UpdateHighscores()
        {
            // Fragen Sie den Spieler nach seinem Namen
            string playerName = PromptForPlayerName();

            if (!string.IsNullOrEmpty(playerName))
            {
                // Füge den neuen Highscore hinzu
                string mode = maxNumber == 1000 ? "Hardmode" : "Standard";
                highscores.Add((playerName, attemptCount, mode));
                highscores = highscores.OrderBy(h => h.Attempts).Take(10).ToList(); // Sortiere und begrenze auf die Top 10
                SaveHighscores();
            }

            // Aktualisiere die Highscore-Anzeige
            DisplayHighscores();
        }

        private string PromptForPlayerName()
        {
            // Zeige ein Eingabefeld für den Namen an
            return Microsoft.VisualBasic.Interaction.InputBox(
                "Herzlichen Glückwunsch! Sie haben einen neuen Highscore erreicht.\nBitte geben Sie Ihren Namen ein:",
                "Neuer Highscore",
                "Spieler");
        }

        private void LoadHighscores()
        {
            // Lade die gespeicherten Highscores
            if (!Directory.Exists(highscorePath))
            {
                Directory.CreateDirectory(highscorePath);
            }

            string fullPath = Path.Combine(highscorePath, highscoreFile);
            if (File.Exists(fullPath))
            {
                var lines = File.ReadAllLines(fullPath);
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 3 && int.TryParse(parts[1], out int attempts))
                    {
                        highscores.Add((parts[0], attempts, parts[2]));
                    }
                }
            }
        }

        private void SaveHighscores()
        {
            // Speichere die Highscores in einer Datei
            try
            {
                string fullPath = Path.Combine(highscorePath, highscoreFile);
                var lines = highscores.Select(h => $"{h.Name};{h.Attempts};{h.Mode}");
                File.WriteAllLines(fullPath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Highscores: {ex.Message}");
            }
        }

        private void DisplayHighscores()
        {
            // Zeige die Highscores im Label an
            lblHighscore.Text = "Highscores:\n" +
                string.Join("\n", highscores.Select((h, index) => $"{index + 1}. {h.Name} ({h.Mode}): {h.Attempts} Versuche"));
        }

        private void btnRestart_Click_2(object sender, EventArgs e)
        {
            StartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
