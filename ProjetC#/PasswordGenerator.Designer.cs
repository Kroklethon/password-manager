namespace ProjetC_
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            checkbx_min = new CheckBox();
            checkbx_spec = new CheckBox();
            checkbx_num = new CheckBox();
            checkbx_max = new CheckBox();
            numPick = new NumericUpDown();
            lnl_length = new Label();
            label1 = new Label();
            button1 = new Button();
            btn_ok = new Button();
            btn_go = new Button();
            ((System.ComponentModel.ISupportInitialize)numPick).BeginInit();
            SuspendLayout();
            // 
            // checkbx_min
            // 
            checkbx_min.AutoSize = true;
            checkbx_min.Checked = true;
            checkbx_min.CheckState = CheckState.Checked;
            checkbx_min.Location = new Point(53, 56);
            checkbx_min.Name = "checkbx_min";
            checkbx_min.Size = new Size(86, 19);
            checkbx_min.TabIndex = 1;
            checkbx_min.Text = "Minuscules";
            checkbx_min.UseVisualStyleBackColor = true;
            // 
            // checkbx_spec
            // 
            checkbx_spec.AutoSize = true;
            checkbx_spec.Checked = true;
            checkbx_spec.CheckState = CheckState.Checked;
            checkbx_spec.Location = new Point(53, 131);
            checkbx_spec.Name = "checkbx_spec";
            checkbx_spec.Size = new Size(137, 19);
            checkbx_spec.TabIndex = 4;
            checkbx_spec.Text = "Charactères spéciaux";
            checkbx_spec.UseVisualStyleBackColor = true;
            // 
            // checkbx_num
            // 
            checkbx_num.AutoSize = true;
            checkbx_num.Checked = true;
            checkbx_num.CheckState = CheckState.Checked;
            checkbx_num.Location = new Point(53, 106);
            checkbx_num.Name = "checkbx_num";
            checkbx_num.Size = new Size(75, 19);
            checkbx_num.TabIndex = 3;
            checkbx_num.Text = "Numéros";
            checkbx_num.UseVisualStyleBackColor = true;
            // 
            // checkbx_max
            // 
            checkbx_max.AutoSize = true;
            checkbx_max.Checked = true;
            checkbx_max.CheckState = CheckState.Checked;
            checkbx_max.Location = new Point(53, 81);
            checkbx_max.Name = "checkbx_max";
            checkbx_max.Size = new Size(85, 19);
            checkbx_max.TabIndex = 2;
            checkbx_max.Text = "Majuscules";
            checkbx_max.UseVisualStyleBackColor = true;
            // 
            // numPick
            // 
            numPick.Location = new Point(277, 102);
            numPick.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            numPick.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPick.Name = "numPick";
            numPick.Size = new Size(120, 23);
            numPick.TabIndex = 5;
            numPick.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // lnl_length
            // 
            lnl_length.AutoSize = true;
            lnl_length.Location = new Point(277, 69);
            lnl_length.Name = "lnl_length";
            lnl_length.Size = new Size(58, 15);
            lnl_length.TabIndex = 8;
            lnl_length.Text = "Longueur";
            lnl_length.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(53, 194);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 9;
            label1.Text = "Password";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(217, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            btn_ok.DialogResult = DialogResult.OK;
            btn_ok.Location = new Point(322, 228);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 7;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_go
            // 
            btn_go.Location = new Point(260, 171);
            btn_go.Name = "btn_go";
            btn_go.Size = new Size(75, 23);
            btn_go.TabIndex = 6;
            btn_go.Text = "GO!";
            btn_go.UseVisualStyleBackColor = true;
            btn_go.Click += btn_go_Click;
            // 
            // PasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 278);
            Controls.Add(btn_go);
            Controls.Add(btn_ok);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lnl_length);
            Controls.Add(numPick);
            Controls.Add(checkbx_max);
            Controls.Add(checkbx_num);
            Controls.Add(checkbx_spec);
            Controls.Add(checkbx_min);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PasswordGenerator";
            Text = "Generateur de mot de passe";
            ((System.ComponentModel.ISupportInitialize)numPick).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkbx_min;
        private CheckBox checkbx_spec;
        private CheckBox checkbx_num;
        private CheckBox checkbx_max;
        private NumericUpDown numPick;
        private Label lnl_length;
        private Button button1;
        private Button btn_ok;
        private Button btn_go;
        public Label label1;
    }
}