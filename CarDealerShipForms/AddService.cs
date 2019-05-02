using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealerShip;

namespace CarDealerShipForms
{
    public partial class AddService : Form
    {
        public Car Car;
        public AddService(Car car)
        {
            Car = car;
            InitializeComponent();
            ServiceListBox.DataSource = null;
            ServiceListBox.DataSource = Car.CrashHistory;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (DescTb.Text != "")
            {
                var crash = new Crash()
                {
                    Description = DescTb.Text,
                    Date = DateTp.Value,
                    IsSerious = SeriousCb.Checked,
                };

                Car.CrashHistory.Add(crash);
                ServiceListBox.DataSource = null;
                ServiceListBox.DataSource = Car.CrashHistory;
            }
            else
            {
                MessageBox.Show("Заполните описание ДТП!");
            }
        }

        private void ServiceListBox_Click(object sender, EventArgs e)
        {
            var index = ServiceListBox.SelectedIndex;
            if (index >= 0 && ServiceListBox.GetSelected(index))
            {
                var crash = Car.CrashHistory[index];
                DateTp.Value = crash.Date;
                DescTb.Text = crash.Description;
                if (crash.IsSerious)
                    SeriousCb.CheckState = CheckState.Checked;
                else
                    SeriousCb.CheckState = CheckState.Unchecked;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var index = ServiceListBox.SelectedIndex;
            if (index >= 0 && ServiceListBox.GetSelected(index))
            {
                var crash = Car.CrashHistory[index];
                if (DescTb.Text != crash.Description &&
                    DescTb.Text != "" ||
                    DateTp.Value != crash.Date ||
                    SeriousCb.Checked != crash.IsSerious)
                {
                    crash.Description = DescTb.Text;
                    crash.Date = DateTp.Value;
                    crash.IsSerious = SeriousCb.Checked;

                    ServiceListBox.DataSource = null;
                    ServiceListBox.DataSource = Car.CrashHistory;
                }
                else
                {
                    MessageBox.Show("Введите изменения!");
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var index = ServiceListBox.SelectedIndex;
            if (index >= 0 && ServiceListBox.GetSelected(index))
            {
                var crash = Car.CrashHistory[index];
                Car.CrashHistory.Remove(crash);

                ServiceListBox.DataSource = null;
                ServiceListBox.DataSource = Car.CrashHistory;

                DateTp.Value = DateTime.Today;
                DescTb.Text = "";
                SeriousCb.CheckState = CheckState.Unchecked;
            }
        }
    }
}
