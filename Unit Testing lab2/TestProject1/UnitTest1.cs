using System;
using Xunit;
using Unit_Testing_lab2;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestViewBalance()
        {
            Assert.NotEqual(-123, Program.ViewBalance());
        }

        [Fact]
        public void TestViewBalance2()
        {
            Assert.Equal(2000, Program.ViewBalance());
        }


        [Fact]
        public void TestWithDraw()
        {
            Assert.Equal(1900, Program.WithDraw(100));
        }

        [Fact]
        public void TestDeposit()
        {
            Assert.Equal(2100, Program.Deposit(100));
        }









    }
}
