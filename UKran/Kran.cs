using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKran
{
    public class Kran
    {
        public void AuslegerAusfahren(string bewKran, Panel ausleger, Panel hacken)
        {
            if (bewKran == "Links")
            {
                ausleger.Width += 10;
                ausleger.Location = new Point(ausleger.Location.X - 10, ausleger.Location.Y);
                hacken.Location = new Point(hacken.Location.X - 10, hacken.Location.Y);
            }
            else
            {
                ausleger.Width += 10;
                hacken.Location = new Point(hacken.Location.X + 10, hacken.Location.Y);


            }
        }

        public void AuslegerEinfahren(string bewKran, Panel ausleger, Panel hacken)
        {
            if (bewKran == "Links")
            {
                ausleger.Width -= 10;
                ausleger.Location = new Point(ausleger.Location.X + 10, ausleger.Location.Y);
                hacken.Location = new Point(hacken.Location.X + 10, hacken.Location.Y);
            }
            else
            {
                ausleger.Width -= 10;
                ausleger.Location = new Point(ausleger.Location.X - 10, ausleger.Location.Y);
                hacken.Location = new Point(hacken.Location.X - 10, hacken.Location.Y);
            }
        }
        public void HackenAusfahren(Panel hacken)
        {
            hacken.Height += 10;
        }
        public void HackenEinfahren(Panel hacken) 
        {
            hacken.Height -= 10;
        }
        public void KranHochfahren(string bewKran, Panel ausleger, Panel hacken, Panel pfosten)
        {
            pfosten.Height += 10;
            pfosten.Location = new Point(pfosten.Location.X, pfosten.Location.Y - 10);
            ausleger.Location = new Point(ausleger.Location.X, ausleger.Location.Y - 10);
            hacken.Location = new Point(hacken.Location.X, hacken.Location.Y - 10);
        }
        public void KranRunterFahren(string bewKran, Panel ausleger, Panel hacken, Panel pfosten) 
        {
            pfosten.Height -= 10;
            pfosten.Location = new Point(pfosten.Location.X, pfosten.Location.Y + 10);
            ausleger.Location = new Point(ausleger.Location.X, ausleger.Location.Y + 10);
            hacken.Location = new Point(hacken.Location.X, hacken.Location.Y + 10);
        }
    }
}
