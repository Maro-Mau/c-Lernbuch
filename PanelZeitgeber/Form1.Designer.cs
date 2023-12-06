namespace PanelZeitgeber
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
            components = new System.ComponentModel.Container();
            Pan1 = new Panel();
            Pan2 = new Panel();
            Pan3 = new Panel();
            Pan4 = new Panel();
            CmdSTart = new Button();
            TimeMove = new System.Windows.Forms.Timer(components);
            TimeMove2 = new System.Windows.Forms.Timer(components);
            TimeMove3 = new System.Windows.Forms.Timer(components);
            TimeMove4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Pan1
            // 
            Pan1.BackColor = Color.Red;
            Pan1.Location = new Point(251, 269);
            Pan1.Name = "Pan1";
            Pan1.Size = new Size(20, 20);
            Pan1.TabIndex = 1;
            // 
            // Pan2
            // 
            Pan2.BackColor = Color.Lime;
            Pan2.Location = new Point(277, 269);
            Pan2.Name = "Pan2";
            Pan2.Size = new Size(20, 20);
            Pan2.TabIndex = 2;
            // 
            // Pan3
            // 
            Pan3.BackColor = Color.Cyan;
            Pan3.Location = new Point(251, 295);
            Pan3.Name = "Pan3";
            Pan3.Size = new Size(20, 20);
            Pan3.TabIndex = 3;
            // 
            // Pan4
            // 
            Pan4.BackColor = Color.FromArgb(192, 64, 0);
            Pan4.Location = new Point(277, 295);
            Pan4.Name = "Pan4";
            Pan4.Size = new Size(20, 20);
            Pan4.TabIndex = 4;
            // 
            // CmdSTart
            // 
            CmdSTart.Location = new Point(251, 12);
            CmdSTart.Name = "CmdSTart";
            CmdSTart.Size = new Size(46, 23);
            CmdSTart.TabIndex = 5;
            CmdSTart.Text = "Start";
            CmdSTart.UseVisualStyleBackColor = true;
            CmdSTart.Click += CmdSTart_Click;
            // 
            // TimeMove
            // 
            TimeMove.Tick += TimeMove_tick;
            // 
            // TimeMove3
            // 
            TimeMove3.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(CmdSTart);
            Controls.Add(Pan4);
            Controls.Add(Pan3);
            Controls.Add(Pan2);
            Controls.Add(Pan1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel Pan1;
        private Panel Pan2;
        private Panel Pan3;
        private Panel Pan4;
        private Button CmdSTart;
        private System.Windows.Forms.Timer TimeMove;
        private System.Windows.Forms.Timer TimeMove2;
        public System.Windows.Forms.Timer TimeMove3;
        private System.Windows.Forms.Timer TimeMove4;
    }
}
