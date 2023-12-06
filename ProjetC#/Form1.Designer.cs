namespace ProjetC_
{
    partial class Form1
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
            lbl_choisir = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lbl_choisir
            // 
            lbl_choisir.AutoSize = true;
            lbl_choisir.Location = new Point(111, 67);
            lbl_choisir.Name = "lbl_choisir";
            lbl_choisir.Size = new Size(174, 15);
            lbl_choisir.TabIndex = 0;
            lbl_choisir.Text = "Choisir fichier de Mots de Passe";
            lbl_choisir.Click += label1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_choisir);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_choisir;
        private OpenFileDialog openFileDialog1;
    }
}
