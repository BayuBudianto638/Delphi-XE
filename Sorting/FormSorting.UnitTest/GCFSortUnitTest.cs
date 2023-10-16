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
    public class GCFSortUnitTest
    {
        [TestMethod]
        public void GCFSortTest()
        {
            GCFSortAppService gcfSortAppService = new GCFSortAppService();
            int[] input = { 64, 34, 25, 12, 22, 11, 90 };
            List<GCFSortDto> result = gcfSortAppService.getGCFSort(input);
            Assert.IsNotNull(result);
        }
    }
}
