using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Recursion
{
    public class FibonacciNumberTest
    {
        [Fact]
        public void Test01()
        {
            FibonacciNumber fibonacci = new();
            int answer = fibonacci.Fib(2);

            Assert.Equal(1, answer);
        }

        [Fact]
        public void Test02()
        {
            FibonacciNumber fibonacci = new();
            int answer = fibonacci.Fib(3);

            Assert.Equal(2, answer);
        }
    }
}
