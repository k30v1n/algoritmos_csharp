using Algoritmos.Core.Order;
using Algoritmos.Core.Tests.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algoritmos.Core.Tests.Order
{
    public class QuickSortTests
    {
        [Fact]
        public void NormalOrder()
        {
            int[] resultado = QuickSortOrder.Order(OrderData.NormalArrayUnsorted());

            Assert.Equal(resultado, OrderData.NormalArraySorted());
        }
    }
}
