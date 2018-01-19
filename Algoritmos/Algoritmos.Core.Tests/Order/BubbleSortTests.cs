using Algoritmos.Core.Order;
using Algoritmos.Core.Tests.Order;
using System;
using Xunit;

namespace Algoritmos.Core.Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void NormalOrder()
        {
            int[] resultado = BubbleSortOrder.Order(OrderData.NormalArrayUnsorted());

            Assert.Equal(resultado, OrderData.NormalArraySorted());
        }

        [Fact]
        public void BigOrder()
        {
            int[] resultado = BubbleSortOrder.Order(OrderData.BigArrayUnsorted());

            Assert.Equal(resultado, OrderData.BigArraySorted());
        }
    }
}
