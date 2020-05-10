namespace Garage
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
            this.rbSportsCar = new System.Windows.Forms.RadioButton();
            this.rbFamilyCar = new System.Windows.Forms.RadioButton();
            this.lblCarType = new System.Windows.Forms.Label();
            this.gbCar = new System.Windows.Forms.GroupBox();
            this.btAddCar = new System.Windows.Forms.Button();
            this.lblHorsePower = new System.Windows.Forms.Label();
            this.lblSpeeds = new System.Windows.Forms.Label();
            this.nudHorsePower = new System.Windows.Forms.NumericUpDown();
            this.nudSpeedSettings = new System.Windows.Forms.NumericUpDown();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.mtbLicensePlate = new System.Windows.Forms.MaskedTextBox();
            this.lblInUseDate = new System.Windows.Forms.Label();
            this.mtbInUseDate = new System.Windows.Forms.MaskedTextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btRemoveCar = new System.Windows.Forms.Button();
            this.lblRemoveCarPlate = new System.Windows.Forms.Label();
            this.mtbFindLicensePlate = new System.Windows.Forms.MaskedTextBox();
            this.lbCars = new System.Windows.Forms.ListBox();
            this.gbCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorsePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedSettings)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSportsCar
            // 
            this.rbSportsCar.AutoSize = true;
            this.rbSportsCar.Checked = true;
            this.rbSportsCar.Location = new System.Drawing.Point(15, 25);
            this.rbSportsCar.Name = "rbSportsCar";
            this.rbSportsCar.Size = new System.Drawing.Size(74, 17);
            this.rbSportsCar.TabIndex = 0;
            this.rbSportsCar.TabStop = true;
            this.rbSportsCar.Text = "Sports Car";
            this.rbSportsCar.UseVisualStyleBackColor = true;
            this.rbSportsCar.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbFamilyCar
            // 
            this.rbFamilyCar.AutoSize = true;
            this.rbFamilyCar.Location = new System.Drawing.Point(15, 48);
            this.rbFamilyCar.Name = "rbFamilyCar";
            this.rbFamilyCar.Size = new System.Drawing.Size(73, 17);
            this.rbFamilyCar.TabIndex = 1;
            this.rbFamilyCar.Text = "Family Car";
            this.rbFamilyCar.UseVisualStyleBackColor = true;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(12, 9);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(96, 13);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Choose type of car";
            // 
            // gbCar
            // 
            this.gbCar.Controls.Add(this.btAddCar);
            this.gbCar.Controls.Add(this.lblHorsePower);
            this.gbCar.Controls.Add(this.lblSpeeds);
            this.gbCar.Controls.Add(this.nudHorsePower);
            this.gbCar.Controls.Add(this.nudSpeedSettings);
            this.gbCar.Controls.Add(this.lblLicensePlate);
            this.gbCar.Controls.Add(this.mtbLicensePlate);
            this.gbCar.Controls.Add(this.lblInUseDate);
            this.gbCar.Controls.Add(this.mtbInUseDate);
            this.gbCar.Controls.Add(this.lblModel);
            this.gbCar.Controls.Add(this.tbModel);
            this.gbCar.Controls.Add(this.tbBrand);
            this.gbCar.Controls.Add(this.lblBrand);
            this.gbCar.Location = new System.Drawing.Point(116, 25);
            this.gbCar.Name = "gbCar";
            this.gbCar.Size = new System.Drawing.Size(503, 179);
            this.gbCar.TabIndex = 3;
            this.gbCar.TabStop = false;
            // 
            // btAddCar
            // 
            this.btAddCar.Location = new System.Drawing.Point(368, 156);
            this.btAddCar.Name = "btAddCar";
            this.btAddCar.Size = new System.Drawing.Size(135, 23);
            this.btAddCar.TabIndex = 13;
            this.btAddCar.Text = "Add Car";
            this.btAddCar.UseVisualStyleBackColor = true;
            this.btAddCar.Click += new System.EventHandler(this.btAddCar_Click);
            // 
            // lblHorsePower
            // 
            this.lblHorsePower.AutoSize = true;
            this.lblHorsePower.Location = new System.Drawing.Point(365, 77);
            this.lblHorsePower.Name = "lblHorsePower";
            this.lblHorsePower.Size = new System.Drawing.Size(68, 13);
            this.lblHorsePower.TabIndex = 12;
            this.lblHorsePower.Text = "Horse Power";
            // 
            // lblSpeeds
            // 
            this.lblSpeeds.AutoSize = true;
            this.lblSpeeds.Location = new System.Drawing.Point(187, 77);
            this.lblSpeeds.Name = "lblSpeeds";
            this.lblSpeeds.Size = new System.Drawing.Size(77, 13);
            this.lblSpeeds.TabIndex = 11;
            this.lblSpeeds.Text = "Speed settings";
            // 
            // nudHorsePower
            // 
            this.nudHorsePower.Location = new System.Drawing.Point(368, 93);
            this.nudHorsePower.Name = "nudHorsePower";
            this.nudHorsePower.Size = new System.Drawing.Size(135, 20);
            this.nudHorsePower.TabIndex = 10;
            // 
            // nudSpeedSettings
            // 
            this.nudSpeedSettings.Location = new System.Drawing.Point(190, 94);
            this.nudSpeedSettings.Name = "nudSpeedSettings";
            this.nudSpeedSettings.Size = new System.Drawing.Size(135, 20);
            this.nudSpeedSettings.TabIndex = 9;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(-3, 77);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(71, 13);
            this.lblLicensePlate.TabIndex = 8;
            this.lblLicensePlate.Text = "License Plate";
            // 
            // mtbLicensePlate
            // 
            this.mtbLicensePlate.Location = new System.Drawing.Point(0, 93);
            this.mtbLicensePlate.Mask = "0-LLL-000";
            this.mtbLicensePlate.Name = "mtbLicensePlate";
            this.mtbLicensePlate.Size = new System.Drawing.Size(135, 20);
            this.mtbLicensePlate.TabIndex = 7;
            // 
            // lblInUseDate
            // 
            this.lblInUseDate.AutoSize = true;
            this.lblInUseDate.Location = new System.Drawing.Point(365, 20);
            this.lblInUseDate.Name = "lblInUseDate";
            this.lblInUseDate.Size = new System.Drawing.Size(64, 13);
            this.lblInUseDate.TabIndex = 6;
            this.lblInUseDate.Text = "In use since";
            // 
            // mtbInUseDate
            // 
            this.mtbInUseDate.Location = new System.Drawing.Point(368, 36);
            this.mtbInUseDate.Mask = "00/00/0000";
            this.mtbInUseDate.Name = "mtbInUseDate";
            this.mtbInUseDate.Size = new System.Drawing.Size(135, 20);
            this.mtbInUseDate.TabIndex = 5;
            this.mtbInUseDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(187, 20);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(190, 36);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(135, 20);
            this.tbModel.TabIndex = 1;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(0, 36);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(135, 20);
            this.tbBrand.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(-3, 20);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRemoveCar);
            this.groupBox2.Controls.Add(this.lblRemoveCarPlate);
            this.groupBox2.Controls.Add(this.mtbFindLicensePlate);
            this.groupBox2.Location = new System.Drawing.Point(628, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btRemoveCar
            // 
            this.btRemoveCar.Location = new System.Drawing.Point(0, 156);
            this.btRemoveCar.Name = "btRemoveCar";
            this.btRemoveCar.Size = new System.Drawing.Size(135, 23);
            this.btRemoveCar.TabIndex = 14;
            this.btRemoveCar.Text = "Remove Car";
            this.btRemoveCar.UseVisualStyleBackColor = true;
            this.btRemoveCar.Click += new System.EventHandler(this.btRemoveCar_Click);
            // 
            // lblRemoveCarPlate
            // 
            this.lblRemoveCarPlate.AutoSize = true;
            this.lblRemoveCarPlate.Location = new System.Drawing.Point(-3, 21);
            this.lblRemoveCarPlate.Name = "lblRemoveCarPlate";
            this.lblRemoveCarPlate.Size = new System.Drawing.Size(71, 13);
            this.lblRemoveCarPlate.TabIndex = 14;
            this.lblRemoveCarPlate.Text = "License Plate";
            // 
            // mtbFindLicensePlate
            // 
            this.mtbFindLicensePlate.Location = new System.Drawing.Point(0, 37);
            this.mtbFindLicensePlate.Mask = "0-LLL-000";
            this.mtbFindLicensePlate.Name = "mtbFindLicensePlate";
            this.mtbFindLicensePlate.Size = new System.Drawing.Size(135, 20);
            this.mtbFindLicensePlate.TabIndex = 14;
            // 
            // lbCars
            // 
            this.lbCars.FormattingEnabled = true;
            this.lbCars.Location = new System.Drawing.Point(116, 210);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(647, 225);
            this.lbCars.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCars);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCar);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.rbFamilyCar);
            this.Controls.Add(this.rbSportsCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCar.ResumeLayout(false);
            this.gbCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorsePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedSettings)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSportsCar;
        private System.Windows.Forms.RadioButton rbFamilyCar;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.GroupBox gbCar;
        private System.Windows.Forms.Button btAddCar;
        private System.Windows.Forms.Label lblHorsePower;
        private System.Windows.Forms.Label lblSpeeds;
        private System.Windows.Forms.NumericUpDown nudHorsePower;
        private System.Windows.Forms.NumericUpDown nudSpeedSettings;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.MaskedTextBox mtbLicensePlate;
        private System.Windows.Forms.Label lblInUseDate;
        private System.Windows.Forms.MaskedTextBox mtbInUseDate;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btRemoveCar;
        private System.Windows.Forms.Label lblRemoveCarPlate;
        private System.Windows.Forms.MaskedTextBox mtbFindLicensePlate;
        private System.Windows.Forms.ListBox lbCars;
    }
}

