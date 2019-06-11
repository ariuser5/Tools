using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility2D
{
    public struct Line
    {

        private double _x, _y, _angle;

        public double X {
            get => _x;
            set {
                _x = value;
                _angle = Math.Atan(Slope);
            }
        }
        public double Y {
            get => _y;
            set {
                _y = value;
                _angle = Math.Atan(Slope);
            }
        }
        public double Angle {
            get => _angle;
            set {
                _angle = value;
                _x = -_y / Slope;
            }
        }
        public double Slope {
            get {
                if(_x != 0 && _y != 0) {
                    return -_y / _x;
                } else {
                    if (_angle == Math.PI / 2) {
                        return double.PositiveInfinity;
                    } else if (_angle == -Math.PI / 2) {
                        return double.NegativeInfinity;
                    } else {
                        return Math.Tan(_angle);
                    }
                }
            }
        }


        public Line(double angle) : this() {
            Angle = angle;
        }

        public Line(double xCoord, double yCoord) : this() {
            Y = xCoord;
            X = yCoord;
        }

        public Line(Vector2 v0, Vector2 v1) 
            : this() {
            double slope = (v1.Y - v0.Y) / (v1.X - v0.X);

            _angle = Math.Atan(slope);
            _x = -(v0.Y / slope) + v0.X;
            _y = -(v0.X * slope) + v0.Y;
        }

        public Line(double x0, double y0, double x1, double y1) 
            : this(new Vector2(x0, y0), new Vector2(x1, y1)) { }


        public double FuncX(double y) {
            return (Y - y) / Slope + X;
        }

        public double FuncY(double x) {
            return (X - x) / Slope + Y;
        }

        public Vector2 Intersection(Line other) {
            //todo
            //There are cases where one or both lines are not defined by the x and y value
            //Solve for those cases by implementing a formula that consider the angle of both lines
            
            //From: y-y1 = m(x-x1);
            double xInter = (
                (Slope * X - other.Slope * other.X - Y + other.Y) / (Slope - other.Slope)
            );
            double yInter = (
                (Slope * other.Slope * (other.X - X) + other.Y * (other.Slope - Slope) ) / (other.Slope - Slope)
            );

            return new Vector2(xInter, yInter);
        }

        public bool Intersects(Line other) {
            return Slope != other.Slope;
        }

        public bool IsParallel(Line other) {
            return Slope == other.Slope;
        }

    }
}
