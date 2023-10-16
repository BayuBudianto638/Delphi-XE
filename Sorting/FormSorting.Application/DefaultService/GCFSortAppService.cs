using FormSorting.Core.Interface;
using FormSorting.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSorting.Application.DefaultService
{
    public class GCFSortAppService : IGCFSortAppService
    {
        public List<GCFSortDto> getGCFSort(int[] input)
        {
            List<GCFSortDto> listGCFSort = new List<GCFSortDto>();

            processGCFSort(input);

            for (int i = 0; i < input.Length; i++)
            {
                GCFSortDto gcfSort = new GCFSortDto();
                gcfSort.value = input[i];
                listGCFSort.Add(gcfSort);
            }

            return listGCFSort;
        }

        private static void processGCFSort(int[] input)
        {
            // TODO
        }
    }
}
