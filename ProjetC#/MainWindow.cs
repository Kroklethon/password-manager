﻿using System;
using System.Collections.Generic;
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
                passwordEntry.Website = addEntryForm.txtbx_Url.ToString();
                passwordEntry.Username = addEntryForm.txtbx_User.ToString();
                passwordEntry.Password = addEntryForm.txtbx_Mdp.ToString();
                passwordEntries.Add(passwordEntry);
                DisplayEntries();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {/*
            if (lstPasswords.SelectedItem != null)
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
    }
}
