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
            lstPasswords = new ListView();
            SuspendLayout();
            // 
            // lstPasswords
            // 
            lstPasswords.Location = new Point(188, 143);
            lstPasswords.Name = "lstPasswords";
            lstPasswords.Size = new Size(367, 97);
            lstPasswords.TabIndex = 0;
            lstPasswords.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPasswords);
            Name = "MainWindow";
            Text = "Main View";
            Load += MainWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstPasswords;
    }
}