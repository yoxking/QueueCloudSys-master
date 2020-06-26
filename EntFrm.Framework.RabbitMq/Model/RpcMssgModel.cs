using System;
using EntFrm.Framework.RabbitMq.Config;

namespace EntFrm.Framework.RabbitMq.Model
{
    [RabbitMq("EntFrm.Rpc.QueueName", ExchangeName = "EntFrm.Rpc.ExchangeName", IsProperties = false)]
    public class RpcMssgModel
    {
        public string Msg { get; set; }


        public DateTime CreateDateTime { get; set; }
    }
}
