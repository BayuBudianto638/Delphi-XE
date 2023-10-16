using FormSorting.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSorting.Core.Interface
{
    public interface IQuickSortAppService
    {
        List<QuickSortDto> getQuickSort(int[] input, int nilaiA, int nilaiB);
    }
}
