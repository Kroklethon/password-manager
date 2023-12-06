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
            listBox1 = new ListBox();
            btn_Add = new Button();
            btn_Edit = new Button();
            btn_Remove = new Button();
            lbl_Dbname = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 

            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(176, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 214);
            listBox1.TabIndex = 0;
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(listBox1);
            Controls.Add(lbl_Dbname);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);

            Name = "MainWindow";
            Text = "Main View";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ListBox listBox1;
        private Button btn_Add;
        private Button button1;
        private Button btn_Edit;
        private Button btn_Remove;
        private Label lbl_Dbname;
    }
}