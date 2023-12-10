namespace ProjetC_
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            btn_Add = new Button();
            btn_Edit = new Button();
            btn_Remove = new Button();
            lbl_Dbname = new Label();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            sauvegarderToolStripMenuItem = new ToolStripMenuItem();
            lstPasswords = new ListView();
            columnEntryname = new ColumnHeader();
            coloumnUrl = new ColumnHeader();
            columnUser = new ColumnHeader();
            columnPassword = new ColumnHeader();
            btn_show = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(669, 168);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(119, 33);
            btn_Add.TabIndex = 4;
            btn_Add.Text = "Ajouter";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btnAdd_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(669, 224);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(119, 33);
            btn_Edit.TabIndex = 5;
            btn_Edit.Text = "Changer";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btnEdit_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(669, 281);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(119, 33);
            btn_Remove.TabIndex = 6;
            btn_Remove.Text = "Supprimer";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btnRemove_Click;
            // 
            // lbl_Dbname
            // 
            lbl_Dbname.AutoSize = true;
            lbl_Dbname.Location = new Point(42, 36);
            lbl_Dbname.Name = "lbl_Dbname";
            lbl_Dbname.Size = new Size(82, 15);
            lbl_Dbname.TabIndex = 5;
            lbl_Dbname.Text = "My Passwords";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sauvegarderToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sauvegarderToolStripMenuItem
            // 
            sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            sauvegarderToolStripMenuItem.Size = new Size(139, 22);
            sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            sauvegarderToolStripMenuItem.Click += sauvegarderToolStripMenuItem_Click;
            // 
            // lstPasswords
            // 
            lstPasswords.Columns.AddRange(new ColumnHeader[] { columnEntryname, coloumnUrl, columnUser, columnPassword });
            lstPasswords.FullRowSelect = true;
            lstPasswords.GridLines = true;
            lstPasswords.Location = new Point(168, 109);
            lstPasswords.MultiSelect = false;
            lstPasswords.Name = "lstPasswords";
            lstPasswords.Size = new Size(365, 238);
            lstPasswords.TabIndex = 1;
            lstPasswords.UseCompatibleStateImageBehavior = false;
            lstPasswords.View = View.Details;
            // 
            // columnEntryname
            // 
            columnEntryname.Text = "Nom de l'entrée";
            columnEntryname.Width = 120;
            // 
            // coloumnUrl
            // 
            coloumnUrl.Text = "URL";
            coloumnUrl.Width = 120;
            // 
            // columnUser
            // 
            columnUser.Text = "Utilisateur";
            columnUser.Width = 120;
            // 
            // columnPassword
            // 
            columnPassword.Text = "Password";
            columnPassword.Width = 0;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(669, 109);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(119, 33);
            btn_show.TabIndex = 3;
            btn_show.Text = "Afficher";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_show);
            Controls.Add(lstPasswords);
            Controls.Add(lbl_Dbname);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Main View";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Add;
        private Button btn_show;
        private Button btn_Edit;
        private Button btn_Remove;
        private Label lbl_Dbname;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem sauvegarderToolStripMenuItem;
        private ListView lstPasswords;
        private ColumnHeader coloumnUrl;
        private ColumnHeader columnUser;
        private ColumnHeader columnPassword;
        private ColumnHeader columnEntryname;
    }
}