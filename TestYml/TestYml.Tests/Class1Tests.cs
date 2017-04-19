using NUnit.Framework;

namespace TestYml
{
    public class Class1Tests
    {
        [Test]
        public void TestHello()
        {
            var class1 = new Class1();

            Assert.That(class1.Hello(), Is.EqualTo("wat"));
        }
    }
}
