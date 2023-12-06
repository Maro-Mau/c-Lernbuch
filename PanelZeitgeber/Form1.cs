using Microsoft.VisualBasic;

namespace PanelZeitgeber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void CmdSTart_Click(object sender, EventArgs e)
        {
            TimeMove.Interval = 1000;
            TimeMove.Enabled = true;                                 
        }      
        private void TimeMove_tick(object sender, EventArgs e)
        {
            Pan1.Location = new Point(Pan1.Location.X - 5,
                                      Pan1.Location.Y - 5);
            Pan2.Location = new Point(Pan2.Location.X + 5,
                                      Pan2.Location.Y - 5);
            Pan3.Location = new Point(Pan3.Location.X - 5,
                                      Pan3.Location.Y + 5);
            Pan4.Location = new Point(Pan4.Location.X + 5,
                                      Pan4.Location.Y + 5);
        }
       
    }
}
