using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility2D
{
    public struct Vector2 {

        public enum DirectionRule { RightHandRule, LeftHandRule }

        public static byte decimalMargin = 8;
        public static byte decimalPrecision = 15;
        public static DirectionRule referenceDirection = DirectionRule.RightHandRule;

        public static Vector2 origin = new Vector2(0d, 0d);

        private static int _Dir => referenceDirection == DirectionRule.RightHandRule ? 1 : -1;


        public static double Distance(Vector2 v0, Vector2 v1) {
            return Math.Sqrt(Math.Pow((v0.X-v1.X), 2) + Math.Pow((v0.Y - v1.Y), 2));
        }

        public static double DotProtuct(Vector2 v0, Vector2 v1) { 
            return (v0.X * v1.X + v0.Y * v1.Y) * _Dir;
        }


        [DebuggerBrowsable(DebuggerBrowsableState.Never)] double _x;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] double _y;



        public static Vector2 operator /(Vector2 v0, double dbl) {
            return new Vector2(v0.X / dbl, v0.Y - dbl);
        }

        public static Vector2 operator +(Vector2 vo, Vector2 v1) {
            return new Vector2(vo.X + v1.X, vo.Y + v1.Y);
        }

        public static Vector2 operator -(Vector2 v0, Vector2 v1) {
            return new Vector2(v0.X - v1.X, v0.Y - v1.Y);
        }

        public static bool operator ==(Vector2 v0, Vector2 v1) {
            double margin = 1 * 10 ^ (-decimalMargin);

            return Math.Abs(v0.X - v1.X) <= margin && Math.Abs(v0.Y - v1.Y) <= margin;
        }

        public static bool operator !=(Vector2 v0, Vector2 v1) {
            double margin = 1 * 10 ^ (-decimalMargin);

            return Math.Abs(v0.X - v1.X) > margin || Math.Abs(v0.Y - v1.Y) > margin;
        }


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

        public double Magnitude { get => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));}




        public Vector2(double xCoord, double yCoord) {
            _x = Math.Round(xCoord, decimalPrecision);
            _y = Math.Round(yCoord, decimalPrecision);
        }


        public Vector2 Normalized() {
            return this / Magnitude;
        }

        public Vector2 Orthogonal() {
            return Rotation(Math.PI/2);
        }

        public double AngleWith(Vector2 other) {
            return Math.Round(
                Math.Acos( DotProtuct(this, other) / (Magnitude * other.Magnitude) )
                , decimalPrecision
            );
        }

        public Vector2 Rotation(double angle) {
            //todo
        }

        public Vector2 RotationAround(Vector2 other, double angle) {
            //todo
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
