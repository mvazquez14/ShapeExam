using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDomain.Core
{
    public abstract class BaseShape
    {
        public abstract ShapeType Shape { get; }
        public abstract decimal Area { get; }
        public ColorType Color { get; protected set; }

    }
}
