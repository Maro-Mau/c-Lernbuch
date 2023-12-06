namespace SteuerelementPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdNachOben_Click(object sender, EventArgs e)
        {
            PnlPanel.Location = new Point(PnlPanel.Location.X, PnlPanel.Location.Y - 10);
            PnlPanel.BackColor = Color.Magenta;
        }

        private void CmdNachUnten_Click(object sender, EventArgs e)
        {
            PnlPanel.Location = new Point(PnlPanel.Location.X, PnlPanel.Location.Y + 10);
            PnlPanel.BackColor = Color.DeepPink;
        }

        private void CmdNachLinks_Click(object sender, EventArgs e)
        {
            PnlPanel.Location = new Point(PnlPanel.Location.X - 10, PnlPanel.Location.Y);
            PnlPanel.BackColor = Color.DarkTurquoise;
        }

        private void CmdNachRechts_Click(object sender, EventArgs e)
        {
            PnlPanel.Location = new Point(PnlPanel.Location.X + 10, PnlPanel.Location.Y);
            PnlPanel.BackColor = Color.IndianRed;
        }

        
    }
}
