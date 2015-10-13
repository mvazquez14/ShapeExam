using ShapeDomain.Core;
using ShapeDomain.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDomain.Factory
{
    public class ShapeFactory
    {
        public static BaseShape GetShape(params string[] shapeConfig)
        {
            #region extracting shape configuration
            string _shape = shapeConfig[0];
            string _color;
            
            if (!Enum.IsDefined(typeof(ShapeType), _shape))
                throw new ArgumentOutOfRangeException("Shape", "Shape type not valid");

            ShapeType _createShape = (ShapeType)Enum.Parse(typeof(ShapeType), _shape);

            float p1 = 0f;
            float p2 = 0f;

            float.TryParse(shapeConfig[1], out p1);

            if (float.TryParse(shapeConfig[2], out p2))
                _color = shapeConfig[3];
            else
                _color = shapeConfig[2];

            if (!Enum.IsDefined(typeof(ColorType), _color))
                throw new ArgumentOutOfRangeException("Color", "Color type not valid");

            ColorType _colorType = (ColorType)Enum.Parse(typeof(ColorType), _color);
            #endregion

            #region initialize shape
            switch (_createShape)
            {
                case ShapeType.circle:
                    return new Circle(p1, _colorType);
                case ShapeType.rectangle:
                    return new Rectangle(p1, p2, _colorType);
                case ShapeType.square:
                    return new Square(p1, _colorType);
                case ShapeType.triangle:
                    return new Triangle(p1, p2, _colorType);
                default:
                    return null;
            }
            #endregion
        }
    }
}
