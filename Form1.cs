using System.Diagnostics;
using System.IO.Ports;
using Modbus.Device;  // NModbus4.NetCore by Hakan FISTIK

namespace MedCartTest
{
    public partial class Form1 : Form
    {
        static SerialPort serialPort = new();
        ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);  // create modbus master

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
                if (serialPort.IsOpen)
                {
                    serialPort.Close();

                    btnConnect.Text = "Connect";
                    cbPort.Enabled = true;

                    lbInfo.Text = "-";
                }
                else
                {
                    // set serial port parameters
                    serialPort.PortName = cbPort.Text;  // read port name from CB
                    serialPort.BaudRate = 19200;
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;

                    serialPort.Open();

                    btnConnect.Text = "Disconnect";
                    cbPort.Enabled = false;

                    // Example how to read registers (read board and firmware version)
                    ushort[] regs = master.ReadInputRegisters(1, 40, 2);  // Read input register address 40, 2 words
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
            if (serialPort.IsOpen)
            {
                Debug.WriteLine("Closing serial port before exit");
                serialPort.Close();
            }
        }

        // Example how to write to a holding register (open drawer solenoid)
        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    ushort drawerno = decimal.ToUInt16(numSpinner1.Value);
                    master.WriteSingleRegister(1, 1, (ushort)(1 << (drawerno - 1)));  // Write a holding register address 1
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