namespace ProjetC_
{
    partial class MotDePassNouveau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotDePassNouveau));
            btn_Cancel = new Button();
            btn_Ok = new Button();
            txtbxPassword = new TextBox();
            label1 = new Label();
            txtbxPassword_confirm = new TextBox();
            label2 = new Label();
            lbl_mdp_incorrect = new Label();
            btn_show = new Button();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(273, 256);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 9;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(389, 256);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 8;
            btn_Ok.Text = "OK";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // txtbxPassword
            // 
            txtbxPassword.ForeColor = SystemColors.ControlText;
            txtbxPassword.Location = new Point(27, 101);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.Size = new Size(273, 23);
            txtbxPassword.TabIndex = 1;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 63);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 16;
            label1.Text = "Veuillez saisir votre mot de passe !";
            // 
            // txtbxPassword_confirm
            // 
            txtbxPassword_confirm.ForeColor = SystemColors.ControlText;
            txtbxPassword_confirm.Location = new Point(27, 182);
            txtbxPassword_confirm.Name = "txtbxPassword_confirm";
            txtbxPassword_confirm.Size = new Size(273, 23);
            txtbxPassword_confirm.TabIndex = 4;
            txtbxPassword_confirm.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 145);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 15;
            label2.Text = "Confirmez votre mot de passe !";
            // 
            // lbl_mdp_incorrect
            // 
            lbl_mdp_incorrect.AutoEllipsis = true;
            lbl_mdp_incorrect.AutoSize = true;
            lbl_mdp_incorrect.ForeColor = Color.Red;
            lbl_mdp_incorrect.Location = new Point(27, 222);
            lbl_mdp_incorrect.Name = "lbl_mdp_incorrect";
            lbl_mdp_incorrect.Size = new Size(0, 15);
            lbl_mdp_incorrect.TabIndex = 12;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(325, 145);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(75, 23);
            btn_show.TabIndex = 17;
            btn_show.Text = "Afficher";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // MotDePassNouveau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(btn_show);
            Controls.Add(lbl_mdp_incorrect);
            Controls.Add(label2);
            Controls.Add(txtbxPassword_confirm);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Ok);
            Controls.Add(txtbxPassword);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MotDePassNouveau";
            Text = "Créer une nouvelle base";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Button btn_Ok;
        public TextBox txtbxPassword;
        private Label label1;
        public TextBox txtbxPassword_confirm;
        private Label label2;
        public Label lbl_mdp_incorrect;
        private Button btn_show;
    }
}