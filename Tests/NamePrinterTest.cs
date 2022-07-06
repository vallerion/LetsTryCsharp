using System;
using System.Diagnostics;
using System.IO;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            var np = new NamePrinter.Printer("Valera");
            np.Print();
            Assert.Equal("Name: Valera\n", sw.ToString());
        }
    }
}
