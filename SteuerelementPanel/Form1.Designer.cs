namespace SteuerelementPanel
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
            PnlPanel = new Panel();
            CmdNachOben = new Button();
            CmdNachUnten = new Button();
            CmdNachRechts = new Button();
            CmdNachLinks = new Button();
            SuspendLayout();
            // 
            // PnlPanel
            // 
            PnlPanel.BackColor = SystemColors.ActiveCaptionText;
            PnlPanel.Location = new Point(330, 209);
            PnlPanel.Name = "PnlPanel";
            PnlPanel.Size = new Size(1, 1);
            PnlPanel.TabIndex = 0;
            // 
            // CmdNachOben
            // 
            CmdNachOben.Location = new Point(289, 17);
            CmdNachOben.Name = "CmdNachOben";
            CmdNachOben.Size = new Size(100, 23);
            CmdNachOben.TabIndex = 1;
            CmdNachOben.Text = "Nach Oben";
            CmdNachOben.UseVisualStyleBackColor = true;
            CmdNachOben.Click += CmdNachOben_Click;
            // 
            // CmdNachUnten
            // 
            CmdNachUnten.Location = new Point(289, 431);
            CmdNachUnten.Name = "CmdNachUnten";
            CmdNachUnten.Size = new Size(100, 23);
            CmdNachUnten.TabIndex = 2;
            CmdNachUnten.Text = "Nach Unten";
            CmdNachUnten.UseVisualStyleBackColor = true;
            CmdNachUnten.Click += CmdNachUnten_Click;
            // 
            // CmdNachRechts
            // 
            CmdNachRechts.Location = new Point(546, 209);
            CmdNachRechts.Name = "CmdNachRechts";
            CmdNachRechts.Size = new Size(100, 23);
            CmdNachRechts.TabIndex = 3;
            CmdNachRechts.Text = "Nach Rechts";
            CmdNachRechts.UseVisualStyleBackColor = true;
            CmdNachRechts.Click += CmdNachRechts_Click;
            // 
            // CmdNachLinks
            // 
            CmdNachLinks.Location = new Point(40, 209);
            CmdNachLinks.Name = "CmdNachLinks";
            CmdNachLinks.Size = new Size(100, 23);
            CmdNachLinks.TabIndex = 4;
            CmdNachLinks.Text = "Nach Links";
            CmdNachLinks.UseVisualStyleBackColor = true;
            CmdNachLinks.Click += CmdNachLinks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(CmdNachLinks);
            Controls.Add(CmdNachRechts);
            Controls.Add(CmdNachUnten);
            Controls.Add(CmdNachOben);
            Controls.Add(PnlPanel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlPanel;
        private Button CmdNachOben;
        private Button CmdNachUnten;
        private Button CmdNachRechts;
        private Button CmdNachLinks;
    }
}
