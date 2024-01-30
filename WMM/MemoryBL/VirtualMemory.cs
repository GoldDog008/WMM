using System.Diagnostics;

namespace WMM.MemoryBL
{
    internal class VirtualMemory : Memory
    {
        private PhysicalMemory physicalMemory { get; set; }
        private PageFile pageFile { get; set; }

        public VirtualMemory(PhysicalMemory physicalMemory, PageFile pageFile)
        {
            this.physicalMemory = physicalMemory;
            this.pageFile = pageFile;
        }

        protected override void UpdateAvailableMemory()
        {
            AvailableMemory = physicalMemory.AvailableMemory - pageFile.UsedMemory;
        }

        protected override void UpdateTotalMemory()
        {
            UpdatePhysicalAndPageFileInfo();
            TotalMemory = physicalMemory.TotalMemory + pageFile.TotalMemory;
        }

        protected override void UpdateUsedMemory()
        {
            UpdatePhysicalAndPageFileInfo();
            UsedMemory = physicalMemory.UsedMemory + pageFile.TotalMemory;
        }

        protected override void UpdateUtilization()
        {
            Utilization = UsedMemory / TotalMemory * convertToPercent;
        }

        private void UpdatePhysicalAndPageFileInfo()
        {
            physicalMemory.UpdateAllInfo();
            pageFile.UpdateAllInfo();
        }
    }
}
