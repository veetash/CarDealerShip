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
    public partial class Main : Form
    {
        public Base Base;
        public Main()
        {
            Base = new Base();
            Base.Cars.Add(new Car()
            {
                Name = "Skoda",
                Model = "Octavia",
                VIN = "MISHA2019DOWN1999",
                Manufacted = new DateTime(2015, 01, 01),
                EngineVolume = 1.8,
                HorsePower = 180,
                Drive = Drive.FWD,
                Transmission = Transmission.Manual
            });
            InitializeComponent();
            CarsListBox.DataSource = Base.Cars;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new AddCar(Base, CarsListBox);
            form.ShowDialog();
        }

        private void CarsListBox_Click(object sender, EventArgs e)
        {
            var index = CarsListBox.SelectedIndex;
            if (index >= 0 && Base.Cars.Count > 0 && CarsListBox.GetSelected(index))
            {
                var car = Base.Cars[index];
                NameLb.Text = car.Name;
                NameLb.Visible = true;
                ModelLb.Text = car.Model;
                ModelLb.Visible = true;
                VINLb.Text = car.VIN;
                VINLb.Visible = true;
                ManufactedLb.Text = car.Manufacted.Year.ToString() + " г.";
                ManufactedLb.Visible = true;
                HorsePowerLb.Text = car.HorsePower.ToString() + " л.с.";
                HorsePowerLb.Visible = true;
                EngVolumeLb.Text = car.EngineVolume.ToString() + " л.";
                EngVolumeLb.Visible = true;
                TransmissionLb.Text = car.Transmission.ToString() + " Transmission";
                TransmissionLb.Visible = true;
                DriveLgbt.Text = car.Drive.ToString();
                DriveLgbt.Visible = true;
            }
        }

        private void CarsListBox_DoubleClick(object sender, EventArgs e)
        {
            var index = CarsListBox.SelectedIndex;
            if (index >= 0 && Base.Cars.Count > 0 && CarsListBox.GetSelected(index))
            {
                var item = (Car)CarsListBox.Items[index];
                var form = new AddService(item);
                form.ShowDialog();
            }
        }
    }
}
