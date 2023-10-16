using FormSorting.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormSorting.Core.Model;

namespace FormSorting.Application.DefaultService
{
    public class MergeSortAppService : IMergeSortAppService
    {
        public List<MergeSortDto> getMergeSort(int[] input)
        {
            List<MergeSortDto> listMergeSort = new List<MergeSortDto>();

            int[] data = mergeSort(input);

            for (int i = 0; i < data.Length; i++)
            {
                MergeSortDto mergeSort = new MergeSortDto();
                mergeSort.value = data[i];
                listMergeSort.Add(mergeSort);
            }

            return listMergeSort;
        }

        private static int[] merge(int[] left, int[] right)
        {
            int[] arr = new int[10];
            int i;
            int j = 0;
            int iLeft = 0;
            int iRight = 0;
            int iResult = 0;

            Array.Resize(ref arr, left.Length + right.Length);

            while ((iLeft < left.Length) || (iRight < right.Length))
            {
                if (iLeft < left.Length && iRight < right.Length)
                {
                    if (left[iLeft] <= right[iRight])
                    {
                        arr[iResult] = left[iLeft];
                        iLeft++;
                        iResult++;
                    }
                    else
                    {
                        arr[iResult] = right[iRight];
                        iRight++;
                        iResult++;
                    }
                }
                else if (iLeft < left.Length)
                {
                    arr[iResult] = left[iLeft];
                    iLeft++;
                    iResult++;
                }
                else if (iRight < right.Length)
                {
                    arr[iResult] = right[iRight];
                    iRight++;
                    iResult++;
                }
            }

            return arr;
        }

        private static int[] mergeSort(int[] input)
        {
            int middle = input.Length / 2;

            int[] left = new int[middle];
            int[] right;
            int i;
            int[] ret = new int[input.Length];
            int x = 0;

            ret = input;

            if (input.Length == 1)
            {
                return input;
            }

            if (input.Length % 2 == 0)
                right = new int[middle];
            else
                right = new int[middle + 1];

            for (i = 0; i < middle; i++)
            {
                left[i] = input[i];
            }

            for (i = middle; i < input.Length; i++)
            {
                right[x] = input[i];
                x++;
            }

            left = mergeSort(left);
            right = mergeSort(right);
            ret = merge(left, right);

            return ret;
        }
    }
}
