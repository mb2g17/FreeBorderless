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
            this.label3 = new System.Windows.Forms.Label();
            this.screensComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.screenBoundsBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessBtn
            // 
            this.borderlessBtn.Location = new System.Drawing.Point(359, 97);
            this.borderlessBtn.Name = "borderlessBtn";
            this.borderlessBtn.Size = new System.Drawing.Size(105, 49);
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
            this.refreshListBtn.Location = new System.Drawing.Point(359, 185);
            this.refreshListBtn.Name = "refreshListBtn";
            this.refreshListBtn.Size = new System.Drawing.Size(105, 42);
            this.refreshListBtn.TabIndex = 3;
            this.refreshListBtn.Text = "Refresh processes lists";
            this.refreshListBtn.UseVisualStyleBackColor = true;
            this.refreshListBtn.Click += new System.EventHandler(this.refreshListBtn_Click);
            // 
            // unborderlessBtn
            // 
            this.unborderlessBtn.Location = new System.Drawing.Point(359, 262);
            this.unborderlessBtn.Name = "unborderlessBtn";
            this.unborderlessBtn.Size = new System.Drawing.Size(105, 49);
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
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Screens:";
            // 
            // screensComboBox
            // 
            this.screensComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screensComboBox.FormattingEnabled = true;
            this.screensComboBox.Location = new System.Drawing.Point(473, 55);
            this.screensComboBox.Name = "screensComboBox";
            this.screensComboBox.Size = new System.Drawing.Size(236, 21);
            this.screensComboBox.TabIndex = 10;
            this.screensComboBox.SelectedIndexChanged += new System.EventHandler(this.screensComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bounds of selected screen:";
            // 
            // screenBoundsBox
            // 
            this.screenBoundsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screenBoundsBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenBoundsBox.Location = new System.Drawing.Point(473, 117);
            this.screenBoundsBox.Name = "screenBoundsBox";
            this.screenBoundsBox.ReadOnly = true;
            this.screenBoundsBox.Size = new System.Drawing.Size(236, 96);
            this.screenBoundsBox.TabIndex = 12;
            this.screenBoundsBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 376);
            this.Controls.Add(this.screenBoundsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.screensComboBox);
            this.Controls.Add(this.label3);
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
            this.Text = "FreeBorderless v1.2";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox screensComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox screenBoundsBox;
    }
}

