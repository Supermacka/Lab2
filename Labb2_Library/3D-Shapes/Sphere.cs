using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Labb2_Library
{
    public  class Sphere : Shape3D
    {
        public override float Volume { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }

        readonly float radius;


        public Sphere(Vector3 center, float radius)
        {
            this.radius = radius;

            this.Volume = (float) (4 * Math.PI * Math.Pow(radius, 3)) / 3;
            this.Center = new Vector3(center.X, center.Y, center.Z);
            this.Area = (float) (4 * Math.PI * Math.Pow(radius, 2));
        }

        public override string ToString()
        {
            return $"Sphere @({Center.X}, {Center.Y}, {Center.Z}): r= {radius}";
        }
    }
}
