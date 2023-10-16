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
    public class QuickSortUnitTest
    {
        [TestMethod]
        public void QuickSortTest()
        {
            QuickSortAppService quickSortAppService = new QuickSortAppService();
            int[] input = { 64, 34, 25, 12, 22, 11, 90 };
            List<QuickSortDto> result = quickSortAppService.getQuickSort(input, 0, input.Length - 1);
            Assert.IsNotNull(result);
        }
    }
}
