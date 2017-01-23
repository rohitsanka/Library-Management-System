namespace ThotaControls
{
    partial class ThotaFormControls
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
            this.AuthorcomboBox = new System.Windows.Forms.ComboBox();
            this.TitletextBox = new System.Windows.Forms.TextBox();
            this.PublishertextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodetextBox = new System.Windows.Forms.TextBox();
            this.SubjecttextBox = new System.Windows.Forms.TextBox();
            this.FictiontextBox = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.SubjectCodeLabel = new System.Windows.Forms.Label();
            this.Subjectlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorcomboBox
            // 
            this.AuthorcomboBox.FormattingEnabled = true;
            this.AuthorcomboBox.Location = new System.Drawing.Point(100, 22);
            this.AuthorcomboBox.Name = "AuthorcomboBox";
            this.AuthorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.AuthorcomboBox.TabIndex = 0;
            // 
            // TitletextBox
            // 
            this.TitletextBox.Location = new System.Drawing.Point(368, 23);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(100, 20);
            this.TitletextBox.TabIndex = 1;
            // 
            // PublishertextBox
            // 
            this.PublishertextBox.Location = new System.Drawing.Point(368, 63);
            this.PublishertextBox.Name = "PublishertextBox";
            this.PublishertextBox.Size = new System.Drawing.Size(100, 20);
            this.PublishertextBox.TabIndex = 2;
            // 
            // SubjectCodetextBox
            // 
            this.SubjectCodetextBox.Location = new System.Drawing.Point(368, 113);
            this.SubjectCodetextBox.Name = "SubjectCodetextBox";
            this.SubjectCodetextBox.Size = new System.Drawing.Size(100, 20);
            this.SubjectCodetextBox.TabIndex = 3;
            // 
            // SubjecttextBox
            // 
            this.SubjecttextBox.Location = new System.Drawing.Point(368, 160);
            this.SubjecttextBox.Name = "SubjecttextBox";
            this.SubjecttextBox.Size = new System.Drawing.Size(100, 20);
            this.SubjecttextBox.TabIndex = 4;
            // 
            // FictiontextBox
            // 
            this.FictiontextBox.Location = new System.Drawing.Point(368, 209);
            this.FictiontextBox.Name = "FictiontextBox";
            this.FictiontextBox.Size = new System.Drawing.Size(100, 20);
            this.FictiontextBox.TabIndex = 5;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(12, 26);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(71, 13);
            this.ISBNLabel.TabIndex = 6;
            this.ISBNLabel.Text = "Select Author";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(311, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Title";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(311, 64);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(50, 13);
            this.PublisherLabel.TabIndex = 8;
            this.PublisherLabel.Text = "Publisher";
            // 
            // SubjectCodeLabel
            // 
            this.SubjectCodeLabel.AutoSize = true;
            this.SubjectCodeLabel.Location = new System.Drawing.Point(290, 116);
            this.SubjectCodeLabel.Name = "SubjectCodeLabel";
            this.SubjectCodeLabel.Size = new System.Drawing.Size(71, 13);
            this.SubjectCodeLabel.TabIndex = 9;
            this.SubjectCodeLabel.Text = "Subject Code";
            // 
            // Subjectlabel
            // 
            this.Subjectlabel.AutoSize = true;
            this.Subjectlabel.Location = new System.Drawing.Point(311, 167);
            this.Subjectlabel.Name = "Subjectlabel";
            this.Subjectlabel.Size = new System.Drawing.Size(43, 13);
            this.Subjectlabel.TabIndex = 10;
            this.Subjectlabel.Text = "Subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fiction ?";
            // 
            // ThotaFormControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 308);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Subjectlabel);
            this.Controls.Add(this.SubjectCodeLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.FictiontextBox);
            this.Controls.Add(this.SubjecttextBox);
            this.Controls.Add(this.SubjectCodetextBox);
            this.Controls.Add(this.PublishertextBox);
            this.Controls.Add(this.TitletextBox);
            this.Controls.Add(this.AuthorcomboBox);
            this.Name = "ThotaFormControls";
            this.Text = "Thota Form Controls";
            this.Load += new System.EventHandler(this.ThotaFormControls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AuthorcomboBox;
        private System.Windows.Forms.TextBox TitletextBox;
        private System.Windows.Forms.TextBox PublishertextBox;
        private System.Windows.Forms.TextBox SubjectCodetextBox;
        private System.Windows.Forms.TextBox SubjecttextBox;
        private System.Windows.Forms.TextBox FictiontextBox;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label SubjectCodeLabel;
        private System.Windows.Forms.Label Subjectlabel;
        private System.Windows.Forms.Label label6;
    }
}

