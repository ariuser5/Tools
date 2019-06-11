using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility2D;

namespace UnitTests
{
    [TestClass]
    public class Vector2Test
    {
        [TestMethod]
        public void DotProduct_Test() {

            Vector2 v0 = new Vector2(1, 0);
            Vector2 v1 = new Vector2(0, 1);
            Vector2 v2 = new Vector2(1, 1);
            Vector2 v3 = new Vector2(1, -1);

            Assert.IsTrue(Vector2.DotProtuct(v0, v1) == 0);
            Assert.IsTrue(Vector2.DotProtuct(v1, v2) > 0);
            Assert.IsTrue(Vector2.DotProtuct(v1, v3) < 0);

        }

        [TestMethod]
        public void AngleWith_Test() {

            Vector2 v0 = new Vector2(1, 0);
            Vector2 v1 = new Vector2(0, 1);
            Vector2 v2 = new Vector2(1, 1);

            Assert.IsTrue(v0.AngleWith(v1) == Math.Round( Math.PI/2, Vector2.decimalPrecision) );
            Assert.IsTrue(v0.AngleWith(v2) == Math.Round( Math.PI / 4, Vector2.decimalPrecision) );

        }

        [TestMethod]
        public void Rotation_Test() {

            Vector2 v0 = new Vector2(1, 0);
            Vector2 v1 = new Vector2(0, 1);

            v0 = v0.Rotation(Math.PI/2);

            Assert.IsTrue(v0 == v1);

            v0 = v0.Rotation(Math.PI/2);

            Assert.IsTrue(v0.X == -1 && v0.Y == 0);

        }

        [TestMethod]
        public void RotationAround_Test() {

            Vector2 v0 = new Vector2(1, 0);
            Vector2 v1 = new Vector2(1, 1);
            Vector2 v2 = v0.RotationAround(v1, Math.PI / 2);

            Assert.IsTrue(v2.X == 2 && v2.Y == 1);

        }

        [TestMethod]
        public void Orthogonal_Test() {

            Vector2 v0 = new Vector2(1, 0);
            Vector2 v1 = v0.Orthogonal();

            Assert.IsTrue(v1.X == 0 && v1.Y == 1);

        }
    }
}
