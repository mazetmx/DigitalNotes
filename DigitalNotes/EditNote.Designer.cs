﻿namespace DigitalNotes
{
    partial class EditNote
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
            ReminderEnable = new CheckBox();
            CancelButton = new Button();
            ReminderDateLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            CategoryLabel = new Label();
            TitleTextBox = new TextBox();
            TitleLabel = new Label();
            ConfirmButton = new Button();
            categorySelectorv11 = new CategorySelectorv1();
            SuspendLayout();
            // 
            // ReminderEnable
            // 
            ReminderEnable.AutoSize = true;
            ReminderEnable.Location = new Point(203, 225);
            ReminderEnable.Margin = new Padding(3, 4, 3, 4);
            ReminderEnable.Name = "ReminderEnable";
            ReminderEnable.Size = new Size(18, 17);
            ReminderEnable.TabIndex = 17;
            ReminderEnable.UseVisualStyleBackColor = true;
            ReminderEnable.CheckedChanged += ReminderEnable_CheckedChanged;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(315, 293);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 44);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ReminderDateLabel
            // 
            ReminderDateLabel.AutoSize = true;
            ReminderDateLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReminderDateLabel.ForeColor = Color.White;
            ReminderDateLabel.Location = new Point(69, 220);
            ReminderDateLabel.Name = "ReminderDateLabel";
            ReminderDateLabel.Size = new Size(109, 24);
            ReminderDateLabel.TabIndex = 15;
            ReminderDateLabel.Text = "Reminder";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 220);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.MinDate = new DateTime(2025, 5, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryLabel.ForeColor = Color.White;
            CategoryLabel.Location = new Point(69, 149);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(101, 24);
            CategoryLabel.TabIndex = 12;
            CategoryLabel.Text = "Category";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(203, 60);
            TitleTextBox.Margin = new Padding(3, 4, 3, 4);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(228, 27);
            TitleTextBox.TabIndex = 11;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(69, 63);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(54, 24);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Title";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmButton.Location = new Point(168, 293);
            ConfirmButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(112, 44);
            ConfirmButton.TabIndex = 9;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // categorySelectorv11
            // 
            categorySelectorv11.CategorySelected = "";
            categorySelectorv11.Location = new Point(167, 107);
            categorySelectorv11.Name = "categorySelectorv11";
            categorySelectorv11.Size = new Size(438, 111);
            categorySelectorv11.TabIndex = 18;
            // 
            // EditNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(511, 383);
            Controls.Add(categorySelectorv11);
            Controls.Add(ReminderEnable);
            Controls.Add(CancelButton);
            Controls.Add(ReminderDateLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(CategoryLabel);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(ConfirmButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditNote";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ReminderEnable;
        private Button CancelButton;
        private Label ReminderDateLabel;
        private DateTimePicker dateTimePicker1;
        private Label CategoryLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private Button ConfirmButton;
        private CategorySelectorv1 categorySelectorv11;
    }
}