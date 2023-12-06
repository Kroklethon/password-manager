using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;



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
                    int selectedIndex = lstPasswords.SelectedIndex;
                    passwordEntries[selectedIndex] = editForm.PasswordEntry;
                    DisplayEntries();
                }
            }
            else
            {
                MessageBox.Show("Please select an entry to edit.", "Edit Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select an entry to remove.", "Remove Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using(System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
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
    }
}
