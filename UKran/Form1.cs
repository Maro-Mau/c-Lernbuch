namespace UKran;

public partial class Form1 : Form

{
    Kran Kran = new Kran();

    public Form1()
    {
        InitializeComponent();
    }
    string bewKran = "";


    private void CmdHackenAus_Click(object sender, EventArgs e)
    {
        Kran.HackenAusfahren(hacken);
    }

    private void CmdHackenEin_Click(object sender, EventArgs e)
    {
        Kran.HackenEinfahren(hacken);
    }

    private void CmdAuslegerAus_Click(object sender, EventArgs e)
    {
        Kran.AuslegerAusfahren(bewKran, ausleger, hacken);

    }

    private void CmdAuslegerEin_Click(object sender, EventArgs e)
    {
        Kran.AuslegerEinfahren(bewKran, ausleger, hacken);
    }

    private void CmdKranAus_Click(object sender, EventArgs e)
    {
        Kran.KranHochfahren(bewKran, ausleger, hacken, pfosten);
    }

    private void CmdKranEin_Click(object sender, EventArgs e)
    {
        Kran.KranRunterFahren(bewKran, ausleger, hacken, pfosten);
    }

    private void CmdKranLinks_Click(object sender, EventArgs e)
    {
        Kran.KranStartPosition("Links", ausleger, hacken, pfosten, CmdKranLinks, CmdKranRechts);
    }

    private void CmdKranRechts_Click(object sender, EventArgs e)
    {
        Kran.KranStartPosition("Rechts", ausleger, hacken, pfosten, CmdKranLinks, CmdKranRechts);
    }
}
