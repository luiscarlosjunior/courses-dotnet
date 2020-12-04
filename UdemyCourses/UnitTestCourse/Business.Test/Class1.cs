using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SerialPortParser;

namespace Business.Test
{
    [TestFixture]
    public class Class1
    { 
        [Test]
        public void ParsePort_COM1_Return1()
        {
            int result = SerialParsePort.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
