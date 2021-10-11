using Microsoft.VisualStudio.TestTools.UnitTesting;
using oneGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneGUI.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MaxTest1()
        {
            var a = 709;

            var outMessage = Logic.Max(a);

            Assert.AreEqual("Максимальное число: 9", outMessage);

        }
        [TestMethod()]
        public void MaxTest2()
        {
            var a = 99;

            var outMessage = Logic.Max(a);

            Assert.AreEqual("Введите трехзначное число! ", outMessage);

        }
        [TestMethod()]
        public void MaxTest3()
        {
            var a = 1000;

            var outMessage = Logic.Max(a);

            Assert.AreEqual("Введите трехзначное число! ", outMessage);

        }
        [TestMethod()]
        public void MaxTest4()
        {
            var a = 555;

            var outMessage = Logic.Max(a);

            Assert.AreEqual("Максимального числа нет, числа равны", outMessage);

        }
        
    }
}