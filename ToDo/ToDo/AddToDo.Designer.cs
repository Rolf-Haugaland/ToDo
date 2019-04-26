namespace ToDo
{
    partial class AddToDo
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
            this.txt_WhatToDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_References = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbBx_1 = new System.Windows.Forms.ComboBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_AddRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_WhatToDo
            // 
            this.txt_WhatToDo.Location = new System.Drawing.Point(33, 65);
            this.txt_WhatToDo.Name = "txt_WhatToDo";
            this.txt_WhatToDo.Size = new System.Drawing.Size(688, 22);
            this.txt_WhatToDo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "What to do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "When to do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "References";
            // 
            // txt_References
            // 
            this.txt_References.Location = new System.Drawing.Point(33, 241);
            this.txt_References.Name = "txt_References";
            this.txt_References.Size = new System.Drawing.Size(688, 22);
            this.txt_References.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // cmbBx_1
            // 
            this.cmbBx_1.FormattingEnabled = true;
            this.cmbBx_1.Items.AddRange(new object[] {
            "One time event",
            "Concurrent, remove when finished",
            "Urgent",
            "Reminder"});
            this.cmbBx_1.Location = new System.Drawing.Point(33, 186);
            this.cmbBx_1.Name = "cmbBx_1";
            this.cmbBx_1.Size = new System.Drawing.Size(121, 24);
            this.cmbBx_1.TabIndex = 9;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(350, 372);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 10;
            this.btn_Confirm.Text = "button1";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // btn_AddRef
            // 
            this.btn_AddRef.Location = new System.Drawing.Point(36, 269);
            this.btn_AddRef.Name = "btn_AddRef";
            this.btn_AddRef.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRef.TabIndex = 11;
            this.btn_AddRef.Text = "Add reference";
            this.btn_AddRef.UseVisualStyleBackColor = true;
            this.btn_AddRef.Click += new System.EventHandler(this.Btn_AddRef_Click);
            // 
            // AddToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddRef);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.cmbBx_1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_References);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_WhatToDo);
            this.Name = "AddToDo";
            this.Text = "AddToDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_WhatToDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_References;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbBx_1;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_AddRef;
    }
}