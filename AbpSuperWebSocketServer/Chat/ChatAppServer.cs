using Microsoft.Extensions.Options;
using SuperSocket.Server;
using SuperSocket.Server.Abstractions;
using SuperSocket.Server.Abstractions.Session;
using SuperSocket.WebSocket;

namespace AbpSuperWebSocketServer;

internal sealed class ChatAppServer(IServiceProvider serviceProvider, IOptions<ServerOptions> serverOptions)
    : SuperSocketService<WebSocketPackage>(serviceProvider, serverOptions)
{
    protected override ValueTask OnSessionConnectedAsync(IAppSession session)
    {
        return base.OnSessionConnectedAsync(session);
    }
}