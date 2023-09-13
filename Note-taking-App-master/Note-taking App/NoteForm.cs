using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using NoteTakingApp.Data;
using System.IO;

namespace NoteTakingApp
{
    public partial class NoteForm : Form
    {
        DataTable table;
        List<NoteEntry> noteEntries;

        public NoteForm()
        {
            InitializeComponent();

            // disable scaling
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Attach the FormClosing event handler
            this.FormClosing += NoteForm_FormClosing;
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            savedNotesTable.DataSource = table;

            savedNotesTable.Columns["Messages"].Visible = false;

            savedNotesTable.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            savedNotesTable.Columns["Title"].FillWeight = 100;

            // Load the data from the JSON file
            LoadDataFromJsonFile();
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the data to the JSON file
            SaveDataToJsonFile();
        }

        private void LoadDataFromJsonFile()
        {
            string filePath = "storage.json";

            if (!File.Exists(filePath))
            {
                // File doesn't exist, create a new one with an empty array
                File.WriteAllText(filePath, "[]");
            }

            string json = File.ReadAllText("storage.json");
            noteEntries = JsonConvert.DeserializeObject<List<NoteEntry>>(json);

            // Clear the DataTable
            table.Rows.Clear();

            // Add the data from noteEntries to the DataTable
            foreach (NoteEntry entry in noteEntries)
            {
                table.Rows.Add(entry.Title, entry.Message);
            }
        }

        private void SaveDataToJsonFile()
        {
            noteEntries = new List<NoteEntry>();

            // Retrieve the data from the savedNotesTable and populate noteEntries
            foreach (DataGridViewRow row in savedNotesTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    NoteEntry entry = new NoteEntry
                    {
                        Title = row.Cells["Title"].Value.ToString(),
                        Message = row.Cells["Messages"].Value.ToString()
                    };
                    noteEntries.Add(entry);
                }
            }

            // Serialize noteEntries to JSON
            string json = JsonConvert.SerializeObject(noteEntries, Formatting.Indented);

            // Write the JSON data to the file
            File.WriteAllText("storage.json", json);
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            TitleEntryBox.Clear();
            MessageEntryBox.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string title = TitleEntryBox.Text.Trim();
            string message = MessageEntryBox.Text.Trim();

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(message))
            {
                table.Rows.Add(title, message);

                TitleEntryBox.Clear();
                MessageEntryBox.Clear();
            }
            else
            {
                MessageBox.Show("Both title and message fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No notes available to read.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = savedNotesTable.CurrentCell.RowIndex;

                TitleEntryBox.Clear();
                MessageEntryBox.Clear();

                TitleEntryBox.Text = table.Rows[index].ItemArray[0].ToString();
                MessageEntryBox.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No notes available to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TitleEntryBox.Clear();
                MessageEntryBox.Clear();

                int selectedRowIndex = savedNotesTable.CurrentCell.RowIndex;

                savedNotesTable.Rows.RemoveAt(selectedRowIndex);

                if (savedNotesTable.Rows.Count > 0)
                {
                    if (selectedRowIndex >= savedNotesTable.Rows.Count)
                    {
                        savedNotesTable.Rows[savedNotesTable.Rows.Count - 1].Selected = true;
                    }
                    else
                    {
                        savedNotesTable.Rows[selectedRowIndex].Selected = true;
                    }
                }
            }
        }

        private void savedNotesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
