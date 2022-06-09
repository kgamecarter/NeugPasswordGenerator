using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace NeugPasswordGenerator
{
    public partial class MainForm : Form
    {
        const string NeugBusDescription = "NeuG True RNG";

        SerialPort sp;
        public MainForm()
        {
            InitializeComponent();
            var offset = 0;
            vHex = new ReadOnlyMemory<byte>(buffer, offset, PickLength);
            offset += PickLength;
            vBase62 = new ReadOnlyMemory<byte>(buffer, offset, PickLength);
            offset += PickLength;
            vAscii85 = new ReadOnlyMemory<byte>(buffer, offset, PickLength); 
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

        int length = 150;
        byte[] buffer = new byte[960];
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int len = buffer.Length;
                while (len == buffer.Length)
                    len = sp.Read(buffer, 0, buffer.Length);
            }
            catch
            {
                sp?.Dispose();
                sp = null;
                BeginInvoke(new Action(() =>
                {
                    btnConnect.Enabled = true;
                    tbCom.Enabled = true;
                    timer1.Enabled = false;
                }));
                Array.Clear(buffer, 0, buffer.Length);
            }
        }

        private void BtnToggle_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (!timer1.Enabled)
            {
                Array.Clear(buffer, 0, buffer.Length);
            }
        }

        Ascii85 ascii85 = new Ascii85();
        const int PickLength = 150;
        ReadOnlyMemory<byte> vHex, vBase62, vAscii85;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            tbHex.Text = Hex.ToHex(vHex.Span).Substring(0, length);
            tbBase62.Text = Base62.ToBase62(vBase62.Span).Substring(0, length);
            tbAscii85.Text = ascii85.Encode(vAscii85.Span).Substring(0, length);
        }

        private void TbLength_Scroll(object sender, EventArgs e)
        {
            length = tbLength.Value;
            lbLength.Text = length.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var linq = from c in Win32DeviceMgmt.GetAllCOMPorts()
                       where c.BusDescription == NeugBusDescription
                       select c.Name;
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
