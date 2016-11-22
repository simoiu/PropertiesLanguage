namespace PropertiesLanguage {
    partial class ColorSettingsControl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.clrDlgKey = new System.Windows.Forms.ColorDialog();
            this.btnKeyColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApplyTheme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbThemes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDisplayItems = new System.Windows.Forms.ListBox();
            this.picKeyColor = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyColor)).BeginInit();
            this.SuspendLayout();
            // 
            // clrDlgKey
            // 
            this.clrDlgKey.AnyColor = true;
            this.clrDlgKey.FullOpen = true;
            // 
            // btnKeyColor
            // 
            this.btnKeyColor.Location = new System.Drawing.Point(151, 42);
            this.btnKeyColor.Name = "btnKeyColor";
            this.btnKeyColor.Size = new System.Drawing.Size(79, 22);
            this.btnKeyColor.TabIndex = 1;
            this.btnKeyColor.Text = "Custom...";
            this.btnKeyColor.UseVisualStyleBackColor = true;
            this.btnKeyColor.Click += new System.EventHandler(this.btnKeyColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApplyTheme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbThemes);
            this.groupBox1.Location = new System.Drawing.Point(3, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predefined Themes";
            // 
            // btnApplyTheme
            // 
            this.btnApplyTheme.Location = new System.Drawing.Point(98, 38);
            this.btnApplyTheme.Name = "btnApplyTheme";
            this.btnApplyTheme.Size = new System.Drawing.Size(122, 23);
            this.btnApplyTheme.TabIndex = 2;
            this.btnApplyTheme.Text = "Apply Theme";
            this.btnApplyTheme.UseVisualStyleBackColor = true;
            this.btnApplyTheme.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choose theme:";
            // 
            // cmbThemes
            // 
            this.cmbThemes.FormattingEnabled = true;
            this.cmbThemes.Location = new System.Drawing.Point(7, 41);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(77, 21);
            this.cmbThemes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lstDisplayItems);
            this.groupBox2.Controls.Add(this.picKeyColor);
            this.groupBox2.Controls.Add(this.btnKeyColor);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Colors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Display Items:";
            // 
            // lstDisplayItems
            // 
            this.lstDisplayItems.FormattingEnabled = true;
            this.lstDisplayItems.Items.AddRange(new object[] {
            "Key",
            "Value",
            "Separator",
            "Comment"});
            this.lstDisplayItems.Location = new System.Drawing.Point(6, 42);
            this.lstDisplayItems.Name = "lstDisplayItems";
            this.lstDisplayItems.Size = new System.Drawing.Size(75, 69);
            this.lstDisplayItems.TabIndex = 5;
            this.lstDisplayItems.SelectedIndexChanged += new System.EventHandler(this.listDisplayItems_SelectedIndexChanged);
            // 
            // picKeyColor
            // 
            this.picKeyColor.InitialImage = null;
            this.picKeyColor.Location = new System.Drawing.Point(104, 44);
            this.picKeyColor.Name = "picKeyColor";
            this.picKeyColor.Size = new System.Drawing.Size(41, 20);
            this.picKeyColor.TabIndex = 3;
            this.picKeyColor.TabStop = false;
            // 
            // ColorSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorSettingsControl";
            this.Size = new System.Drawing.Size(360, 300);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog clrDlgKey;
        private System.Windows.Forms.Button btnKeyColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picKeyColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDisplayItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbThemes;
        private System.Windows.Forms.Button btnApplyTheme;
    }
}
