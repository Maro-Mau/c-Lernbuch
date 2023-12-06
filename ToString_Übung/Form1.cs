namespace ToString_Übung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            int x = 42;
            LblAnzeige.Text = x.ToString();
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int y = 42;
            LblAnzeige.Text = $"Wert: {y}";
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            int x = 42, y = 47, z;
            z = x + y;
            LblAnzeige.Text = "Das Ergebnis der " + $"Berechnung: \n{x} + {y} = {z}";
        }

        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            int x = 42, y = 47, z;
            z = x + y;
            MessageBox.Show("Das Ergebnis der " + $"Berechnung: \n{x} + {y} = {z}");
            LblAnzeige.Text = "Ende";

        }
    }
}
