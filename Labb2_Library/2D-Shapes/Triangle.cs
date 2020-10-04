using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using Labb2_Library;
using System.Collections;

namespace Labb2_Library
{
    public class Triangle : Shape2D, IEnumerable, IEnumerator
    {
        public override float Circumference { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }

        public readonly Vector2 vertice1;
        public readonly Vector2 vertice2;
        public readonly Vector2 vertice3;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            vertice1 = new Vector2(p1.X, p1.Y);
            vertice2 = new Vector2(p2.X, p2.Y);
            vertice3 = new Vector2(p3.X, p3.Y);

            float length1 = (float) Math.Sqrt((Math.Pow(Math.Abs((p1.X - p2.X)), 2) + Math.Pow(Math.Abs((p1.Y - p2.Y)), 2)));
            float length2 = (float) Math.Sqrt((Math.Pow(Math.Abs((p2.X - p3.X)), 2) + Math.Pow(Math.Abs((p2.Y - p3.Y)), 2)));
            float length3 = (float) Math.Sqrt((Math.Pow(Math.Abs((p3.X - p1.X)), 2) + Math.Pow(Math.Abs((p3.Y - p1.Y)), 2)));
            

            this.Circumference = length1 + length2 + length3;

            this.Center = new Vector3(((p1.X + p2.X + p3.X) / 3), ((p1.Y + p2.Y + p3.Y) / 3), 0);

            float p = (length1 + length2 + length3) / 2;
            this.Area = (float)Math.Sqrt(p * (p - length1) * (p - length2) * (p - length3));
        }

        public override string ToString()
        {
            return $"Triangle: @({Center.X}, {Center.Y}): p1({vertice1.X}, {vertice1.Y}), p2({vertice2.X}, {vertice2.Y}), p3({vertice3.X}, {vertice3.Y})";
        }


        public object Current
        {
            get
            {
                var verticeArray = new Vector2[] { vertice1, vertice2, vertice3 };
                return verticeArray[position];
            }
        }
        
        public int position = -1;
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator) this;
        }
        public bool MoveNext() //Must start at (-1)
        {
            position++;
            return position < 3;
        }
        public void Reset()
        {
            position = -1;
        }
    }
}
