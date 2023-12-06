namespace ProjetC_
{
    partial class LoginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_choisir = new Label();
            openFileDialog1 = new OpenFileDialog();
            btn_OpenFile = new Button();
            txtbxPassword = new TextBox();
            btnLogin = new Button();
            lbl_insertPswd = new Label();
            SuspendLayout();
            // 
            // lbl_choisir
            // 
            lbl_choisir.AutoSize = true;
            lbl_choisir.Location = new Point(203, 91);
            lbl_choisir.Name = "lbl_choisir";
            lbl_choisir.Size = new Size(174, 15);
            lbl_choisir.TabIndex = 0;
            lbl_choisir.Text = "Choisir fichier de Mots de Passe";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_OpenFile
            // 
            btn_OpenFile.Location = new Point(533, 151);
            btn_OpenFile.Name = "btn_OpenFile";
            btn_OpenFile.Size = new Size(75, 23);
            btn_OpenFile.TabIndex = 1;
            btn_OpenFile.Text = "Choisir...";
            btn_OpenFile.UseVisualStyleBackColor = true;
            btn_OpenFile.Click += btn_OpenFile_Click;
            // 
            // txtbxPassword
            // 
            txtbxPassword.ForeColor = SystemColors.ControlText;
            txtbxPassword.Location = new Point(206, 238);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '*';
            txtbxPassword.Size = new Size(311, 23);
            txtbxPassword.TabIndex = 2;
            txtbxPassword.UseSystemPasswordChar = true;
            txtbxPassword.TextChanged += txtbxPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(533, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbl_insertPswd
            // 
            lbl_insertPswd.AutoSize = true;
            lbl_insertPswd.Location = new Point(203, 207);
            lbl_insertPswd.Name = "lbl_insertPswd";
            lbl_insertPswd.Size = new Size(69, 15);
            lbl_insertPswd.TabIndex = 4;
            lbl_insertPswd.Text = "SAISIR MDP";
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_insertPswd);
            Controls.Add(btnLogin);
            Controls.Add(txtbxPassword);
            Controls.Add(btn_OpenFile);
            Controls.Add(lbl_choisir);
            Name = "LoginWindow";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_choisir;
        private OpenFileDialog openFileDialog1;
        private Button btn_OpenFile;
        private TextBox txtbxPassword;
        private Button btnLogin;
        private Label lbl_insertPswd;
    }
}
