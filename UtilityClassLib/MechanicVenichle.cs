using System;

namespace UtilityClassLib
{
    public class VenichleSize
    {
        public double Height { get; set; }
        public double Lenght { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("VenichleSize: [Lenght: {0}, Height: {1}]", this.Lenght, this.Height);
        }
    }
    public class MechanicVenichle
    {
        private double power = 108;
        public double Power
        {
            get
            {
                return this.power;
            }

            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new InvalidOperationException("Too much power");
                }
                this.power = value;
            }
        }

        public double EmptyWeight { get; set; } = 800;

        private double weight;
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 0 || value < EmptyWeight)
                {
                    throw new InvalidOperationException("Weight can' be less empty weight");
                }
                this.weight = value;
            }
        }

        public double MaxWeight { get; set; } = 2000;
        public VenichleSize Size { get; set; } = new VenichleSize()
        {
            Height = 1.7,
            Lenght = 4.0
        };
        public double Velocity { get; set; } = 0;
        public double MaxVelocity { get; set; } = 180;
        public double TankVolume { get; set; } = 40;

        public MechanicVenichle()
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("MechanicVenichle: [Power: {0}, EmptyWeight: {1}, Weight: {2}, MaxWeight: {3}, Size: {4}, Velocity: {5}, TankVolume: {6}]", Power, EmptyWeight, Weight, MaxWeight, Size, Velocity, MaxVelocity, TankVolume);
        }
    }

    public class PassengerVenichle: MechanicVenichle
    {
        public int PassengerCount = 5;
        public int DoorCount = 5;
        public bool HasLoadTank = false;

        public PassengerVenichle(): base()
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("PassengerCar[{0}, PassengerCount: {1}, DorCount: {2}, HasLoadTank: {3}]", base.ToString(), PassengerCount, DoorCount, HasLoadTank);
        }
    }
}
