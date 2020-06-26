using System;
using EntFrm.Framework.RabbitMq.Config;

namespace EntFrm.Framework.RabbitMq.Model
{
    [RabbitMq("EntFrm.QueueName", ExchangeName = "EntFrm.ExchangeName", IsProperties = false)]
    public class MessageModel
    {
        public string Msg { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
