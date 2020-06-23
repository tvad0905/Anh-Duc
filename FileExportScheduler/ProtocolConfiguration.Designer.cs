namespace FileExportScheduler
{
    partial class ProtocolConfiguration
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.gbTCPIPProtocol = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPAdress = new IPAddressControlLib.IPAddressControl();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnEditProtocol = new System.Windows.Forms.Button();
            this.btnSaveProtocol = new System.Windows.Forms.Button();
            this.gbSerialSettingProtocol = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBit = new System.Windows.Forms.ComboBox();
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.txtTenGiaoThuc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.dgvDataProtocol = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvido_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorPort = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorIP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTenGiaoThuc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGiaoThuc = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbTCPIPProtocol.SuspendLayout();
            this.gbSerialSettingProtocol.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProtocol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenGiaoThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiaoThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 739);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbProtocol);
            this.tabPage1.Controls.Add(this.gbTCPIPProtocol);
            this.tabPage1.Controls.Add(this.btnEditProtocol);
            this.tabPage1.Controls.Add(this.btnSaveProtocol);
            this.tabPage1.Controls.Add(this.gbSerialSettingProtocol);
            this.tabPage1.Controls.Add(this.txtTenGiaoThuc);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1009, 713);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cấu hình";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbProtocol
            // 
            this.cbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtocol.FormattingEnabled = true;
            this.cbProtocol.Items.AddRange(new object[] {
            "Modbus TCP/IP",
            "Serial Port"});
            this.cbProtocol.Location = new System.Drawing.Point(111, 45);
            this.cbProtocol.Name = "cbProtocol";
            this.cbProtocol.Size = new System.Drawing.Size(345, 21);
            this.cbProtocol.TabIndex = 16;
            this.cbProtocol.SelectedIndexChanged += new System.EventHandler(this.cbProtocol_SelectedIndexChanged);
            // 
            // gbTCPIPProtocol
            // 
            this.gbTCPIPProtocol.Controls.Add(this.label2);
            this.gbTCPIPProtocol.Controls.Add(this.label3);
            this.gbTCPIPProtocol.Controls.Add(this.txtIPAdress);
            this.gbTCPIPProtocol.Controls.Add(this.txtPort);
            this.gbTCPIPProtocol.Location = new System.Drawing.Point(22, 68);
            this.gbTCPIPProtocol.Margin = new System.Windows.Forms.Padding(2);
            this.gbTCPIPProtocol.Name = "gbTCPIPProtocol";
            this.gbTCPIPProtocol.Padding = new System.Windows.Forms.Padding(2);
            this.gbTCPIPProtocol.Size = new System.Drawing.Size(439, 73);
            this.gbTCPIPProtocol.TabIndex = 10;
            this.gbTCPIPProtocol.TabStop = false;
            this.gbTCPIPProtocol.Text = "Cấu hình địa chỉ IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cổng";
            // 
            // txtIPAdress
            // 
            this.txtIPAdress.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtIPAdress.AllowInternalTab = true;
            this.txtIPAdress.AutoHeight = true;
            this.txtIPAdress.BackColor = System.Drawing.SystemColors.Window;
            this.txtIPAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPAdress.Location = new System.Drawing.Point(89, 18);
            this.txtIPAdress.Name = "txtIPAdress";
            this.txtIPAdress.ReadOnly = false;
            this.txtIPAdress.Size = new System.Drawing.Size(345, 20);
            this.txtIPAdress.TabIndex = 1;
            this.txtIPAdress.Text = "...";
            this.txtIPAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPAdress_KeyPress);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(89, 43);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(345, 20);
            this.txtPort.TabIndex = 2;
            // 
            // btnEditProtocol
            // 
            this.btnEditProtocol.Location = new System.Drawing.Point(381, 298);
            this.btnEditProtocol.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProtocol.Name = "btnEditProtocol";
            this.btnEditProtocol.Size = new System.Drawing.Size(75, 23);
            this.btnEditProtocol.TabIndex = 14;
            this.btnEditProtocol.Text = "Lưu";
            this.btnEditProtocol.UseVisualStyleBackColor = true;
            this.btnEditProtocol.Click += new System.EventHandler(this.btnEditProtocol_Click_1);
            // 
            // btnSaveProtocol
            // 
            this.btnSaveProtocol.Location = new System.Drawing.Point(381, 298);
            this.btnSaveProtocol.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveProtocol.Name = "btnSaveProtocol";
            this.btnSaveProtocol.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProtocol.TabIndex = 1;
            this.btnSaveProtocol.Text = "Lưu";
            this.btnSaveProtocol.UseVisualStyleBackColor = true;
            this.btnSaveProtocol.Click += new System.EventHandler(this.btnSaveProtocol_Click_1);
            // 
            // gbSerialSettingProtocol
            // 
            this.gbSerialSettingProtocol.Controls.Add(this.label9);
            this.gbSerialSettingProtocol.Controls.Add(this.label8);
            this.gbSerialSettingProtocol.Controls.Add(this.label7);
            this.gbSerialSettingProtocol.Controls.Add(this.label6);
            this.gbSerialSettingProtocol.Controls.Add(this.label5);
            this.gbSerialSettingProtocol.Controls.Add(this.cbBaud);
            this.gbSerialSettingProtocol.Controls.Add(this.cbStopBit);
            this.gbSerialSettingProtocol.Controls.Add(this.cbParity);
            this.gbSerialSettingProtocol.Controls.Add(this.cbDataBit);
            this.gbSerialSettingProtocol.Controls.Add(this.cbCOM);
            this.gbSerialSettingProtocol.Location = new System.Drawing.Point(22, 145);
            this.gbSerialSettingProtocol.Margin = new System.Windows.Forms.Padding(2);
            this.gbSerialSettingProtocol.Name = "gbSerialSettingProtocol";
            this.gbSerialSettingProtocol.Padding = new System.Windows.Forms.Padding(2);
            this.gbSerialSettingProtocol.Size = new System.Drawing.Size(439, 149);
            this.gbSerialSettingProtocol.TabIndex = 9;
            this.gbSerialSettingProtocol.TabStop = false;
            this.gbSerialSettingProtocol.Text = "Cấu hình cổng COM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Stop bit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Parity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data bit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tốc độ truyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cổng COM";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "230400",
            "256000"});
            this.cbBaud.Location = new System.Drawing.Point(89, 42);
            this.cbBaud.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(345, 21);
            this.cbBaud.TabIndex = 4;
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStopBit.Location = new System.Drawing.Point(89, 117);
            this.cbStopBit.Margin = new System.Windows.Forms.Padding(2);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(345, 21);
            this.cbStopBit.TabIndex = 7;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParity.Location = new System.Drawing.Point(89, 92);
            this.cbParity.Margin = new System.Windows.Forms.Padding(2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(345, 21);
            this.cbParity.TabIndex = 6;
            // 
            // cbDataBit
            // 
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbDataBit.Location = new System.Drawing.Point(89, 67);
            this.cbDataBit.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(345, 21);
            this.cbDataBit.TabIndex = 5;
            // 
            // cbCOM
            // 
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(89, 17);
            this.cbCOM.Margin = new System.Windows.Forms.Padding(2);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(345, 21);
            this.cbCOM.TabIndex = 3;
            // 
            // txtTenGiaoThuc
            // 
            this.txtTenGiaoThuc.Location = new System.Drawing.Point(111, 20);
            this.txtTenGiaoThuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenGiaoThuc.Name = "txtTenGiaoThuc";
            this.txtTenGiaoThuc.Size = new System.Drawing.Size(345, 20);
            this.txtTenGiaoThuc.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giao thức";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên giao thức";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExport);
            this.tabPage2.Controls.Add(this.btnImport);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnAddData);
            this.tabPage2.Controls.Add(this.dgvDataProtocol);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1009, 713);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dữ liệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(926, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(845, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(89, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(5, 5);
            this.btnAddData.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(80, 23);
            this.btnAddData.TabIndex = 7;
            this.btnAddData.Text = "Thêm";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // dgvDataProtocol
            // 
            this.dgvDataProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataProtocol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataProtocol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.Diachi_P,
            this.Donvido_P});
            this.dgvDataProtocol.Location = new System.Drawing.Point(5, 32);
            this.dgvDataProtocol.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataProtocol.Name = "dgvDataProtocol";
            this.dgvDataProtocol.RowHeadersWidth = 51;
            this.dgvDataProtocol.RowTemplate.Height = 24;
            this.dgvDataProtocol.Size = new System.Drawing.Size(999, 676);
            this.dgvDataProtocol.TabIndex = 3;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 200;
            this.ten.Name = "ten";
            // 
            // Diachi_P
            // 
            this.Diachi_P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diachi_P.DataPropertyName = "Diachi";
            this.Diachi_P.HeaderText = "Địa Chỉ";
            this.Diachi_P.MinimumWidth = 200;
            this.Diachi_P.Name = "Diachi_P";
            // 
            // Donvido_P
            // 
            this.Donvido_P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Donvido_P.DataPropertyName = "Donvido";
            this.Donvido_P.HeaderText = "Đơn Vị Đo";
            this.Donvido_P.MinimumWidth = 200;
            this.Donvido_P.Name = "Donvido_P";
            // 
            // errorPort
            // 
            this.errorPort.ContainerControl = this;
            // 
            // errorIP
            // 
            this.errorIP.ContainerControl = this;
            // 
            // errorTenGiaoThuc
            // 
            this.errorTenGiaoThuc.ContainerControl = this;
            // 
            // errorGiaoThuc
            // 
            this.errorGiaoThuc.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProtocolConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ProtocolConfiguration";
            this.Size = new System.Drawing.Size(1017, 739);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbTCPIPProtocol.ResumeLayout(false);
            this.gbTCPIPProtocol.PerformLayout();
            this.gbSerialSettingProtocol.ResumeLayout(false);
            this.gbSerialSettingProtocol.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProtocol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenGiaoThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiaoThuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTenGiaoThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSaveProtocol;
        public IPAddressControlLib.IPAddressControl txtIPAdress;
        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.GroupBox gbTCPIPProtocol;
        public System.Windows.Forms.GroupBox gbSerialSettingProtocol;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBit;
        public System.Windows.Forms.ComboBox cbCOM;
        public System.Windows.Forms.Button btnEditProtocol;
        private System.Windows.Forms.ErrorProvider errorPort;
        private System.Windows.Forms.ErrorProvider errorIP;
        private System.Windows.Forms.ErrorProvider errorTenGiaoThuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.DataGridView dgvDataProtocol;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.ErrorProvider errorGiaoThuc;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvido_P;
    }
}
