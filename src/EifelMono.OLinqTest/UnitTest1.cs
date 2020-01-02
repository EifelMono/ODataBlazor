using System;
using System.Collections.Generic;
using ODataBlazor.Common.Models;
using Xunit;
using EifelMono.OLinq;

namespace EifelMono.OLinqTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = ODataLinq.Get<Customer>("http://127.0.0.1:5003/odatat/customers")
                .FirstOrDefault(c => c.Name == "ss");
        }
    }
}
