using WMM.MemoryBL;
using static WMM.MemoryBL.RAMCollection;

namespace WMM
{
    public partial class Form4 : Form
    {
        private RAMCollection ram;
        List<RAM> rams;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ram = new RAMCollection();
            rams = ram.GetInfoAboutRAM();

            InitializeMenu();
        }

        private void InitializeMenu()
        {
            foreach (var ram in rams)
            {
                var item = menuStrip1.Items.Add(ram.Manufacturer + " " + ram.Model);
                item.Click += RAMItem_Click;
                item.Tag = ram.SerialNumber;
            }
        }

        private void RAMItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;

            foreach (var ram in rams)
            {
                if (ram.SerialNumber == menuItem.Tag)
                {
                    ManufacturerInfoLabel.Text = ram.Manufacturer;
                    ModelInfoLabel.Text = ram.Model;
                    SerialNumberInfoLabel.Text = ram.SerialNumber;
                    CapacityInfoLabel.Text = ram.Capacity;
                    FormFactorInfoLabel.Text = ram.FormFactor;
                    SpeedInfoLabel.Text = ram.Speed;
                    DeviceLocatorInfoLabel.Text = ram.DeviceLocator;

                    break;
                }
            }
        }
    }
}
