using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidianSpace
{
    public static class PathStorage
    {
        public static void SavePath(Path path, string filePath)
        {
            var sr = new StreamWriter(filePath);
            using (sr)
            {
                foreach (var point in path)
                {
                    sr.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            var path = new Path();
            var sr = new StreamReader(filePath, true);
            using (sr)
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var point = Point3D.Parse(line);
                    path.AddPoint(point);
                }
            }
            return path;
        }
    }
}
