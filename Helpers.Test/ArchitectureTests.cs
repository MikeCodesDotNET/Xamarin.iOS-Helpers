using System;
using NUnit.Framework;
using Foundation;
using MikeJames;

namespace Helpers.Test
{
    [TestFixture]
    public class ArchitectureTests
    {
        [Test]
        public void DateTimeToNsDate()
        {
            var arch = Architecture.Is64Bit();
            Assert.IsTrue(arch == false);
        }


    }
}

