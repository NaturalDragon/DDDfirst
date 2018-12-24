using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Core.Event
{
    public class ActionDelegatedEventHandler<TEvent> : IEventHandler<TEvent>
             where TEvent : class, IEvent
    {
        private Action<TEvent> _handler;

        public ActionDelegatedEventHandler(Action<TEvent> eventHandlerFunc)
        {
            this._handler = eventHandlerFunc;
        }

        public void Handle(TEvent evt)
        {
            _handler(evt);
        }

        public override bool Equals(object obj)
        {
            var other = obj as ActionDelegatedEventHandler<TEvent>;
            if (other == null)
                return false;

            return this._handler.Equals(other._handler);
        }

        public override int GetHashCode()
        {
            return _handler.GetHashCode();
        }
    }
}
