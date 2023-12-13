namespace UKran
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmdHackenAus = new Button();
            CmdHackenEin = new Button();
            CmdAuslegerAus = new Button();
            CmdAuslegerEin = new Button();
            CmdKranRechts = new Button();
            CmdKranLinks = new Button();
            CmdKranAus = new Button();
            CmdKranEin = new Button();
            f = new Panel();
            hacken = new Panel();
            ausleger = new Panel();
            pfosten = new Panel();
            SuspendLayout();
            // 
            // CmdHackenAus
            // 
            CmdHackenAus.Location = new Point(12, 12);
            CmdHackenAus.Name = "CmdHackenAus";
            CmdHackenAus.Size = new Size(75, 23);
            CmdHackenAus.TabIndex = 0;
            CmdHackenAus.Text = "Haken aus";
            CmdHackenAus.UseVisualStyleBackColor = true;
            CmdHackenAus.Click += CmdHackenAus_Click;
            // 
            // CmdHackenEin
            // 
            CmdHackenEin.Location = new Point(93, 12);
            CmdHackenEin.Name = "CmdHackenEin";
            CmdHackenEin.Size = new Size(75, 23);
            CmdHackenEin.TabIndex = 1;
            CmdHackenEin.Text = "Hacken ein";
            CmdHackenEin.UseVisualStyleBackColor = true;
            CmdHackenEin.Click += CmdHackenEin_Click;
            // 
            // CmdAuslegerAus
            // 
            CmdAuslegerAus.Location = new Point(174, 12);
            CmdAuslegerAus.Name = "CmdAuslegerAus";
            CmdAuslegerAus.Size = new Size(86, 23);
            CmdAuslegerAus.TabIndex = 2;
            CmdAuslegerAus.Text = "Ausleger aus";
            CmdAuslegerAus.UseVisualStyleBackColor = true;
            CmdAuslegerAus.Click += CmdAuslegerAus_Click;
            // 
            // CmdAuslegerEin
            // 
            CmdAuslegerEin.Location = new Point(266, 12);
            CmdAuslegerEin.Name = "CmdAuslegerEin";
            CmdAuslegerEin.Size = new Size(82, 23);
            CmdAuslegerEin.TabIndex = 3;
            CmdAuslegerEin.Text = "Ausleger ein";
            CmdAuslegerEin.UseVisualStyleBackColor = true;
            CmdAuslegerEin.Click += CmdAuslegerEin_Click;
            // 
            // CmdKranRechts
            // 
            CmdKranRechts.Location = new Point(354, 12);
            CmdKranRechts.Name = "CmdKranRechts";
            CmdKranRechts.Size = new Size(86, 23);
            CmdKranRechts.TabIndex = 4;
            CmdKranRechts.Text = "Kran Rechts";
            CmdKranRechts.UseVisualStyleBackColor = true;
            CmdKranRechts.Click += CmdKranRechts_Click;
            // 
            // CmdKranLinks
            // 
            CmdKranLinks.Location = new Point(446, 12);
            CmdKranLinks.Name = "CmdKranLinks";
            CmdKranLinks.Size = new Size(82, 23);
            CmdKranLinks.TabIndex = 5;
            CmdKranLinks.Text = "Kran Links";
            CmdKranLinks.UseVisualStyleBackColor = true;
            CmdKranLinks.Click += CmdKranLinks_Click;
            // 
            // CmdKranAus
            // 
            CmdKranAus.Location = new Point(534, 12);
            CmdKranAus.Name = "CmdKranAus";
            CmdKranAus.Size = new Size(75, 23);
            CmdKranAus.TabIndex = 6;
            CmdKranAus.Text = "Kran Aus";
            CmdKranAus.UseVisualStyleBackColor = true;
            CmdKranAus.Click += CmdKranAus_Click;
            // 
            // CmdKranEin
            // 
            CmdKranEin.Location = new Point(615, 12);
            CmdKranEin.Name = "CmdKranEin";
            CmdKranEin.Size = new Size(75, 23);
            CmdKranEin.TabIndex = 7;
            CmdKranEin.Text = "Kran Ein";
            CmdKranEin.UseVisualStyleBackColor = true;
            CmdKranEin.Click += CmdKranEin_Click;
            // 
            // f
            // 
            f.BackColor = Color.Red;
            f.Cursor = Cursors.IBeam;
            f.Location = new Point(399, 423);
            f.Name = "f";
            f.Size = new Size(100, 20);
            f.TabIndex = 8;
            // 
            // h
            // 
            hacken.Anchor = AnchorStyles.None;
            hacken.BackColor = Color.Blue;
            hacken.Cursor = Cursors.IBeam;
            hacken.Location = new Point(489, 318);
            hacken.Name = "hacken";
            hacken.Size = new Size(20, 20);
            hacken.TabIndex = 9;
            // 
            // w
            // 
            ausleger.BackColor = Color.Yellow;
            ausleger.Cursor = Cursors.IBeam;
            ausleger.Location = new Point(459, 298);
            ausleger.Name = "ausleger";
            ausleger.Size = new Size(50, 20);
            ausleger.TabIndex = 10;
            // 
            // s
            // 
            pfosten.BackColor = Color.FromArgb(0, 192, 0);
            pfosten.Cursor = Cursors.IBeam;
            pfosten.Location = new Point(440, 297);
            pfosten.Name = "pfosten";
            pfosten.Size = new Size(20, 126);
            pfosten.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 853);
            Controls.Add(hacken);
            Controls.Add(f);
            Controls.Add(pfosten);
            Controls.Add(ausleger);
            Controls.Add(CmdKranEin);
            Controls.Add(CmdKranAus);
            Controls.Add(CmdKranLinks);
            Controls.Add(CmdKranRechts);
            Controls.Add(CmdAuslegerEin);
            Controls.Add(CmdAuslegerAus);
            Controls.Add(CmdHackenEin);
            Controls.Add(CmdHackenAus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdHackenAus;
        private Button CmdHackenEin;
        private Button CmdAuslegerAus;
        private Button CmdAuslegerEin;
        private Button CmdKranRechts;
        private Button CmdKranLinks;
        private Button CmdKranAus;
        private Button CmdKranEin;
        private Panel f;
        private Panel hacken;
        private Panel ausleger;
        private Panel pfosten;
    }
}
