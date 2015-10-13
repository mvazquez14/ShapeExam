using ShapeDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDomain.Shapes
{
    public class Square : BaseShape
    {
        private float _length;
        public Square(float length, ColorType color)
        {
            _length = length;
            Color = color;
        }

        public override ShapeType Shape
        {
            get { return ShapeType.square; }
        }

        public override decimal Area
        {
            get { return (decimal)(_length * _length); }
        }
    }
}
