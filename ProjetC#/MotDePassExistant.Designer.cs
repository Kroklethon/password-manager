namespace ProjetC_
{
    partial class MotDePassExistant
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
            label1 = new Label();
            txtbxPassword = new TextBox();
            btn_Ok = new Button();
            btn_Cancel = new Button();
            btn_show = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 70);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 0;
            label1.Text = "Veuillez saisir votre mot de passe !";
            // 
            // txtbxPassword
            // 
            txtbxPassword.ForeColor = SystemColors.ControlText;
            txtbxPassword.Location = new Point(55, 115);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.Size = new Size(220, 23);
            txtbxPassword.TabIndex = 3;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(315, 163);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 4;
            btn_Ok.Text = "OK";
            btn_Ok.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Location = new Point(209, 163);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 5;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(315, 114);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(75, 23);
            btn_show.TabIndex = 18;
            btn_show.Text = "Afficher";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // MotDePassExistant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 213);
            Controls.Add(btn_show);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Ok);
            Controls.Add(txtbxPassword);
            Controls.Add(label1);
            Name = "MotDePassExistant";
            Text = "Saisir Mot de passe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtbxPassword;
        private Button btn_Ok;
        private Button btn_Cancel;
        private Button btn_show;
    }
}