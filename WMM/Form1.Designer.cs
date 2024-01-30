namespace WMM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            virtualMemoryToolStripMenuItem = new ToolStripMenuItem();
            physicalMemoryToolStripMenuItem = new ToolStripMenuItem();
            pageFileToolStripMenuItem = new ToolStripMenuItem();
            moreToolStripMenuItem = new ToolStripMenuItem();
            processesToolStripMenuItem = new ToolStripMenuItem();
            chartsToolStripMenuItem = new ToolStripMenuItem();
            sPDToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            nameLabel = new Label();
            usedLabel = new Label();
            totalLabel = new Label();
            availableLabel = new Label();
            utilizationLabel = new Label();
            utilizationDataLabel = new Label();
            availableDataLabel = new Label();
            totalDataLabel = new Label();
            usedDataLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Maroon;
            menuStrip1.Items.AddRange(new ToolStripItem[] { virtualMemoryToolStripMenuItem, physicalMemoryToolStripMenuItem, pageFileToolStripMenuItem, moreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(331, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // virtualMemoryToolStripMenuItem
            // 
            virtualMemoryToolStripMenuItem.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            virtualMemoryToolStripMenuItem.ForeColor = SystemColors.ControlText;
            virtualMemoryToolStripMenuItem.Name = "virtualMemoryToolStripMenuItem";
            virtualMemoryToolStripMenuItem.Size = new Size(101, 20);
            virtualMemoryToolStripMenuItem.Text = "Virtual memory";
            virtualMemoryToolStripMenuItem.Click += virtualMemoryToolStripMenuItem_Click;
            // 
            // physicalMemoryToolStripMenuItem
            // 
            physicalMemoryToolStripMenuItem.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            physicalMemoryToolStripMenuItem.Name = "physicalMemoryToolStripMenuItem";
            physicalMemoryToolStripMenuItem.Size = new Size(108, 20);
            physicalMemoryToolStripMenuItem.Text = "Physical memory";
            physicalMemoryToolStripMenuItem.Click += physicalMemoryToolStripMenuItem_Click;
            // 
            // pageFileToolStripMenuItem
            // 
            pageFileToolStripMenuItem.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pageFileToolStripMenuItem.Name = "pageFileToolStripMenuItem";
            pageFileToolStripMenuItem.Size = new Size(67, 20);
            pageFileToolStripMenuItem.Text = "Page File";
            pageFileToolStripMenuItem.Click += pageFileToolStripMenuItem_Click;
            // 
            // moreToolStripMenuItem
            // 
            moreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { processesToolStripMenuItem, chartsToolStripMenuItem, sPDToolStripMenuItem, aboutToolStripMenuItem });
            moreToolStripMenuItem.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            moreToolStripMenuItem.Size = new Size(46, 20);
            moreToolStripMenuItem.Text = "More";
            // 
            // processesToolStripMenuItem
            // 
            processesToolStripMenuItem.Name = "processesToolStripMenuItem";
            processesToolStripMenuItem.Size = new Size(180, 22);
            processesToolStripMenuItem.Text = "Processes";
            processesToolStripMenuItem.Click += processesToolStripMenuItem_Click;
            // 
            // chartsToolStripMenuItem
            // 
            chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            chartsToolStripMenuItem.Size = new Size(180, 22);
            chartsToolStripMenuItem.Text = "Charts";
            chartsToolStripMenuItem.Click += chartsToolStripMenuItem_Click;
            // 
            // sPDToolStripMenuItem
            // 
            sPDToolStripMenuItem.Name = "sPDToolStripMenuItem";
            sPDToolStripMenuItem.Size = new Size(180, 22);
            sPDToolStripMenuItem.Text = "SPD";
            sPDToolStripMenuItem.Click += sPDToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.FromArgb(255, 192, 192);
            nameLabel.Dock = DockStyle.Top;
            nameLabel.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.Linen;
            nameLabel.Image = (Image)resources.GetObject("nameLabel.Image");
            nameLabel.Location = new Point(0, 24);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(331, 37);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "VIRTUAL MEMORY";
            nameLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // usedLabel
            // 
            usedLabel.AutoSize = true;
            usedLabel.BackColor = Color.Transparent;
            usedLabel.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usedLabel.ForeColor = Color.Linen;
            usedLabel.Location = new Point(13, 122);
            usedLabel.Name = "usedLabel";
            usedLabel.Size = new Size(70, 23);
            usedLabel.TabIndex = 3;
            usedLabel.Text = "Used:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = Color.Transparent;
            totalLabel.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.ForeColor = Color.Linen;
            totalLabel.Location = new Point(13, 82);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(82, 23);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "Total:";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.BackColor = Color.Transparent;
            availableLabel.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            availableLabel.ForeColor = Color.Linen;
            availableLabel.Location = new Point(13, 162);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new Size(130, 23);
            availableLabel.TabIndex = 5;
            availableLabel.Text = "Available:";
            // 
            // utilizationLabel
            // 
            utilizationLabel.AutoSize = true;
            utilizationLabel.BackColor = Color.Transparent;
            utilizationLabel.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            utilizationLabel.ForeColor = Color.Linen;
            utilizationLabel.Location = new Point(13, 202);
            utilizationLabel.Name = "utilizationLabel";
            utilizationLabel.Size = new Size(154, 23);
            utilizationLabel.TabIndex = 6;
            utilizationLabel.Text = "Utilization:";
            // 
            // utilizationDataLabel
            // 
            utilizationDataLabel.BackColor = Color.Transparent;
            utilizationDataLabel.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            utilizationDataLabel.ForeColor = Color.Linen;
            utilizationDataLabel.Location = new Point(173, 202);
            utilizationDataLabel.Name = "utilizationDataLabel";
            utilizationDataLabel.Size = new Size(146, 23);
            utilizationDataLabel.TabIndex = 10;
            utilizationDataLabel.Text = "null";
            utilizationDataLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // availableDataLabel
            // 
            availableDataLabel.BackColor = Color.Transparent;
            availableDataLabel.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            availableDataLabel.ForeColor = Color.Linen;
            availableDataLabel.Location = new Point(173, 162);
            availableDataLabel.Name = "availableDataLabel";
            availableDataLabel.Size = new Size(146, 23);
            availableDataLabel.TabIndex = 9;
            availableDataLabel.Text = "null";
            availableDataLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalDataLabel
            // 
            totalDataLabel.BackColor = Color.Transparent;
            totalDataLabel.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalDataLabel.ForeColor = Color.Linen;
            totalDataLabel.Location = new Point(173, 82);
            totalDataLabel.Name = "totalDataLabel";
            totalDataLabel.Size = new Size(146, 23);
            totalDataLabel.TabIndex = 8;
            totalDataLabel.Text = "null";
            totalDataLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // usedDataLabel
            // 
            usedDataLabel.BackColor = Color.Transparent;
            usedDataLabel.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usedDataLabel.ForeColor = Color.Linen;
            usedDataLabel.Location = new Point(173, 122);
            usedDataLabel.Name = "usedDataLabel";
            usedDataLabel.Size = new Size(146, 23);
            usedDataLabel.TabIndex = 7;
            usedDataLabel.Text = "null";
            usedDataLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(331, 242);
            Controls.Add(utilizationDataLabel);
            Controls.Add(availableDataLabel);
            Controls.Add(totalDataLabel);
            Controls.Add(usedDataLabel);
            Controls.Add(utilizationLabel);
            Controls.Add(availableLabel);
            Controls.Add(totalLabel);
            Controls.Add(usedLabel);
            Controls.Add(nameLabel);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VMM";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem virtualMemoryToolStripMenuItem;
        private ToolStripMenuItem physicalMemoryToolStripMenuItem;
        private ToolStripMenuItem pageFileToolStripMenuItem;
        private ToolStripMenuItem moreToolStripMenuItem;
        private Label nameLabel;
        private Label usedLabel;
        private Label totalLabel;
        private Label availableLabel;
        private Label utilizationLabel;
        private Label utilizationDataLabel;
        private Label availableDataLabel;
        private Label totalDataLabel;
        private Label usedDataLabel;
        private ToolStripMenuItem processesToolStripMenuItem;
        private ToolStripMenuItem chartsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem sPDToolStripMenuItem;
    }
}