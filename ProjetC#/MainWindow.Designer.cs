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
            lstPasswords = new ListBox();
            btn_Add = new Button();
            btn_Edit = new Button();
            btn_Remove = new Button();
            lbl_Dbname = new Label();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            sauvegarderToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstPasswords
            // 
            lstPasswords.FormattingEnabled = true;
            lstPasswords.ItemHeight = 15;
            lstPasswords.Location = new Point(176, 98);
            lstPasswords.Name = "lstPasswords";
            lstPasswords.Size = new Size(360, 214);
            lstPasswords.TabIndex = 0;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(669, 109);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(119, 33);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Ajouter";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btnAdd_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(669, 165);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(119, 33);
            btn_Edit.TabIndex = 3;
            btn_Edit.Text = "Changer";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btnEdit_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(669, 222);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(119, 33);
            btn_Remove.TabIndex = 4;
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPasswords);
            Controls.Add(lbl_Dbname);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);
            Controls.Add(menuStrip1);
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


        private ListBox lstPasswords;
        private Button btn_Add;
        private Button button1;
        private Button btn_Edit;
        private Button btn_Remove;
        private Label lbl_Dbname;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem sauvegarderToolStripMenuItem;
    }
}