using EntFrm.Framework.RabbitMq;
using EntFrm.Framework.RabbitMq.Config;
using EntFrm.Framework.RabbitMq.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string result = "";
            string queuename = "Qbab9e6478cc8";

            var rabbitMqProxy1 = new RabbitMqService(new MqConfig
            {
                AutomaticRecoveryEnabled = true,
                HeartBeat = 60,
                NetworkRecoveryInterval = new TimeSpan(60),
                Host = "103.40.31.50",
                UserName = "guest",
                Password = "guest"
            });

            if (rabbitMqProxy1 != null)
            {
                var rpcMsgModel = new RpcMssgModel
                {
                    CreateDateTime = DateTime.Now,
                    Msg = "helloMessage"
                };

                result = rabbitMqProxy1.RpcClient(queuename, queuename, queuename, JsonConvert.SerializeObject(rpcMsgModel), true);

                rabbitMqProxy1.RemoveChannel(queuename); 

                textBox1.AppendText(result + Environment.NewLine);
            }
        }
    }
}
