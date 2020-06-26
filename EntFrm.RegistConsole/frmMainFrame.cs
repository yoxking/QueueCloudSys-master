using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EntFrm.RegistConsole
{
    public partial class frmMainFrame : Form
    {

        private ListAppsForm listForm;
        public frmMainFrame()
        {
            InitializeComponent();
        }

        private void frmMainFrame_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenListForm();
        }

        private void MenuItemList_Click(object sender, EventArgs e)
        {
            OpenListForm();
        }

        private void OpenListForm()
        {
            if (listForm == null)
            {
                listForm = new ListAppsForm();
                listForm.MdiParent = this;
                listForm.Show();
            }
            else
            {
                if (listForm.IsDisposed)
                {
                    listForm = new ListAppsForm();
                    listForm.MdiParent = this;
                    listForm.Show();
                }
                else
                {
                    listForm.Activate();
                }
            }
        }

        private void MenuItemWDog_Click(object sender, EventArgs e)
        {
            GenDogDialog form = new GenDogDialog();
            form.ShowDialog();
        }

        private void MenuItemRDog_Click(object sender, EventArgs e)
        {
            AddDogDialog form = new AddDogDialog();
            form.ShowDialog();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutDialog form = new AboutDialog();
            form.ShowDialog();
        }

        private void MenuItemUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已经是最新版本!!");
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemSetting_Click(object sender, EventArgs e)
        {
            SettingDialog form = new SettingDialog();
            form.ShowDialog();
        }

        private void btnListApps_Click(object sender, EventArgs e)
        {
            OpenListForm();
        }

        private void btnReadDog_Click(object sender, EventArgs e)
        {
            AddDogDialog form = new AddDogDialog();
            if (form.ShowDialog() == DialogResult.OK)
            { 
                if (listForm != null)
                {
                    listForm.OnBindGridList();
                }
            }
        }

        private void btnWriteDog_Click(object sender, EventArgs e)
        {
            GenDogDialog form = new GenDogDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (listForm != null)
                {
                    listForm.OnBindGridList();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (listForm != null)
            {
                listForm.OnBindGridList();
            }
        }

        private void frmMainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出程序吗？", "确认", MessageBoxButtons.OKCancel) == DialogResult.Cancel) 
            {
                e.Cancel = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string serverIp = IPublicHelper.GetConfigValue("ServerIp");
                string serverPort = IPublicHelper.GetConfigValue("ServerPort");
                string url = "http://" + serverIp + ":" + serverPort + "/IService/postAppInfo";
                //url = "http://localhost:3641/IService/postAppInfo";
                string result = "";

                AppInfoData data = null;
                List<RegisterInfo> infoList = IMyPublicUtils.Load_InfoList();

                if (infoList != null && infoList.Count > 0)
                {
                    foreach(RegisterInfo info in infoList)
                    {
                        data = new AppInfoData();
                        data.AppCode = info.EncDogId;
                        data.AppClassNo = "160148364901";
                        data.AppClassName = "大厅排队程序";
                        data.AppName = "大厅排队程序";
                        data.AppVersion = "1";
                        data.GuestName = string.IsNullOrEmpty(info.OrganizName) ? "未知" : info.OrganizName;  
                        data.GuestEMail = string.IsNullOrEmpty(info.Contact)?"test@qq.com":info.Contact;
                        data.GuestPhone = string.IsNullOrEmpty(info.Telphone)?"188888":info.Telphone;
                        data.DogId = info.EncDogId;
                        data.RegistDate = info.UpdateDate.ToString("yyyy-MM-dd");
                        data.ActiveDate = info.ActiveDate.ToString("yyyy-MM-dd");
                        data.ActiveCount = info.ActiveCount.ToString();
                        data.ActiveCode = string.IsNullOrEmpty(info.ActiveValCode) ? "n/a" : info.ActiveValCode; 

                        result=MyHttpUtils.HttpPost(url, JsonConvert.SerializeObject(data));
                    }

                    if (result.Equals("success"))
                    {
                        MessageBox.Show("同步数据成功!");

                        if (listForm != null)
                        {
                            listForm.OnBindGridList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("同步数据失败!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
