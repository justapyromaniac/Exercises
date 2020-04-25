namespace Bank
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
            this.nudDeposit = new System.Windows.Forms.NumericUpDown();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.btDepositOrWithdraw = new System.Windows.Forms.Button();
            this.lblDepositOrWithdraw = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDeposit
            // 
            this.nudDeposit.DecimalPlaces = 2;
            this.nudDeposit.Location = new System.Drawing.Point(180, 183);
            this.nudDeposit.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudDeposit.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudDeposit.Name = "nudDeposit";
            this.nudDeposit.Size = new System.Drawing.Size(120, 20);
            this.nudDeposit.TabIndex = 1;
            this.nudDeposit.ValueChanged += new System.EventHandler(this.nudDeposit_ValueChanged);
            // 
            // tbAccount
            // 
            this.tbAccount.Enabled = false;
            this.tbAccount.Location = new System.Drawing.Point(410, 183);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(168, 20);
            this.tbAccount.TabIndex = 2;
            // 
            // btDepositOrWithdraw
            // 
            this.btDepositOrWithdraw.Location = new System.Drawing.Point(179, 209);
            this.btDepositOrWithdraw.Name = "btDepositOrWithdraw";
            this.btDepositOrWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btDepositOrWithdraw.TabIndex = 4;
            this.btDepositOrWithdraw.Text = "Deposit";
            this.btDepositOrWithdraw.UseVisualStyleBackColor = true;
            this.btDepositOrWithdraw.Click += new System.EventHandler(this.btDepositOrWithdraw_Click);
            // 
            // lblDepositOrWithdraw
            // 
            this.lblDepositOrWithdraw.AutoSize = true;
            this.lblDepositOrWithdraw.Location = new System.Drawing.Point(177, 167);
            this.lblDepositOrWithdraw.Name = "lblDepositOrWithdraw";
            this.lblDepositOrWithdraw.Size = new System.Drawing.Size(77, 13);
            this.lblDepositOrWithdraw.TabIndex = 6;
            this.lblDepositOrWithdraw.Text = "Deposit money";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(407, 167);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(39, 13);
            this.lblAccount.TabIndex = 8;
            this.lblAccount.Text = "Money";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblDepositOrWithdraw);
            this.Controls.Add(this.btDepositOrWithdraw);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.nudDeposit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudDeposit;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Button btDepositOrWithdraw;
        private System.Windows.Forms.Label lblDepositOrWithdraw;
        private System.Windows.Forms.Label lblAccount;
    }
}

