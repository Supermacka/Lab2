using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Labb2_Library
{
    public class Rectangle : Shape2D
    {
        public override float Circumference { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }

        public Vector2 Size { get; }
        public bool IsSquare { get; } = false;


        public Rectangle(Vector2 center, Vector2 size)
        {
            this.Circumference = (2 * size.X) + (2 * size.Y);
            this.Center = new Vector3(center, 0);
            this.Area = (size.X) * (size.Y);

            this.Size = size;

            if (size.X == size.Y)
            {
                IsSquare = true;
            }
        }
        public Rectangle(Vector2 center, float width)
        {
            this.Circumference = (4 * width);
            this.Center = new Vector3(center, 0);
            this.Area = (width) * (width);

            this.Size = new Vector2(width, width);

            IsSquare = true;
        }

        public override string ToString()
        {
            return $"Rectangle: @({Center.X}, {Center.Y}): W={Size.X}, h={Size.Y}: isSquare: {IsSquare}";
        }
    }
}
