namespace CarDealerShipForms
{
    partial class AddService
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
            this.ServiceListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DateTp = new System.Windows.Forms.DateTimePicker();
            this.DescTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SeriousCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ServiceListBox
            // 
            this.ServiceListBox.AllowDrop = true;
            this.ServiceListBox.FormattingEnabled = true;
            this.ServiceListBox.Location = new System.Drawing.Point(10, 88);
            this.ServiceListBox.Name = "ServiceListBox";
            this.ServiceListBox.Size = new System.Drawing.Size(468, 368);
            this.ServiceListBox.TabIndex = 16;
            this.ServiceListBox.Click += new System.EventHandler(this.ServiceListBox_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(423, 27);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 38);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(270, 27);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(128, 38);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(117, 27);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 38);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить ";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateTp
            // 
            this.DateTp.Location = new System.Drawing.Point(484, 110);
            this.DateTp.Name = "DateTp";
            this.DateTp.Size = new System.Drawing.Size(160, 20);
            this.DateTp.TabIndex = 17;
            // 
            // DescTb
            // 
            this.DescTb.Location = new System.Drawing.Point(484, 158);
            this.DescTb.Multiline = true;
            this.DescTb.Name = "DescTb";
            this.DescTb.Size = new System.Drawing.Size(160, 270);
            this.DescTb.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Дата аварии:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Описание аварии:";
            // 
            // SeriousCb
            // 
            this.SeriousCb.AutoSize = true;
            this.SeriousCb.Location = new System.Drawing.Point(513, 434);
            this.SeriousCb.Name = "SeriousCb";
            this.SeriousCb.Size = new System.Drawing.Size(108, 17);
            this.SeriousCb.TabIndex = 21;
            this.SeriousCb.Text = "Серьёзное ДТП";
            this.SeriousCb.UseVisualStyleBackColor = true;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 468);
            this.Controls.Add(this.SeriousCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescTb);
            this.Controls.Add(this.DateTp);
            this.Controls.Add(this.ServiceListBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.MaximumSize = new System.Drawing.Size(673, 507);
            this.MinimumSize = new System.Drawing.Size(673, 507);
            this.Name = "AddService";
            this.Text = "AddService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ServiceListBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker DateTp;
        private System.Windows.Forms.TextBox DescTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SeriousCb;
    }
}