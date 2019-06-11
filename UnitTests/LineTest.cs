using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility2D;

namespace UnitTests
{
    [TestClass]
    public class LineTest
    {

        [TestMethod]
        public void DefineLine_Test() {

            Line l0 = new Line(1,2);
            Line l1 = new Line(new Vector2(1, 1), new Vector2(2, 0));
            Line l2 = new Line(1, 1 , 2, 0);

            Assert.IsTrue(l0.Intersects(l1));
            Assert.IsTrue(l1.IsParallel(l2));

        }

        [TestMethod]
        public void Intersection_Test() {

            Line l0 = new Line(1, 2);
            Line l1 = new Line(new Vector2(1, 1), new Vector2(2, 0));
            Line l2 = new Line(Math.PI/2);
            Line l3 = new Line(1, 1, 2, 2);

            Vector2 inter0 = l0.Intersection(l1);
            Vector2 inter1 = l2.Intersection(l3);

            //Assert.IsTrue(l0.Intersection(l1));
            //Assert.IsTrue(l1.IsParallel(l2));

        }
    }
}
