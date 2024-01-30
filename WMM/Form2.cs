using System.ComponentModel;
using System.Diagnostics;

namespace WMM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();

            DataGridViewColumn columnToSort = dataGridViewProcesses.Columns["ProcessName"];
            dataGridViewProcesses.Sort(columnToSort, System.ComponentModel.ListSortDirection.Ascending);
        }

        private void PopulateDataGridView()
        {
            dataGridViewProcesses.Rows.Clear();
            int rowIndex = 0;

            foreach (var process in Process.GetProcesses())
            {
                rowIndex = dataGridViewProcesses.Rows.Add();
                DataGridViewRow row = dataGridViewProcesses.Rows[rowIndex];

                row.Cells["ProcessName"].Value = $"{process.ProcessName}";
                row.Cells["ProcessId"].Value = $"{process.Id}";
                row.Cells["UsedMemory"].Value = $"{process.WorkingSet64 / 1024} KB";
                row.Cells["AllocatedVirtualMemory"].Value = $"{process.PrivateMemorySize64 / 1024} KB";


                try
                {
                    row.Cells["ProcessFileName"].Value = $"{process.MainModule.FileName}";
                    row.Cells["Description"].Value = $"{process.MainModule.FileVersionInfo.FileDescription}";
                }
                catch (Win32Exception)
                {
                    row.Cells["ProcessFileName"].Value = $"Access denied";
                    row.Cells["Description"].Value = $"Access denied";

                }

                rowIndex++;
            }
        }
    }
}
