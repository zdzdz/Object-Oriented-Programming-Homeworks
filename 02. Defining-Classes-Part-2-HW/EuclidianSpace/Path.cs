using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidianSpace
{
    public class Path : IEnumerable<Point3D>
    {
        private ICollection<Point3D> points;

        public Path()
        {
            points = new HashSet<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.points.GetEnumerator();
        }

        System.Collections.IEnumerator 
            System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
