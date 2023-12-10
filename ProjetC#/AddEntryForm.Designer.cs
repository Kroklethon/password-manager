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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEntryForm));
            txtbx_User = new TextBox();
            txtbx_Mdp = new TextBox();
            txtbx_Url = new TextBox();
            lbl_url = new Label();
            lbl_User = new Label();
            lbl_Mdp = new Label();
            btn_add = new Button();
            btn_Cancel = new Button();
            btn_generate = new Button();
            txtbx_entryname = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtbx_User
            // 
            txtbx_User.Location = new Point(112, 121);
            txtbx_User.Name = "txtbx_User";
            txtbx_User.Size = new Size(100, 23);
            txtbx_User.TabIndex = 3;
            // 
            // txtbx_Mdp
            // 
            txtbx_Mdp.Location = new Point(112, 169);
            txtbx_Mdp.Name = "txtbx_Mdp";
            txtbx_Mdp.Size = new Size(100, 23);
            txtbx_Mdp.TabIndex = 4;
            // 
            // txtbx_Url
            // 
            txtbx_Url.Location = new Point(112, 70);
            txtbx_Url.Name = "txtbx_Url";
            txtbx_Url.Size = new Size(100, 23);
            txtbx_Url.TabIndex = 2;
            // 
            // lbl_url
            // 
            lbl_url.AutoSize = true;
            lbl_url.Location = new Point(78, 78);
            lbl_url.Name = "lbl_url";
            lbl_url.Size = new Size(28, 15);
            lbl_url.TabIndex = 3;
            lbl_url.Text = "URL";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(46, 124);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(60, 15);
            lbl_User.TabIndex = 4;
            lbl_User.Text = "Utilisateur";
            // 
            // lbl_Mdp
            // 
            lbl_Mdp.AutoSize = true;
            lbl_Mdp.Location = new Point(29, 169);
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
            btn_add.TabIndex = 7;
            btn_add.Text = "Ajouter";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(242, 208);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 8;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_generate
            // 
            btn_generate.Location = new Point(242, 140);
            btn_generate.Name = "btn_generate";
            btn_generate.Size = new Size(132, 47);
            btn_generate.TabIndex = 6;
            btn_generate.Text = "Generer un mot de passe";
            btn_generate.UseVisualStyleBackColor = true;
            btn_generate.Click += btn_generate_Click;
            // 
            // txtbx_entryname
            // 
            txtbx_entryname.Location = new Point(112, 23);
            txtbx_entryname.Name = "txtbx_entryname";
            txtbx_entryname.Size = new Size(100, 23);
            txtbx_entryname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 10;
            label1.Text = "Nom de l'entrée";
            // 
            // AddEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 243);
            Controls.Add(label1);
            Controls.Add(txtbx_entryname);
            Controls.Add(btn_generate);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_add);
            Controls.Add(lbl_Mdp);
            Controls.Add(lbl_User);
            Controls.Add(lbl_url);
            Controls.Add(txtbx_Url);
            Controls.Add(txtbx_Mdp);
            Controls.Add(txtbx_User);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btn_generate;
        public TextBox txtbx_entryname;
        private Label label1;
    }
}