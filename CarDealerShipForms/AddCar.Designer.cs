namespace CarDealerShipForms
{
    partial class AddCar
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
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BinTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VolumeTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PowerTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TransCb = new System.Windows.Forms.ComboBox();
            this.DriveCb = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.YearDp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(152, 26);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(431, 20);
            this.NameTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название автомобиля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модель автомобиля";
            // 
            // ModelTb
            // 
            this.ModelTb.Location = new System.Drawing.Point(152, 67);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(431, 20);
            this.ModelTb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "VIN";
            // 
            // BinTb
            // 
            this.BinTb.Location = new System.Drawing.Point(152, 110);
            this.BinTb.Name = "BinTb";
            this.BinTb.Size = new System.Drawing.Size(431, 20);
            this.BinTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Год выпуска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Объём двигателя";
            // 
            // VolumeTb
            // 
            this.VolumeTb.Location = new System.Drawing.Point(152, 195);
            this.VolumeTb.Name = "VolumeTb";
            this.VolumeTb.Size = new System.Drawing.Size(431, 20);
            this.VolumeTb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Мощность (л.с.)";
            // 
            // PowerTb
            // 
            this.PowerTb.Location = new System.Drawing.Point(152, 238);
            this.PowerTb.Name = "PowerTb";
            this.PowerTb.Size = new System.Drawing.Size(431, 20);
            this.PowerTb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Трансмиссия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Привод";
            // 
            // TransCb
            // 
            this.TransCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransCb.FormattingEnabled = true;
            this.TransCb.Items.AddRange(new object[] {
            "AT",
            "MT"});
            this.TransCb.Location = new System.Drawing.Point(152, 279);
            this.TransCb.Name = "TransCb";
            this.TransCb.Size = new System.Drawing.Size(430, 21);
            this.TransCb.TabIndex = 15;
            // 
            // DriveCb
            // 
            this.DriveCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriveCb.FormattingEnabled = true;
            this.DriveCb.Items.AddRange(new object[] {
            "AWD",
            "FWD",
            "RWD"});
            this.DriveCb.Location = new System.Drawing.Point(152, 322);
            this.DriveCb.Name = "DriveCb";
            this.DriveCb.Size = new System.Drawing.Size(430, 21);
            this.DriveCb.TabIndex = 16;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(235, 366);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(133, 41);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // YearDp
            // 
            this.YearDp.CustomFormat = "yyyy";
            this.YearDp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YearDp.Location = new System.Drawing.Point(152, 152);
            this.YearDp.Name = "YearDp";
            this.YearDp.Size = new System.Drawing.Size(430, 20);
            this.YearDp.TabIndex = 18;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 419);
            this.Controls.Add(this.YearDp);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DriveCb);
            this.Controls.Add(this.TransCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PowerTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VolumeTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BinTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTb);
            this.MaximumSize = new System.Drawing.Size(611, 458);
            this.MinimumSize = new System.Drawing.Size(611, 458);
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BinTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VolumeTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PowerTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TransCb;
        private System.Windows.Forms.ComboBox DriveCb;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker YearDp;
    }
}