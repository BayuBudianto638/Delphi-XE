using FormSorting.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormSorting.Core.Model;

namespace FormSorting.Application.DefaultService
{
    public class QuickSortAppService : IQuickSortAppService
    {
        public List<QuickSortDto> getQuickSort(int[] input, int nilaiA, int nilaiB)
        {
            List<QuickSortDto> listQuickSort = new List<QuickSortDto>();
            processQuickSort(input, nilaiA, nilaiB);

            for (int i = 0; i < input.Length; i++)
            {
                QuickSortDto quickSort = new QuickSortDto();
                quickSort.value = input[i];
                listQuickSort.Add(quickSort);
            }

            return listQuickSort;
        }

        private static void processQuickSort(int[] input, int nilaiA, int nilaiB)
        {
            int balik = input[(nilaiA + nilaiB) / 2];
            int T = 0;

            while (nilaiB > nilaiA)
            {
                while (input[nilaiA] < balik)
                {
                    nilaiA++;
                }

                while (input[nilaiB] > balik)
                {
                    nilaiB--;
                }

                if (nilaiA <= nilaiB)
                {
                    T = input[nilaiA];
                    input[nilaiA] = input[nilaiB];
                    input[nilaiB] = T;
                    nilaiA++;
                    nilaiB--;
                }
            }

            if (nilaiB > nilaiA)
            {
                processQuickSort(input, nilaiA, nilaiB);
            }

            if (nilaiA < nilaiB)
            {
                processQuickSort(input, nilaiA, nilaiB);
            }
        }
    }
}
