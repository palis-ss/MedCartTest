using System.Diagnostics;
using System.IO.Ports;
using EasyModbus;  // EasyModbusTCP.NETCore

namespace MedCartTest
{
    public partial class Form1 : Form
    {
        ModbusClient modbus = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbus.Connected)
                {
                    modbus.Disconnect();

                    btnConnect.Text = "Connect";
                    cbPort.Enabled = true;

                    lbInfo.Text = "-";
                }
                else
                {
                    modbus.SerialPort = cbPort.Text;
                    modbus.Baudrate = 19200;
                    modbus.Parity = Parity.None;
                    modbus.StopBits = StopBits.One;
                    modbus.UnitIdentifier = 1;  // slave address
                    modbus.NumberOfRetries = 2;
                    modbus.Connect();

                    btnConnect.Text = "Disconnect";
                    cbPort.Enabled = false;

                    // Example how to read to register (read board and firmware version)                    
                    var regs = modbus.ReadInputRegisters(40, 2);
                    byte[] ver0 = BitConverter.GetBytes(regs[0]);
                    byte[] ver1 = BitConverter.GetBytes(regs[1]);
                    string boardver = ver0[1].ToString() + "." + ver0[0].ToString();
                    string fwver = ver1[1].ToString() + "." + ver1[0].ToString();
                    lbInfo.Text = "Board: " + boardver + "\nFirmware: " + fwver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cbPort.Items.Add(port);
            }

            cbPort.SelectedIndex = 0;
        }

        private void cbPort_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            cbPort.Items.Clear();
            foreach (string port in ports)
            {
                cbPort.Items.Add(port);
            }

            cbPort.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modbus.Connected)
            {
                Debug.WriteLine("Closing serial port before exit");
                modbus.Disconnect();
            }
        }


        // Example how to write to register (open drawer solenoid)
        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbus.Connected)
                {
                    ushort drawerno = decimal.ToUInt16(numSpinner1.Value);
                    modbus.WriteSingleRegister(1, (ushort)(1 << (drawerno - 1)));
                }
                else
                    MessageBox.Show("Port not open");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}