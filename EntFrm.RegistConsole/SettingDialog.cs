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
    public partial class SettingDialog : Form
    {
        public SettingDialog()
        {
            InitializeComponent();
        }

        private void SettingDialog_Load(object sender, EventArgs e)
        {
            txtIpAddress.Text=IPublicHelper.GetConfigValue("ServerIp");
            txtPort.Text=IPublicHelper.GetConfigValue("ServerPort");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                IPublicHelper.SetConfigValue("ServerIp", txtIpAddress.Text.Trim());
                IPublicHelper.SetConfigValue("ServerPort", txtPort.Text.Trim()); 

                MessageBox.Show("保存参数信息成功，请重新启动程序!");
                 
                this.Close(); //关闭登陆窗体
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存参数信息出错！详细信息：" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
