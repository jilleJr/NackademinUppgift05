﻿namespace NackademinUppgift05.UI
{
	partial class HomePage
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
			this.animalsListBox = new System.Windows.Forms.ListBox();
			this.animalCreateButton = new System.Windows.Forms.Button();
			this.animalDeleteButton = new System.Windows.Forms.Button();
			this.animalSearchTextBox = new System.Windows.Forms.TextBox();
			this.animalSearchBoxLabel = new System.Windows.Forms.Label();
			this.animalSearchButton = new System.Windows.Forms.Button();
			this.animalListLabel = new System.Windows.Forms.Label();
			this.animalSearchEaterTypesCheckBoxList = new System.Windows.Forms.CheckedListBox();
			this.animalSearchEnvironmentCheckBoxList = new System.Windows.Forms.CheckedListBox();
			this.animalEditButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// animalsListBox
			// 
			this.animalsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalsListBox.FormattingEnabled = true;
			this.animalsListBox.IntegralHeight = false;
			this.animalsListBox.Location = new System.Drawing.Point(12, 164);
			this.animalsListBox.Name = "animalsListBox";
			this.animalsListBox.Size = new System.Drawing.Size(432, 141);
			this.animalsListBox.TabIndex = 0;
			this.animalsListBox.SelectedIndexChanged += new System.EventHandler(this.animalsListBox_SelectedIndexChanged);
			this.animalsListBox.DoubleClick += new System.EventHandler(this.animalsListBox_DoubleClick);
			// 
			// animalCreateButton
			// 
			this.animalCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animalCreateButton.Location = new System.Drawing.Point(450, 164);
			this.animalCreateButton.Name = "animalCreateButton";
			this.animalCreateButton.Size = new System.Drawing.Size(103, 43);
			this.animalCreateButton.TabIndex = 1;
			this.animalCreateButton.Text = "New animal";
			this.animalCreateButton.UseVisualStyleBackColor = true;
			this.animalCreateButton.Click += new System.EventHandler(this.animalCreateButton_Click);
			// 
			// animalDeleteButton
			// 
			this.animalDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animalDeleteButton.Enabled = false;
			this.animalDeleteButton.Location = new System.Drawing.Point(450, 262);
			this.animalDeleteButton.Name = "animalDeleteButton";
			this.animalDeleteButton.Size = new System.Drawing.Size(103, 43);
			this.animalDeleteButton.TabIndex = 2;
			this.animalDeleteButton.Text = "Delete animal";
			this.animalDeleteButton.UseVisualStyleBackColor = true;
			this.animalDeleteButton.Click += new System.EventHandler(this.animalDeleteButton_Click);
			// 
			// animalSearchTextBox
			// 
			this.animalSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalSearchTextBox.Location = new System.Drawing.Point(12, 29);
			this.animalSearchTextBox.Name = "animalSearchTextBox";
			this.animalSearchTextBox.Size = new System.Drawing.Size(432, 20);
			this.animalSearchTextBox.TabIndex = 3;
			// 
			// animalSearchBoxLabel
			// 
			this.animalSearchBoxLabel.AutoSize = true;
			this.animalSearchBoxLabel.Location = new System.Drawing.Point(13, 13);
			this.animalSearchBoxLabel.Name = "animalSearchBoxLabel";
			this.animalSearchBoxLabel.Size = new System.Drawing.Size(41, 13);
			this.animalSearchBoxLabel.TabIndex = 4;
			this.animalSearchBoxLabel.Text = "Search";
			// 
			// animalSearchButton
			// 
			this.animalSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animalSearchButton.Location = new System.Drawing.Point(450, 29);
			this.animalSearchButton.Name = "animalSearchButton";
			this.animalSearchButton.Size = new System.Drawing.Size(103, 117);
			this.animalSearchButton.TabIndex = 5;
			this.animalSearchButton.Text = "Search";
			this.animalSearchButton.UseVisualStyleBackColor = true;
			this.animalSearchButton.Click += new System.EventHandler(this.animalSearchButton_Click);
			// 
			// animalListLabel
			// 
			this.animalListLabel.AutoSize = true;
			this.animalListLabel.Location = new System.Drawing.Point(13, 148);
			this.animalListLabel.Name = "animalListLabel";
			this.animalListLabel.Size = new System.Drawing.Size(43, 13);
			this.animalListLabel.TabIndex = 6;
			this.animalListLabel.Text = "Animals";
			// 
			// animalSearchEaterTypesCheckBoxList
			// 
			this.animalSearchEaterTypesCheckBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalSearchEaterTypesCheckBoxList.FormattingEnabled = true;
			this.animalSearchEaterTypesCheckBoxList.Location = new System.Drawing.Point(12, 56);
			this.animalSearchEaterTypesCheckBoxList.Name = "animalSearchEaterTypesCheckBoxList";
			this.animalSearchEaterTypesCheckBoxList.Size = new System.Drawing.Size(432, 34);
			this.animalSearchEaterTypesCheckBoxList.TabIndex = 7;
			// 
			// animalSearchEnvironmentCheckBoxList
			// 
			this.animalSearchEnvironmentCheckBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animalSearchEnvironmentCheckBoxList.FormattingEnabled = true;
			this.animalSearchEnvironmentCheckBoxList.Location = new System.Drawing.Point(12, 96);
			this.animalSearchEnvironmentCheckBoxList.Name = "animalSearchEnvironmentCheckBoxList";
			this.animalSearchEnvironmentCheckBoxList.Size = new System.Drawing.Size(432, 49);
			this.animalSearchEnvironmentCheckBoxList.TabIndex = 8;
			// 
			// animalEditButton
			// 
			this.animalEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animalEditButton.Enabled = false;
			this.animalEditButton.Location = new System.Drawing.Point(450, 213);
			this.animalEditButton.Name = "animalEditButton";
			this.animalEditButton.Size = new System.Drawing.Size(103, 43);
			this.animalEditButton.TabIndex = 9;
			this.animalEditButton.Text = "Change animal";
			this.animalEditButton.UseVisualStyleBackColor = true;
			this.animalEditButton.Click += new System.EventHandler(this.animalEditButton_Click);
			// 
			// HomePage
			// 
			this.AcceptButton = this.animalSearchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 316);
			this.Controls.Add(this.animalEditButton);
			this.Controls.Add(this.animalSearchEnvironmentCheckBoxList);
			this.Controls.Add(this.animalSearchEaterTypesCheckBoxList);
			this.Controls.Add(this.animalListLabel);
			this.Controls.Add(this.animalSearchButton);
			this.Controls.Add(this.animalSearchBoxLabel);
			this.Controls.Add(this.animalSearchTextBox);
			this.Controls.Add(this.animalDeleteButton);
			this.Controls.Add(this.animalCreateButton);
			this.Controls.Add(this.animalsListBox);
			this.MinimumSize = new System.Drawing.Size(330, 355);
			this.Name = "HomePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zoophobia";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox animalsListBox;
		private System.Windows.Forms.Button animalCreateButton;
		private System.Windows.Forms.Button animalDeleteButton;
		private System.Windows.Forms.TextBox animalSearchTextBox;
		private System.Windows.Forms.Label animalSearchBoxLabel;
		private System.Windows.Forms.Button animalSearchButton;
		private System.Windows.Forms.Label animalListLabel;
		private System.Windows.Forms.CheckedListBox animalSearchEaterTypesCheckBoxList;
		private System.Windows.Forms.CheckedListBox animalSearchEnvironmentCheckBoxList;
		private System.Windows.Forms.Button animalEditButton;
	}
}

