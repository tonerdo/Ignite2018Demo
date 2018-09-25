using System;

namespace Ignite2018Demo.Lib
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Format("{0} {1}", FirstName, LastName);
    }
}
