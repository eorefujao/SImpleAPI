using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetreturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Emanuel", returnValue.value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
