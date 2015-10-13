using ShapeDomain.Core;
using ShapeDomain.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseShape> _shapes = new List<BaseShape>();

            Console.WriteLine("Please input your shape configuration in the next order");
            Console.WriteLine("shapename, value, (value), color");
            Console.WriteLine("To finish input shapes write X");
            Console.WriteLine("");

            string _input = String.Empty;
            bool _stop = false;

            do
            {
                _input = Console.ReadLine();

                if (_input.ToLower().Equals("x"))
                {
                    _stop = true;
                }
                else
                {
                    try
                    {
                        _shapes.Add(ShapeFactory.GetShape(_input.Split(new char[] { ',' })));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("UPS: Your shape can't be validated, try again");
                    }

                }

            } while (!_stop);

            //order all shapes
            if(_shapes.Count > 0)
            {
                var _orderall = _shapes.OrderBy(a => a.Area).ThenBy(c => c.Color);

                Console.WriteLine("");
                Console.WriteLine("Displaying all shapes ordered by area then color");

                foreach (var _shape in _orderall)
                {
                    Console.WriteLine("{0}, {1:0.00}, {2}", _shape.Shape.ToString(), _shape.Area, _shape.Color.ToString());
                }

                var _grouptype = _shapes.GroupBy(s => s.Shape);

                Console.WriteLine("");
                Console.WriteLine("Displaying grouped by type shape ordered by area then color");

                foreach (var _group in _grouptype)
                {
                    Console.WriteLine(String.Format("*** {0} ***",_group.Key.ToString()));

                    foreach (var _shape in _group)
                    {
                        Console.WriteLine("{0}, {1:0.00}, {2}", _shape.Shape.ToString(), _shape.Area, _shape.Color.ToString());                        
                    }

                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Thank you ! (c) Mario Alejandro 2015");
            Console.ReadKey();
        }
    }
}
