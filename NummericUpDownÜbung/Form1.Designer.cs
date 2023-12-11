namespace NummericUpDownÜbung
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
            numZahl = new NumericUpDown();
            LblAnzeige = new Label();
            ((System.ComponentModel.ISupportInitialize)numZahl).BeginInit();
            SuspendLayout();
            // 
            // numZahl
            // 
            numZahl.DecimalPlaces = 1;
            numZahl.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numZahl.Location = new Point(22, 31);
            numZahl.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numZahl.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
            numZahl.Name = "numZahl";
            numZahl.Size = new Size(120, 23);
            numZahl.TabIndex = 0;
            numZahl.ThousandsSeparator = true;
            numZahl.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numZahl.ValueChanged += numZahl_ValueChanged;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(218, 32);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 176);
            Controls.Add(LblAnzeige);
            Controls.Add(numZahl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numZahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numZahl;
        private Label LblAnzeige;
    }
}
