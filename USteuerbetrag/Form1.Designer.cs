namespace USteuerbetrag
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
            TxtGehalt = new TextBox();
            CmdIfElse = new Button();
            CmdSwitch = new Button();
            LblSteuerbetrag = new Label();
            SuspendLayout();
            // 
            // TxtGehalt
            // 
            TxtGehalt.Location = new Point(38, 37);
            TxtGehalt.Name = "TxtGehalt";
            TxtGehalt.Size = new Size(100, 23);
            TxtGehalt.TabIndex = 0;
            // 
            // CmdIfElse
            // 
            CmdIfElse.Location = new Point(12, 66);
            CmdIfElse.Name = "CmdIfElse";
            CmdIfElse.Size = new Size(163, 23);
            CmdIfElse.TabIndex = 1;
            CmdIfElse.Text = "Berechnen mit if ... else";
            CmdIfElse.UseVisualStyleBackColor = true;
            CmdIfElse.Click += CmdIfElse_Click;
            // 
            // CmdSwitch
            // 
            CmdSwitch.Location = new Point(12, 95);
            CmdSwitch.Name = "CmdSwitch";
            CmdSwitch.Size = new Size(163, 23);
            CmdSwitch.TabIndex = 2;
            CmdSwitch.Text = "Berechnen mit Switch";
            CmdSwitch.UseVisualStyleBackColor = true;
            CmdSwitch.Click += CmdSwitch_Click;
            // 
            // LblSteuerbetrag
            // 
            LblSteuerbetrag.AutoSize = true;
            LblSteuerbetrag.Location = new Point(163, 45);
            LblSteuerbetrag.Name = "LblSteuerbetrag";
            LblSteuerbetrag.Size = new Size(38, 15);
            LblSteuerbetrag.TabIndex = 3;
            LblSteuerbetrag.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 192);
            Controls.Add(LblSteuerbetrag);
            Controls.Add(CmdSwitch);
            Controls.Add(CmdIfElse);
            Controls.Add(TxtGehalt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtGehalt;
        private Button CmdIfElse;
        private Button CmdSwitch;
        private Label LblSteuerbetrag;
    }
}
