using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetC_
{
    public partial class AddEntryForm : Form
    {
        public PasswordEntry PasswordEntry { get; internal set; }
        public AddEntryForm()
        {
            InitializeComponent();
        }
        public AddEntryForm(PasswordEntry entry)
        {
            InitializeComponent();
            PasswordEntry = entry;
            txtbx_Url.Text = entry.Website;
            txtbx_User.Text = entry.Username;
            txtbx_Mdp.Text = entry.Password;
            txtbx_entryname.Text = entry.Entryname;
            btn_add.Text = "Modifier";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordGenerator passwordGenerator = new PasswordGenerator();
            if(passwordGenerator.ShowDialog() == DialogResult.OK)
            {
                txtbx_Mdp.Text = passwordGenerator.label1.Text;
            }
        }
    }
}
