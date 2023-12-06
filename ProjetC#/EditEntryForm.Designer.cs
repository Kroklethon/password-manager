namespace ProjetC_
{
    partial class EditEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Cancel = new Button();
            btn_add = new Button();
            lbl_Mdp = new Label();
            lbl_User = new Label();
            lbl_url = new Label();
            txtbx_Url = new TextBox();
            txtbx_Mdp = new TextBox();
            txtbx_User = new TextBox();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(244, 207);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.DialogResult = DialogResult.OK;
            btn_add.Location = new Point(349, 207);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 14;
            btn_add.Text = "Changer";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // lbl_Mdp
            // 
            lbl_Mdp.AutoSize = true;
            lbl_Mdp.Location = new Point(42, 152);
            lbl_Mdp.Name = "lbl_Mdp";
            lbl_Mdp.Size = new Size(77, 15);
            lbl_Mdp.TabIndex = 13;
            lbl_Mdp.Text = "Mot de passe";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(59, 107);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(60, 15);
            lbl_User.TabIndex = 12;
            lbl_User.Text = "Utilisateur";
            // 
            // lbl_url
            // 
            lbl_url.AutoSize = true;
            lbl_url.Location = new Point(91, 61);
            lbl_url.Name = "lbl_url";
            lbl_url.Size = new Size(28, 15);
            lbl_url.TabIndex = 11;
            lbl_url.Text = "URL";
            // 
            // txtbx_Url
            // 
            txtbx_Url.Location = new Point(125, 53);
            txtbx_Url.Name = "txtbx_Url";
            txtbx_Url.Size = new Size(100, 23);
            txtbx_Url.TabIndex = 10;
            // 
            // txtbx_Mdp
            // 
            txtbx_Mdp.Location = new Point(125, 152);
            txtbx_Mdp.Name = "txtbx_Mdp";
            txtbx_Mdp.Size = new Size(100, 23);
            txtbx_Mdp.TabIndex = 9;
            // 
            // txtbx_User
            // 
            txtbx_User.Location = new Point(125, 104);
            txtbx_User.Name = "txtbx_User";
            txtbx_User.Size = new Size(100, 23);
            txtbx_User.TabIndex = 8;
            // 
            // EditEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 247);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_add);
            Controls.Add(lbl_Mdp);
            Controls.Add(lbl_User);
            Controls.Add(lbl_url);
            Controls.Add(txtbx_Url);
            Controls.Add(txtbx_Mdp);
            Controls.Add(txtbx_User);
            Name = "EditEntryForm";
            Text = "Changer Entrée";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Button btn_add;
        private Label lbl_Mdp;
        private Label lbl_User;
        private Label lbl_url;
        public TextBox txtbx_Url;
        public TextBox txtbx_Mdp;
        public TextBox txtbx_User;
    }
}