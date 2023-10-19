using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public static class Utils
    {
        public static double CalculerDistance(Point p1, Point p2)
        {
            int deltaX = p1.x - p2.x;
            int deltaY = p1.y - p2.y;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }
    }
}
