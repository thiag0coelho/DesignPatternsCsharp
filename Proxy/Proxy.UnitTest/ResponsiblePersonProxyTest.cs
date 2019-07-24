using NUnit.Framework;
using Proxy;

namespace Tests
{
    [TestFixture]
    public class ResponsiblePersonProxyTest
    {
        [TestCase(20)]
        public void When_personAgeAbove18(int age)
        {
            var person = new Person(age);
            var personProxy = new ResponsiblePersonProxy(person);

            Assert.That(personProxy.Drive(), Is.EqualTo("driving"));
            Assert.That(personProxy.Drink(), Is.EqualTo("drinking"));
            Assert.That(personProxy.DrinkAndDrive(), Is.EqualTo("dead"));
        }

        [TestCase(10)]
        public void When_personAgeBelow18_expect_Drinking(int age)
        {
            var person = new Person(age);
            var personProxy = new ResponsiblePersonProxy(person);

            Assert.That(personProxy.Drive(), Is.EqualTo("too young"));
            Assert.That(personProxy.Drink(), Is.EqualTo("too young"));
            Assert.That(personProxy.DrinkAndDrive(), Is.EqualTo("dead"));
        }
    }
}