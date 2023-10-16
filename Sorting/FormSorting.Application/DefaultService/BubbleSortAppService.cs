using FormSorting.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormSorting.Core.Model;

namespace FormSorting.Application.DefaultService
{
    public class BubbleSortAppService : IBubbleSortAppService
    {
        public List<BubbleSortDto> getBubbleSort(int[] input)
        {
            List<BubbleSortDto> listBubbleSort = new List<BubbleSortDto>();

            processBubbleSort(input);

            for (int i = 0; i < input.Length; i++)
            {
                BubbleSortDto quickSort = new BubbleSortDto();
                quickSort.value = input[i];
                listBubbleSort.Add(quickSort);
            }

            return listBubbleSort;
        }

        private static void processBubbleSort(int[] input)
        {
            int n = input.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
        }
    }
}
