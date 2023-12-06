using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace ProjetC_
{
    public partial class MainWindow : Form
    {   private string filePath = "passwords.xml";
        private List<PasswordEntry> passwordEntries = new List<PasswordEntry>();
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        // Load password entries from XML file into passwordEntries list
        private void LoadPasswordEntriesFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<PasswordEntry>));

            using (TextReader reader = new StreamReader(filePath))
            {
                passwordEntries = (List<PasswordEntry>)serializer.Deserialize(reader);
            }
        }

        private void DisplayEntries()
        {
            lstPasswords.Items.Clear();
            foreach (var entry in passwordEntries)
            {
                ListViewItem listViewItem = lstPasswords.Items.Add(entry);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           /* var addForm = new AddEntryForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                passwordEntries.Add(addForm.PasswordEntry);
                DisplayEntries();
            }*/
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           /* if (lstPasswords.SelectedItem != null)
            {
                var selectedEntry = (PasswordEntry)lstPasswords.SelectedItem;
                var editForm = new AddEntryForm(selectedEntry);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    int selectedIndex = lstPasswords.SelectedIndex;
                    passwordEntries[selectedIndex] = editForm.PasswordEntry;
                    DisplayEntries();
                }
            }
            else
            {
                MessageBox.Show("Please select an entry to edit.", "Edit Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           /* if (lstPasswords.SelectedItem != null)
            {
                int selectedIndex = lstPasswords.SelectedIndex;
                passwordEntries.RemoveAt(selectedIndex);
                DisplayEntries();
            }
            else
            {
                MessageBox.Show("Please select an entry to remove.", "Remove Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        public class PasswordEntry
        {
            public string Website { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public override string ToString()
            {
                return $"Website: {Website}, Username: {Username}, Password: {Password}";
            }
        }
    }
}
