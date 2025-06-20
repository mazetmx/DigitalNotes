﻿using DigitalNotes.Data;
using DigitalNotes.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace DigitalNotes
{
    public partial class AddNote : Form
    {
        int userId;
        public DigitalNoteDbContext db { get; set; }
        public AddNote(int userId)
        {
            this.userId = userId;
            this.db = new DigitalNoteDbContext();
            InitializeComponent();
            addNoteCategorySelector.LoadCategories();
            this.dateTimePicker1.MinDate = DateTime.Today;
            this.dateTimePicker1.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string title = this.TitleTextBox.Text;
            string? categoryName = this.addNoteCategorySelector.CategorySelected;
            DateTime? reminderDate = this.dateTimePicker1.Value;
            Category category = null;
            int? CategoryId = null;
            if (title.Length == 0)
            {
                var popup = MessageBox.Show("Title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (categoryName.Length != 0)
            {
                category = db.Categories.SingleOrDefault(c => c.Name == categoryName);
                if (category == null)
                {
                    category = new Category() { Name = categoryName };
                    db.Categories.Add(category);
                    db.SaveChanges();
                }
                CategoryId = category.CategoryId;
            }

            if (!this.ReminderEnable.Checked)
            {
                reminderDate = null;
            }
            Note newNote = new Note() { Title = title, CategoryId = CategoryId, CreationDate = DateTime.Now, ReminderDate = reminderDate, UserId = userId };

            this.db.Add(newNote);
            this.db.SaveChanges();
            this.Close();
        }

        private void ReminderEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = this.ReminderEnable.Checked;
        }

        private void AddNote_Load(object sender, EventArgs e)
        {

        }

        private void categorySelectorv11_Load(object sender, EventArgs e)
        {

        }

        private void ReminderDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
