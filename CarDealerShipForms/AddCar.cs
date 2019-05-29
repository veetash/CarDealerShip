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
    public partial class AddCar : Form
    {
        private Base Base;
        public ListBox CarsListBox;
        public AddCar(Base cbase, ListBox list)
        {
            Base = cbase;
            CarsListBox = list;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTb.Text != "" &&
                ModelTb.Text != "" &&
                BinTb.Text != "" &&
                VolumeTb.Text != "" && double.TryParse(VolumeTb.Text, out double n) &&
                PowerTb.Text != "" && int.TryParse(PowerTb.Text, out int k) &&
                TransCb.Text != "" &&
                DriveCb.Text != "")
            {
                var car = new Car()
                {
                    Name = NameTb.Text,
                    Model = ModelTb.Text,
                    VIN = BinTb.Text,
                    Manufacted = YearDp.Value,
                    EngineVolume = ParseToDoble(VolumeTb.Text),
                    HorsePower = int.Parse(PowerTb.Text),
                    Transmission = GetTransmission(TransCb.Text),
                    Drive = GetDrive(DriveCb.Text)
                };

                Base.Cars.Add(car);

                CarsListBox.DataSource = null;
                CarsListBox.DataSource = Base.Cars;

                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля корректно!");
            }
        }

        private double ParseToDoble(string str)
        {
            var result = str;
            foreach (var c in str)
            {
                if (c == '.')
                {
                    result = str.Replace('.', ',');
                    break;
                }
            }
            return double.Parse(result);
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
