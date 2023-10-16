namespace Sorting
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgQuickSort = new System.Windows.Forms.DataGridView();
            this.dgBubbleSort = new System.Windows.Forms.DataGridView();
            this.dgMergeSort = new System.Windows.Forms.DataGridView();
            this.dgGCFSort = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuicksort = new System.Windows.Forms.Label();
            this.lblBubblesort = new System.Windows.Forms.Label();
            this.lblMergesort = new System.Windows.Forms.Label();
            this.lblGCFsort = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuickSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBubbleSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMergeSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGCFSort)).BeginInit();
            this.SuspendLayout();
            // 
            // dgQuickSort
            // 
            this.dgQuickSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuickSort.Location = new System.Drawing.Point(12, 151);
            this.dgQuickSort.Name = "dgQuickSort";
            this.dgQuickSort.RowTemplate.Height = 24;
            this.dgQuickSort.Size = new System.Drawing.Size(240, 388);
            this.dgQuickSort.TabIndex = 0;
            // 
            // dgBubbleSort
            // 
            this.dgBubbleSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBubbleSort.Location = new System.Drawing.Point(258, 151);
            this.dgBubbleSort.Name = "dgBubbleSort";
            this.dgBubbleSort.RowTemplate.Height = 24;
            this.dgBubbleSort.Size = new System.Drawing.Size(240, 388);
            this.dgBubbleSort.TabIndex = 1;
            // 
            // dgMergeSort
            // 
            this.dgMergeSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMergeSort.Location = new System.Drawing.Point(504, 151);
            this.dgMergeSort.Name = "dgMergeSort";
            this.dgMergeSort.RowTemplate.Height = 24;
            this.dgMergeSort.Size = new System.Drawing.Size(240, 388);
            this.dgMergeSort.TabIndex = 2;
            // 
            // dgGCFSort
            // 
            this.dgGCFSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGCFSort.Location = new System.Drawing.Point(750, 151);
            this.dgGCFSort.Name = "dgGCFSort";
            this.dgGCFSort.RowTemplate.Height = 24;
            this.dgGCFSort.Size = new System.Drawing.Size(240, 388);
            this.dgGCFSort.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(691, 62);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(140, 28);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quicksort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bubblesort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mergesort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "GCF Sort";
            // 
            // lblQuicksort
            // 
            this.lblQuicksort.AutoSize = true;
            this.lblQuicksort.Location = new System.Drawing.Point(81, 546);
            this.lblQuicksort.Name = "lblQuicksort";
            this.lblQuicksort.Size = new System.Drawing.Size(42, 17);
            this.lblQuicksort.TabIndex = 9;
            this.lblQuicksort.Text = "10ms";
            // 
            // lblBubblesort
            // 
            this.lblBubblesort.AutoSize = true;
            this.lblBubblesort.Location = new System.Drawing.Point(330, 546);
            this.lblBubblesort.Name = "lblBubblesort";
            this.lblBubblesort.Size = new System.Drawing.Size(50, 17);
            this.lblBubblesort.TabIndex = 10;
            this.lblBubblesort.Text = "500ms";
            // 
            // lblMergesort
            // 
            this.lblMergesort.AutoSize = true;
            this.lblMergesort.Location = new System.Drawing.Point(592, 546);
            this.lblMergesort.Name = "lblMergesort";
            this.lblMergesort.Size = new System.Drawing.Size(50, 17);
            this.lblMergesort.TabIndex = 11;
            this.lblMergesort.Text = "460ms";
            // 
            // lblGCFsort
            // 
            this.lblGCFsort.AutoSize = true;
            this.lblGCFsort.Location = new System.Drawing.Point(844, 546);
            this.lblGCFsort.Name = "lblGCFsort";
            this.lblGCFsort.Size = new System.Drawing.Size(50, 17);
            this.lblGCFsort.TabIndex = 12;
            this.lblGCFsort.Text = "600ms";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(84, 65);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(601, 22);
            this.txtInput.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 609);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblGCFsort);
            this.Controls.Add(this.lblMergesort);
            this.Controls.Add(this.lblBubblesort);
            this.Controls.Add(this.lblQuicksort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dgGCFSort);
            this.Controls.Add(this.dgMergeSort);
            this.Controls.Add(this.dgBubbleSort);
            this.Controls.Add(this.dgQuickSort);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Sorting";
            ((System.ComponentModel.ISupportInitialize)(this.dgQuickSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBubbleSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMergeSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGCFSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgQuickSort;
        private System.Windows.Forms.DataGridView dgBubbleSort;
        private System.Windows.Forms.DataGridView dgMergeSort;
        private System.Windows.Forms.DataGridView dgGCFSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuicksort;
        private System.Windows.Forms.Label lblBubblesort;
        private System.Windows.Forms.Label lblMergesort;
        private System.Windows.Forms.Label lblGCFsort;
        private System.Windows.Forms.TextBox txtInput;
    }
}

