using FormSorting.Application.DefaultService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class MainForm : Form
    {
        QuickSortAppService qsAppService = new QuickSortAppService();
        BubbleSortAppService bsAppService = new BubbleSortAppService();
        MergeSortAppService msAppService = new MergeSortAppService();
        GCFSortAppService gcfAppService = new GCFSortAppService();

        BindingSource bsQS = new BindingSource();
        BindingSource bsBS = new BindingSource();
        BindingSource bsMS = new BindingSource();
        BindingSource bsGCF = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }


        public void QuickSortThread(int[] input)
        {
            bsQS.DataSource = qsAppService.getQuickSort(input, 0, input.Length - 1);
            dgQuickSort.DataSource = bsQS;
        }

        public void BubbleSortThread(int[] input)
        {
            bsBS.DataSource = bsAppService.getBubbleSort(input);
            dgBubbleSort.DataSource = bsBS;
        }
        public void MergeSortThread(int[] input)
        {
            bsMS.DataSource = msAppService.getMergeSort(input);
            dgMergeSort.DataSource = bsMS;
        }
        public void GCFSortThread(int[] input)
        {
            bsGCF.DataSource = gcfAppService.getGCFSort(input);
            dgGCFSort.DataSource = bsGCF;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            string inputStr = txtInput.Text;
            string[] subInputStr = inputStr.Split(',');
            int[] input = new int[subInputStr.Length];
            int i = 0;
            foreach (var sub in subInputStr)
            {
                input[i] = Convert.ToInt32(sub);
                i++;
            }

            QuickSortThread(input);
            BubbleSortThread(input);
            MergeSortThread(input);
            GCFSortThread(input);
        }
    }
}
