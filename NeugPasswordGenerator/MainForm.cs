using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace NeugPasswordGenerator
{
    public partial class MainForm : Form
    {
        SerialPort sp;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            sp = new SerialPort(tbCom.Text)
            {
                DtrEnable = true,
                RtsEnable = true,
                Parity = Parity.None, // Even=Raw, Odd=CRC32, None=SHA256
                BaudRate = 9600
            };
            sp.DataReceived += Sp_DataReceived;
            sp.Open();
            btnConnect.Enabled = false;
            tbCom.Enabled = false;
            timer1.Enabled = true;
        }

        int length = 100;
        byte[] buffer = new byte[80];
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int len = 80;
                while (len == 80)
                    len = sp.Read(buffer, 0, 80);
            }
            catch { }
        }

        private void BtnToggle_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        Ascii85 ascii85 = new Ascii85()
        {
            PrefixMark = "",
            SuffixMark = ""
        };
        private void Timer1_Tick(object sender, EventArgs e)
        {
            tbResult.Text = ascii85.Encode(buffer).Substring(0, length);
        }

        private void TbLength_Scroll(object sender, EventArgs e)
        {
            length = tbLength.Value;
            lbLength.Text = length.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var linq = from c in Win32DeviceMgmt.GetAllCOMPorts()
                       where c.bus_description == "NeuG True RNG"
                       select c.name;
            var result = linq.FirstOrDefault();
            if (result != null)
            {
                tbCom.Text = result;
                BtnConnect_Click(sender, e);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp?.Dispose();
            sp = null;
        }
    }
}
