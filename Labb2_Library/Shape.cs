using System;
using System.Numerics;

namespace Labb2_Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static int RandomNumberGenerator()
        {
            Random rndm = new Random();
            return  rndm.Next(1, 20);
        }

        public static Shape GenerateShape()
        {
            Random rndm = new Random();
            int randomShape = rndm.Next(0, 7);

            Shape returnShape = null;


            switch (randomShape)
            {
                //Circle
                case 0:
                    returnShape = new Circle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), RandomNumberGenerator());
                    break;
                
                //Rectangle
                case 1:
                    returnShape =  new Rectangle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()));
                    break;

                //Square
                case 2:
                    returnShape = new Rectangle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), RandomNumberGenerator());
                    break; 

                //Triangle
                case 3:
                    returnShape = new Triangle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()));
                    break;

                //Cuboid
                case 4:
                    returnShape = new Cuboid(new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()), new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()));
                    break;

                //Cube
                case 5:
                    returnShape = new Cuboid(new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()), RandomNumberGenerator());
                    break;

                //Sphere
                case 6:
                    returnShape = new Sphere(new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()), RandomNumberGenerator());
                    break;
            }
            return returnShape;
        }

        public static Shape GenerateShape(Vector3 postition)
        {
            Random rndm = new Random();
            int randomShape = rndm.Next(0, 7);

            Shape returnShape = null;


            switch (randomShape)
            {
                //Circle
                case 0:
                    returnShape = new Circle(new Vector2(postition.X, postition.Y), RandomNumberGenerator());
                    break;

                //Rectangle
                case 1:
                    returnShape = new Rectangle(new Vector2(postition.X, postition.Y), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()));
                    break;

                //Square
                case 2:
                    returnShape = new Rectangle(new Vector2(postition.X, postition.Y), RandomNumberGenerator());
                    break;

                //Triangle
                case 3:
                    float p1X = RandomNumberGenerator();
                    float p1Y = RandomNumberGenerator();
                    float p2X = RandomNumberGenerator();
                    float p2Y = RandomNumberGenerator();

                    returnShape = new Triangle(new Vector2(p1X, p1Y), new Vector2(p2X, p1Y), new Vector2((postition.X*3) - p1X - p2X, (postition.Y*3) - p1Y - p2Y));
                    break;

                //Cuboid
                case 4:
                    returnShape = new Cuboid(new Vector3(postition.X, postition.Y, postition.Z), new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()));
                    break;

                //Cube
                case 5:
                    returnShape = new Cuboid(new Vector3(postition.X, postition.Y, postition.Z), RandomNumberGenerator());
                    break;

                //Sphere
                case 6:
                    returnShape = new Sphere(new Vector3(postition.X, postition.Y, postition.Z), RandomNumberGenerator());
                    break;
            }
            return returnShape;
        }
    }
}
