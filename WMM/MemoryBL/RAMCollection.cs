using System.Management;

namespace WMM.MemoryBL
{
    internal class RAMCollection
    {
        public class RAM
        {
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public string SerialNumber { get; set; }
            public string Capacity { get; set; }
            public string FormFactor { get; set; }
            public string Speed { get; set; }
            public string DeviceLocator { get; set; }
        }

        private string query = "SELECT * FROM Win32_PhysicalMemory";
        private ManagementObjectSearcher searcher;
        private List<RAM> RAMs { get; set; }
        private const float bytesToMegabytes = 1024f * 1024f;


        public RAMCollection()
        {
            RAMs = new List<RAM>();
            searcher = new ManagementObjectSearcher(query);
        }

        public List<RAM> GetInfoAboutRAM()
        {
            foreach (ManagementObject obj in searcher.Get())
            {
                RAM ram = new RAM();

                ram.Manufacturer = (string)obj["Manufacturer"];
                ram.Model = (string)obj["PartNumber"];
                ram.SerialNumber = (string)obj["SerialNumber"];
                ram.Capacity = ((ulong)obj["Capacity"] / bytesToMegabytes).ToString();
                ram.Speed = ((uint)obj["Speed"]).ToString();
                ram.DeviceLocator = (string)obj["DeviceLocator"];
                ram.FormFactor = GetFormFactorString((ushort)obj["FormFactor"]);

                RAMs.Add(ram);
            }

            return RAMs;
        }

        private string GetFormFactorString(ushort formFactor)
        {
            switch (formFactor)
            {
                case 8:
                    return "DIMM";
                case 12:
                    return "SODIMM";

                default:
                    return "Unknown";
            }
        }
    }
}
