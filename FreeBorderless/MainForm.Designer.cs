namespace FreeBorderless
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.borderlessBtn = new System.Windows.Forms.Button();
            this.processesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshListBtn = new System.Windows.Forms.Button();
            this.unborderlessBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.borderlessListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessBtn
            // 
            this.borderlessBtn.Location = new System.Drawing.Point(357, 97);
            this.borderlessBtn.Name = "borderlessBtn";
            this.borderlessBtn.Size = new System.Drawing.Size(89, 49);
            this.borderlessBtn.TabIndex = 0;
            this.borderlessBtn.Text = "Borderless it!";
            this.borderlessBtn.UseVisualStyleBackColor = true;
            this.borderlessBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // processesListBox
            // 
            this.processesListBox.FormattingEnabled = true;
            this.processesListBox.Location = new System.Drawing.Point(12, 55);
            this.processesListBox.Name = "processesListBox";
            this.processesListBox.Size = new System.Drawing.Size(339, 134);
            this.processesListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Processes:";
            // 
            // refreshListBtn
            // 
            this.refreshListBtn.Location = new System.Drawing.Point(357, 185);
            this.refreshListBtn.Name = "refreshListBtn";
            this.refreshListBtn.Size = new System.Drawing.Size(89, 42);
            this.refreshListBtn.TabIndex = 3;
            this.refreshListBtn.Text = "Refresh processes lists";
            this.refreshListBtn.UseVisualStyleBackColor = true;
            this.refreshListBtn.Click += new System.EventHandler(this.refreshListBtn_Click);
            // 
            // unborderlessBtn
            // 
            this.unborderlessBtn.Location = new System.Drawing.Point(357, 262);
            this.unborderlessBtn.Name = "unborderlessBtn";
            this.unborderlessBtn.Size = new System.Drawing.Size(89, 49);
            this.unborderlessBtn.TabIndex = 4;
            this.unborderlessBtn.Text = "Unborderless it!";
            this.unborderlessBtn.UseVisualStyleBackColor = true;
            this.unborderlessBtn.Click += new System.EventHandler(this.unborderlessBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Borderless processes:";
            // 
            // borderlessListBox
            // 
            this.borderlessListBox.FormattingEnabled = true;
            this.borderlessListBox.Location = new System.Drawing.Point(12, 223);
            this.borderlessListBox.Name = "borderlessListBox";
            this.borderlessListBox.Size = new System.Drawing.Size(339, 134);
            this.borderlessListBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borderlessListBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.unborderlessBtn);
            this.Controls.Add(this.refreshListBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processesListBox);
            this.Controls.Add(this.borderlessBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FreeBorderless";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borderlessBtn;
        private System.Windows.Forms.ListBox processesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshListBtn;
        private System.Windows.Forms.Button unborderlessBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox borderlessListBox;
    }
}

