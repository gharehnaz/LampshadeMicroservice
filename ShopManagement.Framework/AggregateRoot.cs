﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Framework
{
    public class AggregateRoot : Entity
    {
        private readonly List<IDomainEvent> _events = new List<IDomainEvent>();
        public int Version { get; private set; }
        public IReadOnlyList<IDomainEvent> Events => _events;


        public AggregateRoot(IReadOnlyList<IDomainEvent> events)
        {
            if (events == null || events.Count < 1) return;
            foreach (var @event in events)
            {
                Mutate(@event);
                Version++;
            }
        }
        public AggregateRoot()
        {

        }
        protected void AddEvent(IDomainEvent @event)
        {
            _events.Add(@event);
        }
        protected void Apply(IDomainEvent @event)
        {
            Mutate(@event);
            AddEvent(@event);
        }

        private void Mutate(IDomainEvent @event)
        {
            var onMethod = this.GetType().GetMethod("On", BindingFlags.Instance | BindingFlags.NonPublic, [@event.GetType()]);
            var res = onMethod.Invoke(this, new[] { @event });
        }

        public void ClearEvent()
        {
            _events.Clear();
        }
    }
}
