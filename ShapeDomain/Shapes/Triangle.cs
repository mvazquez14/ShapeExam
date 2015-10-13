using ShapeDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDomain.Shapes
{
    public class Triangle : BaseShape
    {
        private float _basis;
        private float _height;

        public Triangle(float basis, float height, ColorType color)
        {
            _basis = basis;
            _height = height;
            Color = color;
        }

        public override ShapeType Shape
        {
            get { return ShapeType.triangle; }
        }

        public override decimal Area
        {
            get { return (decimal)((_basis * _height) / 2); }
        }
    }
}
