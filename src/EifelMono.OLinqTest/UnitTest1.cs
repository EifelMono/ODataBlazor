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
        public void Test_Get_FirstOrDefault()
        {
            var x = ODataLinq.Get<Customer>("http://127.0.0.1:5003/odatat/customers")
                .FirstOrDefault(c => c.Name == "ss");

            x.Se
        }

        [Fact]
        public void Test_Get_Where_FirstOrDefault()
        {
            var x = ODataLinq.Get<Customer>("http://127.0.0.1:5003/odatat/customers")
                .FirstOrDefault(c => c.Name == "ss");
        }
    }
}
