using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility2D
{
    public struct Vector2 : ICoordinate2
    {

        public static byte decimalPrecision = 8;
        public static Vector2 origin = new Vector2(0d, 0d);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] double _x;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] double _y;

        public double X {
            get {
                return _x;
            }
            set {
                _x = Math.Round(value, decimalPrecision);
            }
        }

        public double Y {
            get {
                return _y;
            }
            set {
                _y = Math.Round(value, decimalPrecision);
            }
        }

        public Vector2(double xCoord, double yCoord) {
            _x = Math.Round(xCoord, decimalPrecision);
            _y = Math.Round(yCoord, decimalPrecision);
        }
    }
}
