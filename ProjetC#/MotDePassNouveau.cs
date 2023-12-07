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
    public partial class MotDePassNouveau : Form
    {
        // 0 = pas changé, 1 = match, 2 = pas de match, 3 = vide, 4 = Trop court
        public int mdpMatch = 0;
        public MotDePassNouveau()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (txtbxPassword.Text != txtbxPassword_confirm.Text)
            {
                mdpMatch = 2;
                lbl_mdp_incorrect.Visible = true;
                lbl_mdp_incorrect.Text = "Les mots de passe ne correspondent pas !";
                
            }
            else if (String.IsNullOrWhiteSpace(txtbxPassword.Text) || String.IsNullOrWhiteSpace(txtbxPassword_confirm.Text))
            {
                mdpMatch = 3;
                lbl_mdp_incorrect.Visible = true;
                lbl_mdp_incorrect.Text = "Le mot de passe ne peut pas être vide !";
            }
            else if (txtbxPassword.Text.Length < 8)
            {
                mdpMatch = 4;
                
                lbl_mdp_incorrect.Text = "Le mot de passe doit contenir au moins 8 caractères !";
            }
            else
            {
                lbl_mdp_incorrect.Visible = false;
                mdpMatch = 1;
                DialogResult = DialogResult.OK;
            }

        }

    }
}
