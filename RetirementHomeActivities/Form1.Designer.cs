namespace RetirementHomeActivities
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
            this.cbInhabitants = new System.Windows.Forms.ComboBox();
            this.cbActivities = new System.Windows.Forms.ComboBox();
            this.mtbActivityDate = new System.Windows.Forms.MaskedTextBox();
            this.lblInhabitants = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.btAddActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbInhabitants
            // 
            this.cbInhabitants.FormattingEnabled = true;
            this.cbInhabitants.Location = new System.Drawing.Point(90, 67);
            this.cbInhabitants.Name = "cbInhabitants";
            this.cbInhabitants.Size = new System.Drawing.Size(121, 21);
            this.cbInhabitants.TabIndex = 0;
            // 
            // cbActivities
            // 
            this.cbActivities.FormattingEnabled = true;
            this.cbActivities.Location = new System.Drawing.Point(537, 67);
            this.cbActivities.Name = "cbActivities";
            this.cbActivities.Size = new System.Drawing.Size(121, 21);
            this.cbActivities.TabIndex = 1;
            // 
            // mtbActivityDate
            // 
            this.mtbActivityDate.Location = new System.Drawing.Point(537, 108);
            this.mtbActivityDate.Mask = "00/00/0000";
            this.mtbActivityDate.Name = "mtbActivityDate";
            this.mtbActivityDate.Size = new System.Drawing.Size(121, 20);
            this.mtbActivityDate.TabIndex = 2;
            this.mtbActivityDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblInhabitants
            // 
            this.lblInhabitants.AutoSize = true;
            this.lblInhabitants.Location = new System.Drawing.Point(87, 51);
            this.lblInhabitants.Name = "lblInhabitants";
            this.lblInhabitants.Size = new System.Drawing.Size(93, 13);
            this.lblInhabitants.TabIndex = 3;
            this.lblInhabitants.Text = "Choose Inhabitant";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(534, 92);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(534, 51);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(80, 13);
            this.lblActivity.TabIndex = 5;
            this.lblActivity.Text = "Choose Activity";
            // 
            // btAddActivity
            // 
            this.btAddActivity.Location = new System.Drawing.Point(319, 292);
            this.btAddActivity.Name = "btAddActivity";
            this.btAddActivity.Size = new System.Drawing.Size(162, 23);
            this.btAddActivity.TabIndex = 6;
            this.btAddActivity.Text = "Add Activity";
            this.btAddActivity.UseVisualStyleBackColor = true;
            this.btAddActivity.Click += new System.EventHandler(this.btAddActivity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAddActivity);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInhabitants);
            this.Controls.Add(this.mtbActivityDate);
            this.Controls.Add(this.cbActivities);
            this.Controls.Add(this.cbInhabitants);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInhabitants;
        private System.Windows.Forms.ComboBox cbActivities;
        private System.Windows.Forms.MaskedTextBox mtbActivityDate;
        private System.Windows.Forms.Label lblInhabitants;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Button btAddActivity;
    }
}

