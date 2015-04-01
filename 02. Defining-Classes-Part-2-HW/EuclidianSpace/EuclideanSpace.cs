using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidianSpace
{
    public class EuclideanSpace
    {
        static void Main()
        {
            Point3D point = new Point3D(1,2,3);

            //point.X = 1;
            //point.Y = 2;
            //point.Z = 3;

            Console.WriteLine(point);
            Console.WriteLine(new string('=', 20));
            Console.WriteLine(Point3D.Origin);
            Console.WriteLine(new string('=', 20));
            var dist = Point3DExtensions.CalculateDistance(point, Point3D.Origin);
            Console.WriteLine(dist);
            Console.WriteLine(new string('=', 20));

            Path path = new Path();
            for (int i = 0; i < 10; i++)
            {
                path.AddPoint(new Point3D(){X = i, Y = i+2, Z=i*2});
            }

            string pathStr = "../../testfile.txt";
            PathStorage.SavePath(path, pathStr);
            var pathFromFile = PathStorage.LoadPath(pathStr);

            foreach (var line in pathFromFile)
            {
                Console.WriteLine(line);
            }
        }
    }
}
