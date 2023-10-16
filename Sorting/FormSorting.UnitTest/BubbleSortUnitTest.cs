using FormSorting.Application.DefaultService;
using FormSorting.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSorting.UnitTest
{
    [TestClass]
    public class BubbleSortUnitTest
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            BubbleSortAppService bubbleSortAppService = new BubbleSortAppService();
            int[] input = { 64, 34, 25, 12, 22, 11, 90 };
            List<BubbleSortDto> result = bubbleSortAppService.getBubbleSort(input);
            Assert.IsNotNull(result);
        }
    }
}
