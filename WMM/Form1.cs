using WMM.Memory;

namespace WMM
{
    public partial class Form1 : Form
    {
        private VirtualMemory virtualMemory;
        private PhysicalMemory physicalMemory;
        private PageFile pageFile;
        private System.Windows.Forms.Timer timer;

        private const int timerInterval = 1000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            physicalMemory = new PhysicalMemory();
            pageFile = new PageFile();
            virtualMemory = new VirtualMemory(physicalMemory, pageFile);

            virtualMemoryToolStripMenuItem.PerformClick();
        }

        private void virtualMemoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataModificationInWindow("virtualMemoryToolStripMenuItem", "VIRTUAL MEMORY", "Used");
            StartTimerForUpdateInfo(UpdateAndPrintInfoAboutVirtualMemory);
        }
        private void physicalMemoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataModificationInWindow("physicalMemoryToolStripMenuItem", "PHYSICAL MEMORY", "Used");
            StartTimerForUpdateInfo(UpdateAndPrintInfoAboutPhysicalMemory);
        }
        private void pageFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataModificationInWindow("pageFileToolStripMenuItem", "PAGE FILE", "Current/peak");
            StartTimerForUpdateInfo(UpdateAndPrintInfoAboutPageFile);
        }


        private void StartTimerForUpdateInfo(Action<object, EventArgs> action)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }

            timer = new System.Windows.Forms.Timer();
            timer.Interval = timerInterval;

            EventHandler handler = (sender, e) => action(sender, e);

            timer.Tick += handler;
            timer.Start();
        }

        private void UpdateAndPrintInfoAboutPageFile(object sender, EventArgs e)
        {
            try
            {
                pageFile.UpdateAllInfo();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            PrintInfoAboutMemory(pageFile);
        }
        private void UpdateAndPrintInfoAboutVirtualMemory(object sender, EventArgs e)
        {
            try
            {
                virtualMemory.UpdateAllInfo();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            PrintInfoAboutMemory(virtualMemory);
        }
        private void UpdateAndPrintInfoAboutPhysicalMemory(object sender, EventArgs e)
        {
            try
            {
                physicalMemory.UpdateAllInfo();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            PrintInfoAboutMemory(physicalMemory);
        }


        private void PrintInfoAboutMemory(Memory memory)
        {
            string mbLable = " Mb";

            usedDataLabel.Text = ((int)memory.UsedMemory).ToString() + mbLable;
            totalDataLabel.Text = ((int)memory.TotalMemory).ToString() + mbLable;
            availableDataLabel.Text = ((int)memory.AvailableMemory).ToString() + mbLable;
            utilizationDataLabel.Text = ((int)memory.Utilization).ToString() + "%";

            if (memory is PageFile pageFile)
            {
                int lableIndex = usedDataLabel.Text.IndexOf(mbLable);
                usedDataLabel.Text = usedDataLabel.Text.Insert(lableIndex, "/" + pageFile.PeakMemory.ToString());
            }

        }

        private void ColorizeTheSelectedMenu(string name)
        {
            List<ToolStripMenuItem> menuItems = menuStrip1.Items.OfType<ToolStripMenuItem>().ToList();

            if (menuItems != null)
            {
                foreach (var item in menuItems)
                {
                    if (item.Name == name)
                    {
                        item.BackColor = Color.Tomato;
                    }
                    else
                    {
                        item.BackColor = Color.Firebrick;
                    }
                }
            }
        }
        private void DataModificationInWindow(string selectedMenuName, string nameText, string usedText)
        {
            ColorizeTheSelectedMenu(selectedMenuName);

            nameLabel.Text = nameText;
            usedLabel.Text = usedText;
        }

        private void processesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void chartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work was performed by Kamyshan Alexander");
        }

        private void sPDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}