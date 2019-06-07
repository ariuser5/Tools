using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility2D
{
    public struct Position2 : ICoordinate2
    {

        public static byte decimalPrecision = 8;
        public static Position2 origin = new Position2(0d, 0d);

        public static Position2 operator +(Position2 pos0, Position2 pos1) {
            return new Position2(pos0.X + pos1.X, pos0.Y + pos1.Y);
        }

        public static Position2 operator -(Position2 pos0, Position2 pos1) {
            return new Position2(pos0.X - pos1.X, pos0.Y - pos1.Y);
        }

        public static bool operator ==(Position2 pos0, Position2 pos1) {
            return (pos0.X == pos1.X && pos0.Y == pos1.Y) ? true : false;
        }

        public static bool operator !=(Position2 pos0, Position2 pos1) {
            return (pos0.X != pos1.X && pos0.Y != pos1.Y) ? true : false;
        }


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


        public Position2(double xCoord, double yCoord) {
            _x = Math.Round(xCoord, decimalPrecision);
            _y = Math.Round(yCoord, decimalPrecision);
        }


        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

    }
}
