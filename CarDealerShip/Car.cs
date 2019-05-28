using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class Base
    {
        public List<Car> Cars = new List<Car>();
    }

    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public DateTime Manufacted { get; set; }
        public double EngineVolume { get; set; }
        public int HorsePower { get; set; }
        public Drive Drive { get; set; }
        public Transmission Transmission { get; set; }
        public List<Crash> CrashHistory = new List<Crash>();

        public override string ToString()
        {
            return Name + " " + Model + " (" + Manufacted.Year.ToString() + ")";
        }
    }

    public enum Drive
    {
        AWD,
        FWD,
        RWD
    }
    public enum Transmission
    {
        Manual,
        Automatic
    }
}
