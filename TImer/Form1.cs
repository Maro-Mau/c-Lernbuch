namespace TImer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TimAzeige.Enabled = true;
        }

        private void CmdStop_Click(object sender, EventArgs e)
        {
            TimAzeige.Enabled = false;
        }
        private void TimAnzeige_Tick(object sender, EventArgs e)
        {
            LblAnzeige.Text += "x";
        }
    }
}
