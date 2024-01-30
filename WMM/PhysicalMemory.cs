using Microsoft.VisualBasic.Devices;

namespace WMM
{
    internal class PhysicalMemory : Memory
    {
        protected override void UpdateAvailableMemory()
        {
            AvailableMemory = new ComputerInfo().AvailablePhysicalMemory;
            AvailableMemory /= bytesToMegabytes;
        }

        protected override void UpdateTotalMemory()
        {
            TotalMemory = new ComputerInfo().TotalPhysicalMemory;
            TotalMemory /= bytesToMegabytes;
        }

        protected override void UpdateUsedMemory()
        {
            UsedMemory = TotalMemory - AvailableMemory;
        }

        protected override void UpdateUtilization()
        {
            Utilization = (UsedMemory / TotalMemory) * convertToPercent;
        }
    }
}
