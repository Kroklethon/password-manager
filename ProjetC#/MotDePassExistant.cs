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
    public partial class MotDePassExistant : Form
    {
        public event EventHandler ButtonClicked;
        public MotDePassExistant()
        {
            InitializeComponent();
        }

        // De/Affichage du mot de passe
        private void btn_show_Click(object sender, EventArgs e)
        {
            txtbxPassword.UseSystemPasswordChar = !txtbxPassword.UseSystemPasswordChar;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
