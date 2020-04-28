namespace IMBD
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
            this.components = new System.ComponentModel.Container();
            this.rbMovie = new System.Windows.Forms.RadioButton();
            this.rbSeries = new System.Windows.Forms.RadioButton();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.gbMovie = new System.Windows.Forms.GroupBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.mtbDirectorBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.nudReleaseYear = new System.Windows.Forms.NumericUpDown();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.tbProducer = new System.Windows.Forms.TextBox();
            this.lblDirectorSex = new System.Windows.Forms.Label();
            this.tbDirectorFirstName = new System.Windows.Forms.TextBox();
            this.cbDirectorSex = new System.Windows.Forms.ComboBox();
            this.tbDirectorLastName = new System.Windows.Forms.TextBox();
            this.lblDirectorBirthDate = new System.Windows.Forms.Label();
            this.lblDirectorFirstName = new System.Windows.Forms.Label();
            this.lblDirectorLastName = new System.Windows.Forms.Label();
            this.btAddMedia = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSeries = new System.Windows.Forms.GroupBox();
            this.nudSeasons = new System.Windows.Forms.NumericUpDown();
            this.lblSeasons = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbMedia = new System.Windows.Forms.ComboBox();
            this.btAddRating = new System.Windows.Forms.Button();
            this.gbRating = new System.Windows.Forms.GroupBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.lblMedia = new System.Windows.Forms.Label();
            this.tbAverageRating = new System.Windows.Forms.TextBox();
            this.lblAverge = new System.Windows.Forms.Label();
            this.gbMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReleaseYear)).BeginInit();
            this.gbSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasons)).BeginInit();
            this.gbRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMovie
            // 
            this.rbMovie.AutoSize = true;
            this.rbMovie.Checked = true;
            this.rbMovie.Location = new System.Drawing.Point(12, 12);
            this.rbMovie.Name = "rbMovie";
            this.rbMovie.Size = new System.Drawing.Size(54, 17);
            this.rbMovie.TabIndex = 0;
            this.rbMovie.TabStop = true;
            this.rbMovie.Text = "Movie";
            this.rbMovie.UseVisualStyleBackColor = true;
            this.rbMovie.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbSeries
            // 
            this.rbSeries.AutoSize = true;
            this.rbSeries.Location = new System.Drawing.Point(12, 35);
            this.rbSeries.Name = "rbSeries";
            this.rbSeries.Size = new System.Drawing.Size(54, 17);
            this.rbSeries.TabIndex = 1;
            this.rbSeries.TabStop = true;
            this.rbSeries.Text = "Series";
            this.rbSeries.UseVisualStyleBackColor = true;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(120, 32);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // gbMovie
            // 
            this.gbMovie.Controls.Add(this.lblDirector);
            this.gbMovie.Controls.Add(this.mtbDirectorBirthDate);
            this.gbMovie.Controls.Add(this.nudReleaseYear);
            this.gbMovie.Controls.Add(this.lblReleaseYear);
            this.gbMovie.Controls.Add(this.lblProducer);
            this.gbMovie.Controls.Add(this.lblGenre);
            this.gbMovie.Controls.Add(this.cbGenres);
            this.gbMovie.Controls.Add(this.tbProducer);
            this.gbMovie.Controls.Add(this.lblDirectorSex);
            this.gbMovie.Controls.Add(this.tbDirectorFirstName);
            this.gbMovie.Controls.Add(this.cbDirectorSex);
            this.gbMovie.Controls.Add(this.tbDirectorLastName);
            this.gbMovie.Controls.Add(this.lblDirectorBirthDate);
            this.gbMovie.Controls.Add(this.lblDirectorFirstName);
            this.gbMovie.Controls.Add(this.lblDirectorLastName);
            this.gbMovie.Location = new System.Drawing.Point(2, 70);
            this.gbMovie.Name = "gbMovie";
            this.gbMovie.Size = new System.Drawing.Size(440, 117);
            this.gbMovie.TabIndex = 3;
            this.gbMovie.TabStop = false;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(230, 16);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 21;
            this.lblDirector.Text = "Director";
            // 
            // mtbDirectorBirthDate
            // 
            this.mtbDirectorBirthDate.Location = new System.Drawing.Point(233, 95);
            this.mtbDirectorBirthDate.Mask = "00/00/0000";
            this.mtbDirectorBirthDate.Name = "mtbDirectorBirthDate";
            this.mtbDirectorBirthDate.Size = new System.Drawing.Size(100, 20);
            this.mtbDirectorBirthDate.TabIndex = 20;
            this.mtbDirectorBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // nudReleaseYear
            // 
            this.nudReleaseYear.Location = new System.Drawing.Point(111, 96);
            this.nudReleaseYear.Maximum = new decimal(new int[] {
            1895,
            0,
            0,
            0});
            this.nudReleaseYear.Minimum = new decimal(new int[] {
            1895,
            0,
            0,
            0});
            this.nudReleaseYear.Name = "nudReleaseYear";
            this.nudReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.nudReleaseYear.TabIndex = 19;
            this.nudReleaseYear.Value = new decimal(new int[] {
            1895,
            0,
            0,
            0});
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Location = new System.Drawing.Point(108, 82);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(71, 13);
            this.lblReleaseYear.TabIndex = 18;
            this.lblReleaseYear.Text = "Release Year";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(108, 40);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(50, 13);
            this.lblProducer.TabIndex = 17;
            this.lblProducer.Text = "Producer";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(2, 40);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // cbGenres
            // 
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Location = new System.Drawing.Point(5, 55);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(100, 21);
            this.cbGenres.TabIndex = 4;
            // 
            // tbProducer
            // 
            this.tbProducer.Location = new System.Drawing.Point(111, 56);
            this.tbProducer.Name = "tbProducer";
            this.tbProducer.Size = new System.Drawing.Size(100, 20);
            this.tbProducer.TabIndex = 5;
            this.tbProducer.Leave += new System.EventHandler(this.tbProducer_Leave);
            // 
            // lblDirectorSex
            // 
            this.lblDirectorSex.AutoSize = true;
            this.lblDirectorSex.Location = new System.Drawing.Point(336, 82);
            this.lblDirectorSex.Name = "lblDirectorSex";
            this.lblDirectorSex.Size = new System.Drawing.Size(25, 13);
            this.lblDirectorSex.TabIndex = 15;
            this.lblDirectorSex.Text = "Sex";
            // 
            // tbDirectorFirstName
            // 
            this.tbDirectorFirstName.Location = new System.Drawing.Point(233, 56);
            this.tbDirectorFirstName.Name = "tbDirectorFirstName";
            this.tbDirectorFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbDirectorFirstName.TabIndex = 11;
            // 
            // cbDirectorSex
            // 
            this.cbDirectorSex.FormattingEnabled = true;
            this.cbDirectorSex.Location = new System.Drawing.Point(339, 95);
            this.cbDirectorSex.Name = "cbDirectorSex";
            this.cbDirectorSex.Size = new System.Drawing.Size(100, 21);
            this.cbDirectorSex.TabIndex = 14;
            // 
            // tbDirectorLastName
            // 
            this.tbDirectorLastName.Location = new System.Drawing.Point(339, 56);
            this.tbDirectorLastName.Name = "tbDirectorLastName";
            this.tbDirectorLastName.Size = new System.Drawing.Size(100, 20);
            this.tbDirectorLastName.TabIndex = 13;
            // 
            // lblDirectorBirthDate
            // 
            this.lblDirectorBirthDate.AutoSize = true;
            this.lblDirectorBirthDate.Location = new System.Drawing.Point(230, 82);
            this.lblDirectorBirthDate.Name = "lblDirectorBirthDate";
            this.lblDirectorBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblDirectorBirthDate.TabIndex = 10;
            this.lblDirectorBirthDate.Text = "Birth Date";
            // 
            // lblDirectorFirstName
            // 
            this.lblDirectorFirstName.AutoSize = true;
            this.lblDirectorFirstName.Location = new System.Drawing.Point(230, 38);
            this.lblDirectorFirstName.Name = "lblDirectorFirstName";
            this.lblDirectorFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblDirectorFirstName.TabIndex = 8;
            this.lblDirectorFirstName.Text = "First Name";
            // 
            // lblDirectorLastName
            // 
            this.lblDirectorLastName.AutoSize = true;
            this.lblDirectorLastName.Location = new System.Drawing.Point(336, 40);
            this.lblDirectorLastName.Name = "lblDirectorLastName";
            this.lblDirectorLastName.Size = new System.Drawing.Size(58, 13);
            this.lblDirectorLastName.TabIndex = 9;
            this.lblDirectorLastName.Text = "Last Name";
            // 
            // btAddMedia
            // 
            this.btAddMedia.Location = new System.Drawing.Point(2, 193);
            this.btAddMedia.Name = "btAddMedia";
            this.btAddMedia.Size = new System.Drawing.Size(100, 23);
            this.btAddMedia.TabIndex = 4;
            this.btAddMedia.Text = "Add Movie";
            this.btAddMedia.UseVisualStyleBackColor = true;
            this.btAddMedia.Click += new System.EventHandler(this.btAddMedia_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(118, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Title";
            // 
            // gbSeries
            // 
            this.gbSeries.Controls.Add(this.nudSeasons);
            this.gbSeries.Controls.Add(this.lblSeasons);
            this.gbSeries.Location = new System.Drawing.Point(226, 7);
            this.gbSeries.Name = "gbSeries";
            this.gbSeries.Size = new System.Drawing.Size(109, 57);
            this.gbSeries.TabIndex = 17;
            this.gbSeries.TabStop = false;
            this.gbSeries.Visible = false;
            // 
            // nudSeasons
            // 
            this.nudSeasons.Location = new System.Drawing.Point(0, 25);
            this.nudSeasons.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSeasons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeasons.Name = "nudSeasons";
            this.nudSeasons.Size = new System.Drawing.Size(100, 20);
            this.nudSeasons.TabIndex = 21;
            this.nudSeasons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSeasons
            // 
            this.lblSeasons.AutoSize = true;
            this.lblSeasons.Location = new System.Drawing.Point(-3, 9);
            this.lblSeasons.Name = "lblSeasons";
            this.lblSeasons.Size = new System.Drawing.Size(48, 13);
            this.lblSeasons.TabIndex = 18;
            this.lblSeasons.Text = "Seasons";
            // 
            // cbMedia
            // 
            this.cbMedia.FormattingEnabled = true;
            this.cbMedia.Location = new System.Drawing.Point(0, 79);
            this.cbMedia.Name = "cbMedia";
            this.cbMedia.Size = new System.Drawing.Size(121, 21);
            this.cbMedia.TabIndex = 18;
            // 
            // btAddRating
            // 
            this.btAddRating.Location = new System.Drawing.Point(0, 19);
            this.btAddRating.Name = "btAddRating";
            this.btAddRating.Size = new System.Drawing.Size(100, 23);
            this.btAddRating.TabIndex = 19;
            this.btAddRating.Text = "Add Rating";
            this.btAddRating.UseVisualStyleBackColor = true;
            this.btAddRating.Click += new System.EventHandler(this.btAddRating_Click);
            // 
            // gbRating
            // 
            this.gbRating.Controls.Add(this.lblAverge);
            this.gbRating.Controls.Add(this.tbAverageRating);
            this.gbRating.Controls.Add(this.lblRating);
            this.gbRating.Controls.Add(this.nudRating);
            this.gbRating.Controls.Add(this.lblMedia);
            this.gbRating.Controls.Add(this.btAddRating);
            this.gbRating.Controls.Add(this.cbMedia);
            this.gbRating.Location = new System.Drawing.Point(2, 239);
            this.gbRating.Name = "gbRating";
            this.gbRating.Size = new System.Drawing.Size(261, 100);
            this.gbRating.TabIndex = 20;
            this.gbRating.TabStop = false;
            this.gbRating.Text = "Rating";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(138, 64);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 22;
            this.lblRating.Text = "Rating";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 2;
            this.nudRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRating.Location = new System.Drawing.Point(141, 80);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 20);
            this.nudRating.TabIndex = 21;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(-3, 63);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 20;
            this.lblMedia.Text = "Media";
            // 
            // tbAverageRating
            // 
            this.tbAverageRating.Location = new System.Drawing.Point(141, 22);
            this.tbAverageRating.Name = "tbAverageRating";
            this.tbAverageRating.ReadOnly = true;
            this.tbAverageRating.Size = new System.Drawing.Size(120, 20);
            this.tbAverageRating.TabIndex = 21;
            // 
            // lblAverge
            // 
            this.lblAverge.AutoSize = true;
            this.lblAverge.Location = new System.Drawing.Point(138, 6);
            this.lblAverge.Name = "lblAverge";
            this.lblAverge.Size = new System.Drawing.Size(76, 13);
            this.lblAverge.TabIndex = 23;
            this.lblAverge.Text = "Average rating";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRating);
            this.Controls.Add(this.gbSeries);
            this.Controls.Add(this.gbMovie);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btAddMedia);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rbSeries);
            this.Controls.Add(this.rbMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.gbMovie.ResumeLayout(false);
            this.gbMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReleaseYear)).EndInit();
            this.gbSeries.ResumeLayout(false);
            this.gbSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasons)).EndInit();
            this.gbRating.ResumeLayout(false);
            this.gbRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMovie;
        private System.Windows.Forms.RadioButton rbSeries;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox gbMovie;
        private System.Windows.Forms.Label lblDirectorSex;
        private System.Windows.Forms.ComboBox cbDirectorSex;
        private System.Windows.Forms.Label lblDirectorBirthDate;
        private System.Windows.Forms.Label lblDirectorLastName;
        private System.Windows.Forms.Label lblDirectorFirstName;
        private System.Windows.Forms.TextBox tbDirectorLastName;
        private System.Windows.Forms.TextBox tbDirectorFirstName;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btAddMedia;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.TextBox tbProducer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSeries;
        private System.Windows.Forms.Label lblSeasons;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown nudReleaseYear;
        private System.Windows.Forms.MaskedTextBox mtbDirectorBirthDate;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.ComboBox cbMedia;
        private System.Windows.Forms.Button btAddRating;
        private System.Windows.Forms.GroupBox gbRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.NumericUpDown nudSeasons;
        private System.Windows.Forms.Label lblAverge;
        private System.Windows.Forms.TextBox tbAverageRating;
    }
}

