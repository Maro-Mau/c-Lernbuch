namespace GundlagenIfElseVerzweigungen
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
            int x = r.Next(5, 13);
            LblAnzeigen.ForeColor = Color.Black;
            LblAnzeigen.Text = "Wert: " + x + "\n";
            if (x > 9)
            {
                LblAnzeigen.Text += "Zweistellig ";
                LblAnzeigen.ForeColor = Color.Red;
            }

        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int x = r.Next(5, 13);
            LblAnzeigen.ForeColor = Color.Black;
            LblAnzeigen.Text = "Wert: " + x + "\n";
            if (x > 9)
            {
                LblAnzeigen.Text += "Zweistellig ";
                LblAnzeigen.ForeColor = Color.Red;
            }
            else
            {
                LblAnzeigen.Text += "Einstellig";
                LblAnzeigen.ForeColor = Color.Blue;
            }

        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int x = r.Next(-7, 7);
            LblAnzeigen.ForeColor = Color.Black;
            LblAnzeigen.Text = "Wert: " + x + "\n";
            if (x < 0)
            {
                LblAnzeigen.Text += "Grösser als 0";
                //LblAnzeigen.ForeColor = Color.Red;
            }
            else
            {
                if (x < 0)
                {
                    LblAnzeigen.Text += "Kleiner als Null";

                }
                else
                {
                    LblAnzeigen.Text += "Gleich 0";
                }
            }
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int x = r.Next(-3, 4);
            LblAnzeigen.ForeColor = Color.Black;
            LblAnzeigen.Text = "Wert: " + x + "\n";

            LblAnzeigen.Text += x > 0 ? "Grösser als 0\n"
                : "Kleiner als 0 0der gleich 0\n";
           
            
            LblAnzeigen.Text += x > 0 ? "Gröser als 0"
                : x < 0 ? "Kleiner als 0" : "Gleich 0";

        }
    }
}
