using System.Management;

namespace WMM
{
    internal class PageFile : Memory
    {
        private string query = "SELECT * FROM Win32_PageFileUsage";
        private ManagementObjectSearcher searcher;

        public float PeakMemory { get; private set; }

        public PageFile()
        {
            UpdateQuery();
        }

        protected override void UpdateAvailableMemory()
        {
            AvailableMemory = PeakMemory - UsedMemory;
        }

        protected override void UpdateTotalMemory()
        {
            TotalMemory = 0;

            foreach (ManagementObject obj in searcher.Get())
            {
                TotalMemory += (uint)obj["AllocatedBaseSize"];
            }
        }

        protected override void UpdateUsedMemory()
        {
            UsedMemory = 0;

            foreach (ManagementObject obj in searcher.Get())
            {
                UsedMemory += (uint)obj["CurrentUsage"];
            }
        }

        protected override void UpdateUtilization()
        {
            if (UsedMemory > 0) 
            {
                Utilization = (UsedMemory / PeakMemory) * convertToPercent;
            }
            else
            {
                Utilization = 0;
            }
        }

        private void UpdateQuery()
        {
            searcher = new ManagementObjectSearcher(query);
        }

        private void UpdatePeakMemory()
        {
            PeakMemory = 0;

            foreach (ManagementObject obj in searcher.Get())
            {
                PeakMemory += (uint)obj["PeakUsage"];
            }
        }

        public override void UpdateAllInfo()
        {
            UpdateQuery();
            UpdateUsedMemory();
            UpdatePeakMemory();
            UpdateTotalMemory(); 
            UpdateUtilization();
            UpdateAvailableMemory();                
        }
    }
}
