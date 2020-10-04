using Labb2_Library;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Labb2_ConsoleApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            float triangleCircumferenceSum = 0; 
            float averageArea = 0;
            float greatestVolume = 0;
            Shape3D greatestVolumeItem = null;

            List<Shape> randomShapesList = new List<Shape>();
            int count = 1;
            int greatestVolumeCount = 0;

            for (int i = 0; i < 20; i++)
            {
                randomShapesList.Add(Shape.GenerateShape());
            }
            foreach (Shape this_Shape in randomShapesList)
            {
                if (this_Shape is Triangle this_Triangle)
                {
                    triangleCircumferenceSum += this_Triangle.Circumference;
                }
                if (this_Shape is Shape3D this_Shape3D)
                {
                    if (this_Shape3D.Volume > greatestVolume)
                    {
                        greatestVolumeItem = this_Shape3D;
                        greatestVolume = this_Shape3D.Volume;
                        greatestVolumeCount = count;
                    }
                }
                Console.WriteLine($"{count}: {this_Shape}");
                averageArea += this_Shape.Area;
                count++;
            }

            Console.WriteLine("- - - - - - - - - - - - - - - - -");
            Console.WriteLine();
            Console.WriteLine("Calculations");
            Console.WriteLine($"The sum for the circumference of all the triangles is: {triangleCircumferenceSum}cm");
            Console.WriteLine($"The average area of all the shapes is: {averageArea/randomShapesList.Count}cm2");
            Console.WriteLine($"Item [{greatestVolumeCount}: {greatestVolumeItem}] has the greatest volume of: {greatestVolume}cm³");

            
            //VG 
            Triangle t = new Triangle(Vector2.Zero, Vector2.One, new Vector2(2.0f, 0.5f));

            Console.WriteLine("- - - - - - - - - - - - - - - - -");
            Console.WriteLine();
            Console.WriteLine("The triangle you created has the following vertices");
            foreach (Vector2 v in t)
            {
                Console.WriteLine($"Vertice {t.position + 1}: {v}");
            }
        }
    }
}
