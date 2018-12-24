using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Core.DomainEvent
{
    /// <summary>
    /// 定义事件处理器公共接口
    /// </summary>
  public  interface IEventHandler
    {
    }

    /// <summary>
    /// 泛型事件处理器接口
    /// </summary>
    /// <typeparam name="TEventData"></typeparam>
    public interface IEventHandler<TEventData>:IEventHandler where TEventData : IEventData
    {

        void HandleEvent(TEventData eventData);
    }
}
