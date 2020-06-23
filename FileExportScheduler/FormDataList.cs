using FileExportScheduler.Controller;
using FileExportScheduler.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace FileExportScheduler
{
    public partial class FormDataList : Form
    {
        #region biến toàn cục
        // List<Device> lstDevices;
        Dictionary<string, DeviceModel> deviceDic = new Dictionary<string, DeviceModel>();
        public TreeNode selectedNode = new TreeNode();
        public TreeNode selectedNodeDouble = new TreeNode();
        #endregion
        public FormDataList()
        {
            InitializeComponent();
        }
        //set context menu strip cho các node
        private void setMenu(TreeNode node)
        {

            if (node.Name.ToLower() == "devices" || node.Name.ToLower() == "protocols")
            {
                node.ContextMenuStrip = ctxMenu;
            }
            else
            {
                node.ContextMenuStrip = tx2;
            }
        }

        //đọc file json ra list
        private void JsonToList()
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
        //viết vào file json
        private void WriteListObjectToJson()
        {
            string jsonString = (new JavaScriptSerializer()).Serialize((object)deviceDic);
            File.WriteAllText(GetPathJson.getPathConfig(@"\Configuration\DeviceConfigure.json"), jsonString);
        }

        #region sự kiện của form
        public void LoadTreeView()
        {
            JsonToList();

            foreach (KeyValuePair<string, DeviceModel> device in deviceDic)
            {
                if (device.Value.TypeModel == TypeEnum.Device)
                {
                    TreeNode node = new TreeNode(device.Value.Name);
                    tvMain.Nodes["Devices"].Nodes.Add(node);
                }
                else if (device.Value.TypeModel == TypeEnum.Protocol)
                {
                    TreeNode node = new TreeNode(device.Value.Name);
                    tvMain.Nodes["Protocols"].Nodes.Add(node);
                }
            }
            foreach (TreeNode node in tvMain.Nodes)
            {
                foreach (TreeNode _node in node.Nodes)
                {
                    setMenu(_node);
                }
                setMenu(node);
            }
            WindowState = FormWindowState.Maximized;
        }
        private void FormDataList_Load(object sender, EventArgs e)
        {
            LoadTreeView();
            DeviceConfiguration deviceConfiguration = new DeviceConfiguration(this);
            ProtocolConfiguration protocolConfiguration = new ProtocolConfiguration(this);

            var ports = SerialPort.GetPortNames();
            deviceConfiguration.cbCOM.DataSource = ports;
        }
        private void tvMain_DoubleClick(object sender, EventArgs e)
        {
            selectedNodeDouble = tvMain.SelectedNode;
            var ports = SerialPort.GetPortNames();
            JsonToList();
            if (tvMain.SelectedNode.Parent != null)
            {
                if (tvMain.SelectedNode.Parent.Name.ToLower() == "devices")
                {
                    splitContainer.Panel2.Controls.Clear();

                    DeviceConfiguration deviceConfiguration = new DeviceConfiguration(this);
                    deviceConfiguration.Dock = DockStyle.Fill;
                    deviceConfiguration.txtName.Text = tvMain.SelectedNode.Text;
                    DeviceModel deviceTemp = deviceDic[deviceConfiguration.txtName.Text];
                    deviceConfiguration.btnSave.Enabled = false;
                    deviceConfiguration.txtIPAdress.Text = deviceTemp.IP;
                    deviceConfiguration.txtPort.Text = deviceTemp.Port.ToString();
                    deviceConfiguration.cbConnect.Text = deviceTemp.Protocol.ToString();
                    splitContainer.Panel2.Controls.Add(deviceConfiguration);
                    
                    deviceConfiguration.cbCOM.DataSource = ports;
                }
                if (tvMain.SelectedNode.Parent.Name.ToLower() == "protocols")
                {
                    splitContainer.Panel2.Controls.Clear();

                    ProtocolConfiguration protocolConfiguration = new ProtocolConfiguration(this);
                    protocolConfiguration.Dock = DockStyle.Fill;
                    protocolConfiguration.txtTenGiaoThuc.Text = tvMain.SelectedNode.Text;

                    DeviceModel deviceTemp = deviceDic[protocolConfiguration.txtTenGiaoThuc.Text];

                    protocolConfiguration.txtIPAdress.Text = deviceTemp.IP;
                    protocolConfiguration.txtPort.Text = deviceTemp.Port.ToString();
                    protocolConfiguration.btnEditProtocol.Visible = true;
                    protocolConfiguration.btnSaveProtocol.Visible = false;
                    protocolConfiguration.cbProtocol.Text = deviceTemp.Protocol.ToString();
                    protocolConfiguration.cbCOM.DataSource = ports;
                    splitContainer.Panel2.Controls.Add(protocolConfiguration);
                }
            }
        }
        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    if (tvMain.SelectedNode != null)
                    {
                        if (tvMain.SelectedNode.Parent == null)
                        {
                            //tvMain.Nodes.Remove(tvMain.SelectedNode);
                            return;
                        }
                        else
                        {
                            deviceDic.Remove(tvMain.SelectedNode.Text);
                            WriteListObjectToJson();

                            tvMain.SelectedNode.Parent.Nodes.Remove(tvMain.SelectedNode);
                        }
                    }
                    splitContainer.Panel2.Controls.Clear();
                    break;
                default:
                    break;
            }

        }

        private void tvMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectedNode = e.Node;
            if (e.Button == MouseButtons.Right)
            {
                tvMain.SelectedNode = e.Node;
            }

            if (e.Node.Level == 2)
            {
                e.Node.ContextMenuStrip = tx2;
            }
        }
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            splitContainer.Panel2.Controls.Clear();
            switch (selectedNode.Name)
            {
                case "Devices":
                    DeviceConfiguration deviceConfiguration = new DeviceConfiguration(this);
                    deviceConfiguration.Dock = DockStyle.Fill;
                    deviceConfiguration.btnEdit.Visible = false;
                    splitContainer.Panel2.Controls.Add(deviceConfiguration);
                    
                    deviceConfiguration.cbCOM.DataSource = ports;
                    break;
                case "Protocols":
                    ProtocolConfiguration protocolConfiguration = new ProtocolConfiguration(this);
                    protocolConfiguration.Dock = DockStyle.Fill;
                    protocolConfiguration.btnEditProtocol.Visible = false;
                    protocolConfiguration.btnSaveProtocol.Visible = true;
                    splitContainer.Panel2.Controls.Add(protocolConfiguration);
                    
                    protocolConfiguration.cbCOM.DataSource = ports;
                    break;

            }
        }
        #endregion
    }
}

