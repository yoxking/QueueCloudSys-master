using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntFrm.Framework.RabbitMq.IProxy
{
    public interface IEvent : IMessage
    {
        List<ICommand> Commands { get; set; }
    }
}