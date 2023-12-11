namespace EinfacheSwitchAnweisung
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
            LblAnzeigen = new Label();
            CmdAnzeige2 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(12, 12);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(75, 23);
            CmdAnzeige1.TabIndex = 0;
            CmdAnzeige1.Text = "Anzeige 1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(12, 292);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 1;
            LblAnzeigen.Text = "label1";
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(93, 12);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(75, 23);
            CmdAnzeige2.TabIndex = 2;
            CmdAnzeige2.Text = "Anzeigen 2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeige2);
            Controls.Add(LblAnzeigen);
            Controls.Add(CmdAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige1;
        private Label LblAnzeigen;
        private Button CmdAnzeige2;
    }
}
