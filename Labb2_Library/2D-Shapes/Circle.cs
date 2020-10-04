using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace Labb2_Library
{
    public class Circle : Shape2D
    {
        public override float Circumference { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }

        public float Radius { get; } //Kanske måste ha en set?

        public Circle(Vector2 center, float radius)
        {
            this.Center = new Vector3(center, 0);
            this.Circumference = (float)(2 * Math.PI) * (radius);
            this.Area = (float) (Math.PI) * (float) (Math.Pow(radius, 2f));

            this.Radius = radius;
        }

        public override string ToString()
        {
            return ($"Circle: @({Center.X}, {Center.Y}): r={Radius}");
        }
    }
}
