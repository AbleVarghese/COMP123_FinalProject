namespace FinalProject
{
    partial class SelectionForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MovieSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.GroupBox_SelectionForm = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovieCostLabel = new System.Windows.Forms.Label();
            this.MovieCategoryLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieCostTextBox = new System.Windows.Forms.TextBox();
            this.MovieCategoryTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.GroupBox_SelectionForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieSelectionComboBox
            // 
            this.MovieSelectionComboBox.FormattingEnabled = true;
            this.MovieSelectionComboBox.Location = new System.Drawing.Point(19, 68);
            this.MovieSelectionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MovieSelectionComboBox.Name = "MovieSelectionComboBox";
            this.MovieSelectionComboBox.Size = new System.Drawing.Size(227, 24);
            this.MovieSelectionComboBox.Sorted = true;
            this.MovieSelectionComboBox.TabIndex = 1;
            this.MovieSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GroupBox_SelectionForm
            // 
            this.GroupBox_SelectionForm.Controls.Add(this.pictureBox1);
            this.GroupBox_SelectionForm.Controls.Add(this.MovieCostLabel);
            this.GroupBox_SelectionForm.Controls.Add(this.MovieCategoryLabel);
            this.GroupBox_SelectionForm.Controls.Add(this.MovieTitleLabel);
            this.GroupBox_SelectionForm.Controls.Add(this.MovieCostTextBox);
            this.GroupBox_SelectionForm.Controls.Add(this.MovieCategoryTextBox);
            this.GroupBox_SelectionForm.Controls.Add(this.MovieTitleTextBox);
            this.GroupBox_SelectionForm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_SelectionForm.Location = new System.Drawing.Point(16, 119);
            this.GroupBox_SelectionForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_SelectionForm.Name = "GroupBox_SelectionForm";
            this.GroupBox_SelectionForm.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_SelectionForm.Size = new System.Drawing.Size(591, 334);
            this.GroupBox_SelectionForm.TabIndex = 2;
            this.GroupBox_SelectionForm.TabStop = false;
            this.GroupBox_SelectionForm.Text = "Your Selection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.waitingforever;
            this.pictureBox1.Location = new System.Drawing.Point(316, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MovieCostLabel
            // 
            this.MovieCostLabel.AutoSize = true;
            this.MovieCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCostLabel.Location = new System.Drawing.Point(32, 263);
            this.MovieCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieCostLabel.Name = "MovieCostLabel";
            this.MovieCostLabel.Size = new System.Drawing.Size(87, 17);
            this.MovieCostLabel.TabIndex = 2;
            this.MovieCostLabel.Text = "Movie Cost";
            // 
            // MovieCategoryLabel
            // 
            this.MovieCategoryLabel.AutoSize = true;
            this.MovieCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCategoryLabel.Location = new System.Drawing.Point(-1, 231);
            this.MovieCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieCategoryLabel.Name = "MovieCategoryLabel";
            this.MovieCategoryLabel.Size = new System.Drawing.Size(120, 17);
            this.MovieCategoryLabel.TabIndex = 2;
            this.MovieCategoryLabel.Text = "Movie Category";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(32, 199);
            this.MovieTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(87, 17);
            this.MovieTitleLabel.TabIndex = 2;
            this.MovieTitleLabel.Text = "Movie Title";
            // 
            // MovieCostTextBox
            // 
            this.MovieCostTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCostTextBox.Location = new System.Drawing.Point(133, 260);
            this.MovieCostTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MovieCostTextBox.Name = "MovieCostTextBox";
            this.MovieCostTextBox.ReadOnly = true;
            this.MovieCostTextBox.Size = new System.Drawing.Size(173, 27);
            this.MovieCostTextBox.TabIndex = 1;
            // 
            // MovieCategoryTextBox
            // 
            this.MovieCategoryTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCategoryTextBox.Location = new System.Drawing.Point(133, 228);
            this.MovieCategoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MovieCategoryTextBox.Name = "MovieCategoryTextBox";
            this.MovieCategoryTextBox.ReadOnly = true;
            this.MovieCategoryTextBox.Size = new System.Drawing.Size(173, 27);
            this.MovieCategoryTextBox.TabIndex = 1;
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleTextBox.Location = new System.Drawing.Point(133, 196);
            this.MovieTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(173, 27);
            this.MovieTitleTextBox.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(401, 478);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(136, 42);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.Nextbutton1_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 534);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GroupBox_SelectionForm);
            this.Controls.Add(this.MovieSelectionComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionForm";
            this.GroupBox_SelectionForm.ResumeLayout(false);
            this.GroupBox_SelectionForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox MovieSelectionComboBox;
        private System.Windows.Forms.GroupBox GroupBox_SelectionForm;
        private System.Windows.Forms.Label MovieCostLabel;
        private System.Windows.Forms.Label MovieCategoryLabel;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.TextBox MovieCostTextBox;
        private System.Windows.Forms.TextBox MovieCategoryTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NextButton;

    }
}