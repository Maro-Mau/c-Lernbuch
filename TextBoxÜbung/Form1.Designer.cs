namespace TextBoxÜbung
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
            TxtEingabe = new TextBox();
            CmdAnzeigen = new Button();
            CmdRechnen = new Button();
            LblOutput = new Label();
            SuspendLayout();
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 30);
            TxtEingabe.Multiline = true;
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.ShortcutsEnabled = false;
            TxtEingabe.Size = new Size(183, 23);
            TxtEingabe.TabIndex = 0;
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(201, 30);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(75, 23);
            CmdAnzeigen.TabIndex = 1;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // CmdRechnen
            // 
            CmdRechnen.Location = new Point(201, 59);
            CmdRechnen.Name = "CmdRechnen";
            CmdRechnen.Size = new Size(75, 23);
            CmdRechnen.TabIndex = 2;
            CmdRechnen.Text = "Rechnen";
            CmdRechnen.UseVisualStyleBackColor = true;
            CmdRechnen.Click += CmdRechnen_Click;
            // 
            // LblOutput
            // 
            LblOutput.AutoSize = true;
            LblOutput.Location = new Point(12, 78);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(38, 15);
            LblOutput.TabIndex = 3;
            LblOutput.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 146);
            Controls.Add(LblOutput);
            Controls.Add(CmdRechnen);
            Controls.Add(CmdAnzeigen);
            Controls.Add(TxtEingabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe;
        private Button CmdAnzeigen;
        private Button CmdRechnen;
        private Label LblOutput;
    }
}
