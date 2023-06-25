using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariable
{
    abstract public class Shape
    {
        public abstract void CalculateArea();
    }

    public class Rectanglel: Shape {
        private int length, breath, rect;

        public Rectanglel(int length, int breath)
        {
           this.length = length;
            this.breath = breath;
        }
        public override void CalculateArea()
        {
            rect = length * breath;
        }
        public override string ToString()
        {
            return $"Area of rectangle {rect}";
        }
    }
}
