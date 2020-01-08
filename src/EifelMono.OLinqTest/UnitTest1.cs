using ODataBlazor.Common.Models;
using Xunit;
using EifelMono.OLinq;
using Microsoft.Rest.Azure.OData;
using System.Diagnostics;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using ODataBlazor.Data;

namespace EifelMono.OLinqTest
{
    public class UnitTest1
    {

        [Fact]
        public void Test_Linq()
        {
            var repro = new DefaultDataRespository();

            var y = repro.GetCustomers().Select(c => c.Name);
            var z = repro.GetCustomers().OrderBy(c=> c.Orders).Select(c => c.Name);
        }

        [Fact]
        public void Test_ODataQuery_Azure()
        {
            {
                var sw = Stopwatch.StartNew();
                var x = new ODataQuery<Customer>();
                x.SetFilter(c => c.Name == "x");
                var s = x.ToString();
                sw.Stop();
                Debug.WriteLine(sw.ElapsedMilliseconds);
                Debug.WriteLine(s);
            }

            {
                var sw = Stopwatch.StartNew();
                var x = new ODataQuery<Customer>();
                x.SetFilter(c => c.Name.ToLower().Contains("x"));
                var s = x.ToString();
                sw.Stop();
                Debug.WriteLine(sw.ElapsedMilliseconds);
                Debug.WriteLine(s);
            }

            {
                var sw = Stopwatch.StartNew();
                var x = new ODataQuery<Customer>();
                x.SetFilter(c => c.TimeStamp== DateTime.Now);
                var s = x.ToString();
                sw.Stop();
                Debug.WriteLine(sw.ElapsedMilliseconds);
                Debug.WriteLine(s);
            }
        }

        [Fact]
        public void Test_Get_Where_FirstOrDefault()
        {
            var x = ODataLinq.Get<Customer>("http://127.0.0.1:5003/odatat/customers")
                .Where(c => c.Name == "ss")
                .OrderBy(c => new { c.Name, c.Id })
                .Take(5)
                .Skip(2);
        }
    }
}
