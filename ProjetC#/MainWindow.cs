using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace ProjetC_
{
    public partial class MainWindow : Form
    {
        private List<PasswordEntry> passwordEntries = new List<PasswordEntry>();

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DisplayEntries();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetPasswordEntries(List<PasswordEntry> passwordEntries)
        {
            this.passwordEntries = passwordEntries;
        }

        private void DisplayEntries()
        {
            lstPasswords.Items.Clear();
            //load the password entries into the list box
            foreach (var entry in passwordEntries)
            {
                lstPasswords.Items.Add(entry);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEntryForm addEntryForm = new AddEntryForm();
            if (addEntryForm.ShowDialog() == DialogResult.OK)
            {
                PasswordEntry passwordEntry = new PasswordEntry();
                passwordEntry.Website = addEntryForm.txtbx_Url.Text;
                passwordEntry.Username = addEntryForm.txtbx_User.Text;
                passwordEntry.Password = addEntryForm.txtbx_Mdp.Text;
                passwordEntries.Add(passwordEntry);
                DisplayEntries();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPasswords.SelectedItem != null)
            {
                var selectedEntry = (PasswordEntry)lstPasswords.SelectedItem;
                var editForm = new AddEntryForm(selectedEntry);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    editForm.PasswordEntry.Website = editForm.txtbx_Url.Text;
                    editForm.PasswordEntry.Username = editForm.txtbx_User.Text; 
                    editForm.PasswordEntry.Password = editForm.txtbx_Mdp.Text;
                    int selectedIndex = lstPasswords.SelectedIndex;
                    passwordEntries[selectedIndex] = editForm.PasswordEntry;
                    DisplayEntries();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entrée à modifier.", "Modifier une entrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
             if (lstPasswords.SelectedItem != null)
             {
                var selectedEntry = (PasswordEntry)lstPasswords.SelectedItem;
                    passwordEntries.Remove(selectedEntry);
                    DisplayEntries();
             }
             else
             {
                    MessageBox.Show("Veuillez sélectionner une entrée à supprimer.", "Supprimer une entrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
                
        }
    }
}
