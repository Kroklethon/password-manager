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

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<PasswordEntry>));
                        passwordEntries = (List<PasswordEntry>)serializer.Deserialize(reader);
                    }
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtbxPassword.Text;
            string hashedPassword = string.Empty;
            string initialVector = string.Empty;
            if (enteredPassword == masterPassword)
            {
                using (SHA256 mySHA256 = SHA256.Create())
                {
                    byte[] bytes = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    hashedPassword = builder.ToString();
                    Debug.WriteLine(hashedPassword);

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.SetPasswordEntries(passwordEntries);
                    mainWindow.HashedPassword = hashedPassword;
                    mainWindow.Show();
                    this.Hide();
                }

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
