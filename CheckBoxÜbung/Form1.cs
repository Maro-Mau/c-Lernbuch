namespace CheckBoxÜbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            LblPruefen.Text = OptRot.Checked ? "Rot" : OptGruen.Checked ? "Grün" : "Blau";
        }

        private void OptRot_CheckedChanged(object sender, EventArgs e)
        {
            LblAnzeigen.Text = "Rot";
        }

        private void OptGruen_CheckedChanged(object sender, EventArgs e)
        {
            LblAnzeigen.Text = "Grün";
        }

        private void OptBlau_CheckedChanged(object sender, EventArgs e)
        {
            LblAnzeigen.Text = "Blau";
        }

        private void CmdSetRed_Click(object sender, EventArgs e)
        {
            OptRot.Checked = true;
        }
    }
}
