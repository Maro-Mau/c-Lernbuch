namespace GrundlagenSteuerelemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdRelPos_Click(object sender, EventArgs e)
        {
            PosFixChange(20, -30);
        }

        private void PosFixChange(int PoX, int PoY)
        {
            CmdTest.Location = new Point(
                            CmdTest.Location.X + PoX , CmdTest.Location.Y + PoY);
            PosShow(Color.Brown, Color.RebeccaPurple);
        }

        private void CmdAbsoPos_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(100, 150);s
            PosShow(Color.Purple , Color.RebeccaPurple);
        }

        private void CmdRelGr_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(
                CmdTest.Size.Width + 20, CmdTest.Size.Height + 20);
            PosShow(Color.IndianRed, Color.RebeccaPurple);
        }

        private void CmdAbsoGr_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(50, 100);
            PosShow(Color.DeepPink, Color.RebeccaPurple);
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            PosShow(Color.LawnGreen, Color.RebeccaPurple);
        }
        string name = "";

        private void PosShow(System.Drawing.Color PosColor, System.Drawing.Color BakColor )
        {
            LblAnzeigem.Text = $"X:{CmdTest.Location.X} " + $"Y:{CmdTest.Location.Y}\n" + $"Breite:{CmdTest.Size.Width} " + $"Höhe{CmdTest.Size.Height}";
            LblAnzeigem.BackColor = PosColor;
            BackColor = BakColor;
            CmdTest.BackColor = BackColor;
        }

        private void CmdFarbe_Click(object sender, EventArgs e)
        {
            BackColor = Color.Tomato;
            LblAnzeigem.BackColor = Color.FromArgb(192, 255, 0);
        }
    }
}
