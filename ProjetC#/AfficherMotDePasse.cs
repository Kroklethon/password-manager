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
    public partial class AfficherMotDePasse : Form
    {
        public AfficherMotDePasse()
        {
            InitializeComponent();
        }

        private void Btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_password.Text);
            btn_copy.Text = "Copié !";

        }

        private void AfficherMotDePasse_Load(object sender, EventArgs e)
        {

        }
    }
}
