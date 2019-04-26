namespace ToDo
{
    partial class Form1
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
            this.lstVw_Main = new System.Windows.Forms.ListView();
            this.chkBx_Today = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstVw_References = new System.Windows.Forms.ListView();
            this.clmn_What = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_When = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.clmn_RefID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVw_Main
            // 
            this.lstVw_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmn_What,
            this.clmn_When,
            this.clmn_Type,
            this.refID});
            this.lstVw_Main.Location = new System.Drawing.Point(83, 56);
            this.lstVw_Main.Name = "lstVw_Main";
            this.lstVw_Main.Size = new System.Drawing.Size(1228, 264);
            this.lstVw_Main.TabIndex = 0;
            this.lstVw_Main.UseCompatibleStateImageBehavior = false;
            this.lstVw_Main.View = System.Windows.Forms.View.Details;
            // 
            // chkBx_Today
            // 
            this.chkBx_Today.AutoSize = true;
            this.chkBx_Today.Location = new System.Drawing.Point(742, 29);
            this.chkBx_Today.Name = "chkBx_Today";
            this.chkBx_Today.Size = new System.Drawing.Size(70, 21);
            this.chkBx_Today.TabIndex = 1;
            this.chkBx_Today.Text = "Today";
            this.chkBx_Today.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(431, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lstVw_References
            // 
            this.lstVw_References.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmn_RefID,
            this.clmn_Content});
            this.lstVw_References.Location = new System.Drawing.Point(83, 372);
            this.lstVw_References.Name = "lstVw_References";
            this.lstVw_References.Size = new System.Drawing.Size(729, 97);
            this.lstVw_References.TabIndex = 3;
            this.lstVw_References.UseCompatibleStateImageBehavior = false;
            this.lstVw_References.View = System.Windows.Forms.View.Details;
            // 
            // clmn_What
            // 
            this.clmn_What.Text = "What to do";
            this.clmn_What.Width = 314;
            // 
            // clmn_When
            // 
            this.clmn_When.Text = "When to do";
            this.clmn_When.Width = 175;
            // 
            // clmn_Type
            // 
            this.clmn_Type.Text = "Type";
            this.clmn_Type.Width = 234;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "References:";
            // 
            // clmn_RefID
            // 
            this.clmn_RefID.Text = "Ref ID";
            // 
            // clmn_Content
            // 
            this.clmn_Content.Text = "Content";
            this.clmn_Content.Width = 659;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.UploadToolStripMenuItem_Click);
            // 
            // refID
            // 
            this.refID.Text = "Ref ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVw_References);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chkBx_Today);
            this.Controls.Add(this.lstVw_Main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVw_Main;
        private System.Windows.Forms.CheckBox chkBx_Today;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader clmn_What;
        private System.Windows.Forms.ColumnHeader clmn_When;
        private System.Windows.Forms.ColumnHeader clmn_Type;
        private System.Windows.Forms.ListView lstVw_References;
        private System.Windows.Forms.ColumnHeader clmn_RefID;
        private System.Windows.Forms.ColumnHeader clmn_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader refID;
    }
}

