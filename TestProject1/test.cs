using NUnit.Framework;

namespace TestProject1
{
    public class test
    {
        private ConsoleApp1.Number _number;

        [SetUp]
        public void Setup()
        {
            _number = new ConsoleApp1.Number();
        }

        [Test]
        public void Test_SoChan()
        {
            Assert.That(_number.IsEven(2), Is.True);
        }

        [Test]
        public void Test_SoLe()
        {
            Assert.That(_number.IsEven(3), Is.False);
        }

        [Test]
        public void Test_SoAm()
        {
            Assert.That(_number.IsEven(-4), Is.True);
        }

        [Test]
        public void Test_SoKhongAmKhongDuong()
        {
            Assert.That(_number.IsEven(0), Is.True);
        }

        [Test]
        public void Test_SoLon()
        {
            Assert.That(_number.IsEven(1000000), Is.True);
        }
    }
}