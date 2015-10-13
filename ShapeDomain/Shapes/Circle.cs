using ShapeDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDomain.Shapes
{
    public class Circle : BaseShape
    {
        private float _radius;
        public Circle(float radius, ColorType color)
        {
            _radius = radius;
            Color = color;
        }

        public override ShapeType Shape
        {
            get { return ShapeType.circle; }
        }

        public override decimal Area
        {
            get { return (decimal)(Math.PI * (_radius * _radius)); }
        }

    }
}
