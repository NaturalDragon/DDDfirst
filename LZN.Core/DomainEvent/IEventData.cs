using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Core.DomainEvent
{
    /// <summary>
    /// 定义事件源接口，
    /// </summary>
   public interface IEventData
    {
        /// <summary>
        /// 事件发生的时间
        /// </summary>
        DateTime EventTime { set; get; }

        /// <summary>
        /// 触发事件的对象
        /// </summary>
        object EventSource { set; get; }
    }
}
