namespace CarDealerShipForms
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NameLb = new System.Windows.Forms.Label();
            this.ModelLb = new System.Windows.Forms.Label();
            this.ManufactedLb = new System.Windows.Forms.Label();
            this.VINLb = new System.Windows.Forms.Label();
            this.EngVolumeLb = new System.Windows.Forms.Label();
            this.HorsePowerLb = new System.Windows.Forms.Label();
            this.TransmissionLb = new System.Windows.Forms.Label();
            this.DriveLgbt = new System.Windows.Forms.Label();
            this.CarsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 42);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 38);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить ";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(165, 42);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(128, 38);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(318, 42);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 38);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NameLb
            // 
            this.NameLb.AllowDrop = true;
            this.NameLb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLb.Location = new System.Drawing.Point(650, 119);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(180, 20);
            this.NameLb.TabIndex = 4;
            this.NameLb.Text = "Название автомобиля";
            this.NameLb.Visible = false;
            // 
            // ModelLb
            // 
            this.ModelLb.AllowDrop = true;
            this.ModelLb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ModelLb.AutoSize = true;
            this.ModelLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLb.Location = new System.Drawing.Point(650, 161);
            this.ModelLb.Name = "ModelLb";
            this.ModelLb.Size = new System.Drawing.Size(167, 20);
            this.ModelLb.TabIndex = 5;
            this.ModelLb.Text = "Модель автомобиля";
            this.ModelLb.Visible = false;
            // 
            // ManufactedLb
            // 
            this.ManufactedLb.AllowDrop = true;
            this.ManufactedLb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ManufactedLb.AutoSize = true;
            this.ManufactedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufactedLb.Location = new System.Drawing.Point(650, 203);
            this.ManufactedLb.Name = "ManufactedLb";
            this.ManufactedLb.Size = new System.Drawing.Size(103, 20);
            this.ManufactedLb.TabIndex = 6;
            this.ManufactedLb.Text = "Год выпуска";
            this.ManufactedLb.Visible = false;
            // 
            // VINLb
            // 
            this.VINLb.AllowDrop = true;
            this.VINLb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VINLb.AutoSize = true;
            this.VINLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VINLb.Location = new System.Drawing.Point(650, 246);
            this.VINLb.Name = "VINLb";
            this.VINLb.Size = new System.Drawing.Size(36, 20);
            this.VINLb.TabIndex = 7;
            this.VINLb.Text = "VIN";
            this.VINLb.Visible = false;
            // 
            // EngVolumeLb
            // 
            this.EngVolumeLb.AllowDrop = true;
            this.EngVolumeLb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EngVolumeLb.AutoSize = true;
            this.EngVolumeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EngVolumeLb.Location = new System.Drawing.Point(650, 291);
            this.EngVolumeLb.Name = "EngVolumeLb";
            this.EngVolumeLb.Size = new System.Drawing.Size(147, 20);
            this.EngVolumeLb.TabIndex = 8;
            this.EngVolumeLb.Text = "Объём двигателя";
            this.EngVolumeLb.Visible = false;
            // 
            // HorsePowerLb
            // 
            this.HorsePowerLb.AllowDrop = true;
            this.HorsePowerLb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HorsePowerLb.AutoSize = true;
            this.HorsePowerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HorsePowerLb.Location = new System.Drawing.Point(650, 336);
            this.HorsePowerLb.Name = "HorsePowerLb";
            this.HorsePowerLb.Size = new System.Drawing.Size(88, 20);
            this.HorsePowerLb.TabIndex = 9;
            this.HorsePowerLb.Text = "Мощность";
            this.HorsePowerLb.Visible = false;
            // 
            // TransmissionLb
            // 
            this.TransmissionLb.AllowDrop = true;
            this.TransmissionLb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TransmissionLb.AutoSize = true;
            this.TransmissionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransmissionLb.Location = new System.Drawing.Point(650, 378);
            this.TransmissionLb.Name = "TransmissionLb";
            this.TransmissionLb.Size = new System.Drawing.Size(107, 20);
            this.TransmissionLb.TabIndex = 10;
            this.TransmissionLb.Text = "Трансмиссия";
            this.TransmissionLb.Visible = false;
            // 
            // DriveLgbt
            // 
            this.DriveLgbt.AllowDrop = true;
            this.DriveLgbt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DriveLgbt.AutoSize = true;
            this.DriveLgbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriveLgbt.Location = new System.Drawing.Point(650, 423);
            this.DriveLgbt.Name = "DriveLgbt";
            this.DriveLgbt.Size = new System.Drawing.Size(68, 20);
            this.DriveLgbt.TabIndex = 11;
            this.DriveLgbt.Text = "Привод";
            this.DriveLgbt.Visible = false;
            // 
            // CarsListBox
            // 
            this.CarsListBox.AllowDrop = true;
            this.CarsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarsListBox.FormattingEnabled = true;
            this.CarsListBox.Location = new System.Drawing.Point(12, 98);
            this.CarsListBox.Name = "CarsListBox";
            this.CarsListBox.Size = new System.Drawing.Size(632, 368);
            this.CarsListBox.TabIndex = 12;
            this.CarsListBox.Click += new System.EventHandler(this.CarsListBox_Click);
            this.CarsListBox.DoubleClick += new System.EventHandler(this.CarsListBox_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 486);
            this.Controls.Add(this.CarsListBox);
            this.Controls.Add(this.DriveLgbt);
            this.Controls.Add(this.TransmissionLb);
            this.Controls.Add(this.HorsePowerLb);
            this.Controls.Add(this.EngVolumeLb);
            this.Controls.Add(this.VINLb);
            this.Controls.Add(this.ManufactedLb);
            this.Controls.Add(this.ModelLb);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(866, 525);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосалон";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Label ModelLb;
        private System.Windows.Forms.Label ManufactedLb;
        private System.Windows.Forms.Label VINLb;
        private System.Windows.Forms.Label EngVolumeLb;
        private System.Windows.Forms.Label HorsePowerLb;
        private System.Windows.Forms.Label TransmissionLb;
        private System.Windows.Forms.Label DriveLgbt;
        private System.Windows.Forms.ListBox CarsListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    }
}

