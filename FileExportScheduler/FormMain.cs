using EasyModbus;
using FileExportScheduler.Controller;
using FileExportScheduler.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FileExportScheduler
{
    public partial class FormMain : Form
    {
        #region Variables Declaration
        bool isStarted = false;
        bool checkExit = false;
        Dictionary<string, DeviceModel> deviceDic = new Dictionary<string, DeviceModel>();
        Dictionary<string, string> dcExportData = new Dictionary<string, string>();
        #endregion
        public FormMain()
        {
            InitializeComponent();

        }

        ModbusClient mobus = new ModbusClient();
        #region Button Events
        private void btnStart_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            notifyIcon.ShowBalloonTip(1000);
            notifyIcon.Visible = true;

            btnStop.Enabled = true;
            btnStart.Enabled = false;
            btnDataList.Enabled = false;
            btnSetting.Enabled = false;

            using (StreamReader sr = File.OpenText(GetPathJson.getPathConfig(@"\Configuration\Config.json")))
            {
                var obj = sr.ReadToEnd();
                SettingModel export = JsonConvert.DeserializeObject<SettingModel>(obj.ToString());
                tmrScheduler.Interval = export.Interval * 60000;
            }

            try
            {
                JObject jsonObj = JObject.Parse(File.ReadAllText(GetPathJson.getPathConfig(@"\Configuration\DeviceConfigure.json")));
                deviceDic = jsonObj.ToObject<Dictionary<string, DeviceModel>>();
            }
            catch (Exception ex)
            {
            }

            tmrScheduler.Start();

            lblStatus.Text = "Hệ thống đang chạy !";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnDataList.Enabled = true;
            btnSetting.Enabled = true;
            tmrScheduler.Stop();
            lblStatus.Text = "Hệ thống đã dừng !";
            notifyIcon.ShowBalloonTip(1000, "Hệ thống", "Hệ thống đã dừng !", ToolTipIcon.Warning);
        }

        private void btnDataList_Click(object sender, EventArgs e)
        {
            FormDataList f = new FormDataList();
            f.ShowDialog();
            //
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FormSetting f = new FormSetting();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            checkExit = true;

            DialogResult result = MessageBox.Show("Thoát hệ thống  ?", "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                default:
                    break;
            }
            notifyIcon.Visible = false;
        }
        #endregion

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!checkExit)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon.ShowBalloonTip(1000);
                notifyIcon.Visible = true;
                ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;

            ShowInTaskbar = true;
        }



        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            ShowInTaskbar = true;
        }



        private void FormMain_Load_1(object sender, EventArgs e)
        {

            if (File.Exists(GetPathJson.getPathConfig(@"\Configuration\Config.json")))
            {
                using (StreamReader sr = File.OpenText(GetPathJson.getPathConfig(@"\Configuration\Config.json")))
                {
                    var obj = sr.ReadToEnd();
                    SettingModel export = JsonConvert.DeserializeObject<SettingModel>(obj.ToString());
                    if (export.AutoRun == true)
                    {
                        btnStart.PerformClick();
                    }
                }
            }
        }
        /// <summary>
        /// lấy kết nối của thiết bị
        /// </summary>
        /// 

        object objW = new object();
        private async void getDeviceConnect()
        {
            string filePath;
            try
            {
                using (StreamReader sr = File.OpenText(GetPathJson.getPathConfig(@"\Configuration\Config.json")))
                {
                    var obj = sr.ReadToEnd();
                    SettingModel export = JsonConvert.DeserializeObject<SettingModel>(obj.ToString());
                    filePath = export.ExportFilePath.Substring(0, export.ExportFilePath.LastIndexOf("\\")) + "\\" + $"{ DateTime.Now.ToString("yyyyMMddHHmmss")}.csv";
                }

                foreach (KeyValuePair<string, DeviceModel> deviceUnit in deviceDic)
                {
                    mobus = new ModbusClient(deviceUnit.Value.IP, deviceUnit.Value.Port);
                    try
                    {
                        await Task.Run(() => ThreadConnect(filePath, deviceUnit));

                    }
                    catch (Exception ex)
                    {
                    }
                }
                WriteValueToFileCSV(filePath);
            }
            catch (Exception ex)
            {
                tmrScheduler.Stop();
                MessageBox.Show("Chọn đường dẫn đến thư mục");
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                btnStop.PerformClick();
                btnSetting.PerformClick();
            }
        }

        // tạo 1 thread cho connect
        void ThreadConnect(string filePath, KeyValuePair<string, DeviceModel> deviceUnit)
        {
            try
            {
                mobus.Connect();

            }
            catch (Exception ex)
            {

                lock (objW)
                {

                    deviceUnit.Value.TrangThaiKetNoi = 0;
                    WriteValueToFileCSV(filePath);
                    return;
                }

            }
            getDataDevice(deviceUnit, filePath);
        }

        //lấy dữ liệu của các thiết bị 
        private void getDataDevice(KeyValuePair<string, DeviceModel> deviceUnit, string filePath)
        {
            string[] output = new string[deviceUnit.Value.ListDuLieuChoTungPLC.Count];
            //doc tung dong trong list data cua 1 device
            for (int i = 0; i < deviceUnit.Value.ListDuLieuChoTungPLC.Count; i++)
            {
                DuLieuModel duLieuTemp = deviceUnit.Value.ListDuLieuChoTungPLC.ElementAt(i).Value;
                string giaTriDuLieu = "";
                try
                {
                    if (Convert.ToInt32(duLieuTemp.DiaChi) <= 65536)
                    {
                        bool[] readCoil = mobus.ReadCoils(Convert.ToInt32(duLieuTemp.DiaChi), 1);
                        giaTriDuLieu = readCoil[0].ToString();
                    }
                    else if (Convert.ToInt32(duLieuTemp.DiaChi) <= 165536 && Convert.ToInt32(duLieuTemp.DiaChi) >= 100001)
                    {
                        bool[] discreteInput = mobus.ReadDiscreteInputs(Convert.ToInt32(duLieuTemp.DiaChi) - 100001, 1);
                        giaTriDuLieu = discreteInput[0].ToString();
                    }
                    else if (Convert.ToInt32(duLieuTemp.DiaChi) <= 365536 && Convert.ToInt32(duLieuTemp.DiaChi) >= 300001)
                    {
                        int[] readRegister = mobus.ReadInputRegisters(Convert.ToInt32(duLieuTemp.DiaChi) - 300001, 1);
                        giaTriDuLieu = readRegister[0].ToString();
                    }
                    else if (Convert.ToInt32(duLieuTemp.DiaChi) <= 465536 && Convert.ToInt32(duLieuTemp.DiaChi) >= 400001)
                    {
                        int[] readHoldingRegister = mobus.ReadHoldingRegisters(Convert.ToInt32(duLieuTemp.DiaChi) - 400001, 1);
                        giaTriDuLieu = readHoldingRegister[0].ToString();
                    }
                    duLieuTemp.GiaTri = Convert.ToInt32(giaTriDuLieu);
                    duLieuTemp.ThoiGianDocGiuLieu = DateTime.Now;
                    deviceUnit.Value.TrangThaiKetNoi = 1;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void tmrScheduler_Tick(object sender, EventArgs e)
        {
            getDeviceConnect();
        }

        private void WriteValueToFileCSV(string filePath)
        {
            string csvData = "Thoi_gian,Thiet_bi,Ten_du_lieu,Don_vi_do,Dia_chi,Trang_thai,Gia_tri" + "\n";

            foreach (KeyValuePair<string, DeviceModel> deviceUnit in deviceDic)
            {
                foreach (KeyValuePair<string, DuLieuModel> duLieuUnit in deviceUnit.Value.ListDuLieuChoTungPLC)
                {
                    csvData += duLieuUnit.Value.ThoiGianDocGiuLieu + "," +
                            deviceUnit.Key + "," +
                            duLieuUnit.Key + "," +
                            duLieuUnit.Value.DonViDo + "," +
                            duLieuUnit.Value.DiaChi + "," +
                            deviceUnit.Value.TrangThaiKetNoi + "," +
                            duLieuUnit.Value.GiaTri + "\n";
                }
            }
            File.WriteAllText(filePath, csvData);
        }
    }
}
