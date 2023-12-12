namespace CheckBoxÜbung
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
            CmdPruefen = new Button();
            OptRot = new RadioButton();
            OptGruen = new RadioButton();
            OptBlau = new RadioButton();
            CmdSetRed = new Button();
            LblPruefen = new Label();
            LblAnzeigen = new Label();
            SuspendLayout();
            // 
            // CmdPruefen
            // 
            CmdPruefen.Location = new Point(120, 8);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(75, 23);
            CmdPruefen.TabIndex = 0;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = true;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(120, 37);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(43, 19);
            OptRot.TabIndex = 1;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            OptRot.CheckedChanged += OptRot_CheckedChanged;
            // 
            // OptGruen
            // 
            OptGruen.AutoSize = true;
            OptGruen.Location = new Point(120, 62);
            OptGruen.Name = "OptGruen";
            OptGruen.Size = new Size(51, 19);
            OptGruen.TabIndex = 2;
            OptGruen.Text = "Grün";
            OptGruen.UseVisualStyleBackColor = true;
            OptGruen.CheckedChanged += OptGruen_CheckedChanged;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(120, 87);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(48, 19);
            OptBlau.TabIndex = 3;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            OptBlau.CheckedChanged += OptBlau_CheckedChanged;
            // 
            // CmdSetRed
            // 
            CmdSetRed.Location = new Point(120, 112);
            CmdSetRed.Name = "CmdSetRed";
            CmdSetRed.Size = new Size(75, 23);
            CmdSetRed.TabIndex = 4;
            CmdSetRed.Text = "Set Rot";
            CmdSetRed.UseVisualStyleBackColor = true;
            CmdSetRed.Click += CmdSetRed_Click;
            // 
            // LblPruefen
            // 
            LblPruefen.AutoSize = true;
            LblPruefen.Location = new Point(12, 16);
            LblPruefen.Name = "LblPruefen";
            LblPruefen.Size = new Size(38, 15);
            LblPruefen.TabIndex = 5;
            LblPruefen.Text = "label1";
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(12, 124);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 6;
            LblAnzeigen.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 163);
            Controls.Add(LblAnzeigen);
            Controls.Add(LblPruefen);
            Controls.Add(CmdSetRed);
            Controls.Add(OptBlau);
            Controls.Add(OptGruen);
            Controls.Add(OptRot);
            Controls.Add(CmdPruefen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdPruefen;
        private RadioButton OptRot;
        private RadioButton OptGruen;
        private RadioButton OptBlau;
        private Button CmdSetRed;
        private Label LblPruefen;
        private Label LblAnzeigen;
    }
}
