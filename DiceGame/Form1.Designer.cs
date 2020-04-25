namespace DiceGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGame = new System.Windows.Forms.Button();
            this.lbRolls = new System.Windows.Forms.ListBox();
            this.lblRolls = new System.Windows.Forms.Label();
            this.tbGameOutput = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGame
            // 
            this.btGame.Location = new System.Drawing.Point(346, 206);
            this.btGame.Name = "btGame";
            this.btGame.Size = new System.Drawing.Size(75, 23);
            this.btGame.TabIndex = 1;
            this.btGame.Text = "Roll";
            this.btGame.UseVisualStyleBackColor = true;
            this.btGame.Click += new System.EventHandler(this.btGame_Click);
            // 
            // lbRolls
            // 
            this.lbRolls.Enabled = false;
            this.lbRolls.FormattingEnabled = true;
            this.lbRolls.Location = new System.Drawing.Point(12, 12);
            this.lbRolls.Name = "lbRolls";
            this.lbRolls.Size = new System.Drawing.Size(185, 355);
            this.lbRolls.TabIndex = 3;
            // 
            // lblRolls
            // 
            this.lblRolls.AutoSize = true;
            this.lblRolls.Location = new System.Drawing.Point(204, 13);
            this.lblRolls.Name = "lblRolls";
            this.lblRolls.Size = new System.Drawing.Size(30, 13);
            this.lblRolls.TabIndex = 4;
            this.lblRolls.Text = "Rolls";
            // 
            // tbGameOutput
            // 
            this.tbGameOutput.Enabled = false;
            this.tbGameOutput.Location = new System.Drawing.Point(277, 180);
            this.tbGameOutput.Name = "tbGameOutput";
            this.tbGameOutput.Size = new System.Drawing.Size(217, 20);
            this.tbGameOutput.TabIndex = 6;
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(12, 386);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(185, 20);
            this.tbAverage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbGameOutput);
            this.Controls.Add(this.lblRolls);
            this.Controls.Add(this.lbRolls);
            this.Controls.Add(this.btGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGame;
        private System.Windows.Forms.ListBox lbRolls;
        private System.Windows.Forms.Label lblRolls;
        private System.Windows.Forms.TextBox tbGameOutput;
        private System.Windows.Forms.TextBox tbAverage;
    }
}

