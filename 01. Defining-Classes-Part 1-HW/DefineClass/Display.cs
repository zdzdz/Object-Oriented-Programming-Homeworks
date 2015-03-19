using System;

namespace DefineClass
{
    public class Display
    {
        private long numberOfColors;
        private double size;

        public Display()
        { }
        public Display(double size, long numberOfColors)
        {
            this.NumberOfColors = numberOfColors;
            this.Size = size;
        }

        public long NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
    }
}
