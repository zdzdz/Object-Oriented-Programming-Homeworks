using System;

namespace DefineClass
{
    public class Battery
    {
        private const string DEFAULT_MODEL = "Unknown";
        private const int DEFAULT_HOURS_TALK = 0;
        private const int DEFAULT_HOURS_IDLE = 0;
        private const Type DEFAULT_BATTERY_TYPE = Type.Unknown;

        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private Type batteryType;

        public enum Type
        {
            
            LiIon,
            Li_Po,
            NiMH,
            NiCd,
            Unknown
        }

        public Battery()
            : this(DEFAULT_MODEL, DEFAULT_HOURS_IDLE, DEFAULT_HOURS_TALK ,DEFAULT_BATTERY_TYPE)
        {
            
        }
        public Battery(string model)
        {
            this.ModelBat = model;
        }

        public Battery (Type batteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk, Type batteryType)
        {
            this.ModelBat = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public Battery(string model, Type batteryType)
        {
            this.ModelBat = model;
            this.BatteryType = batteryType;
        }


        public string ModelBat
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The battery model cannot be null or emtpy.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public int? HoursIdle { get; set; }


        public int? HoursTalk { get; set; }
        public Type BatteryType { get; set; }

    }
}



