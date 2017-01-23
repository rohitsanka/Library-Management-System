namespace SankaWeek15DBApplication
{
    partial class rnrForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.TitletTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.ShelfLocationTextBox = new System.Windows.Forms.TextBox();
            this.FictionComboBox = new System.Windows.Forms.ComboBox();
            this.InsertRowButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.UbdataDatabaseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shelf Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiction";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(290, 36);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNTextBox.TabIndex = 7;
            // 
            // TitletTextBox
            // 
            this.TitletTextBox.Location = new System.Drawing.Point(290, 93);
            this.TitletTextBox.Name = "TitletTextBox";
            this.TitletTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitletTextBox.TabIndex = 8;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(290, 142);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorTextBox.TabIndex = 9;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(290, 234);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubjectCodeTextBox.TabIndex = 10;
            // 
            // ShelfLocationTextBox
            // 
            this.ShelfLocationTextBox.Location = new System.Drawing.Point(290, 284);
            this.ShelfLocationTextBox.Name = "ShelfLocationTextBox";
            this.ShelfLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShelfLocationTextBox.TabIndex = 11;
            // 
            // FictionComboBox
            // 
            this.FictionComboBox.FormattingEnabled = true;
            this.FictionComboBox.Location = new System.Drawing.Point(269, 341);
            this.FictionComboBox.Name = "FictionComboBox";
            this.FictionComboBox.Size = new System.Drawing.Size(121, 21);
            this.FictionComboBox.TabIndex = 12;
            // 
            // InsertRowButton
            // 
            this.InsertRowButton.Location = new System.Drawing.Point(315, 390);
            this.InsertRowButton.Name = "InsertRowButton";
            this.InsertRowButton.Size = new System.Drawing.Size(75, 23);
            this.InsertRowButton.TabIndex = 13;
            this.InsertRowButton.Text = "Insert Row";
            this.InsertRowButton.UseVisualStyleBackColor = true;
            this.InsertRowButton.Click += new System.EventHandler(this.InsertRowButton_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(91, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 61);
            this.label8.TabIndex = 14;
            // 
            // UbdataDatabaseButton
            // 
            this.UbdataDatabaseButton.Location = new System.Drawing.Point(989, 389);
            this.UbdataDatabaseButton.Name = "UbdataDatabaseButton";
            this.UbdataDatabaseButton.Size = new System.Drawing.Size(75, 23);
            this.UbdataDatabaseButton.TabIndex = 15;
            this.UbdataDatabaseButton.Text = "Update Database";
            this.UbdataDatabaseButton.UseVisualStyleBackColor = true;
            this.UbdataDatabaseButton.Click += new System.EventHandler(this.UbdataDatabaseButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(568, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 326);
            this.dataGridView1.TabIndex = 16;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(290, 185);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.PublisherTextBox.TabIndex = 17;
            // 
            // errorLabel1
            // 
            this.errorLabel1.Location = new System.Drawing.Point(236, 431);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(244, 47);
            this.errorLabel1.TabIndex = 18;
            // 
            // rnrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 510);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UbdataDatabaseButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InsertRowButton);
            this.Controls.Add(this.FictionComboBox);
            this.Controls.Add(this.ShelfLocationTextBox);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.TitletTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rnrForm";
            this.Text = "rnr Books";
            this.Load += new System.EventHandler(this.rnrForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox TitletTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.TextBox ShelfLocationTextBox;
        private System.Windows.Forms.ComboBox FictionComboBox;
        private System.Windows.Forms.Button InsertRowButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UbdataDatabaseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.Label errorLabel1;
    }
}

