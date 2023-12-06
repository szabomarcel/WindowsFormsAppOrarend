namespace WindowsFormsAppOrarend
{
    partial class FormModositasok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModositasok));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Megerosit = new System.Windows.Forms.Button();
            this.numericUpDownSorszam = new System.Windows.Forms.NumericUpDown();
            this.textBoxTantargyak = new System.Windows.Forms.TextBox();
            this.textBoxOraId = new System.Windows.Forms.TextBox();
            this.comboBoxNapja = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSorszam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox1.Controls.Add(this.comboBoxNapja);
            this.groupBox1.Controls.Add(this.button_Megerosit);
            this.groupBox1.Controls.Add(this.numericUpDownSorszam);
            this.groupBox1.Controls.Add(this.textBoxTantargyak);
            this.groupBox1.Controls.Add(this.textBoxOraId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modósított lehetőségek";
            // 
            // button_Megerosit
            // 
            this.button_Megerosit.BackColor = System.Drawing.Color.Olive;
            this.button_Megerosit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Megerosit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Megerosit.ForeColor = System.Drawing.Color.Black;
            this.button_Megerosit.Location = new System.Drawing.Point(33, 71);
            this.button_Megerosit.Name = "button_Megerosit";
            this.button_Megerosit.Size = new System.Drawing.Size(321, 36);
            this.button_Megerosit.TabIndex = 4;
            this.button_Megerosit.Text = "Megerősít";
            this.button_Megerosit.UseVisualStyleBackColor = false;
            // 
            // numericUpDownSorszam
            // 
            this.numericUpDownSorszam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownSorszam.Location = new System.Drawing.Point(33, 45);
            this.numericUpDownSorszam.Name = "numericUpDownSorszam";
            this.numericUpDownSorszam.Size = new System.Drawing.Size(145, 20);
            this.numericUpDownSorszam.TabIndex = 2;
            // 
            // textBoxTantargyak
            // 
            this.textBoxTantargyak.Location = new System.Drawing.Point(200, 19);
            this.textBoxTantargyak.Name = "textBoxTantargyak";
            this.textBoxTantargyak.Size = new System.Drawing.Size(154, 20);
            this.textBoxTantargyak.TabIndex = 1;
            // 
            // textBoxOraId
            // 
            this.textBoxOraId.Location = new System.Drawing.Point(33, 19);
            this.textBoxOraId.Name = "textBoxOraId";
            this.textBoxOraId.Size = new System.Drawing.Size(145, 20);
            this.textBoxOraId.TabIndex = 0;
            // 
            // comboBoxNapja
            // 
            this.comboBoxNapja.FormattingEnabled = true;
            this.comboBoxNapja.Location = new System.Drawing.Point(200, 46);
            this.comboBoxNapja.Name = "comboBoxNapja";
            this.comboBoxNapja.Size = new System.Drawing.Size(154, 21);
            this.comboBoxNapja.TabIndex = 5;
            // 
            // FormModositasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(408, 157);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModositasok";
            this.Text = "FormModositasok";
            this.Load += new System.EventHandler(this.FormModositasok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSorszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSorszam;
        private System.Windows.Forms.TextBox textBoxTantargyak;
        private System.Windows.Forms.TextBox textBoxOraId;
        private System.Windows.Forms.Button button_Megerosit;
        private System.Windows.Forms.ComboBox comboBoxNapja;
    }
}