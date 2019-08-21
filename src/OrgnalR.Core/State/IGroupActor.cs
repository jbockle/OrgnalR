﻿using System.Threading;
using System.Threading.Tasks;
using OrgnalR.Core.Provider;

namespace OrgnalR.Core.State
{
    public interface IGroupActor
    {
        Task AddToGroupAsync(string connectionId, CancellationToken cancellationToken = default);
        Task RemoveFromGroupAsync(string connectionId, CancellationToken cancellationToken = default);
        Task AcceptMessageAsync(AnonymousMessage targetedMessage, CancellationToken cancellationToken = default);
    }
}