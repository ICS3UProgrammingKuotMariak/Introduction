namespace SchoolAppWithMenu
{
    partial class SchoolAppWithMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolAppWithMenuForm));
            this.lblImmaculata = new System.Windows.Forms.Label();
            this.lblSaints = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImmaculata
            // 
            this.lblImmaculata.BackColor = System.Drawing.Color.White;
            this.lblImmaculata.Font = new System.Drawing.Font("Minion Pro", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImmaculata.ForeColor = System.Drawing.Color.Navy;
            this.lblImmaculata.Location = new System.Drawing.Point(31, 24);
            this.lblImmaculata.Name = "lblImmaculata";
            this.lblImmaculata.Size = new System.Drawing.Size(533, 44);
            this.lblImmaculata.TabIndex = 0;
            this.lblImmaculata.Text = "Immacualata";
            this.lblImmaculata.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblImmaculata.Click += new System.EventHandler(this.lblImmaculata_Click);
            // 
            // lblSaints
            // 
            this.lblSaints.BackColor = System.Drawing.Color.Transparent;
            this.lblSaints.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaints.ForeColor = System.Drawing.Color.Navy;
            this.lblSaints.Location = new System.Drawing.Point(184, 59);
            this.lblSaints.Name = "lblSaints";
            this.lblSaints.Size = new System.Drawing.Size(225, 31);
            this.lblSaints.TabIndex = 1;
            this.lblSaints.Text = "Saints";
            this.lblSaints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaints.Click += new System.EventHandler(this.lblSaints_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProgram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuProgram
            // 
            this.mnuProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(65, 20);
            this.mnuProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmSchoolApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 581);
            this.Controls.Add(this.lblSaints);
            this.Controls.Add(this.lblImmaculata);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmSchoolApp";
            this.Text = "School App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImmaculata;
        private System.Windows.Forms.Label lblSaints;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

