namespace WindowsFormsAppOrarend
{
    partial class FormTanarok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTanarok));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxjelszo = new System.Windows.Forms.TextBox();
            this.button_belep = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // textBoxnev
            // 
            this.textBoxnev.Location = new System.Drawing.Point(12, 42);
            this.textBoxnev.Name = "textBoxnev";
            this.textBoxnev.Size = new System.Drawing.Size(100, 20);
            this.textBoxnev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(115, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó:";
            // 
            // textBoxjelszo
            // 
            this.textBoxjelszo.Location = new System.Drawing.Point(118, 42);
            this.textBoxjelszo.Name = "textBoxjelszo";
            this.textBoxjelszo.Size = new System.Drawing.Size(100, 20);
            this.textBoxjelszo.TabIndex = 3;
            // 
            // button_belep
            // 
            this.button_belep.BackColor = System.Drawing.Color.Olive;
            this.button_belep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_belep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_belep.Location = new System.Drawing.Point(12, 68);
            this.button_belep.Name = "button_belep";
            this.button_belep.Size = new System.Drawing.Size(100, 23);
            this.button_belep.TabIndex = 4;
            this.button_belep.Text = "Belépés";
            this.button_belep.UseVisualStyleBackColor = false;
            this.button_belep.Click += new System.EventHandler(this.button_belep_Click);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.Sienna;
            this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_register.Location = new System.Drawing.Point(118, 68);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(100, 23);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Regisztráció";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // FormTanarok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(231, 104);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_belep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxjelszo);
            this.Controls.Add(this.textBoxnev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTanarok";
            this.Text = "FormTanarok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxjelszo;
        private System.Windows.Forms.Button button_belep;
        private System.Windows.Forms.Button button_register;
    }
}

