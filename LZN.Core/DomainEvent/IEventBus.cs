using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Core.DomainEvent
{
   public interface IEventBus
    {
        void Register<TEventData>(IEventHandler eventHandler);

        void UnRegister<TEventData>(Type handlerType) where TEventData : IEventData;

        void Trigger<TEventData>(Type eventHandlerType, TEventData eventData) where TEventData : IEventData;
    }
}
