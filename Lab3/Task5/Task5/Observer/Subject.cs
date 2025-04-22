using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Observer
{
    public class Subject
    {
        private Dictionary<string, List<IEventListener>> _subscribers = new();

        public void Subscribe(string eventType, IEventListener listener)
        {
            if (!_subscribers.ContainsKey(eventType))
                _subscribers[eventType] = new List<IEventListener>();

            _subscribers[eventType].Add(listener);
        }

        public void Unsubscribe(string eventType, IEventListener listener)
        {
            if (_subscribers.ContainsKey(eventType))
                _subscribers[eventType].Remove(listener);
        }

        public void Notify(string eventType)
        {
            if (_subscribers.ContainsKey(eventType))
            {
                foreach (var listener in _subscribers[eventType])
                    listener.Update(eventType);
            }
        }
    }

}
