namespace GundlagenIfElseVerzweigungen
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
            CmdAnzeige1 = new Button();
            CmdAnzeige2 = new Button();
            CmdAnzeigen3 = new Button();
            CmdAnzeigen4 = new Button();
            LblAnzeigen = new Label();
            CmdAnzeigen5 = new Button();
            CmdAnzeigen6 = new Button();
            CmdAnzeigen7 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(12, 12);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(75, 23);
            CmdAnzeige1.TabIndex = 0;
            CmdAnzeige1.Text = "Anzeigen 1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(93, 12);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(75, 23);
            CmdAnzeige2.TabIndex = 1;
            CmdAnzeige2.Text = "Anzeige 2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(174, 12);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(75, 23);
            CmdAnzeigen3.TabIndex = 2;
            CmdAnzeigen3.Text = "Anzeigen 3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(255, 12);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(75, 23);
            CmdAnzeigen4.TabIndex = 3;
            CmdAnzeigen4.Text = "Anzeigen 4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(155, 99);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(35, 15);
            LblAnzeigen.TabIndex = 4;
            LblAnzeigen.Text = "Label";
            // 
            // CmdAnzeigen5
            // 
            CmdAnzeigen5.Location = new Point(12, 43);
            CmdAnzeigen5.Name = "CmdAnzeigen5";
            CmdAnzeigen5.Size = new Size(75, 23);
            CmdAnzeigen5.TabIndex = 5;
            CmdAnzeigen5.Text = "Anzeige 5";
            CmdAnzeigen5.UseVisualStyleBackColor = true;
            CmdAnzeigen5.Click += CmdAnzeigen5_Click;
            // 
            // CmdAnzeigen6
            // 
            CmdAnzeigen6.Location = new Point(93, 43);
            CmdAnzeigen6.Name = "CmdAnzeigen6";
            CmdAnzeigen6.Size = new Size(75, 23);
            CmdAnzeigen6.TabIndex = 6;
            CmdAnzeigen6.Text = "Anzeige 6";
            CmdAnzeigen6.UseVisualStyleBackColor = true;
            CmdAnzeigen6.Click += CmdAnzeigen6_Click;
            // 
            // CmdAnzeigen7
            // 
            CmdAnzeigen7.Location = new Point(174, 41);
            CmdAnzeigen7.Name = "CmdAnzeigen7";
            CmdAnzeigen7.Size = new Size(75, 23);
            CmdAnzeigen7.TabIndex = 7;
            CmdAnzeigen7.Text = "Anzweige 7";
            CmdAnzeigen7.UseVisualStyleBackColor = true;
            CmdAnzeigen7.Click += CmdAnzeigen7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 156);
            Controls.Add(CmdAnzeigen7);
            Controls.Add(CmdAnzeigen6);
            Controls.Add(CmdAnzeigen5);
            Controls.Add(LblAnzeigen);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(CmdAnzeige2);
            Controls.Add(CmdAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige1;
        private Button CmdAnzeige2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Label LblAnzeigen;
        private Button CmdAnzeigen5;
        private Button CmdAnzeigen6;
        private Button CmdAnzeigen7;
    }
}
