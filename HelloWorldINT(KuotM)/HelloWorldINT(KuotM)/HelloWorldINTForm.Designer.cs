namespace HelloWorldINT_KuotM_
{
    partial class frmHelloWorldINT
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radEspañol = new System.Windows.Forms.RadioButton();
            this.radعربى = new System.Windows.Forms.RadioButton();
            this.radKiswahili = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLanguage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblGreeting.Location = new System.Drawing.Point(12, 23);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(511, 134);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello World";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.radKiswahili);
            this.gbLanguage.Controls.Add(this.radعربى);
            this.gbLanguage.Controls.Add(this.radEspañol);
            this.gbLanguage.Controls.Add(this.radEnglish);
            this.gbLanguage.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLanguage.Location = new System.Drawing.Point(60, 171);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(431, 212);
            this.gbLanguage.TabIndex = 1;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Language";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(27, 47);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(91, 28);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radEspañol
            // 
            this.radEspañol.AutoSize = true;
            this.radEspañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEspañol.Location = new System.Drawing.Point(27, 141);
            this.radEspañol.Name = "radEspañol";
            this.radEspañol.Size = new System.Drawing.Size(97, 28);
            this.radEspañol.TabIndex = 1;
            this.radEspañol.TabStop = true;
            this.radEspañol.Text = "Español";
            this.radEspañol.UseVisualStyleBackColor = true;
            this.radEspañol.CheckedChanged += new System.EventHandler(this.radEspañol_CheckedChanged);
            // 
            // radعربى
            // 
            this.radعربى.AutoSize = true;
            this.radعربى.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radعربى.Location = new System.Drawing.Point(263, 47);
            this.radعربى.Name = "radعربى";
            this.radعربى.Size = new System.Drawing.Size(63, 28);
            this.radعربى.TabIndex = 2;
            this.radعربى.TabStop = true;
            this.radعربى.Text = "عربى";
            this.radعربى.UseVisualStyleBackColor = true;
            this.radعربى.CheckedChanged += new System.EventHandler(this.radعربى_CheckedChanged);
            // 
            // radKiswahili
            // 
            this.radKiswahili.AutoSize = true;
            this.radKiswahili.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKiswahili.Location = new System.Drawing.Point(263, 141);
            this.radKiswahili.Name = "radKiswahili";
            this.radKiswahili.Size = new System.Drawing.Size(114, 29);
            this.radKiswahili.TabIndex = 3;
            this.radKiswahili.TabStop = true;
            this.radKiswahili.Text = "Kiswahili";
            this.radKiswahili.UseVisualStyleBackColor = true;
            this.radKiswahili.CheckedChanged += new System.EventHandler(this.radKiswahili_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmHelloWorldINT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 456);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHelloWorldINT";
            this.Text = "Hello World International";
            this.Load += new System.EventHandler(this.frmHelloWorldINT_Load);
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.RadioButton radKiswahili;
        private System.Windows.Forms.RadioButton radعربى;
        private System.Windows.Forms.RadioButton radEspañol;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

