using System;
namespace project
{
    class circle
    {
        private double r;
        double pi = 3.14;
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        public circle() { }
        public circle(double R)
        {
            r = R;
        }
        public double A()
        { return r * r * pi; }
        public double S()
        { return 2 * r * pi; }
    }//end class circle
    class triangle
    {
        private double x;
        private double h;
        private double z;
        public double X
        {
            get { return x; }
            set
            {
                if (value > 0)
                { x = value; }
            }

        }
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                { h = value; }
            }
        }
        public double Z
        {
            get { return z; }
            set
            {
                if (value > 0)
                { z = value; }
            }
        }
        public triangle() { }
        public triangle(double X, double H, double Z)
        {
            x = X;
            h = H; ;
            z = Z;

        }
        public double A()
        { return x * h / 2; }
        public double S()
        { return x + h + z; }

    }//end class triangle
    class square
    {
        private double x;
        public double X
        {
            get { return x; }
            set
            {
                if (value > 0)
                { x = value; }
            }
        }
        public square() { }
        public square(double X)
        {
            x = X;
        }
        public double A()
        { return x * x; }
        public double P()
        { return 2 * x; }
    }//end square
    class zoozanaghe
    {
        private double a_min;
        private double a_max;
        private double h;
        private double n;
        private double o;
        public double A_min
        {
            get { return a_min; }
            set
            {
                if (value > 0)
                { a_min = value; }

            }

        }
        public double A_max
        {
            get { return a_max; }
            set
            {
                if (value > 0)
                { a_max = value; }

            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                { h = value; }

            }
        }
        public double N
        {
            get { return n; }
            set
            {
                if (value > 0)
                { n = value; }

            }
        }
        public double O
        {
            get { return o; }
            set
            {
                if (value > 0)
                { o = value; }

            }
        }

        public zoozanaghe() { }
        public zoozanaghe(double A_max, double A_min, double H, double N, double O)
        {
            a_max = A_max;
            a_min = A_min;
            h = H;
            n = N;
            o = O;
        }
        public double A()
        { return ((a_max + a_min) / 2) * h; }
        public double P()
        { return o + a_min + n + a_max; }
    }//end class zoozanaghe
    class Polygan
    {
        private double n;
        private double b;
        private double h;
        double pi = 180;
        public double N
        {
            get { return n; }
            set
            {
                if (value > 0)
                { n = value; }

            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                { b = value; }

            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                { h = value; }

            }
        }
        public Polygan() { }
        public Polygan(double N, double B, double H)
        {
            n = N;
            b = B;
            h = H;
        }
        public double P()
        { return (n * Math.Pow(b, 2)) / (4 * Math.Tan(pi / n)); }
        public double S()
        {
            return ((n * Math.Pow(b, 2)) / (4 * Math.Tan(pi / n))) * h / 2;

        }
    }//end class polygan
    class beizi
        {
            private double r_min;
            private double r_max;
            double pi = 3.14;

            public double Max
            {
                get { return r_max; }
                set
                {
                    if (value > 0)
                    { r_max = value; }
                }
            }

            public double Min
            {
                get { return r_min; }
                set
                {
                    if (value > 0)
                    { r_min = value; }
                }

            }
            public beizi() { } //mokhareb function
            public beizi(double Max, double Min)
            {
                r_max = Max;
                r_min = Min;
            }//sazande function
            public double A()
            {
                return pi * r_max * r_min;
            }
            public double P()
            {
                return ((r_max * r_min) / 2) * pi * 2;
            }
        }//end class beizi
    class mostatil
    {
        private double w;
        private double b;

        public double W
        {
            get { return w; }
            set
            {
                if (value > 0)
                { w = value; }

            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                { b = value; }

            }
        }
        public mostatil() { }
        public mostatil(double W,double B) 
        {
            w = W;
            b = B;
        }
        public double A() 
        { return w * b; }
        public double P()
        { return 2 * (w + b); }
    }
    
    

    class test
    {
        public static void Main()
        {
            Console.WriteLine("choose a number of these shapes: 1.circle 2.triangle 3.square 4.zoozanaghe 5.polygan(has n side) 6.beizi  7.mostatil");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("inter shoae");
                double r = Convert.ToDouble(Console.ReadLine());
                circle c = new circle(r);
                Console.WriteLine("masahat:" + c.A());
                Console.WriteLine("mohit:" + c.S());
            }
            else if (num == 2)
            {
                Console.WriteLine("inter x , hieght,z");
                double x = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                triangle t = new triangle(x, h, z);
                Console.WriteLine("masahat" + t.A());
                Console.WriteLine("mohit:" + t.S());
            }
            else if (num == 3)
            {
                Console.WriteLine("inter numbe:");
                double x = Convert.ToDouble(Console.ReadLine());
                square s = new square(x);
                Console.WriteLine("masahat" + s.A());
                Console.WriteLine("mohit:" + s.P());
            }
            else if (num == 4)
            {
                Console.WriteLine("inter min and max ghaedes and hieght and then inter other sides");
                double x = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                zoozanaghe q = new zoozanaghe(x, h, z, a, b);
                Console.WriteLine("masahat" + q.A());
                Console.WriteLine("mohit:" + q.P());
            }
            else if(num==5)
            {
                Console.WriteLine("inter number of sides and then inter one side size and then hieght");
                int n = Convert.ToInt32(Console.ReadLine());
                double x = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());
                Polygan i = new Polygan(n, x, h);
                Console.WriteLine("masahat" + i.P());
                Console.WriteLine("mohit:" + i.S());

            }
            else if (num == 6)
            {
                Console.WriteLine("inter shoae koochack then bozorg");
                double x = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());
                beizi b = new beizi(x, h);
                Console.WriteLine("masahat" + b.A());
                Console.WriteLine("mohit:" + b.P());
            }
            else if (num==7)
            {
                Console.WriteLine("inter tool and arz");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                mostatil m = new mostatil(x, y);
                Console.WriteLine("masahat" +m.A());
                Console.WriteLine("mohit:" + m.P());
            }
        }
    }
}