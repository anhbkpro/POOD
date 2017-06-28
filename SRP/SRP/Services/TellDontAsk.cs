using System.Collections.Generic;

namespace SRP.Services
{

    public class TellDontAsk
    {
        public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square()
        {
            var shapes = new List<Shape>
            {
                 new Rectangle { Height = 4, Width = 5 },
                 new Square {SideLength = 3}
            };
            
            foreach (var item in shapes)
            {
                //Tell, Don't Ask ---> no need to check item type is Rectangle or Square
                item.Area();
            }
        }

        public abstract class Shape
        {
            public abstract int Area();
        }

        public class Rectangle : Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public override int Area()
            {
                return Height * Width;
            }
        }

        public class Square : Shape
        {
            public int SideLength { get; set; }
            public override int Area()
            {
                return SideLength * SideLength;
            }
        }
    }
}
