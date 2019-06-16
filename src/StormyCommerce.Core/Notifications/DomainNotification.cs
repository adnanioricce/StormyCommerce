using StormyCommerce.Core.Events;
using System;

namespace StormyCommerce.Core.Notifications
{
    public class DomainNotification : Event
    {
        public Guid DomainNotificationId { get; private set; }
        public string NotificationKey { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }
        public DomainNotification(string key,string value)
        {
            DomainNotificationId = Guid.NewGuid();
            Version = 1;
            NotificationKey = key;
            Value = value;
        }
    }
}
