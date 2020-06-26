using EntFrm.Framework.RabbitMq;
using EntFrm.Framework.RabbitMq.Config;
using EntFrm.Framework.RabbitMq.Model;
using EntFrm.Framework.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntWeb.BkConsole
{
    public class RabbitMqUtil
    { 

        private static RabbitMqService rabbitMqProxy;
        private static RpcMssgModel rpcMsgModel;

        static RabbitMqUtil()
        {
            string serverip = PublicHelper.GetConfigValue("MqServerip");
            string username = PublicHelper.GetConfigValue("MqUsername");
            string password = PublicHelper.GetConfigValue("MqPassword"); 

            rabbitMqProxy = new RabbitMqService(new MqConfig
            {
                AutomaticRecoveryEnabled = true,
                HeartBeat = 60,
                NetworkRecoveryInterval = new TimeSpan(60),
                Host = serverip,
                UserName = username,
                Password = password
            });
        }

        /// <summary>
        /// 发布消息
        /// </summary>
        public static void publish(string message)
        { 

            var log = new MessageModel
            {
                CreateDateTime = DateTime.Now,
                Msg = message
            };
            rabbitMqProxy.Publish("","","","");

            rabbitMqProxy.Dispose();
        }

        /// <summary>
        /// 订阅消息
        /// </summary>
        public static void subscribe()
        { 

            rabbitMqProxy.Subscribe<MessageModel>("status",false,msg =>
            {
                var json = msg.ToString();
                Console.WriteLine(json);
            }, false);

            rabbitMqProxy.Dispose();
        }

        /// <summary>
        /// 从队列拉消息
        /// </summary>
        public static void pull()
        { 

            rabbitMqProxy.Pull<MessageModel>("","","",msg =>
            {
                Console.WriteLine(msg.ToString());
            });


            rabbitMqProxy.Dispose();
        }

        /// <summary>
        /// RPC请求数据
        /// </summary>
        /// <param name="serverip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string requestMq(string queuename, string message)
        {
            string result = "";

            if (rabbitMqProxy != null)
            {
                try
                {
                    PublicHelper.AddLogRecord("rabbitmq",queuename+"::::"+ message);
                    rpcMsgModel = new RpcMssgModel
                    {
                        CreateDateTime = DateTime.Now,
                        Msg = message
                    };
                     
                    result = rabbitMqProxy.RpcClient(queuename, queuename, queuename, JsonConvert.SerializeObject(rpcMsgModel), true);

                    rabbitMqProxy.RemoveChannel(queuename);

                    rpcMsgModel = JsonConvert.DeserializeObject<RpcMssgModel>(result);
                    result = rpcMsgModel.Msg;
                    PublicHelper.AddLogRecord("rabbitmq", "返回：" + result);
                }
                catch (Exception ex)
                { 
                    PublicHelper.AddLogRecord("rabbitmq", ex.Message);
                }
            }

            return result;
        }

        /// <summary>
        /// 监听服务
        /// </summary>
        /// <param name="serverip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void listenMq()
        { 

            rabbitMqProxy.RpcService<RpcMssgModel>("status", "status", true, msg =>
            {
                Console.WriteLine("接受信息：");
                //Console.WriteLine(msg.ToJson());

                msg.CreateDateTime = DateTime.Now;
                msg.Msg = "Hello:" + DateTime.Now.ToString();

                return msg;
            }, false);
        }
    }
}