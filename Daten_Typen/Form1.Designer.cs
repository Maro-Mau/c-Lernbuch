namespace Daten_Typen
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
            CmdShow = new Button();
            LblAdress = new Label();
            SuspendLayout();
            // 
            // CmdShow
            // 
            CmdShow.Location = new Point(172, 5);
            CmdShow.Name = "CmdShow";
            CmdShow.Size = new Size(75, 23);
            CmdShow.TabIndex = 0;
            CmdShow.Text = "Show";
            CmdShow.UseVisualStyleBackColor = true;
            CmdShow.Click += CmdShow_Click;
            // 
            // LblAdress
            // 
            LblAdress.AutoSize = true;
            LblAdress.Location = new Point(12, 9);
            LblAdress.Name = "LblAdress";
            LblAdress.Size = new Size(16, 15);
            LblAdress.TabIndex = 1;
            LblAdress.Text = "   ";
            // 
            // Form1
            // 
            AccessibleDescription = "Datentypen";
            AccessibleName = "Datentypen";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 140);
            Controls.Add(LblAdress);
            Controls.Add(CmdShow);
            Name = "Form1";
            Text = "Datentypen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdShow;
        private Label LblAdress;
    }
}
