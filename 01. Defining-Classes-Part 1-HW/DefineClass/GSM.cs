using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class GSM
    {
        public static GSM IPhone4SInfo = new GSM("Iphone 4S", "Apple", 1300, "Mtel",
                                     new Battery("Apple", 640, 200, Battery.Type.LiIon),
                                     new Display(4.7, 160000000));

        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private List<Call> callHistory = new List<Call>();


        public GSM(string model, string manufacturer)
            : this(model, manufacturer, new Battery(), new Display())
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }


        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer, price, owner, new Battery(), new Display())
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Battery = battery;
            this.Display = display;
        }

        public GSM()
        {
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null or empty.");
                }
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be at least zero.");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.owner = null;
                }
                this.owner = value;
            }
        }
    

        public Display Display { get; set; }

        public Battery Battery { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("####### GSM Specifications #######");
            result.AppendLine();
            result.AppendLine(new string('=', 62));
            result.AppendLine("GSM Model: " + this.Model);
            result.AppendLine("GSM Manufacturer: " + this.Manufacturer);
            result.AppendLine("GSM Price: " + this.Price);
            result.AppendLine("GSM Owner: " + this.Owner);
            result.AppendLine("GSM battery specs : model - " + this.Battery.ModelBat +
                              ", type - " + this.Battery.BatteryType +
                              ", talk time - " + this.Battery.HoursTalk +
                              ", idle time - " + this.Battery.HoursIdle);

            result.AppendLine("GSM display specs : size - " + this.Display.Size +
                              ", number of colors - " + this.Display.NumberOfColors);
            
            result.AppendLine(new string('=', 62));
            result.AppendLine();
            return result.ToString();
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCalls(Call call)
        {
            int index = callHistory.IndexOf(call);
            if (index != -1)
            {
                this.callHistory.RemoveAt(index);
            }
            CallDeleted(null, null);
        }

        public event EventHandler CallDeleted;
        public void ClearCallHistory()
        {
            this.callHistory = new List<Call>();
            callHistoryClaeared(null, null);
        }

        public event EventHandler callHistoryClaeared;

        public double CalculateTotalPrice(double pricePerMinute)
        {
            double spentMoney = 0.0;
            double entireDuration = 0.0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                entireDuration += CallHistory[i].Duration;
            }
            spentMoney += (entireDuration * pricePerMinute);
            return spentMoney;
        }
    }
}
