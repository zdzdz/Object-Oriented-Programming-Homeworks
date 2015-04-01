using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace EuclidianSpace
{
    public struct Point3D
    {
        private static readonly Point3D origin = new Point3D() {X=0,Y=0,Z=0};

        public Point3D(double x, double y, double z) :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D Origin
        {
            get { return origin; }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("Point({0}, {1}, {2})", this.X, this.Y, this.Z));
            return result.ToString();
        }

        public static Point3D Parse(string text)
        {
            int openPar = text.IndexOf('(');
            double[] coordinates = text.Substring(openPar + 1, text.Length - openPar- 2)
                .Split(new[]{", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();

            return new Point3D(coordinates[0], coordinates[1], coordinates[2]);
        }
    }
}
