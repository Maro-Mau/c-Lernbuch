using System.Web;

namespace Daten_Typen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name = "Rene Barthel";
        string straﬂe = "Akademiestr";
        int hausnummer = 27;
        int postleitzahl = 63450;
        string stadt = "Hanau";
        int alter = 36;
        private void CmdShow_Click(object sender, EventArgs e)
        {
            LblAdress.Text = $"{name}\n" + $"{straﬂe} {hausnummer}\n" + postleitzahl + " " + stadt + $"\n \n \n Alter: {alter} Jahre" ; 
        }
    }
}
