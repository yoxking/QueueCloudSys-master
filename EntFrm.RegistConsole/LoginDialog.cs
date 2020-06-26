using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntFrm.RegistConsole
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string result = "false";
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户名和密码不能为空!");
            }
            else
            {
                string serverIp = IPublicHelper.GetConfigValue("ServerIp");
                string serverPort = IPublicHelper.GetConfigValue("ServerPort");
                try
                {
                    result = MyHttpUtils.HttpGet("http://" + serverIp + ":" + serverPort + "/IService/getLoginUser?userName=" + userName + "&password=" + password);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("出错:"+ex.Message);
                }

                if (result.Equals("true"))
                {
                    ILoginHelper.CurrentUser.IsLogin = true; 
                    ILoginHelper.CurrentUser.sLoginId = userName; 
                    ILoginHelper.CurrentUser.sPassword = password; 
                    ILoginHelper.CurrentUser.dLoginTime = DateTime.Now;

                    this.Close(); //关闭登陆窗体
                }
                else
                {
                    MessageBox.Show("用户名或者密码错误!");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        { 
            this.Close(); //关闭登陆窗体
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingDialog dlg = new SettingDialog();
            dlg.ShowDialog();
        }
    }
}
