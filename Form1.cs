using System.Diagnostics;
using System.IO.Ports;
using Modbus.Device;  // NModbus4.NetCore by Hakan FISTIK
using Modbus.Extensions.Enron;

namespace MedCartTest
{
    public partial class Form1 : Form
    {
        static SerialPort MCSerialPort = new();
        static SerialPort SupplySerialPort = new();
        ModbusSerialMaster MCMaster = ModbusSerialMaster.CreateRtu(MCSerialPort);  // create modbus master
        ModbusSerialMaster SupplyMaster = ModbusSerialMaster.CreateRtu(SupplySerialPort);  // create modbus master

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
                cbMCPort.Items.Add(port);
                cbSupplyPort.Items.Add(port);
            }

            cbMCPort.SelectedIndex = 0;
            cbSupplyPort.SelectedIndex = 0;
        }

        // User clicks on the Connect button
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (MCSerialPort.IsOpen)
                {
                    MCSerialPort.Close();

                    btnMCConnect.Text = "Connect";
                    cbMCPort.Enabled = true;

                    lbHWInfo.Text = "-";
                    timer1.Enabled = false;
                }
                else
                {
                    // set serial port parameters
                    MCSerialPort.PortName = cbMCPort.Text;  // read port name from CB
                    MCSerialPort.BaudRate = 19200;
                    MCSerialPort.DataBits = 8;
                    MCSerialPort.Parity = Parity.None;
                    MCSerialPort.StopBits = StopBits.One;

                    MCSerialPort.Open();

                    btnMCConnect.Text = "Disconnect";
                    cbMCPort.Enabled = false;

                    // Example how to read registers (read board and firmware version)
                    ushort[] regs = MCMaster.ReadInputRegisters(1, 40, 2);  // Read input register address 40, 2 words
                    byte[] ver0 = BitConverter.GetBytes(regs[0]);
                    byte[] ver1 = BitConverter.GetBytes(regs[1]);
                    string boardver = ver0[1].ToString() + "." + ver0[0].ToString();
                    string fwver = ver1[1].ToString() + "." + ver1[0].ToString();
                    lbHWInfo.Text = "Board: " + boardver + "\nFirmware: " + fwver;

                    FetchBattCal();

                    timer1.Enabled = true;
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

            cbMCPort.Items.Clear();
            foreach (string port in ports)
            {
                cbMCPort.Items.Add(port);
            }

            cbMCPort.SelectedIndex = 0;
        }

        // Close serial port before exit
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MCSerialPort.IsOpen)
            {
                timer1.Enabled = false;
                Debug.WriteLine("Closing serial port before exit");
                MCSerialPort.Close();
            }
            if (SupplySerialPort.IsOpen)
            {
                timer1.Enabled = false;
                Debug.WriteLine("Closing serial port before exit");
                SupplySerialPort.Close();
            }
        }

        // Example how to write to a holding register (open drawer solenoid)
        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MCSerialPort.IsOpen)
                {
                    ushort drawerno = decimal.ToUInt16(numSpinner1.Value);
                    MCMaster.WriteSingleRegister(1, 1, (ushort)(1 << (drawerno - 1)));  // Write a holding register address 1
                }
                else
                    MessageBox.Show("Port not open");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ushort[] d = MCMaster.ReadInputRegisters(1, 52, 1);
            ushort nibble1 = (ushort)(d[0] >> 8);
            ushort nibble0 = (ushort)(d[0] & 0xFF);
            double vbatt = (double)nibble1 + (double)nibble0 * 0.01;
            lblBattInfo.Text = string.Format("Batt level: {0}V", vbatt.ToString("N2"));

            d = MCMaster.ReadInputRegisters(1, 22, 3);
            double[] sensor = new double[3];
            for (int i = 0; i < d.Length; i++)
            {
                nibble1 = (ushort)(d[i] >> 8);
                nibble0 = (ushort)(d[i] & 0xFF);
                sensor[i] = (double)nibble1 + (double)nibble0 * 0.01;

            }
            lblSensorInfo.Text = string.Format("Temp: {0}, {1}, {2}",
                sensor[0].ToString("N2"), sensor[1].ToString("N2"), sensor[2].ToString("N2"));

            d = MCMaster.ReadInputRegisters(1, 32, 3);
            for (int i = 0; i < d.Length; i++)
            {
                nibble1 = (ushort)(d[i] >> 8);
                nibble0 = (ushort)(d[i] & 0xFF);
                sensor[i] = (double)nibble1 + (double)nibble0 * 0.01;

            }
            lblSensorInfo.Text += string.Format("\nHumidity: {0}, {1}, {2}",
                sensor[0].ToString("N2"), sensor[1].ToString("N2"), sensor[2].ToString("N2"));

        }

        private void btnSendVolt_Click(object sender, EventArgs e)
        {
            MCMaster.WriteSingleRegister(1, 10000, (ushort)(spnVoltage.Value * 100));

            System.Threading.Thread.Sleep(100);
            FetchBattCal();  // refresh value
        }

        private void btnFetchBattCal_Click(object sender, EventArgs e)
        {
            FetchBattCal();
        }

        void FetchBattCal()
        { 
            ushort[] d = MCMaster.ReadInputRegisters(1, 10002, 1);
            lblBattRecords.Text = string.Format("Number of Records: {0}", d[0]);

            if (d[0] > 0)
            {
                ushort[] x = MCMaster.ReadHoldingRegisters(1, 10100, d[0]);
                ushort[] y = MCMaster.ReadHoldingRegisters(1, 10200, d[0]);

                for (int i = 0; i < d[0]; i++)
                {
                    lblBattRecords.Text += string.Format("\n{0}  {1}", x[i], y[i]);
                }
            }

            d = MCMaster.ReadHoldingRegisters(1, 10003, 1);
            chkEnableParam.Checked = d[0] > 0;
        }

        private void btnClearRecords_Click(object sender, EventArgs e)
        {
            MCMaster.WriteSingleRegister(1, 10001, 0);
            FetchBattCal();  // refresh value
        }

        private void chkEnableParam_CheckedChanged(object sender, EventArgs e)
        {
            MCMaster.WriteSingleRegister(1, 10003, chkEnableParam.Checked ? (ushort)1 : (ushort)0);
        }

        private void btnSupplyConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (SupplySerialPort.IsOpen)
                {
                    SupplySerialPort.Close();

                    btnSupplyConnect.Text = "Connect";
                    cbSupplyPort.Enabled = true;
                }
                else
                {
                    // set serial port parameters
                    SupplySerialPort.PortName = cbSupplyPort.Text;  // read port name from CB
                    SupplySerialPort.BaudRate = 9600;
                    SupplySerialPort.DataBits = 8;
                    SupplySerialPort.Parity = Parity.None;
                    SupplySerialPort.StopBits = StopBits.One;

                    SupplySerialPort.Open();

                    btnSupplyConnect.Text = "Disconnect";
                    cbSupplyPort.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMCPortRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            cbMCPort.Items.Clear();
            foreach (string port in ports)
            {
                cbMCPort.Items.Add(port);
            }

            cbMCPort.SelectedIndex = 0;
        }

        private void btnSupplyPortRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            cbSupplyPort.Items.Clear();
            foreach (string port in ports)
            {
                cbSupplyPort.Items.Add(port);
            }

            cbSupplyPort.SelectedIndex = 0;
        }

        const ushort CHARGER_SET_VOLTAGE_OFFSET = 0;
        const ushort CHARGER_SET_CURRENT_OFFSET = 1;
        const ushort CHARGER_READ_VOLTAGE_OFFSET = 2;
        const ushort CHARGER_READ_CURRENT_OFFSET = 3;
        const ushort CHARGER_CCCV_OFFSET = 8;
        const ushort CHARGER_ONOFF_OFFSET = 9;
        const ushort CHARGER_SET_DEFAULT_VOLTAGE_OFFSET = 0x50;
        const ushort CHARGER_SET_DEFAULT_CURRENT_OFFSET = 0x51;
        const ushort CHARGER_SET_OVER_VOLTAGE_OFFSET = 0x52;
        const ushort CHARGER_SET_OVER_CURRENT_OFFSET = 0x53;
        private void btnAutoRecord_Click(object sender, EventArgs e)
        {
            List<ushort> volts = new List<ushort> {
                900, 1000, 1100, 1200, 1300};

            if(MCSerialPort.IsOpen == false)
            {
                MessageBox.Show("Please connect to target board and try again");
                return;
            }

            if (SupplySerialPort.IsOpen == false)
            {
                MessageBox.Show("Please connect to power supply and try again");
                return;
            }

            lblBattRecords.Text = "Populating records.  Please wait ...";

            // set current limit to 1A
            SupplyMaster.WriteSingleRegister(1, CHARGER_SET_CURRENT_OFFSET, 100);

            // set voltages and record
            foreach (ushort vol in volts)
            {
                SupplyMaster.WriteSingleRegister(1, CHARGER_SET_VOLTAGE_OFFSET, vol);
                Thread.Sleep(500);
                MCMaster.WriteSingleRegister(1, 10000, vol);
                Thread.Sleep(500);
            }
            FetchBattCal();
        }
    }
}
