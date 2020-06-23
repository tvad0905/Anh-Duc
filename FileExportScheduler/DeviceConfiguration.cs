using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileExportScheduler.Models;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.Reflection;
using FileExportScheduler.Controller;

namespace FileExportScheduler
{
    public partial class DeviceConfiguration : UserControl
    {
        #region biến toàn cục
        //List<Device> lstDevices;
        public Dictionary<string, DeviceModel> deviceDic = new Dictionary<string, DeviceModel>();
        TreeView TVMain;
        public FormDataList formDataList;
        public string tenDuLieuDuocChon;
        private string tenDuLieu, diaChi, donViDoDuLieu;
        #endregion
        public DeviceConfiguration(FormDataList formDataList)
        {
            InitializeComponent();
            this.TVMain = formDataList.tvMain;
            this.formDataList = formDataList;
            WriteJsonToList();
            LoadDuLieuLenDgv();

            //set mặc định lên màn hình
            cbCOM.SelectedIndex = cbCOM.Items.IndexOf("COM 1");
            cbBaud.SelectedIndex = cbBaud.Items.IndexOf("9600 Baud");
            cbDataBit.SelectedIndex = cbDataBit.Items.IndexOf("8 Data bits");
            cbParity.SelectedIndex = cbParity.Items.IndexOf("Even Parity");
            cbStopBit.SelectedIndex = cbStopBit.Items.IndexOf("1 Stop Bit");

            // btnXoaDuLieu.Enabled = false;
        }
        #region Thao tác file .json
        //Viết từ .json vào 1 list
        public void WriteJsonToList()
        {
            try
            {
                JObject jsonObj = JObject.Parse(File.ReadAllText(GetPathJson.getPathConfig(@"\Configuration\DeviceConfigure.json")));
                deviceDic = jsonObj.ToObject<Dictionary<string, DeviceModel>>();
            }
            catch (Exception ex)
            {

            }
        }

        //Viết từ list vào file .json
        public void WriteListToJson()
        {
            string jsonString = (new JavaScriptSerializer()).Serialize((object)deviceDic);
            File.WriteAllText(GetPathJson.getPathConfig(@"\Configuration\DeviceConfigure.json"), jsonString);
        }
        #endregion

        #region Sự kiện Nút
        private void txtDiaChiDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //Chọn giao thức kết nối
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConnect.SelectedIndex == 0)
            {
                groupSerialSetting.Enabled = false;
                groupTCP.Enabled = true;
            }
            else
            {
                groupSerialSetting.Enabled = true;
                groupTCP.Enabled = false;
            }
        }
        //Nút đóng tab
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        //lưu dữ liệu device
        private void btnSave_Click(object sender, EventArgs e)
        {

            WriteJsonToList();


            if (checkInputStringDevice() == false)
            {
                return;
            }

            DeviceModel deviceObj = new DeviceModel
            {
                Name = txtName.Text,
                IP = txtIPAdress.Text,
                Port = Convert.ToInt32(txtPort.Text),
                Protocol = cbConnect.SelectedItem.ToString(),
                ListDuLieuChoTungPLC = new Dictionary<string, DuLieuModel>(),

            };

            deviceDic.Add(deviceObj.Name, deviceObj);
            WriteListToJson();
            TreeNode node = new TreeNode(txtName.Text);
            if (TVMain.SelectedNode.Parent == null)
            {
                TVMain.SelectedNode.Nodes.Add(node);
            }
            else
            {
                TVMain.SelectedNode.Parent.Nodes.Add(node);
            }

            node.ContextMenuStrip = formDataList.tx2;

            MessageBox.Show("Lưu thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Xóa dữ liệu device
        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvShowDuLieu.SelectedRows)
                {
                    deviceDic[txtName.Text].ListDuLieuChoTungPLC.Remove(row.Cells[0].Value.ToString());
                    dgvShowDuLieu.Rows.Remove(row);

                }
                int a = deviceDic.Count;
                WriteListToJson();
            }


        }
        //lưu mới dữ liệu nhập vào 
        private void btnThemDuLieu_Click(object sender, EventArgs e)
        {
            if (saveToJson())
            {
                MessageBox.Show("Luu thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu sai định dạng !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region sự kiện datagridview
        public void LoadDuLieuLenDgv()
        {

            dgvShowDuLieu.AutoGenerateColumns = false;
            try
            {
                var cc = deviceDic[formDataList.selectedNodeDouble.Text].ListDuLieuChoTungPLC.Select(x => x.Value).ToList();
                var bindingSource = new BindingSource();
                bindingSource.DataSource = cc;
                dgvShowDuLieu.DataSource = bindingSource;

            }
            catch (Exception ex)
            {

            }

        }

        #endregion

        #region Kiểm tra nhập vào
        //Kiểm tra nhập vào dữ liệu device
        private bool validation()
        {
            List<string> list = new List<string>();
            list.Clear();
            bool isPassed = true;
            foreach (DataGridViewRow dr in dgvShowDuLieu.Rows)
            {
                if (dr.Index == dgvShowDuLieu.Rows.Count - 1)
                {
                    break;
                }


                foreach (DataGridViewCell dc in dr.Cells)
                {
                    if (dc.ColumnIndex == 3)
                    {
                        break;
                    }

                    if (dc.Value == null || dc.Value.ToString().Trim() == string.Empty)
                    {
                        dc.ErrorText = "Không được để trống";
                        isPassed = false;
                    }
                    else
                    {
                        dc.ErrorText = "";
                    }

                    if (!Regex.IsMatch(dc.Value.ToString(), @"^[a-zA-Z0-9_-]+$"))
                    {
                        dc.ErrorText = "Sai định dạng";
                        isPassed = false;
                    }
                    else
                    {
                        dc.ErrorText = "";
                    }

                    if (list.Contains(dc.Value.ToString()))
                    {
                        dc.ErrorText = "Tên bị trùng";
                        isPassed = false;
                    }
                    if (dc.ColumnIndex == 1)
                    {
                        if (!CheckAddress(dc.Value.ToString()))
                        {
                            dc.ErrorText = "Địa chỉ sai định dạng";
                            isPassed = false;
                        }
                        else
                        {
                            dc.ErrorText = "";
                        }
                    }
                }
                list.Add(dr.Cells[0].Value.ToString());
            }
            return isPassed;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            WriteJsonToList();
            if (!checkInputStringDevice())
            {
                return;
            }
            DeviceModel deviceTemp = deviceDic[formDataList.selectedNodeDouble.Text];

            deviceTemp.Name = txtName.Text;
            deviceTemp.IP = txtIPAdress.Text;
            deviceTemp.Port = Convert.ToInt32(txtPort.Text);
            deviceTemp.Protocol = cbConnect.SelectedItem.ToString();

            deviceDic.Remove(formDataList.selectedNodeDouble.Text);
            deviceDic.Add(deviceTemp.Name, deviceTemp);

            WriteListToJson();
            formDataList.selectedNodeDouble.Text = txtName.Text;

            MessageBox.Show("Sửa thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Xuất dữ liệu từ datagridview ra file CSV
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvShowDuLieu.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể xuất dữ liệu" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dgvShowDuLieu.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvShowDuLieu.Rows.Count + 1];
                            int rowCount = dgvShowDuLieu.Rows.Count - 1;
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvShowDuLieu.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < rowCount; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvShowDuLieu.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Xuất dữ liệu thành công", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            BindDataCSV(openFileDialog1.FileName);
        }

        private void BindDataCSV(string filePath)
        {
            //dgvShowDuLieu.Columns.Clear();
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);

            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("DonViDo", typeof(string));

            for (int i = 1; i < lines.Length; i++)
            {
                string[] t = lines[i].Split(',');
                dt.Rows.Add(t[0], t[1], t[2]);
            }

            dgvShowDuLieu.DataSource = dt;
            if (saveToJson())
            {
                MessageBox.Show("Nhập file thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu sai định dạng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Lưu dữ liệu từ datagridview vào list
        private bool saveToJson()
        {
            if (validation())
            {
                Dictionary<string, DuLieuModel> ListDuLieuChoTungPLC = new Dictionary<string, DuLieuModel>();
                string a = dgvShowDuLieu.Rows[0].Cells[0].Value.ToString();

                foreach (DataGridViewRow dr in dgvShowDuLieu.Rows)
                {
                    if (dr.Index == dgvShowDuLieu.Rows.Count - 1)
                    {
                        break;
                    }

                    DuLieuModel duLieuTemp = new DuLieuModel();
                    duLieuTemp.Ten = dr.Cells[0].Value.ToString();
                    duLieuTemp.DiaChi = dr.Cells[1].Value.ToString();
                    duLieuTemp.DonViDo = dr.Cells[2].Value.ToString();

                    ListDuLieuChoTungPLC.Add(duLieuTemp.Ten, duLieuTemp);
                }
                deviceDic[txtName.Text].ListDuLieuChoTungPLC = ListDuLieuChoTungPLC;
                WriteListToJson();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Check địa chỉ nhập vào 
        private bool CheckAddress(string addressStr)
        {
            bool error = true;
            try
            {
                int address = Convert.ToInt32(addressStr);
                if (address < 1 || (address > 65536 && address < 100001) ||
                    (address > 165536 && address < 300001) ||
                    (address > 365536 && address < 400001) ||
                    address > 465536)
                {

                    error = false;
                }
            }
            catch (Exception ex)
            {
                error = false;
            }
            return error;
        }
        //check nhập vào cấu hình
        public bool checkInputStringDevice()
        {
            bool error = true;
            //Match IPRegex = Regex.Match(txtIP.Text, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            Match PortRegex = Regex.Match(txtPort.Text, @"^()([1-9]|[1-5]?[0-9]{2,4}|6[1-4][0-9]{3}|65[1-4][0-9]{2}|655[1-2][0-9]|6553[1-5])$");
            if (txtName.Text.Trim() == "")
            {
                errorName.SetError(txtName, "Chưa nhập tên thiết bị");
                error = false;
            }
            else
            {
                errorName.SetError(txtName, "");

            }
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9_-]+$"))
            {
                errorTenDL.SetError(txtName, "Tên Dữ liệu sai định dạng!!!");
                error = false;
            }
            else
                errorTenDL.SetError(txtName, "");

            if (deviceDic.ContainsKey(txtName.Text) && txtName.Text != formDataList.selectedNodeDouble.Text)
            {
                errorName.SetError(txtName, "Tên thiết bị trùng lặp");
                error = false;
            }

            if (txtIPAdress.Text.Trim() == "...")
            {
                errorIP.SetError(txtIPAdress, "Chưa nhập IP");
                error = false;
            }
            else
            {
                errorIP.SetError(txtIPAdress, "");
            }

            if (txtPort.Text.Trim() == "")
            {
                errorPort.SetError(txtPort, "Chưa nhập cổng đỉa chị");
                error = false;
            }
            else if (!PortRegex.Success)
            {
                errorPort.SetError(txtPort, "Chưa nhập đúng dạng cổng địa chỉ");
                error = false;
            }
            else
            {
                errorPort.SetError(txtPort, "");
            }
            if (cbConnect.SelectedIndex == -1)
            {
                errorConnect.SetError(cbConnect, "Chưa chọn loại thiết bị");
                error = false;
            }
            else
            {
                errorConnect.SetError(cbConnect, "");
            }
            return error;

        }

        #endregion
    }
}
