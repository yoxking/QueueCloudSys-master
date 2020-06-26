using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EntFrm.RegistConsole
{
    public partial class ListAppsForm : Form
    {
        public delegate void SetGridViewCallback();
        public static SetGridViewCallback BindGridView;

        private List<AppInfoData> infoList = new List<AppInfoData>();

        public ListAppsForm()
        {
            InitializeComponent();
        }

        private void ListAppsForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            BindGridView += doBindGridView;

            gvDataList.AutoGenerateColumns = false;
            gvDataList.DataSource = infoList;

            OnBindGridList();

        }

        /// <summary>
        /// 更新文本框内容的方法
        /// </summary>
        /// <param name="text"></param>
        private void doBindGridView()
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.gvDataList.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
            {
                while (!this.gvDataList.IsHandleCreated)
                {
                    //解决窗体关闭时出现“访问已释放句柄“的异常
                    if (this.gvDataList.Disposing || this.gvDataList.IsDisposed)
                        return;
                }

                SetGridViewCallback d = new SetGridViewCallback(doBindGridView);
                this.gvDataList.Invoke(d, null);
            }
            else
            {
                gvDataList.DataSource = infoList;
            }
        }

        public void OnBindGridList()
        { 

            //通过匿名委托创建
            Thread thread1 = new Thread(delegate () {
                try
                {
                    string serverIp = IPublicHelper.GetConfigValue("ServerIp");
                    string serverPort = IPublicHelper.GetConfigValue("ServerPort");
                    string result = MyHttpUtils.HttpGet("http://" + serverIp + ":" + serverPort + "/IService/getAppInfosByPaging?pageIndex=1&pageSize=100&condition=");

                     infoList = JsonConvert.DeserializeObject<List<AppInfoData>>(result);

                    ListAppsForm.BindGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
            thread1.Start();
            

        }
    }
}
