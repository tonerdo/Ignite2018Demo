using System;
using GenFu;
using Ignite2018Demo.Lib;
using Shouldly;
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
            person.FullName.ShouldBe(fullname);
        }

        [Fact]
        public void TestFullnames()
        {
            var people = A.ListOf<Person>();
            people.ShouldAllBe(p => p.FullName == string.Format("{0} {1}", p.FirstName, p.LastName));
        }
    }
}
