namespace WindowsFormsAppOrarend
{
    partial class FormOrak
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrak));
            this.listBoxTanarok = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.felhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modósításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSorszam = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxHetnap = new System.Windows.Forms.ComboBox();
            this.textBoxOra = new System.Windows.Forms.TextBox();
            this.textBoxTantargy = new System.Windows.Forms.TextBox();
            this.buttonIgenyles = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSorszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTanarok
            // 
            this.listBoxTanarok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxTanarok.FormattingEnabled = true;
            this.listBoxTanarok.Location = new System.Drawing.Point(12, 27);
            this.listBoxTanarok.Name = "listBoxTanarok";
            this.listBoxTanarok.Size = new System.Drawing.Size(459, 121);
            this.listBoxTanarok.TabIndex = 0;
            this.listBoxTanarok.SelectedIndexChanged += new System.EventHandler(this.listBoxTanarok_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Olive;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // felhaToolStripMenuItem
            // 
            this.felhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.modósításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.felhaToolStripMenuItem.Name = "felhaToolStripMenuItem";
            this.felhaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.felhaToolStripMenuItem.Text = "Órarend";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.BackColor = System.Drawing.Color.Chartreuse;
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // modósításToolStripMenuItem
            // 
            this.modósításToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.modósításToolStripMenuItem.Name = "modósításToolStripMenuItem";
            this.modósításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modósításToolStripMenuItem.Text = "Modósítás";
            this.modósításToolStripMenuItem.Click += new System.EventHandler(this.modósításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Óra(\"id\"):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(114, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tantárgy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(220, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sorszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(346, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hétnapja:";
            // 
            // numericUpDownSorszam
            // 
            this.numericUpDownSorszam.Location = new System.Drawing.Point(224, 174);
            this.numericUpDownSorszam.Name = "numericUpDownSorszam";
            this.numericUpDownSorszam.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSorszam.TabIndex = 6;
            // 
            // comboBoxHetnap
            // 
            this.comboBoxHetnap.FormattingEnabled = true;
            this.comboBoxHetnap.Location = new System.Drawing.Point(350, 173);
            this.comboBoxHetnap.Name = "comboBoxHetnap";
            this.comboBoxHetnap.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHetnap.TabIndex = 7;
            // 
            // textBoxOra
            // 
            this.textBoxOra.Location = new System.Drawing.Point(12, 174);
            this.textBoxOra.Name = "textBoxOra";
            this.textBoxOra.Size = new System.Drawing.Size(100, 20);
            this.textBoxOra.TabIndex = 8;
            // 
            // textBoxTantargy
            // 
            this.textBoxTantargy.Location = new System.Drawing.Point(118, 174);
            this.textBoxTantargy.Name = "textBoxTantargy";
            this.textBoxTantargy.Size = new System.Drawing.Size(100, 20);
            this.textBoxTantargy.TabIndex = 9;
            // 
            // buttonIgenyles
            // 
            this.buttonIgenyles.BackColor = System.Drawing.Color.Olive;
            this.buttonIgenyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIgenyles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIgenyles.Location = new System.Drawing.Point(12, 212);
            this.buttonIgenyles.Name = "buttonIgenyles";
            this.buttonIgenyles.Size = new System.Drawing.Size(459, 38);
            this.buttonIgenyles.TabIndex = 10;
            this.buttonIgenyles.Text = "Igénylem";
            this.buttonIgenyles.UseVisualStyleBackColor = false;
            this.buttonIgenyles.Click += new System.EventHandler(this.buttonIgenyles_Click);
            // 
            // FormOrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(483, 264);
            this.Controls.Add(this.buttonIgenyles);
            this.Controls.Add(this.textBoxTantargy);
            this.Controls.Add(this.textBoxOra);
            this.Controls.Add(this.comboBoxHetnap);
            this.Controls.Add(this.numericUpDownSorszam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTanarok);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrak";
            this.Text = "FormOrak";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSorszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTanarok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem felhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modósításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSorszam;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBoxHetnap;
        private System.Windows.Forms.TextBox textBoxOra;
        private System.Windows.Forms.TextBox textBoxTantargy;
        private System.Windows.Forms.Button buttonIgenyles;
    }
}