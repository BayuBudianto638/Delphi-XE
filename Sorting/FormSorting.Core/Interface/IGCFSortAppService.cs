using FormSorting.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSorting.Core.Interface
{
    public interface IGCFSortAppService
    {
        List<GCFSortDto> getGCFSort(int[] input);
    }
}
