namespace GrundlagenSteuerelemente
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
            CmdRelPos = new Button();
            CmdRelGr = new Button();
            CmdAbsoPos = new Button();
            CmdAbsoGr = new Button();
            CmdTest = new Button();
            LblAnzeigem = new Label();
            SuspendLayout();
            // 
            // CmdRelPos
            // 
            CmdRelPos.Location = new Point(40, 74);
            CmdRelPos.Name = "CmdRelPos";
            CmdRelPos.Size = new Size(118, 23);
            CmdRelPos.TabIndex = 0;
            CmdRelPos.Text = "Relative Position";
            CmdRelPos.UseVisualStyleBackColor = true;
            CmdRelPos.Click += CmdRelPos_Click;
            // 
            // CmdRelGr
            // 
            CmdRelGr.Location = new Point(40, 119);
            CmdRelGr.Name = "CmdRelGr";
            CmdRelGr.Size = new Size(118, 23);
            CmdRelGr.TabIndex = 1;
            CmdRelGr.Text = "Relative Größe";
            CmdRelGr.UseVisualStyleBackColor = true;
            CmdRelGr.Click += CmdRelGr_Click;
            // 
            // CmdAbsoPos
            // 
            CmdAbsoPos.Location = new Point(188, 74);
            CmdAbsoPos.Name = "CmdAbsoPos";
            CmdAbsoPos.Size = new Size(125, 23);
            CmdAbsoPos.TabIndex = 2;
            CmdAbsoPos.Text = "Absolute Position";
            CmdAbsoPos.UseVisualStyleBackColor = true;
            CmdAbsoPos.Click += CmdAbsoPos_Click;
            // 
            // CmdAbsoGr
            // 
            CmdAbsoGr.Location = new Point(188, 119);
            CmdAbsoGr.Name = "CmdAbsoGr";
            CmdAbsoGr.Size = new Size(125, 23);
            CmdAbsoGr.TabIndex = 3;
            CmdAbsoGr.Text = "Absolute Gröse";
            CmdAbsoGr.UseVisualStyleBackColor = true;
            CmdAbsoGr.Click += CmdAbsoGr_Click;
            // 
            // CmdTest
            // 
            CmdTest.Location = new Point(21, 310);
            CmdTest.Name = "CmdTest";
            CmdTest.Size = new Size(75, 23);
            CmdTest.TabIndex = 4;
            CmdTest.Text = "Test";
            CmdTest.UseVisualStyleBackColor = true;
            // 
            // LblAnzeigem
            // 
            LblAnzeigem.AutoSize = true;
            LblAnzeigem.Location = new Point(21, 393);
            LblAnzeigem.Name = "LblAnzeigem";
            LblAnzeigem.Size = new Size(55, 15);
            LblAnzeigem.TabIndex = 6;
            LblAnzeigem.Text = "PosShow";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
            Controls.Add(LblAnzeigem);
            Controls.Add(CmdTest);
            Controls.Add(CmdAbsoGr);
            Controls.Add(CmdAbsoPos);
            Controls.Add(CmdRelGr);
            Controls.Add(CmdRelPos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdRelPos;
        private Button CmdRelGr;
        private Button CmdAbsoPos;
        private Button CmdAbsoGr;
        private Button CmdTest;
        private Label LblAnzeigem;
    }
}
