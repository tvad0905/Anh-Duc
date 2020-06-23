namespace FileExportScheduler
{
    partial class DeviceConfiguration
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.cbConnect = new System.Windows.Forms.ComboBox();
            this.groupSerialSetting = new System.Windows.Forms.GroupBox();
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
            this.groupTCP = new System.Windows.Forms.GroupBox();
            this.txtIPAdress = new IPAddressControlLib.IPAddressControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblConnect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.dgvShowDuLieu = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemDuLieu = new System.Windows.Forms.Button();
            this.btnXoaDuLieu = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorIP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPort = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTenDL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDonViDo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorConnect = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.groupSerialSetting.SuspendLayout();
            this.groupTCP.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenDL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDonViDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConnect)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(890, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.panelForm);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 703);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cấu hình";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelForm
            // 
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.cbConnect);
            this.panelForm.Controls.Add(this.groupSerialSetting);
            this.panelForm.Controls.Add(this.groupTCP);
            this.panelForm.Controls.Add(this.btnEdit);
            this.panelForm.Controls.Add(this.txtName);
            this.panelForm.Controls.Add(this.lblConnect);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.btnSave);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(3, 3);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(872, 693);
            this.panelForm.TabIndex = 0;
            // 
            // cbConnect
            // 
            this.cbConnect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnect.FormattingEnabled = true;
            this.cbConnect.Items.AddRange(new object[] {
            "Siemens S7-1200"});
            this.cbConnect.Location = new System.Drawing.Point(97, 42);
            this.cbConnect.Margin = new System.Windows.Forms.Padding(2);
            this.cbConnect.Name = "cbConnect";
            this.cbConnect.Size = new System.Drawing.Size(344, 21);
            this.cbConnect.TabIndex = 0;
            this.cbConnect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupSerialSetting
            // 
            this.groupSerialSetting.Controls.Add(this.label9);
            this.groupSerialSetting.Controls.Add(this.label8);
            this.groupSerialSetting.Controls.Add(this.label7);
            this.groupSerialSetting.Controls.Add(this.label6);
            this.groupSerialSetting.Controls.Add(this.label5);
            this.groupSerialSetting.Controls.Add(this.cbBaud);
            this.groupSerialSetting.Controls.Add(this.cbStopBit);
            this.groupSerialSetting.Controls.Add(this.cbParity);
            this.groupSerialSetting.Controls.Add(this.cbDataBit);
            this.groupSerialSetting.Controls.Add(this.cbCOM);
            this.groupSerialSetting.Location = new System.Drawing.Point(14, 145);
            this.groupSerialSetting.Margin = new System.Windows.Forms.Padding(2);
            this.groupSerialSetting.Name = "groupSerialSetting";
            this.groupSerialSetting.Padding = new System.Windows.Forms.Padding(2);
            this.groupSerialSetting.Size = new System.Drawing.Size(439, 150);
            this.groupSerialSetting.TabIndex = 0;
            this.groupSerialSetting.TabStop = false;
            this.groupSerialSetting.Text = "Cấu hình cổng COM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Stop bit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Parity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data bit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tốc độ truyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
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
            this.cbBaud.Location = new System.Drawing.Point(83, 42);
            this.cbBaud.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(344, 21);
            this.cbBaud.TabIndex = 3;
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStopBit.Location = new System.Drawing.Point(83, 117);
            this.cbStopBit.Margin = new System.Windows.Forms.Padding(2);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(344, 21);
            this.cbStopBit.TabIndex = 6;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParity.Location = new System.Drawing.Point(83, 92);
            this.cbParity.Margin = new System.Windows.Forms.Padding(2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(344, 21);
            this.cbParity.TabIndex = 5;
            // 
            // cbDataBit
            // 
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbDataBit.Location = new System.Drawing.Point(83, 67);
            this.cbDataBit.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(344, 21);
            this.cbDataBit.TabIndex = 4;
            // 
            // cbCOM
            // 
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(83, 17);
            this.cbCOM.Margin = new System.Windows.Forms.Padding(2);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(344, 21);
            this.cbCOM.TabIndex = 2;
            // 
            // groupTCP
            // 
            this.groupTCP.Controls.Add(this.txtIPAdress);
            this.groupTCP.Controls.Add(this.label3);
            this.groupTCP.Controls.Add(this.txtPort);
            this.groupTCP.Controls.Add(this.label2);
            this.groupTCP.Location = new System.Drawing.Point(14, 68);
            this.groupTCP.Margin = new System.Windows.Forms.Padding(2);
            this.groupTCP.Name = "groupTCP";
            this.groupTCP.Padding = new System.Windows.Forms.Padding(2);
            this.groupTCP.Size = new System.Drawing.Size(439, 73);
            this.groupTCP.TabIndex = 7;
            this.groupTCP.TabStop = false;
            this.groupTCP.Text = "Cấu hình địa chỉ IP";
            // 
            // txtIPAdress
            // 
            this.txtIPAdress.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtIPAdress.AllowInternalTab = true;
            this.txtIPAdress.AutoHeight = true;
            this.txtIPAdress.BackColor = System.Drawing.SystemColors.Window;
            this.txtIPAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPAdress.Location = new System.Drawing.Point(83, 18);
            this.txtIPAdress.Name = "txtIPAdress";
            this.txtIPAdress.ReadOnly = false;
            this.txtIPAdress.Size = new System.Drawing.Size(344, 20);
            this.txtIPAdress.TabIndex = 13;
            this.txtIPAdress.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cổng";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(83, 44);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(344, 20);
            this.txtPort.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ IP";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(366, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Location = new System.Drawing.Point(49, 45);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(42, 13);
            this.lblConnect.TabIndex = 1;
            this.lblConnect.Text = "Thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thiết bị";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExport);
            this.tabPage2.Controls.Add(this.btnImport);
            this.tabPage2.Controls.Add(this.dgvShowDuLieu);
            this.tabPage2.Controls.Add(this.btnThemDuLieu);
            this.tabPage2.Controls.Add(this.btnXoaDuLieu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 703);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dữ liệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(801, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(720, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvShowDuLieu
            // 
            this.dgvShowDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Dia_Chi,
            this.Donvido});
            this.dgvShowDuLieu.GridColor = System.Drawing.SystemColors.Control;
            this.dgvShowDuLieu.Location = new System.Drawing.Point(5, 35);
            this.dgvShowDuLieu.Name = "dgvShowDuLieu";
            this.dgvShowDuLieu.Size = new System.Drawing.Size(871, 662);
            this.dgvShowDuLieu.TabIndex = 3;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 200;
            this.Ten.Name = "Ten";
            // 
            // Dia_Chi
            // 
            this.Dia_Chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dia_Chi.DataPropertyName = "DiaChi";
            this.Dia_Chi.HeaderText = "Địa Chỉ";
            this.Dia_Chi.MinimumWidth = 200;
            this.Dia_Chi.Name = "Dia_Chi";
            // 
            // Donvido
            // 
            this.Donvido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Donvido.DataPropertyName = "Donvido";
            this.Donvido.HeaderText = "Đơn Vị Đo";
            this.Donvido.MinimumWidth = 200;
            this.Donvido.Name = "Donvido";
            // 
            // btnThemDuLieu
            // 
            this.btnThemDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDuLieu.Location = new System.Drawing.Point(5, 7);
            this.btnThemDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDuLieu.Name = "btnThemDuLieu";
            this.btnThemDuLieu.Size = new System.Drawing.Size(80, 23);
            this.btnThemDuLieu.TabIndex = 0;
            this.btnThemDuLieu.Text = "Lưu";
            this.btnThemDuLieu.UseVisualStyleBackColor = true;
            this.btnThemDuLieu.Click += new System.EventHandler(this.btnThemDuLieu_Click);
            // 
            // btnXoaDuLieu
            // 
            this.btnXoaDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDuLieu.Location = new System.Drawing.Point(89, 7);
            this.btnXoaDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDuLieu.Name = "btnXoaDuLieu";
            this.btnXoaDuLieu.Size = new System.Drawing.Size(80, 23);
            this.btnXoaDuLieu.TabIndex = 2;
            this.btnXoaDuLieu.Text = "Xóa";
            this.btnXoaDuLieu.UseVisualStyleBackColor = true;
            this.btnXoaDuLieu.Click += new System.EventHandler(this.btnXoaDL_Click);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorIP
            // 
            this.errorIP.ContainerControl = this;
            // 
            // errorPort
            // 
            this.errorPort.ContainerControl = this;
            // 
            // errorTenDL
            // 
            this.errorTenDL.ContainerControl = this;
            // 
            // errorDiaChi
            // 
            this.errorDiaChi.ContainerControl = this;
            // 
            // errorDonViDo
            // 
            this.errorDonViDo.ContainerControl = this;
            // 
            // errorConnect
            // 
            this.errorConnect.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // DeviceConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DeviceConfiguration";
            this.Size = new System.Drawing.Size(890, 729);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.groupSerialSetting.ResumeLayout(false);
            this.groupSerialSetting.PerformLayout();
            this.groupTCP.ResumeLayout(false);
            this.groupTCP.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenDL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDonViDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConnect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorIP;
        private System.Windows.Forms.ErrorProvider errorPort;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelForm;
        public IPAddressControlLib.IPAddressControl txtIPAdress;
        private System.Windows.Forms.Button btnXoaDuLieu;
        private System.Windows.Forms.ErrorProvider errorTenDL;
        private System.Windows.Forms.ErrorProvider errorDiaChi;
        private System.Windows.Forms.ErrorProvider errorDonViDo;
        private System.Windows.Forms.Button btnThemDuLieu;
        private System.Windows.Forms.GroupBox groupTCP;
        public System.Windows.Forms.ComboBox cbConnect;
        private System.Windows.Forms.GroupBox groupSerialSetting;
        public System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBit;
        private System.Windows.Forms.ErrorProvider errorConnect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvShowDuLieu;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvido;
    }
}
