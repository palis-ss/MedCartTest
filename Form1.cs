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

        // Init GUI
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cbPort.Items.Add(port);
            }

            cbPort.SelectedIndex = 0;
        }

        // User clicks on the Connect button
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
                    // set serial port parameters
                    modbus.SerialPort = cbPort.Text;  // read port name from CB
                    modbus.Baudrate = 19200;
                    modbus.Parity = Parity.None;
                    modbus.StopBits = StopBits.One;
                    modbus.UnitIdentifier = 1;  // slave address
                    modbus.NumberOfRetries = 2;  // set no of retries so it's won't take too long to respond
                    
                    modbus.Connect();

                    btnConnect.Text = "Disconnect";
                    cbPort.Enabled = false;

                    // Example how to read registers (read board and firmware version)
                    int[] regs = modbus.ReadInputRegisters(40, 2);  // Read input register address 40, 2 words
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

        // Refresh serial port list when CB is clicked
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

        // Close serial port before exit
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modbus.Connected)
            {
                Debug.WriteLine("Closing serial port before exit");
                modbus.Disconnect();
            }
        }

        // Example how to write to a holding register (open drawer solenoid)
        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbus.Connected)
                {
                    ushort drawerno = decimal.ToUInt16(numSpinner1.Value);
                    modbus.WriteSingleRegister(1, (ushort)(1 << (drawerno - 1)));  // Write a holding register address 1
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