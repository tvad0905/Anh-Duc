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
using FileExportScheduler.Controller;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace FileExportScheduler
{
    public partial class ProtocolConfiguration : UserControl
    {
        #region biến toàn cục
        public Dictionary<string, DeviceModel> deviceDic = new Dictionary<string, DeviceModel>();
        TreeView TVMain;
        public FormDataList formDataList;
        public string tenDuLieuDuocChon;
        private string tenDuLieu, diaChi, donViDoDuLieu;
        #endregion
        public ProtocolConfiguration(FormDataList formDataList)
        {
            InitializeComponent();
            this.TVMain = formDataList.tvMain;
            this.formDataList = formDataList;
            WriteJsonToList();
            LoadDuLieuLenDgv();

            //cbProtocol.SelectedIndex = cbProtocol.Items.IndexOf();
            cbCOM.SelectedIndex = cbCOM.Items.IndexOf("COM 1");
            cbBaud.SelectedIndex = cbBaud.Items.IndexOf("9600 Baud");
            cbDataBit.SelectedIndex = cbDataBit.Items.IndexOf("8 Data bits");
            cbParity.SelectedIndex = cbParity.Items.IndexOf("Even Parity");
            cbStopBit.SelectedIndex = cbStopBit.Items.IndexOf("1 Stop Bit");
        }
        #region thao tác với json
        //Xuất từ file .json ra 1 list
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

        #region Kiểm tra nhập vào
        //check nhập vào bên cấu hình protocol
        public bool checkInputStringDevice()
        {

            bool error = true;
            if (cbProtocol.SelectedIndex == -1)
            {
                errorGiaoThuc.SetError(cbProtocol, "Chưa chọn giao thức");
                error = false;
            }

            Match PortRegex = Regex.Match(txtPort.Text, @"^()([1-9]|[1-5]?[0-9]{2,4}|6[1-4][0-9]{3}|65[1-4][0-9]{2}|655[1-2][0-9]|6553[1-5])$");
            if (txtTenGiaoThuc.Text.Trim() == "")
            {
                errorTenGiaoThuc.SetError(txtTenGiaoThuc, "Chưa nhập tên thiết bị");
                error = false;
            }
            else
            {
                errorTenGiaoThuc.SetError(txtTenGiaoThuc, "");

            }

            if (deviceDic.ContainsKey(txtTenGiaoThuc.Text) && txtTenGiaoThuc.Text != formDataList.selectedNodeDouble.Text)
            {
                errorTenGiaoThuc.SetError(txtTenGiaoThuc, "Tên thiết bị trùng lặp");
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

            return error;
        }
        //check nhập vào bên dữ liệu protocol
        private bool validation()
        {
            List<string> list = new List<string>();
            list.Clear();
            bool isPassed = true;
            foreach (DataGridViewRow dr in dgvDataProtocol.Rows)
            {
                if (dr.Index == dgvDataProtocol.Rows.Count - 1)
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
                            dc.ErrorText = "Sai định dạng";
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
        //check nhập vào địa chỉ dữ liệu protocol
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
        #endregion

        #region Sự kiện nút
        //button đóng tab
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        private void txtIPAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //thêm dữ liệu protocol
        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                Dictionary<string, DuLieuModel> ListDuLieuChoTungPLC = new Dictionary<string, DuLieuModel>();
                string a = dgvDataProtocol.Rows[0].Cells[0].Value.ToString();

                foreach (DataGridViewRow dr in dgvDataProtocol.Rows)
                {
                    if (dr.Index == dgvDataProtocol.Rows.Count - 1)
                    {
                        break;
                    }

                    DuLieuModel duLieuTemp = new DuLieuModel();
                    duLieuTemp.Ten = dr.Cells[0].Value.ToString();
                    duLieuTemp.DiaChi = dr.Cells[1].Value.ToString();
                    duLieuTemp.DonViDo = dr.Cells[2].Value.ToString();

                    ListDuLieuChoTungPLC.Add(duLieuTemp.Ten, duLieuTemp);
                }

                deviceDic[txtTenGiaoThuc.Text].ListDuLieuChoTungPLC = ListDuLieuChoTungPLC;
                WriteListToJson();
                MessageBox.Show("Lưu thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Xóa dữ liệu protocol
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvDataProtocol.SelectedRows)
                {
                    deviceDic[txtTenGiaoThuc.Text].ListDuLieuChoTungPLC.Remove(row.Cells[0].Value.ToString());
                    dgvDataProtocol.Rows.Remove(row);

                }
                int a = deviceDic.Count;
                WriteListToJson();
            }
        }
        //lưu cấu hình protocol
        private void btnSaveProtocol_Click_1(object sender, EventArgs e)
        {
            WriteJsonToList();

            
            if (checkInputStringDevice() == false)
            {
                return;
            }
            TreeNode nodeTemp = TVMain.SelectedNode;
            if (nodeTemp.Parent != null)
            {
                if (nodeTemp.Parent.Parent == null)
                {
                    nodeTemp = nodeTemp.Parent;
                }
            }

            DeviceModel deviceObj = new DeviceModel
            {
                Name = txtTenGiaoThuc.Text,
                IP = txtIPAdress.Text,
                Port = Convert.ToInt32(txtPort.Text),
                Protocol = cbProtocol.SelectedItem.ToString(),
                TypeModel = TypeEnum.Protocol,
                ListDuLieuChoTungPLC = new Dictionary<string, DuLieuModel>(),
            };

            deviceDic.Add(deviceObj.Name, deviceObj);
            WriteListToJson();
            TreeNode node = new TreeNode(txtTenGiaoThuc.Text);
            if (TVMain.SelectedNode.Parent == null)
            {
                TVMain.SelectedNode.Nodes.Add(node);
            }
            else if (TVMain.SelectedNode.Parent.Parent == null)
            {
                TVMain.SelectedNode.Parent.Nodes.Add(node);
            }

            node.ContextMenuStrip = formDataList.tx2;

            MessageBox.Show("Lưu thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProtocol.SelectedIndex == 0)
            {
                gbSerialSettingProtocol.Enabled = false;
                gbTCPIPProtocol.Enabled = true;
            }
            else
            {
                gbSerialSettingProtocol.Enabled = true;
                gbTCPIPProtocol.Enabled = false;
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

            dgvDataProtocol.DataSource = dt;
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
                string a = dgvDataProtocol.Rows[0].Cells[0].Value.ToString();

                foreach (DataGridViewRow dr in dgvDataProtocol.Rows)
                {
                    if (dr.Index == dgvDataProtocol.Rows.Count - 1)
                    {
                        break;
                    }

                    DuLieuModel duLieuTemp = new DuLieuModel();
                    duLieuTemp.Ten = dr.Cells[0].Value.ToString();
                    duLieuTemp.DiaChi = dr.Cells[1].Value.ToString();
                    duLieuTemp.DonViDo = dr.Cells[2].Value.ToString();

                    ListDuLieuChoTungPLC.Add(duLieuTemp.Ten, duLieuTemp);
                }
                deviceDic[txtTenGiaoThuc.Text].ListDuLieuChoTungPLC = ListDuLieuChoTungPLC;
                WriteListToJson();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvDataProtocol.Rows.Count > 0)
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
                            int columnCount = dgvDataProtocol.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvDataProtocol.Rows.Count + 1];
                            int rowCount = dgvDataProtocol.Rows.Count - 1;
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvDataProtocol.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < rowCount; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvDataProtocol.Rows[i - 1].Cells[j].Value.ToString() + ",";
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
                MessageBox.Show("Không có bản ghi", "Info");
            }
        }

        //sửa cấu hình protocol
        private void btnEditProtocol_Click_1(object sender, EventArgs e)
        {
            WriteJsonToList();
            if (!checkInputStringDevice())
            {
                return;
            }
            DeviceModel deviceTemp = deviceDic[formDataList.selectedNodeDouble.Text];

            deviceTemp.Name = txtTenGiaoThuc.Text;
            deviceTemp.IP = txtIPAdress.Text;
            deviceTemp.Port = Convert.ToInt32(txtPort.Text);

            deviceDic.Remove(formDataList.selectedNodeDouble.Text);
            deviceDic.Add(deviceTemp.Name, deviceTemp);

            WriteListToJson();
            formDataList.selectedNodeDouble.Text = txtTenGiaoThuc.Text;

            MessageBox.Show("Sửa thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion

        #region sự kiện datagridview
        //Load dữ liệu từ json lên datagridview
        public void LoadDuLieuLenDgv()
        {
            dgvDataProtocol.AutoGenerateColumns = false;
            try
            {
                var cc = deviceDic[formDataList.selectedNodeDouble.Text].ListDuLieuChoTungPLC.Select(x => x.Value).ToList();
                var bindingSource = new BindingSource();
                bindingSource.DataSource = cc;
                dgvDataProtocol.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
            }
        }
        #endregion

    }
}
