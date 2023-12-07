using System.Xml.Serialization;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace ProjetC_
{
    public partial class LoginWindow : Form
    {
        private const string masterPassword = "myPass123";
        private string filePath = string.Empty;
        private List<PasswordEntry> passwordEntries = new List<PasswordEntry>();
        public LoginWindow()
        {
            InitializeComponent();
        }

       
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "xml files (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    label1.Text = filePath;
                }
            }
        }

        private void decryptFile(string hashedPassword)
        {
            using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
            {
                //Get half of the hashed password to create the key
                aes.Key = Encoding.UTF8.GetBytes(hashedPassword.Substring(0, hashedPassword.Length / 2));
                //Get quarter of the hashed password to create the initial vector
                aes.IV = Encoding.UTF8.GetBytes(hashedPassword.Substring(0, hashedPassword.Length / 4));
                XmlSerializer serializer = new XmlSerializer(typeof(List<PasswordEntry>));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        //we raise an exception if the password is incorrect
                        try
                        {
                            passwordEntries = (List<PasswordEntry>)serializer.Deserialize(cryptoStream);
                        }
                        catch (Exception)
                        {
                            throw new Exception("Mot de passe incorrect");
                        }   
                    }
                }
            }
        }

        private bool checkPassword(string enteredPassword)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] bytes = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                string hashedPassword = builder.ToString();
                try
                {
                    decryptFile(hashedPassword);
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtbxPassword.Text;
            string hashedPassword = string.Empty;
            if (checkPassword(enteredPassword))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.SetPasswordEntries(passwordEntries);
                mainWindow.HashedPassword = hashedPassword;
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
