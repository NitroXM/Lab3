using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Rectangle
    {
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double side1;
        public double side2;

        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
            return side1 + side2;
        }
    public double Area
    {
        get { return AreaCalculator(); }
    }
    public double Perimeter
    {
        get { return PerimeterCalculator(); }
    }
    }

