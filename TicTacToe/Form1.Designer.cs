namespace TicTacToe
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
            label1 = new Label();
            OWins = new Label();
            label3 = new Label();
            XWins = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 34);
            label1.TabIndex = 12;
            label1.Text = "Tik-Tac-Toe";
            label1.Click += label1_Click;
            // 
            // OWins
            // 
            OWins.AutoSize = true;
            OWins.Font = new Font("Vivaldi", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            OWins.Location = new Point(614, 11);
            OWins.Name = "OWins";
            OWins.Size = new Size(137, 32);
            OWins.TabIndex = 13;
            OWins.Text = "O Wins: 0";
            OWins.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Vivaldi", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(336, 330);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 14;
            label3.Click += label3_Click;
            // 
            // XWins
            // 
            XWins.AutoSize = true;
            XWins.Font = new Font("Vivaldi", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            XWins.Location = new Point(38, 11);
            XWins.Name = "XWins";
            XWins.Size = new Size(145, 32);
            XWins.TabIndex = 15;
            XWins.Text = "X Wins: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 388);
            Controls.Add(XWins);
            Controls.Add(label3);
            Controls.Add(OWins);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label OWins;
        private Label label3;
        private Label XWins;
    }
}
