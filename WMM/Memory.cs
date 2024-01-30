namespace WMM
{
    internal abstract class Memory
    {
        protected const int convertToPercent = 100;
        protected const float bytesToMegabytes = 1024f * 1024f;

        public float TotalMemory { get; protected set; }
        public float UsedMemory { get; protected set; }
        public float AvailableMemory { get; protected set; }
        public float Utilization { get; protected set; }

        protected abstract void UpdateTotalMemory();
        protected abstract void UpdateAvailableMemory();
        protected abstract void UpdateUtilization();
        protected abstract void UpdateUsedMemory();
        public virtual void UpdateAllInfo()
        {
            UpdateTotalMemory();
            UpdateAvailableMemory();
            UpdateUsedMemory();                
            UpdateUtilization();
        }
    }
}
