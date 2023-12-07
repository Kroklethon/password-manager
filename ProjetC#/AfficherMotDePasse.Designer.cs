namespace ProjetC_
{
    partial class AfficherMotDePasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfficherMotDePasse));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_name = new Label();
            lbl_url = new Label();
            lbl_user = new Label();
            lbl_password = new Label();
            btn_ok = new Button();
            btn_copy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom de l'entrée :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 102);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Utilisateur :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 64);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Site Web :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 142);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Mot de Passe :";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(166, 27);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 15);
            lbl_name.TabIndex = 4;
            // 
            // lbl_url
            // 
            lbl_url.AutoSize = true;
            lbl_url.Location = new Point(166, 64);
            lbl_url.Name = "lbl_url";
            lbl_url.Size = new Size(0, 15);
            lbl_url.TabIndex = 5;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(166, 102);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(0, 15);
            lbl_user.TabIndex = 6;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(166, 142);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(0, 15);
            lbl_password.TabIndex = 7;
            // 
            // btn_ok
            // 
            btn_ok.DialogResult = DialogResult.OK;
            btn_ok.Location = new Point(307, 169);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 8;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_copy
            // 
            btn_copy.Location = new Point(47, 169);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new Size(138, 23);
            btn_copy.TabIndex = 9;
            btn_copy.Text = "Copier Mot de Passe";
            btn_copy.UseVisualStyleBackColor = true;
            btn_copy.Click += Btn_copy_Click;
            // 
            // AfficherMotDePasse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 204);
            Controls.Add(btn_copy);
            Controls.Add(btn_ok);
            Controls.Add(lbl_password);
            Controls.Add(lbl_user);
            Controls.Add(lbl_url);
            Controls.Add(lbl_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AfficherMotDePasse";
            Text = "Votre mot de passe";
            Load += AfficherMotDePasse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_ok;
        private Button btn_copy;
        public Label lbl_name;
        public Label lbl_url;
        public Label lbl_user;
        public Label lbl_password;
    }
}