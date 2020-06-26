using EntFrm.Framework.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace EntFrm.RegistConsole
{
    public partial class GenDogDialog : Form
    {
        public delegate void SetDropdownCallback();
        public static SetDropdownCallback BindDropdown;

        private List<AppClassData> infoList = new List<AppClassData>();

        public GenDogDialog()
        {
            InitializeComponent();
        }

        private void GenDogDialog_Load(object sender, EventArgs e)
        {
            lbStatus.Text = "";
            dtActDate.Value = DateTime.Now.AddMonths(1);
            txtActCount.Text = "1";

            BindDropdown += doBindDropdown;

            dpDogType.DataSource = infoList;
            dpDogType.ValueMember = "ClassNo";
            dpDogType.DisplayMember = "ClassName";

            doInitClass();
        }

    private void doBindDropdown()
    {
        // InvokeRequired required compares the thread ID of the 
        // calling thread to the thread ID of the creating thread. 
        // If these threads are different, it returns true. 
        if (this.dpDogType.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
        {
            while (!this.dpDogType.IsHandleCreated)
            {
                //解决窗体关闭时出现“访问已释放句柄“的异常
                if (this.dpDogType.Disposing || this.dpDogType.IsDisposed)
                    return;
            }

            SetDropdownCallback d = new SetDropdownCallback(doBindDropdown);
            this.dpDogType.Invoke(d, null);
        }
        else
        {
            dpDogType.DataSource = infoList;
        }
    }

    private void doInitClass()
    {
        //通过匿名委托创建
        Thread thread1 = new Thread(delegate () {

            try
            {
                string serverIp = IPublicHelper.GetConfigValue("ServerIp");
                string serverPort = IPublicHelper.GetConfigValue("ServerPort");
                string result = MyHttpUtils.HttpGet("http://" + serverIp + ":" + serverPort + "/IService/getAllAppClasses");

                infoList = JsonConvert.DeserializeObject<List<AppClassData>>(result);
                GenDogDialog.BindDropdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
        thread1.Start();


    }

    private void btnGenID_Click(object sender, EventArgs e)
        {
            try
            {
                string DogID = txtDogID.Text.Trim();
                string DogType = dpDogType.SelectedValue.ToString();
                string UptDate = DateTime.Now.ToString("yyyy-MM-dd");
                string ActDate = dtActDate.Value.ToString("yyyy-MM-dd");
                string ActCount = txtActCount.Text.Trim();
                string ActValCode = "";

                EncDogModel dogModel = new EncDogModel(DogID, DogType, UptDate, ActDate, ActCount, ActValCode);

                if (IUserContext.setEncryptDog(dogModel))
                {
                    if (AddNewAppInfo())
                    {
                        MessageBox.Show("生成加密锁成功！");
                        DialogResult = DialogResult.OK;
                        return;
                    }
                }

                MessageBox.Show("生成加密锁失败！");
                DialogResult = DialogResult.Cancel;

            }
            catch (Exception ex)
            {
                MessageBox.Show("出错提示：" + ex.Message);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnInitdog_Click(object sender, EventArgs e)
        {
            if (IUserContext.initEncryptDog())
            {
                lbStatus.Text = "初始加密锁成功，现在可以写信息！";
            }
            else
            {
                lbStatus.Text = "初始加密锁失败，检查加密锁设备！";
            }
        }

        private void btnReadog_Click(object sender, EventArgs e)
        {
            EncryptDogEx encDog = new EncryptDogEx();
            string dogId = encDog.getEntDogId();

            if (string.IsNullOrEmpty(dogId))
            {
                lbStatus.Text = "读加密锁失败!";
            }
            else
            {
                txtDogID.Text = dogId;
                lbStatus.Text = "读加密锁成功!";
            }

            //EncDogModel dogModel = IUserContext.getEncryptDog();
            //if (dogModel == null)
            //{
            //    txtDogID.Text = "";
            //    txtOrganizName.Text = "XXX科技";
            //    txtActCount.Text = "1";
            //    dtActDate.Value = DateTime.Now.AddMonths(1);
            //    lbStatus.Text = "读取加密锁失败!";

            //}
            //else
            //{
            //    txtDogID.Text = dogModel.EncDogId;
            //    txtOrganizName.Text = dogModel.OrganizName;
            //    txtActCount.Text = dogModel.ActiveCount;
            //    dtActDate.Value = DateTime.Parse(dogModel.ActiveDate);
            //    lbStatus.Text = "读取加密锁成功!";
            //}
        }

        private bool AddNewAppInfo()
        {
            try
            {
                string serverIp = IPublicHelper.GetConfigValue("ServerIp");
                string serverPort = IPublicHelper.GetConfigValue("ServerPort");
                string url = "http://" + serverIp + ":" + serverPort + "/IService/postAppInfo";
                //url = "http://localhost:3641/IService/postAppInfo";
                string result = "";

                AppInfoData data = new AppInfoData();
                data.AppCode = CommonHelper.Get_UniqueStringID();
                data.AppClassNo = dpDogType.SelectedValue.ToString();
                data.AppClassName = dpDogType.SelectedValue.ToString();
                data.AppName = dpDogType.SelectedValue.ToString();
                data.AppVersion = "1"; 
                data.GuestName = dpDogType.SelectedValue.ToString();
                data.GuestEMail = "test@qq.com";
                data.GuestPhone = "18888888888";
                data.DogId = txtDogID.Text.Trim();
                data.RegistDate = DateTime.Now.ToString("yyyy-MM-dd");
                data.ActiveDate = dtActDate.Value.ToString("yyyy-MM-dd");
                data.ActiveCount = txtActCount.Text.Trim(); ;
                data.ActiveCode = "n/a";

                result = MyHttpUtils.HttpPost(url, JsonConvert.SerializeObject(data));


                if (result.Equals("success"))
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
