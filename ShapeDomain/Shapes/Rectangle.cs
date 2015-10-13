using ShapeDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDomain.Shapes
{
    public class Rectangle : BaseShape
    {
        private float _length;
        private float _width;

        public Rectangle(float length, float width, ColorType color)
        {
            _length = length;
            _width = width;
            Color = color;
        }

        public override ShapeType Shape
        {
            get { return ShapeType.rectangle; }
        }

        public override decimal Area
        {
            get { return (decimal)(_length * _width); }
        }
    }
}
