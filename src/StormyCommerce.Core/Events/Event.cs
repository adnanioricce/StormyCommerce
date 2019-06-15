﻿using MediatR;
using System;

namespace StormyCommerce.Core.Events
{
    public class Event : Message,INotification
    {
        public DateTime TimeStamp { get; private set; }
        protected Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}