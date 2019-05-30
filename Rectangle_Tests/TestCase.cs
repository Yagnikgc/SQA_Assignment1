using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using NUnit.Framework;

namespace Rectangle_Tests
{
    [TestFixture]
    class TestCase
    {
        [Test]
        public void Test_GetLength()
        {
            int l = 4;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l,w);
            int length = testRectangle.GetLength();
            Assert.AreEqual(length, l);
        }
        [Test]
        public void Test_GetWidth()
        {
            int l = 4;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);
            int width = testRectangle.GetWidth();
            Assert.AreEqual(width, w);
        }
        [Test]
        public void Test_SetLength()
        {
            int temp = 999;
            Rectangle rectangle = new Rectangle();
            int val = rectangle.SetLength(temp);
            Assert.AreEqual(val, temp);
        }
        [Test]
        public void Test_SetWidth()
        {
            int temp = 59;
            Rectangle rectangle = new Rectangle();
            int val = rectangle.SetWidth(temp);
            Assert.AreEqual(val, temp);
        }
        [Test]
        public void Test_GetPerimeter()
        {
            int l = 50, w = 60;
            Rectangle rectangle = new Rectangle(l, w);
            int answer = rectangle.GetPerimeter();
            Assert.AreEqual(answer, (2 * (l + w)));
        }
        [Test]
        public void Test_GetArea()
        {
            int l = 50, w = 60;
            Rectangle rectangle = new Rectangle(l, w);
            int answer = rectangle.GetArea();
            Assert.AreEqual(answer, (l * w));
        }
    }
}