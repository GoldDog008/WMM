namespace WMM
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dataGridViewProcesses = new DataGridView();
            ProcessName = new DataGridViewTextBoxColumn();
            ProcessId = new DataGridViewTextBoxColumn();
            UsedMemory = new DataGridViewTextBoxColumn();
            AllocatedVirtualMemory = new DataGridViewTextBoxColumn();
            ProcessFileName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcesses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProcesses
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewProcesses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProcesses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProcesses.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Peru;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProcesses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcesses.Columns.AddRange(new DataGridViewColumn[] { ProcessName, ProcessId, UsedMemory, AllocatedVirtualMemory, ProcessFileName, Description });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.SeaShell;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewProcesses.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewProcesses.Dock = DockStyle.Fill;
            dataGridViewProcesses.EnableHeadersVisualStyles = false;
            dataGridViewProcesses.Location = new Point(0, 0);
            dataGridViewProcesses.Name = "dataGridViewProcesses";
            dataGridViewProcesses.ReadOnly = true;
            dataGridViewProcesses.RowHeadersVisible = false;
            dataGridViewProcesses.RowTemplate.Height = 25;
            dataGridViewProcesses.Size = new Size(799, 384);
            dataGridViewProcesses.TabIndex = 0;
            // 
            // ProcessName
            // 
            dataGridViewCellStyle3.BackColor = Color.BurlyWood;
            dataGridViewCellStyle3.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProcessName.DefaultCellStyle = dataGridViewCellStyle3;
            ProcessName.FillWeight = 79.14573F;
            ProcessName.HeaderText = "Process Name";
            ProcessName.Name = "ProcessName";
            ProcessName.ReadOnly = true;
            // 
            // ProcessId
            // 
            dataGridViewCellStyle4.BackColor = Color.BurlyWood;
            dataGridViewCellStyle4.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProcessId.DefaultCellStyle = dataGridViewCellStyle4;
            ProcessId.FillWeight = 77.45621F;
            ProcessId.HeaderText = "Process Id";
            ProcessId.Name = "ProcessId";
            ProcessId.ReadOnly = true;
            ProcessId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // UsedMemory
            // 
            dataGridViewCellStyle5.BackColor = Color.BurlyWood;
            dataGridViewCellStyle5.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsedMemory.DefaultCellStyle = dataGridViewCellStyle5;
            UsedMemory.FillWeight = 85.3301239F;
            UsedMemory.HeaderText = "Used Memory";
            UsedMemory.Name = "UsedMemory";
            UsedMemory.ReadOnly = true;
            UsedMemory.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AllocatedVirtualMemory
            // 
            dataGridViewCellStyle6.BackColor = Color.BurlyWood;
            dataGridViewCellStyle6.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AllocatedVirtualMemory.DefaultCellStyle = dataGridViewCellStyle6;
            AllocatedVirtualMemory.FillWeight = 135.35379F;
            AllocatedVirtualMemory.HeaderText = "Allocated Virtual Memory";
            AllocatedVirtualMemory.Name = "AllocatedVirtualMemory";
            AllocatedVirtualMemory.ReadOnly = true;
            // 
            // ProcessFileName
            // 
            dataGridViewCellStyle7.BackColor = Color.BurlyWood;
            dataGridViewCellStyle7.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProcessFileName.DefaultCellStyle = dataGridViewCellStyle7;
            ProcessFileName.FillWeight = 129.315933F;
            ProcessFileName.HeaderText = "Process File Name";
            ProcessFileName.Name = "ProcessFileName";
            ProcessFileName.ReadOnly = true;
            ProcessFileName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            dataGridViewCellStyle8.BackColor = Color.BurlyWood;
            dataGridViewCellStyle8.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Description.DefaultCellStyle = dataGridViewCellStyle8;
            Description.FillWeight = 93.39815F;
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(799, 384);
            Controls.Add(dataGridViewProcesses);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form2";
            Text = "Processes";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcesses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProcesses;
        private DataGridViewTextBoxColumn ProcessName;
        private DataGridViewTextBoxColumn ProcessId;
        private DataGridViewTextBoxColumn UsedMemory;
        private DataGridViewTextBoxColumn AllocatedVirtualMemory;
        private DataGridViewTextBoxColumn ProcessFileName;
        private DataGridViewTextBoxColumn Description;
    }
}