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
    public class MergeSortUnitTest
    {
        [TestMethod]
        public void MergeSortTest()
        {
            MergeSortAppService mergeSortAppService = new MergeSortAppService();
            int[] input = { 64, 34, 25, 12, 22, 11, 90 };
            List<MergeSortDto> result = mergeSortAppService.getMergeSort(input);
            Assert.IsNotNull(result);
        }
    }
}
