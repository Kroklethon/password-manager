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
            txtbx_Url.Text = entry.Website;
            txtbx_User.Text = entry.Username;
            txtbx_Mdp.Text = entry.Password;
            btn_add.Text = "Modifier";
        }

        
    }
}
