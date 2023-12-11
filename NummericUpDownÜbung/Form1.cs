namespace NummericUpDownÜbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numZahl_ValueChanged(object sender, EventArgs e)
        {
            // Schleife CodeSpielerei
            if (numZahl.Value < 0) 
            {
                LblAnzeige.ForeColor = Color.Red;
            }
            else 
            {
                LblAnzeige.ForeColor = Color.Green;
            }


            LblAnzeige.Text = $"Wert: {numZahl.Value}";
        }
    }
}
