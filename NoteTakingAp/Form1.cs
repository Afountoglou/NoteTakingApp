using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingAp
{
    public partial class NoteTaker : Form
    {

        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not a valid note"); }
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            noteTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteTextBox.Text;
            }
            else
            {
                notes.Rows.Add(titleTextBox.Text, noteTextBox.Text);
                titleTextBox.Text = "";
                noteTextBox.Text = "";
                editing = false;
            }
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
