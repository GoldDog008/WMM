using ScottPlot;
using ScottPlot.Plottable;

namespace WMM
{
    public partial class Form3 : Form
    {
        private VirtualMemory virtualMemory;
        private PhysicalMemory physicalMemory;
        private PageFile pageFile;

        private SignalPlot physicalMemorySignalPlot;
        private SignalPlot virtualMemorySignalPlot;
        private SignalPlot pageFileSignalPlot;

        private const int chartSize = 10;
        private const int timerInterval = 1000;

        private double[] physicalMemoryUsageData = new double[chartSize];
        private double[] virtualMemoryUsageData = new double[chartSize];
        private double[] pageFileUsageData = new double[chartSize];

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            physicalMemory = new PhysicalMemory();
            pageFile = new PageFile();
            virtualMemory = new VirtualMemory(physicalMemory, pageFile);

            InitializeCharts();
            StartTimerForUpdateCharts();
        }

        private void StartTimerForUpdateCharts()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = timerInterval;
            timer.Tick += UpdateCharts;
            timer.Start();
        }

        private void InitializeCharts()
        {
            formsPlot1.Plot.YLabel("Load, %");
            formsPlot1.Plot.XLabel("Time, second");

            formsPlot2.Plot.YLabel("Load, %");
            formsPlot2.Plot.XLabel("Time, second");

            formsPlot3.Plot.YLabel("Load, %");
            formsPlot3.Plot.XLabel("Time, second");

            physicalMemorySignalPlot = formsPlot1.Plot.AddSignal(physicalMemoryUsageData, sampleRate: 1, color: Color.Purple);
            formsPlot1.Plot.SetAxisLimits(xMin: 0, xMax: physicalMemoryUsageData.Length, yMin: 0, yMax: 100);

            virtualMemorySignalPlot = formsPlot2.Plot.AddSignal(virtualMemoryUsageData, sampleRate: 1, color: Color.OrangeRed);
            formsPlot2.Plot.SetAxisLimits(xMin: 0, xMax: virtualMemoryUsageData.Length, yMin: 0, yMax: 100);

            pageFileSignalPlot = formsPlot3.Plot.AddSignal(pageFileUsageData, sampleRate: 1.0, color: Color.DarkGoldenrod);
            formsPlot3.Plot.SetAxisLimits(xMin: 0, xMax: pageFileUsageData.Length, yMin: 0, yMax: 100);
        }

        private void UpdateCharts(object sender, EventArgs e)
        {
            UpdateChart(physicalMemory, formsPlot1, physicalMemorySignalPlot, physicalMemoryUsageData);
            UpdateChart(virtualMemory, formsPlot2, virtualMemorySignalPlot, virtualMemoryUsageData);
            UpdateChart(pageFile, formsPlot3, pageFileSignalPlot, pageFileUsageData);
        }

        private void UpdateChart(Memory memory, FormsPlot plot, SignalPlot signalPlot, double[] usageData)
        {
            memory.UpdateAllInfo();

            double newMemoryUsage = memory.Utilization;

            Array.Copy(usageData, 1, usageData, 0, usageData.Length - 1);
            usageData[usageData.Length - 1] = newMemoryUsage;

            signalPlot.Update(usageData);
            plot.Render();
        }
    }
}
