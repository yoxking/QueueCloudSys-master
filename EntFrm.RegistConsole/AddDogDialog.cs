using EntFrm.Framework.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace EntFrm.RegistConsole
{
    public partial class AddDogDialog : Form
    {
        public delegate void SetDropdownCallback();
        public static SetDropdownCallback BindDropdown;

        private string appCode;
        private List<AppClassData> infoList = new List<AppClassData>();
        public AddDogDialog()
        {
            InitializeComponent();
        }


        private void AddDogDialog_Load(object sender, EventArgs e)
        {

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
                    AddDogDialog.BindDropdown();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
            thread1.Start();

            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        } 

        private void btnGenDog_Click(object sender, EventArgs e)
        {
            try
            {  
                if (string.IsNullOrEmpty(txtDogID.Text.Trim())||string.IsNullOrEmpty(txtOrganizName.Text.Trim()) || string.IsNullOrEmpty(txtContact.Text.Trim()) || string.IsNullOrEmpty(txtTelphone.Text.Trim()))
                {
                    MessageBox.Show("加密狗编号、客户名称、邮箱或电话不能为空!");
                    return;
                }


                EncryptDogEx encDog = new EncryptDogEx(); 
                
                string sCode = txtDogID.Text.Trim() + ";" + txtActiveCount.Text.Trim()+";"+dpDogType.SelectedValue;
                sCode=encDog.StrEnc(sCode, IPublicConsts.ENCKEY);
                sCode = encDog.getRegisteNum(sCode);
                sCode= encDog.getNewRegNum(sCode, dtActiveDate.Value.ToString("yyyyMMdd"),IPublicConsts.SPACEVAL); 

                if (!UpdateAppInfo(sCode))
                {
                    MessageBox.Show("生成注册信息失败!");
                }
                else
                {
                    txtActValCode.Text = sCode;
                    txtComment.AppendText(Environment.NewLine);
                    txtComment.AppendText("加密锁ID：" + txtDogID.Text + ";客户名称：" + txtOrganizName.Text + ";授权数量：" + txtActiveCount.Text + ";注册码：" + txtActValCode.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("出错提示：" + ex.Message);
            }
        }

        private bool UpdateAppInfo(string sCode)
        {
            try
            {
                string serverIp = IPublicHelper.GetConfigValue("ServerIp");
                string serverPort = IPublicHelper.GetConfigValue("ServerPort");
                string url = "http://" + serverIp + ":" + serverPort + "/IService/postAppInfo";
                //url = "http://localhost:3641/IService/postAppInfo";
                string result = "";

                AppInfoData data = new AppInfoData();
                data.AppCode = appCode;
                data.AppClassNo = dpDogType.SelectedValue.ToString();
                data.AppClassName = ((AppClassData)dpDogType.SelectedItem).ClassName;
                data.AppName = ((AppClassData)dpDogType.SelectedItem).ClassName;
                data.AppVersion = "1";
                data.GuestName = txtOrganizName.Text.Trim();
                data.GuestEMail = txtContact.Text.Trim();
                data.GuestPhone = txtTelphone.Text.Trim();
                data.DogId = txtDogID.Text.Trim();
                data.RegistDate = DateTime.Now.ToString("yyyy-MM-dd");
                data.ActiveDate = dtActiveDate.Value.ToString("yyyy-MM-dd");
                data.ActiveCount = txtActiveCount.Text.Trim();
                data.ActiveCode = sCode;

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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtDogID.Text.Trim()))
                {
                    MessageBox.Show("编号不能为空!");
                    return;
                }


                string serverIp = IPublicHelper.GetConfigValue("ServerIp");
                string serverPort = IPublicHelper.GetConfigValue("ServerPort");
                string url = "http://" + serverIp + ":" + serverPort + "/IService/getAppInfoByDogId?dogId="+ txtDogID.Text.Trim();
                //url = "http://localhost:3641/IService/getAppInfoByDogId?dogId=" + txtDogID.Text.Trim();
                string result = MyHttpUtils.HttpGet(url);


                AppInfoData appInfo = JsonConvert.DeserializeObject<AppInfoData>(result);
                 
                if (appInfo == null)
                {
                    txtOrganizName.Text = "";
                    txtContact.Text = "";
                    txtTelphone.Text = "";
                    txtActiveCount.Text = "3";
                    txtActValCode.Text = "";
                    txtComment.Text = "";


                    MessageBox.Show("未找到加密狗号信息!");
                }
                else
                {
                    appCode = appInfo.AppCode;
                    dpDogType.SelectedValue = appInfo.AppClassNo;
                    txtOrganizName.Text = appInfo.GuestName;
                    txtContact.Text = appInfo.GuestEMail;
                    txtTelphone.Text = appInfo.GuestPhone;
                    dtActiveDate.Value = DateTime.Parse(appInfo.ActiveDate);
                    txtActiveCount.Text = appInfo.ActiveCount.ToString();
                    txtActValCode.Text = appInfo.ActiveCode;
                    txtComment.Text = "";
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
