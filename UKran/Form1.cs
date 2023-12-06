namespace UKran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Links = "Links";
        string Rechts = "Rechts";
        string bewKran = "";


        private void CmdHackenAus_Click(object sender, EventArgs e)
        {
            h.Height += 10;
        }

        private void CmdHackenEin_Click(object sender, EventArgs e)
        {
            h.Height -= 10;
        }

        private void CmdAuslegerAus_Click(object sender, EventArgs e)
        {
            if (bewKran == Links)
            {
                w.Width += 10;
                w.Location = new Point(w.Location.X - 10, w.Location.Y);
                h.Location = new Point(h.Location.X - 10, h.Location.Y);
            }
            else
            {
                w.Width += 10;
               // w.Location = new Point(w.Location.X + 10, w.Location.Y);
                h.Location = new Point(h.Location.X + 10, h.Location.Y);

            }
        }

        private void CmdAuslegerEin_Click(object sender, EventArgs e)
        {
            if (bewKran == Links)
            {
                w.Width -= 10;
                w.Location = new Point(w.Location.X + 10, w.Location.Y);
                h.Location = new Point(h.Location.X + 10, h.Location.Y);
            }
            else
            {
                w.Width -= 10;
                w.Location = new Point(w.Location.X - 10, w.Location.Y);
                h.Location = new Point(h.Location.X - 10, h.Location.Y);
            }
        }

        private void CmdKranAus_Click(object sender, EventArgs e)
        {
            s.Height += 10;
            s.Location = new Point(s.Location.X, s.Location.Y - 10);
            w.Location = new Point(w.Location.X, w.Location.Y - 10);
            h.Location = new Point(h.Location.X, h.Location.Y - 10);
        }

        private void CmdKranEin_Click(object sender, EventArgs e)
        {
            s.Height -= 10;
            s.Location = new Point(s.Location.X, s.Location.Y + 10);
            w.Location = new Point(w.Location.X, w.Location.Y + 10);
            h.Location = new Point(h.Location.X, h.Location.Y + 10);
        }

        private void CmdKranLinks_Click(object sender, EventArgs e)
        {
            //MoveLeft();
            //PosKranLinks();
            PosKran2(Links);
        }

        private void CmdKranRechts_Click(object sender, EventArgs e)
        {
            //MoveRight();
            //PosKranRechts();
            PosKran(Rechts, Color.Red, Color.Green);
        }


        private string PosKranRechts()
        {
            CmdKranLinks.BackColor = Color.Red;
            CmdKranRechts.BackColor = Color.Green;
            return bewKran = "Rechts";
        }
        private string PosKranLinks()
        {
            CmdKranLinks.BackColor = Color.Green;
            CmdKranRechts.BackColor = Color.Red;
            return bewKran = "Links";

        }
        private string PosKran(string Move, System.Drawing.Color BtnColorLeft, System.Drawing.Color BtnColorRight)
        {
            CmdKranLinks.BackColor = BtnColorLeft;
            CmdKranRechts.BackColor = BtnColorRight;
            return bewKran = Move ;
        }
        //Alternative mit Schleife

        private string PosKran2(string Move)
        {
            if (Move == Links) 
            {
                CmdKranLinks.BackColor = Color.Green;
                CmdKranRechts.BackColor = Color.Red;
                s.Location = new Point(440, 297);
                w.Location = new Point(390, 297);
                h.Location = new Point(390, 317);
                s.Size = new Size(20, 126);
                w.Size = new Size(50, 20);
                h.Size = new Size(20, 20);
                return bewKran = "Links";
            }
            else 
            {
                CmdKranLinks.BackColor = Color.Red;
                CmdKranRechts.BackColor = Color.Green;
                s.Location = new Point(440, 297);
                w.Location = new Point(459, 298);
                h.Location = new Point(489, 318);
                s.Size = new Size(20, 126);
                w.Size = new Size(50, 20);
                h.Size = new Size(20, 20);
                return bewKran = "Rechts";
            }
        }

        private void MoveLeft()
        {
            s.Location = new Point(440, 297);
            w.Location = new Point(390, 297);
            h.Location = new Point(390, 317);
            s.Size = new Size(20, 126);
            w.Size = new Size(50, 20);
            h.Size = new Size(20, 20);
        }
        private void MoveRight()
        {

            s.Location = new Point(440, 297);
            w.Location = new Point(459, 298);
            h.Location = new Point(489, 318);
            s.Size = new Size(20, 126);
            w.Size = new Size(50, 20);
            h.Size = new Size(20, 20);

        }

    }
}
