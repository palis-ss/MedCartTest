namespace MedCartTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnMCConnect = new Button();
            cbMCPort = new ComboBox();
            lbHWInfo = new Label();
            groupBox1 = new GroupBox();
            lblSensorInfo = new Label();
            btnOpenDrawer = new Button();
            numSpinner1 = new NumericUpDown();
            label2 = new Label();
            lblBattInfo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSendVolt = new Button();
            btnFetchBattCal = new Button();
            lblBattRecords = new Label();
            btnClearRecords = new Button();
            chkEnableParam = new CheckBox();
            groupBox2 = new GroupBox();
            btnSetSupplyVoltage = new Button();
            btnSupplyPortRefresh = new Button();
            btnAutoRecord = new Button();
            spnVoltage = new NumericUpDown();
            btnSupplyConnect = new Button();
            cbSupplyPort = new ComboBox();
            label3 = new Label();
            btnMCPortRefresh = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSpinner1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnVoltage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 54);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 5;
            label1.Text = "MetCart Serial Port";
            // 
            // btnMCConnect
            // 
            btnMCConnect.Location = new Point(300, 50);
            btnMCConnect.Name = "btnMCConnect";
            btnMCConnect.Size = new Size(75, 23);
            btnMCConnect.TabIndex = 3;
            btnMCConnect.Text = "Connect";
            btnMCConnect.UseVisualStyleBackColor = true;
            btnMCConnect.Click += btnConnect_Click;
            // 
            // cbMCPort
            // 
            cbMCPort.FormattingEnabled = true;
            cbMCPort.Location = new Point(153, 50);
            cbMCPort.Name = "cbMCPort";
            cbMCPort.Size = new Size(121, 23);
            cbMCPort.TabIndex = 4;
            cbMCPort.Click += cbPort_Click;
            // 
            // lbHWInfo
            // 
            lbHWInfo.AutoSize = true;
            lbHWInfo.Location = new Point(17, 31);
            lbHWInfo.Name = "lbHWInfo";
            lbHWInfo.Size = new Size(12, 15);
            lbHWInfo.TabIndex = 6;
            lbHWInfo.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSensorInfo);
            groupBox1.Controls.Add(lbHWInfo);
            groupBox1.Location = new Point(87, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 132);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // lblSensorInfo
            // 
            lblSensorInfo.AutoSize = true;
            lblSensorInfo.Location = new Point(17, 80);
            lblSensorInfo.Name = "lblSensorInfo";
            lblSensorInfo.Size = new Size(12, 15);
            lblSensorInfo.TabIndex = 7;
            lblSensorInfo.Text = "-";
            // 
            // btnOpenDrawer
            // 
            btnOpenDrawer.Location = new Point(255, 258);
            btnOpenDrawer.Name = "btnOpenDrawer";
            btnOpenDrawer.Size = new Size(120, 42);
            btnOpenDrawer.TabIndex = 8;
            btnOpenDrawer.Text = "Open Drawer";
            btnOpenDrawer.UseVisualStyleBackColor = true;
            btnOpenDrawer.Click += btnOpenDrawer_Click;
            // 
            // numSpinner1
            // 
            numSpinner1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numSpinner1.Location = new Point(176, 258);
            numSpinner1.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSpinner1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSpinner1.Name = "numSpinner1";
            numSpinner1.Size = new Size(57, 36);
            numSpinner1.TabIndex = 9;
            numSpinner1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 272);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 10;
            label2.Text = "Drawer No.";
            // 
            // lblBattInfo
            // 
            lblBattInfo.AutoSize = true;
            lblBattInfo.Location = new Point(30, 29);
            lblBattInfo.Name = "lblBattInfo";
            lblBattInfo.Size = new Size(12, 15);
            lblBattInfo.TabIndex = 12;
            lblBattInfo.Text = "-";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnSendVolt
            // 
            btnSendVolt.Location = new Point(246, 145);
            btnSendVolt.Name = "btnSendVolt";
            btnSendVolt.Size = new Size(148, 28);
            btnSendVolt.TabIndex = 13;
            btnSendVolt.Text = "Send Voltage to Record";
            btnSendVolt.UseVisualStyleBackColor = true;
            btnSendVolt.Click += btnSendVolt_Click;
            // 
            // btnFetchBattCal
            // 
            btnFetchBattCal.Location = new Point(30, 175);
            btnFetchBattCal.Name = "btnFetchBattCal";
            btnFetchBattCal.Size = new Size(148, 40);
            btnFetchBattCal.TabIndex = 14;
            btnFetchBattCal.Text = "Fetch Batt Cal Records";
            btnFetchBattCal.UseVisualStyleBackColor = true;
            btnFetchBattCal.Click += btnFetchBattCal_Click;
            // 
            // lblBattRecords
            // 
            lblBattRecords.AutoSize = true;
            lblBattRecords.Location = new Point(30, 237);
            lblBattRecords.Name = "lblBattRecords";
            lblBattRecords.Size = new Size(12, 15);
            lblBattRecords.TabIndex = 15;
            lblBattRecords.Text = "-";
            // 
            // btnClearRecords
            // 
            btnClearRecords.Location = new Point(246, 313);
            btnClearRecords.Name = "btnClearRecords";
            btnClearRecords.Size = new Size(148, 40);
            btnClearRecords.TabIndex = 16;
            btnClearRecords.Text = "Clear Records";
            btnClearRecords.UseVisualStyleBackColor = true;
            btnClearRecords.Click += btnClearRecords_Click;
            // 
            // chkEnableParam
            // 
            chkEnableParam.AutoSize = true;
            chkEnableParam.Location = new Point(260, 187);
            chkEnableParam.Name = "chkEnableParam";
            chkEnableParam.Size = new Size(118, 19);
            chkEnableParam.TabIndex = 17;
            chkEnableParam.Text = "Enable Cal Param";
            chkEnableParam.UseVisualStyleBackColor = true;
            chkEnableParam.CheckedChanged += chkEnableParam_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSetSupplyVoltage);
            groupBox2.Controls.Add(btnSupplyPortRefresh);
            groupBox2.Controls.Add(btnAutoRecord);
            groupBox2.Controls.Add(spnVoltage);
            groupBox2.Controls.Add(chkEnableParam);
            groupBox2.Controls.Add(btnSupplyConnect);
            groupBox2.Controls.Add(btnClearRecords);
            groupBox2.Controls.Add(lblBattRecords);
            groupBox2.Controls.Add(cbSupplyPort);
            groupBox2.Controls.Add(lblBattInfo);
            groupBox2.Controls.Add(btnFetchBattCal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnSendVolt);
            groupBox2.Location = new Point(488, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 370);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Battery Functions";
            // 
            // btnSetSupplyVoltage
            // 
            btnSetSupplyVoltage.Location = new Point(246, 107);
            btnSetSupplyVoltage.Name = "btnSetSupplyVoltage";
            btnSetSupplyVoltage.Size = new Size(148, 30);
            btnSetSupplyVoltage.TabIndex = 21;
            btnSetSupplyVoltage.Text = "Set Supply Voltage";
            btnSetSupplyVoltage.UseVisualStyleBackColor = true;
            btnSetSupplyVoltage.Click += btnSetSupplyVoltage_Click;
            // 
            // btnSupplyPortRefresh
            // 
            btnSupplyPortRefresh.Font = new Font("Wingdings 3", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupplyPortRefresh.Location = new Point(372, 59);
            btnSupplyPortRefresh.Name = "btnSupplyPortRefresh";
            btnSupplyPortRefresh.Size = new Size(29, 23);
            btnSupplyPortRefresh.TabIndex = 20;
            btnSupplyPortRefresh.Text = "Q";
            btnSupplyPortRefresh.UseVisualStyleBackColor = true;
            btnSupplyPortRefresh.Click += btnSupplyPortRefresh_Click;
            // 
            // btnAutoRecord
            // 
            btnAutoRecord.Location = new Point(246, 258);
            btnAutoRecord.Name = "btnAutoRecord";
            btnAutoRecord.Size = new Size(148, 40);
            btnAutoRecord.TabIndex = 20;
            btnAutoRecord.Text = "Auto Populate Records";
            btnAutoRecord.UseVisualStyleBackColor = true;
            btnAutoRecord.Click += btnAutoRecord_Click;
            // 
            // spnVoltage
            // 
            spnVoltage.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            spnVoltage.Location = new Point(120, 121);
            spnVoltage.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            spnVoltage.Minimum = new decimal(new int[] { 9, 0, 0, 0 });
            spnVoltage.Name = "spnVoltage";
            spnVoltage.Size = new Size(102, 36);
            spnVoltage.TabIndex = 18;
            spnVoltage.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // btnSupplyConnect
            // 
            btnSupplyConnect.Location = new Point(291, 58);
            btnSupplyConnect.Name = "btnSupplyConnect";
            btnSupplyConnect.Size = new Size(75, 23);
            btnSupplyConnect.TabIndex = 19;
            btnSupplyConnect.Text = "Connect";
            btnSupplyConnect.UseVisualStyleBackColor = true;
            btnSupplyConnect.Click += btnSupplyConnect_Click;
            // 
            // cbSupplyPort
            // 
            cbSupplyPort.FormattingEnabled = true;
            cbSupplyPort.Location = new Point(138, 59);
            cbSupplyPort.Name = "cbSupplyPort";
            cbSupplyPort.Size = new Size(121, 23);
            cbSupplyPort.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 64);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 19;
            label3.Text = "Supply Serial Port";
            // 
            // btnMCPortRefresh
            // 
            btnMCPortRefresh.Font = new Font("Wingdings 3", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMCPortRefresh.Location = new Point(381, 50);
            btnMCPortRefresh.Name = "btnMCPortRefresh";
            btnMCPortRefresh.Size = new Size(29, 23);
            btnMCPortRefresh.TabIndex = 19;
            btnMCPortRefresh.Text = "Q";
            btnMCPortRefresh.UseVisualStyleBackColor = true;
            btnMCPortRefresh.Click += btnMCPortRefresh_Click;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(457, 370);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "MedCart Functions";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 394);
            Controls.Add(btnMCPortRefresh);
            Controls.Add(label2);
            Controls.Add(numSpinner1);
            Controls.Add(btnOpenDrawer);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnMCConnect);
            Controls.Add(cbMCPort);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "MedCart Protocol Test";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSpinner1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spnVoltage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMCConnect;
        private ComboBox cbMCPort;
        private Label lbHWInfo;
        private GroupBox groupBox1;
        private Button btnOpenDrawer;
        private NumericUpDown numSpinner1;
        private Label label2;
        private Label lblBattInfo;
        private System.Windows.Forms.Timer timer1;
        private Button btnSendVolt;
        private Button btnFetchBattCal;
        private Label lblBattRecords;
        private Button btnClearRecords;
        private CheckBox chkEnableParam;
        private GroupBox groupBox2;
        private NumericUpDown spnVoltage;
        private Label lblSensorInfo;
        private Button btnSupplyConnect;
        private ComboBox cbSupplyPort;
        private Label label3;
        private Button btnAutoRecord;
        private Button btnSupplyPortRefresh;
        private Button btnMCPortRefresh;
        private Button btnSetSupplyVoltage;
        private GroupBox groupBox3;
    }
}