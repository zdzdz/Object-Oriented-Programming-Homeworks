using System;

namespace DefineClass
{
    public class Call
    {
        private DateTime dateTime;
        private string dialedPhone;
        private string number;
        private double duration;
        public Call(DateTime dateTime, string dialedPhone, string number, double duration)
            : base()
        {
            this.DateTime = dateTime;
            this.DialedPhone = dialedPhone;
            this.Number = number;
            this.Duration = duration;
        }
        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            private set
            {
                this.dateTime = value;
            }
        }
        
        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set { this.dialedPhone = value; }
        }
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public double Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }
    }
}
