using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility2D;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() {

            Vector2 v0 = new Vector2(1, 0);
            Vector2 v1 = new Vector2(1, 10);
            double dist = Vector2.Distance(v0, v1);
            double dp = Vector2.DotProtuct(v0, v1);
            double aw = v0.AngleWith(v1);

            Vector2 v3 = v0 + v1.Orthogonal();


        }
    }
}
