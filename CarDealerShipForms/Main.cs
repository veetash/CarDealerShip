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
using System.Xml.Serialization;
using System.IO;

namespace CarDealerShipForms
{
    public partial class Main : Form
    {
        public Base Base;
        public Main()
        {
            Base = new Base();
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            var index = CarsListBox.SelectedIndex;
            if (index >= 0 && Base.Cars.Count > 0 && CarsListBox.GetSelected(index))
            {
                var car = (Car)CarsListBox.Items[index];
                var ec = new EditCar(car, CarsListBox, Base.Cars);
                ec.ShowDialog();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var index = CarsListBox.SelectedIndex;
            if (index >= 0 && Base.Cars.Count > 0 && CarsListBox.GetSelected(index))
            {
                var car = (Car)CarsListBox.Items[index];
                Base.Cars.Remove(car);

                CarsListBox.DataSource = null;
                CarsListBox.DataSource = Base.Cars;
                
                NameLb.Visible = false;
                ModelLb.Visible = false;
                VINLb.Visible = false;
                ManufactedLb.Visible = false;
                HorsePowerLb.Visible = false;
                EngVolumeLb.Visible = false;
                TransmissionLb.Visible = false;
                DriveLgbt.Visible = false;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Автомобили|*.cars" };

            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                var data = new Base();
                data = Base;

                var stream = new MemoryStream();
                var xs = new XmlSerializer(typeof(Base));
                var file = File.Create(sfd.FileName);

                xs.Serialize(file, data);
                file.Close();
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Автомобили|*.cars" };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                var xs = new XmlSerializer(typeof(Base));
                var file = File.OpenRead(ofd.FileName);
                var data = (Base)xs.Deserialize(file);
                file.Close();

                Base = data;

                CarsListBox.DataSource = null;
                CarsListBox.DataSource = Base.Cars;
            }
        }
    }
}
