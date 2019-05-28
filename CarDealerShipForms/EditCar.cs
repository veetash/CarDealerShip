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
using System.Globalization;

namespace CarDealerShipForms
{
    public partial class EditCar : Form
    {
        private Car Car;
        private List<Car> Cars;
        private ListBox CarListBox;
        public EditCar(Car car, ListBox listbox, List<Car> cars)
        {
            Car = car;
            Cars = cars;
            CarListBox = listbox;
            InitializeComponent();
            YearDp.Value = Car.Manufacted;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var conditions = new List<bool>()
            {
                NameTb.Text != Car.Name,
                NameTb.Text != "",
                ModelTb.Text != Car.Model,
                ModelTb.Text != "",
                BinTb.Text != Car.VIN,
                BinTb.Text != "",
                YearDp.Value.Year != Car.Manufacted.Year,
                VolumeTb.Text != Car.EngineVolume.ToString(),
                VolumeTb.Text != "",
                PowerTb.Text != Car.HorsePower.ToString(),
                PowerTb.Text != "",
                TransCb.SelectedValue != null,
                DriveCb.SelectedValue != null
            };

            if (conditions[0] && conditions[1])
                Car.Name = NameTb.Text;
            if (conditions[2] && conditions[3])
                Car.Model = ModelTb.Text;
            if (conditions[4] && conditions[5])
                Car.VIN = BinTb.Text;
            if (conditions[6])
                Car.Manufacted = YearDp.Value;
            if (conditions[7] && conditions[8])
                Car.EngineVolume = double.Parse(VolumeTb.Text, CultureInfo.InvariantCulture);
            if (conditions[9] && conditions[10])
                Car.HorsePower = int.Parse(PowerTb.Text);
            if (conditions[11] && TransCb.SelectedValue.ToString() != Car.Transmission.ToString())
                Car.Transmission = GetTransmission(TransCb.Text);
            if (conditions[12] && DriveCb.SelectedValue.ToString() != Car.Transmission.ToString())
                Car.Drive = GetDrive(TransCb.Text);

            CarListBox.DataSource = null;
            CarListBox.DataSource = Cars;
            this.Close();
        }
        private Transmission GetTransmission(string text)
        {
            switch (text)
            {
                case "MT":
                    return Transmission.Manual;
                case "AT":
                    return Transmission.Automatic;
                default:
                    return Transmission.Automatic;
            }
        }

        private Drive GetDrive(string text)
        {
            switch (text)
            {
                case "AWD":
                    return Drive.AWD;
                case "FWD":
                    return Drive.FWD;
                default:
                    return Drive.RWD;
            }
        }
    }
}
