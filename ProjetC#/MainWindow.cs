using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ProjetC_
{
    public partial class MainWindow : Form
    {
        private List<PasswordEntry> passwordEntries = new List<PasswordEntry>();
        private string hashedPassword = string.Empty;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            DisplayEntries();
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        public string HashedPassword
        {
            get { return hashedPassword; }
            set { hashedPassword = value; }
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
                ListViewItem item = new ListViewItem(entry.Entryname);
                item.SubItems.Add(entry.Website);
                item.SubItems.Add(entry.Username);
                item.SubItems.Add(entry.Password);
                item.Tag = entry;
                lstPasswords.Items.Add(item);
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
                passwordEntry.Entryname = addEntryForm.txtbx_entryname.Text;
                passwordEntries.Add(passwordEntry);
                DisplayEntries();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPasswords.SelectedItems.Count > 0)
            {
                // Assuming that each ListViewItem's Tag property holds a PasswordEntry object
                var selectedEntry = (PasswordEntry)lstPasswords.SelectedItems[0].Tag;

                var editForm = new AddEntryForm(selectedEntry);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the selected PasswordEntry with values from the edit form
                    selectedEntry.Website = editForm.txtbx_Url.Text;
                    selectedEntry.Username = editForm.txtbx_User.Text;
                    selectedEntry.Password = editForm.txtbx_Mdp.Text;
                    selectedEntry.Entryname = editForm.txtbx_entryname.Text;

                    // Update the corresponding ListViewItem in the ListView
                    lstPasswords.SelectedItems[0].SubItems[0].Text = selectedEntry.Entryname;
                    lstPasswords.SelectedItems[0].SubItems[1].Text = selectedEntry.Website;
                    lstPasswords.SelectedItems[0].SubItems[2].Text = selectedEntry.Username;
                    lstPasswords.SelectedItems[0].SubItems[3].Text = selectedEntry.Password;

                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entrée à modifier.", "Modifier une entrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPasswords.SelectedItems.Count > 0)
            {
                // Assuming that each ListViewItem's Tag property holds a PasswordEntry object
                var selectedEntry = (PasswordEntry)lstPasswords.SelectedItems[0].Tag;

                // Remove the selected PasswordEntry from the list
                passwordEntries.Remove(selectedEntry);

                // Remove the selected ListViewItem from the ListView
                lstPasswords.Items.Remove(lstPasswords.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entrée à supprimer.", "Supprimer une entrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
                    {
                        //Get half of the hashed password to create the key
                        aes.Key = Encoding.UTF8.GetBytes(hashedPassword.Substring(0, hashedPassword.Length / 2));
                        //Get quarter of the hashed password to create the initial vector
                        aes.IV = Encoding.UTF8.GetBytes(hashedPassword.Substring(0, hashedPassword.Length / 4));
                        XmlSerializer serializer = new XmlSerializer(typeof(List<PasswordEntry>));
                        using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                            {
                                serializer.Serialize(cryptoStream, passwordEntries);
                            }
                        }
                    }
                }
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (lstPasswords.SelectedItems.Count > 0)
            {
                AfficherMotDePasse afficherMotDePasser = new AfficherMotDePasse();
                afficherMotDePasser.lbl_name.Text = lstPasswords.SelectedItems[0].SubItems[0].Text;
                afficherMotDePasser.lbl_url.Text = lstPasswords.SelectedItems[0].SubItems[1].Text;
                afficherMotDePasser.lbl_user.Text = lstPasswords.SelectedItems[0].SubItems[2].Text;
                afficherMotDePasser.lbl_password.Text = lstPasswords.SelectedItems[0].SubItems[3].Text;
                afficherMotDePasser.ShowDialog();
                if (afficherMotDePasser.DialogResult == DialogResult.OK)
                {
                    afficherMotDePasser.Close();
                }
            }
        }
    }
}
