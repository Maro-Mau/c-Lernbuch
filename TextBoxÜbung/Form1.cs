namespace TextBoxÜbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            string text = TxtEingabe.Text;
            LblOutput.Text = $"Ihre EIngabe: {TxtEingabe.Text}";
        }

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            double wert;
            wert = Convert.ToDouble(TxtEingabe.Text);
            wert *= 2;
            LblOutput.Text = $"Die eingabe mal 2 ist: {wert}";
        }
    }
}
