using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Labb2_Library
{
    public class Cuboid : Shape3D
    {
        public override float Volume { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }

        public Vector3 size;
        private bool IsCube { get; } = false;


        public Cuboid(Vector3 center, Vector3 size)
        {
            this.size = new Vector3(size.X, size.Y, size.Z);

            this.Volume = (size.X) * (size.Y) * (size.Z);
            this.Center = new Vector3(center.X, center.Y, center.Z);
            this.Area = ((2 * size.X) * size.Y) + ((2 * size.Y) * size.Z) + ((2 * size.X) * size.Z);

            if (size.X == size.Y && size.Z == size.Y)
            {
                IsCube = true;
            }
        }

        public Cuboid(Vector3 center, float width)
        {
            size = new Vector3(width, width, width);

            this.Volume = (width) * (width) * (width);
            this.Center = new Vector3(center.X, center.Y, center.Z);
            this.Area = (width * width) * 6;

            IsCube = true;
        }

        public override string ToString()
        {
            return $"cuboid @({Center.X}, {Center.Y}, {Center.Z}): w= {size.X}, h= {size.Y}, l= {size.Z}: isCube= {IsCube}";
        }
    }
}
