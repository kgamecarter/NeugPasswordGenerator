using System;
using System.IO.Ports;
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

        byte[] buffer = new byte[80];
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int len = 80;
            while (len == 80)
                len = sp.Read(buffer, 0, 80);
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
            tbResult.Text = ascii85.Encode(buffer);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // BtnConnect_Click(sender, e);
        }
    }
}
