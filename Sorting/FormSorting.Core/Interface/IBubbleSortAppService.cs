using FormSorting.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSorting.Core.Interface
{
    public interface IBubbleSortAppService
    {
        List<BubbleSortDto> getBubbleSort(int[] input);
    }
}
