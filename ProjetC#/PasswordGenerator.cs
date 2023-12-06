using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetC_
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }
        public void btn_go_Click(object sender, EventArgs e)
        {
            string characters = "";    
            int passwordLength = int.Parse(numPick.Value.ToString());
            Random random = new Random();
            StringBuilder password = new StringBuilder(passwordLength);
            // Ajouter les caractères à la string characters
            if (checkbx_min.Checked) { characters= characters + "abcdefghijklmnopqrstuvwxyz"; }
            if (checkbx_max.Checked) { characters = characters + "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (checkbx_num.Checked) { characters = characters + "0123456789"; }
            if (checkbx_spec.Checked) { characters = characters + "!@#$%^&*()-_+=<>?"; }   
            if (checkbx_min.Checked == false && checkbx_max.Checked == false && checkbx_num.Checked == false && checkbx_spec.Checked == false)
            {
                MessageBox.Show("Veuillez sélectionner au moins une option");
            }
            Debug.WriteLine(characters);
            // Générer le mot de passe
            for (int i = 0; i < passwordLength; i++)
            {
                int index = random.Next(characters.Length);
                password.Append(characters[index]);
            }            
            label1.Text = password.ToString();

        }
    }
}
