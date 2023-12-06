using System.Xml.Serialization;

namespace ProjetC_
{
    public partial class LoginWindow : Form
    {
        private const string masterPassword = "myPass123";

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtbxPassword.Text;

            if (enteredPassword == masterPassword)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                //ShowPasswordEntries();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files|*.xml|All Files|*.*",
                Title = "Open Password File",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    LoadPasswordEntriesFromXml(filePath);
                    //ShowPasswordEntries();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading password entries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
        /* private void LoadPasswordEntriesFromXml(string filePath)
{
XmlSerializer serializer = new XmlSerializer(typeof(List<PasswordEntry>));

using (TextReader reader = new StreamReader(filePath))
{
passwordEntries = (List<PasswordEntry>)serializer.Deserialize(reader);
}
}*/
    }
}
