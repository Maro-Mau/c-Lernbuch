namespace GrundlagenIfELse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly Random r = new();

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            int x = r.Next(7, 20);
            LblAnzeigen.ForeColor = Color.Black;
            LblAnzeigen.Text = "Wert: " + x + "\n";
            if (x > 9) 
            {
                LblAnzeigen.Text += "Zweistellig ";
                LblAnzeigen.ForeColor = Color.Red;
            }
        }
    }
}
