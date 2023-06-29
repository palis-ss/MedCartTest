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
            btnConnect = new Button();
            cbPort = new ComboBox();
            lbInfo = new Label();
            groupBox1 = new GroupBox();
            btnOpenDrawer = new Button();
            numSpinner1 = new NumericUpDown();
            label2 = new Label();
            txtVoltage = new TextBox();
            lblBattInfo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSendVolt = new Button();
            btnFetchBattCal = new Button();
            lblBattRecords = new Label();
            btnClearRecords = new Button();
            chkEnableParam = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSpinner1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 54);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Serial Port";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(300, 50);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // cbPort
            // 
            cbPort.FormattingEnabled = true;
            cbPort.Location = new Point(153, 50);
            cbPort.Name = "cbPort";
            cbPort.Size = new Size(121, 23);
            cbPort.TabIndex = 4;
            cbPort.Click += cbPort_Click;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(17, 31);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(12, 15);
            lbInfo.TabIndex = 6;
            lbInfo.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbInfo);
            groupBox1.Location = new Point(87, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 86);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Version info";
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
            numSpinner1.Location = new Point(184, 270);
            numSpinner1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSpinner1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSpinner1.Name = "numSpinner1";
            numSpinner1.Size = new Size(40, 23);
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
            // txtVoltage
            // 
            txtVoltage.Location = new Point(557, 75);
            txtVoltage.Name = "txtVoltage";
            txtVoltage.Size = new Size(100, 23);
            txtVoltage.TabIndex = 11;
            // 
            // lblBattInfo
            // 
            lblBattInfo.AutoSize = true;
            lblBattInfo.Location = new Point(557, 30);
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
            btnSendVolt.Location = new Point(684, 63);
            btnSendVolt.Name = "btnSendVolt";
            btnSendVolt.Size = new Size(148, 44);
            btnSendVolt.TabIndex = 13;
            btnSendVolt.Text = "Send Voltage Value";
            btnSendVolt.UseVisualStyleBackColor = true;
            btnSendVolt.Click += btnSendVolt_Click;
            // 
            // btnFetchBattCal
            // 
            btnFetchBattCal.Location = new Point(557, 125);
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
            lblBattRecords.Location = new Point(557, 189);
            lblBattRecords.Name = "lblBattRecords";
            lblBattRecords.Size = new Size(12, 15);
            lblBattRecords.TabIndex = 15;
            lblBattRecords.Text = "-";
            // 
            // btnClearRecords
            // 
            btnClearRecords.Location = new Point(771, 125);
            btnClearRecords.Name = "btnClearRecords";
            btnClearRecords.Size = new Size(109, 40);
            btnClearRecords.TabIndex = 16;
            btnClearRecords.Text = "Clear Records";
            btnClearRecords.UseVisualStyleBackColor = true;
            btnClearRecords.Click += btnClearRecords_Click;
            // 
            // chkEnableParam
            // 
            chkEnableParam.AutoSize = true;
            chkEnableParam.Location = new Point(771, 174);
            chkEnableParam.Name = "chkEnableParam";
            chkEnableParam.Size = new Size(118, 19);
            chkEnableParam.TabIndex = 17;
            chkEnableParam.Text = "Enable Cal Param";
            chkEnableParam.UseVisualStyleBackColor = true;
            chkEnableParam.CheckedChanged += chkEnableParam_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 394);
            Controls.Add(chkEnableParam);
            Controls.Add(btnClearRecords);
            Controls.Add(lblBattRecords);
            Controls.Add(btnFetchBattCal);
            Controls.Add(btnSendVolt);
            Controls.Add(lblBattInfo);
            Controls.Add(txtVoltage);
            Controls.Add(label2);
            Controls.Add(numSpinner1);
            Controls.Add(btnOpenDrawer);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnConnect);
            Controls.Add(cbPort);
            Name = "Form1";
            Text = "MedCart Protocol Test";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSpinner1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConnect;
        private ComboBox cbPort;
        private Label lbInfo;
        private GroupBox groupBox1;
        private Button btnOpenDrawer;
        private NumericUpDown numSpinner1;
        private Label label2;
        private TextBox txtVoltage;
        private Label lblBattInfo;
        private System.Windows.Forms.Timer timer1;
        private Button btnSendVolt;
        private Button btnFetchBattCal;
        private Label lblBattRecords;
        private Button btnClearRecords;
        private CheckBox chkEnableParam;
    }
}