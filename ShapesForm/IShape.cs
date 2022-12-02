using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesForm
{
    internal interface IShape
    {
        string Name();
        string Color(string color);
        double ShapeArea();
        int NumOfVertices();
        void Roll();
    }


    internal class Rectangle : IShape
    {
        public string Name()
        {
            return "Rectangle";
        }
        public string Color(string color)
        {
            return color;
        }

        public double ShapeArea()
        {
            return _height*_width;
        }

        public int NumOfVertices()
        {
            return 4;
        }

        public void Roll() { }

        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }

    internal class Circle : IShape
    {
        static double PI = 3.14159265359;

        public string Name()
        {
            return "Circle";
        }

        public string Color(string color)
        {
            return color;
        }

        public double ShapeArea()
        {
            return _radius * _radius * PI;
        }

        public void Roll() 
        {
            Console.WriteLine("I can Roll, yes you can");
        }

        public int NumOfVertices() { return 0; }

        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        internal class Elipse : IShape
        {
            static double PI = 3.14159265359;
            public string Name()
            {
                return "Elipse";
            }

            public string Color(string color)
            {
                return color;
            }

            public double ShapeArea()
            {
                return _radius1 * _radius2 * PI;
            }

            public void Roll()
            {
                Console.WriteLine("I can Roll, yes you can");
            }

            public int NumOfVertices() { return 0; }

            private int _radius1;

            public int Radius1
            {
                get { return _radius1; }
                set { _radius1 = value; }
            }

            private int _radius2;

            public int Radius2
            {
                get { return _radius2; }
                set { _radius2 = value; }
            }
        }
    }

    internal class Tringle : IShape
    {
        public string Name()
        {
            return "Tringle";
        }
        public string Color(string color)
        {
            return color;
        }

        public double ShapeArea()
        {
            return _base * _height / 2;
        }
        private int _base;

        public int NumOfVertices()
        {
            return 3;
        }

        public void Roll() { }
        public int Base
        {
            get { return _base; }
            set { _base = value; }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
    }

    internal class Moon : IShape
    {
        public string Name()
        {
            return "Moon";
        }
        public string Color(string color)
        {
            return color;
        }

        public double ShapeArea()
        {
            return _spaceBetween;
        }
        private int _spaceBetween;

        public void Roll()
        {
            if(NumOfVertices() == 2)
            {
                Console.WriteLine("I am not a full moon, so i can`t roll");
            }
            else
            {
                Console.WriteLine("I can Roll, i am a full moon");
            }
        }

        public int NumOfVertices()
        {
            Random rand = new Random();
            if (1 == rand.Next(1, 3))
            {
                return 2;
            }
            else 
            { 
                return 0;
            }
        }

        public int SpaceBetween
        {
            get { return _spaceBetween; }
            set { _spaceBetween = value; }
        }
    }
}

