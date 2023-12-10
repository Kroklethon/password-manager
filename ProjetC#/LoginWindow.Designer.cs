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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            lbl_choisir = new Label();
            openFileDialog1 = new OpenFileDialog();
            btn_OpenFile = new Button();
            btn_new = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_choisir
            // 
            lbl_choisir.AutoSize = true;
            lbl_choisir.Font = new Font("Segoe UI", 9F);
            lbl_choisir.Location = new Point(58, 41);
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
            btn_OpenFile.Location = new Point(282, 41);
            btn_OpenFile.Name = "btn_OpenFile";
            btn_OpenFile.Size = new Size(75, 23);
            btn_OpenFile.TabIndex = 1;
            btn_OpenFile.Text = "Choisir...";
            btn_OpenFile.UseVisualStyleBackColor = true;
            btn_OpenFile.Click += Btn_OpenFile_Click;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(282, 117);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(75, 23);
            btn_new.TabIndex = 0;
            btn_new.Text = "Nouveau";
            btn_new.Click += Btn_new_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 82);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Path";
            label1.Visible = false;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 166);
            Controls.Add(label1);
            Controls.Add(btn_new);
            Controls.Add(btn_OpenFile);
            Controls.Add(lbl_choisir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginWindow";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_choisir;
        private OpenFileDialog openFileDialog1;
        private Button btn_OpenFile;
        private Button btn_new;
        private Label label1;
    }
}
