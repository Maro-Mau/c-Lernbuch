namespace UKran;

public partial class Form1 : Form

{
    Kran panelKran = new Kran();

    public Form1()
    {
        InitializeComponent();
    }
    string bewKran = "";


    private void CmdHackenAus_Click(object sender, EventArgs e)
    {
        panelKran.HackenAusfahren(hacken);
    }

    private void CmdHackenEin_Click(object sender, EventArgs e)
    {
        panelKran.HackenEinfahren(hacken);
    }

    private void CmdAuslegerAus_Click(object sender, EventArgs e)
    {
        panelKran.AuslegerAusfahren(bewKran, ausleger, hacken);

    }

    private void CmdAuslegerEin_Click(object sender, EventArgs e)
    {
        panelKran.AuslegerEinfahren(bewKran, ausleger, hacken);
    }

    private void CmdKranAus_Click(object sender, EventArgs e)
    {
        panelKran.KranHochfahren(bewKran, ausleger, hacken, pfosten);
    }

    private void CmdKranEin_Click(object sender, EventArgs e)
    {
        panelKran.KranRunterFahren(bewKran, ausleger, hacken, pfosten);
    }

    private void CmdKranLinks_Click(object sender, EventArgs e)
    {
        PosKran2(bewKran);
    }

    private void CmdKranRechts_Click(object sender, EventArgs e)
    {

        PosKran(bewKran, Color.Red, Color.Green);
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
        if (Move == bewKran) 
        {
            CmdKranLinks.BackColor = Color.Green;
            CmdKranRechts.BackColor = Color.Red;
            pfosten.Location = new Point(440, 297);
            ausleger.Location = new Point(390, 297);
            hacken.Location = new Point(390, 317);
            pfosten.Size = new Size(20, 126);
            ausleger.Size = new Size(50, 20);
            hacken.Size = new Size(20, 20);
            return bewKran = "Links";
        }
        else 
        {
            CmdKranLinks.BackColor = Color.Red;
            CmdKranRechts.BackColor = Color.Green;
            pfosten.Location = new Point(440, 297);
            ausleger.Location = new Point(459, 298);
            hacken.Location = new Point(489, 318);
            pfosten.Size = new Size(20, 126);
            ausleger.Size = new Size(50, 20);
            hacken.Size = new Size(20, 20);
            return bewKran = "Rechts";
        }
    }

    // Switch

    private string PosKran3(string move)
    {
        switch (move)
        {
            case "Links":
                CmdKranLinks.BackColor = Color.Green;
                CmdKranRechts.BackColor = Color.Red;
                pfosten.Location = new Point(440, 297);
                ausleger.Location = new Point(390, 297);
                hacken.Location = new Point(390, 317);
                pfosten.Size = new Size(20, 126);
                ausleger.Size = new Size(50, 20);
                hacken.Size = new Size(20, 20);
                return bewKran = "Links";

            case "Rechts":
                CmdKranLinks.BackColor = Color.Red;
                CmdKranRechts.BackColor = Color.Green;
                pfosten.Location = new Point(440, 297);
                ausleger.Location = new Point(459, 298);
                hacken.Location = new Point(489, 318);
                pfosten.Size = new Size(20, 126);
                ausleger.Size = new Size(50, 20);
                hacken.Size = new Size(20, 20);
                return bewKran = "Rechts";
            default:

                MessageBox.Show("Error");
                return bewKran = "Error";

        }
    }

    private void MoveLeft()
    {
        pfosten.Location = new Point(440, 297);
        ausleger.Location = new Point(390, 297);
        hacken.Location = new Point(390, 317);
        pfosten.Size = new Size(20, 126);
        ausleger.Size = new Size(50, 20);
        hacken.Size = new Size(20, 20);
    }
    private void MoveRight()
    {

        pfosten.Location = new Point(440, 297);
        ausleger.Location = new Point(459, 298);
        hacken.Location = new Point(489, 318);
        pfosten.Size = new Size(20, 126);
        ausleger.Size = new Size(50, 20);
        hacken.Size = new Size(20, 20);

    }

}
