namespace EinfacheSwitchAnweisung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly Random r = new();

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            string stadt = "", land;
            int flaeche;
            switch (stadt)
            {
                case "Paris":
                    land = "Frankreich";
                    flaeche = 632734;
                    break;
                case "Namur":
                case "Antwerpen":
                case "Lüttich":
                    land = "Belgien";
                    flaeche = 30688;
                    break;
                case "Barcelona":
                    land = "Spanien";
                    flaeche = 505970;
                    break;
                default:
                    land = "Unbekannt";
                    flaeche = 0;
                    break;

            }
            LblAnzeigen.Text = $"Stadt: {stadt}, Land: {land},  Fläche: {flaeche}";

        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            double x = r.NextDouble();
            LblAnzeigen.Text = $"wert: {x * 0.1}\n";
            switch (x * 0.1)
            {
                case < 0.02:
                    LblAnzeigen.Text += "Größer oder gleich 0.0\n";
                    LblAnzeigen.Text += "Kleiner als 0.02";
                    break;
                case < 0.05:
                    LblAnzeigen.Text += "Größer oder gleich 0.02\n";
                    LblAnzeigen.Text += "Kleiner als 0.05";
                    break;
                case < 0.08:
                    LblAnzeigen.Text += "Größer oder gleich 0.05\n";
                    LblAnzeigen.Text += "Kleiner als 0.08";
                    break;
                default:
                    LblAnzeigen.Text += "Größer oder gleich 0.08\n";
                    LblAnzeigen.Text += "Kleiner als 0.1";
                    break;
            }
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            string stadt = "Barcelona", land;
            bool hauptstadt = false;
            int flaeche;
            switch (stadt)
            {
                case "Paris":
                    hauptstadt = true;
                    land = "Frankreich";
                    flaeche = 632734;
                    break;
                case "Brüssel":
                    hauptstadt = true;
                    goto case "Namur";
                case "Namur":
                case "Lüttich":
                    land = "Belgien";
                    flaeche = 30688;
                    break;
                case "Barcelona":
                    land = "Spanien";
                    flaeche = 505970;
                    break;
                case "Madrid":
                    hauptstadt = true;
                    goto case "Barcelona";
                default:
                    land = "unbekannt";
                    flaeche = 0;
                    break;
            }
            LblAnzeigen.Text = $"Stadt: {stadt}";
            if (hauptstadt)
                LblAnzeigen.Text += ", ist Hauptstadt";
            LblAnzeigen.Text += $", Land: {land}, Fläche: {flaeche}";
        }

        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            string land = "Frankreich";
            string haubtstadt = land switch
            {
                "Frankreich" => "Paris",
                "Belgien" => "Brüssel",
                "Spanien" => "Madrid",
                _ => "unbekannt"
            };
            LblAnzeigen.Text
        }
    }
}


