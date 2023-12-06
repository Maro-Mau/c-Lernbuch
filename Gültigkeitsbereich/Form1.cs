namespace Gültigkeitsbereich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Mx = 0;
        private const int MaxWert = 75;
        private const string Eintrag = "Picture";
        private enum Farbe : int
        {
            Rot = 1,
            Gelb = 256465465,
            Blau = 3
        }
        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            //    int x = 0;
            //    x++;
            //    Mx++;
            //    LblAnzeige.Text = $"x: {x} Mx: {Mx}";
            //const int MaxWert = 55;
            //const int MinWert = 5;
            //LblAnzeige.Text = $"{(MaxWert -  MinWert) /2}\n{Eintrag}";
            LblAnzeige.Text = $"Farbe: {Farbe.Gelb} {(int)Farbe.Gelb}";

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            //int Mx = 0;
            //Mx++;
            //LblAnzeige.Text = $"Mx: {Mx}";
           // LblAnzeige.Text = $"{Enum.}";

        }
    }
}
