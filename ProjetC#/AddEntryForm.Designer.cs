namespace ProjetC_
{
    partial class AddEntryForm
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
            txtbx_User = new TextBox();
            txtbx_Mdp = new TextBox();
            txtbx_Url = new TextBox();
            lbl_url = new Label();
            lbl_User = new Label();
            lbl_Mdp = new Label();
            btn_add = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // txtbx_User
            // 
            txtbx_User.Location = new Point(123, 105);
            txtbx_User.Name = "txtbx_User";
            txtbx_User.Size = new Size(100, 23);
            txtbx_User.TabIndex = 0;
            // 
            // txtbx_Mdp
            // 
            txtbx_Mdp.Location = new Point(123, 153);
            txtbx_Mdp.Name = "txtbx_Mdp";
            txtbx_Mdp.Size = new Size(100, 23);
            txtbx_Mdp.TabIndex = 1;
            // 
            // txtbx_Url
            // 
            txtbx_Url.Location = new Point(123, 54);
            txtbx_Url.Name = "txtbx_Url";
            txtbx_Url.Size = new Size(100, 23);
            txtbx_Url.TabIndex = 2;
            // 
            // lbl_url
            // 
            lbl_url.AutoSize = true;
            lbl_url.Location = new Point(89, 62);
            lbl_url.Name = "lbl_url";
            lbl_url.Size = new Size(28, 15);
            lbl_url.TabIndex = 3;
            lbl_url.Text = "URL";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(57, 108);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(60, 15);
            lbl_User.TabIndex = 4;
            lbl_User.Text = "Utilisateur";
            // 
            // lbl_Mdp
            // 
            lbl_Mdp.AutoSize = true;
            lbl_Mdp.Location = new Point(40, 153);
            lbl_Mdp.Name = "lbl_Mdp";
            lbl_Mdp.Size = new Size(77, 15);
            lbl_Mdp.TabIndex = 5;
            lbl_Mdp.Text = "Mot de passe";
            // 
            // btn_add
            // 
            btn_add.DialogResult = DialogResult.OK;
            btn_add.Location = new Point(347, 208);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 6;
            btn_add.Text = "Ajouter";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(242, 208);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 7;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // AddEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 243);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_add);
            Controls.Add(lbl_Mdp);
            Controls.Add(lbl_User);
            Controls.Add(lbl_url);
            Controls.Add(txtbx_Url);
            Controls.Add(txtbx_Mdp);
            Controls.Add(txtbx_User);
            Name = "AddEntryForm";
            Text = "Saisir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_url;
        private Label lbl_User;
        private Label lbl_Mdp;
        private Button btn_add;
        private Button btn_Cancel;
        public TextBox txtbx_User;
        public TextBox txtbx_Mdp;
        public TextBox txtbx_Url;
    }
}