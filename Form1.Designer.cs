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
            label1 = new Label();
            btnConnect = new Button();
            cbPort = new ComboBox();
            lbInfo = new Label();
            groupBox1 = new GroupBox();
            btnOpenDrawer = new Button();
            numSpinner1 = new NumericUpDown();
            label2 = new Label();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 394);
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
    }
}