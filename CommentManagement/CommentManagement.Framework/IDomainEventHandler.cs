﻿namespace CommentManagement.Framework
{
    public interface IDomainEventHandler<TDomainEvent> where TDomainEvent : IDomainEvent
    {
        Task Handle(TDomainEvent domainEvent);
    }
}
