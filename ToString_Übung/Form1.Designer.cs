﻿namespace ToString_Übung
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
            CmdAnzeige = new Button();
            CmdAnzeige2 = new Button();
            CmdAnzeige3 = new Button();
            CmdAnzeige4 = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // CmdAnzeige
            // 
            CmdAnzeige.AutoEllipsis = true;
            CmdAnzeige.Location = new Point(237, 29);
            CmdAnzeige.Name = "CmdAnzeige";
            CmdAnzeige.Size = new Size(75, 23);
            CmdAnzeige.TabIndex = 0;
            CmdAnzeige.Text = "Anzeigen 1";
            CmdAnzeige.TextAlign = ContentAlignment.TopCenter;
            CmdAnzeige.UseVisualStyleBackColor = true;
            CmdAnzeige.Click += CmdAnzeige_Click;
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.AutoEllipsis = true;
            CmdAnzeige2.Location = new Point(237, 58);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(75, 23);
            CmdAnzeige2.TabIndex = 1;
            CmdAnzeige2.Text = "Anzeigen 2";
            CmdAnzeige2.TextAlign = ContentAlignment.TopCenter;
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(237, 87);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(75, 23);
            CmdAnzeige3.TabIndex = 2;
            CmdAnzeige3.Text = "Anzeigen 3";
            CmdAnzeige3.UseVisualStyleBackColor = true;
            CmdAnzeige3.Click += CmdAnzeige3_Click;
            // 
            // CmdAnzeige4
            // 
            CmdAnzeige4.Location = new Point(237, 116);
            CmdAnzeige4.Name = "CmdAnzeige4";
            CmdAnzeige4.Size = new Size(75, 23);
            CmdAnzeige4.TabIndex = 3;
            CmdAnzeige4.Text = "Anzeigen 4";
            CmdAnzeige4.UseVisualStyleBackColor = true;
            CmdAnzeige4.Click += CmdAnzeige4_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(26, 29);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(10, 15);
            LblAnzeige.TabIndex = 4;
            LblAnzeige.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 184);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdAnzeige4);
            Controls.Add(CmdAnzeige3);
            Controls.Add(CmdAnzeige2);
            Controls.Add(CmdAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige;
        private Button CmdAnzeige2;
        private Button CmdAnzeige3;
        private Button CmdAnzeige4;
        private Label LblAnzeige;
    }
}
