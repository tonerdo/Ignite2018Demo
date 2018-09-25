using System;
using GenFu;
using Ignite2018Demo.Lib;
using Xunit;

namespace Ignite2018Demo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestFullname()
        {
            Person person = A.New<Person>();
            string fullname = string.Format("{0} {1}", person.FirstName, person.LastName);
            Assert.Equal(fullname, person.FullName);
        }
    }
}
