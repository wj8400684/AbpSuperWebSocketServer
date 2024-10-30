using SuperSocket.Command;
using SuperSocket.ProtoBase;
using SuperSocket.WebSocket.Server;

namespace AbpSuperWebSocketServer.Commands;

[Command(Key = "Add")]
internal sealed class AddCommand : IAsyncCommand<WebSocketSession, StringPackageInfo>
{
    public async ValueTask ExecuteAsync(WebSocketSession session, StringPackageInfo package,
        CancellationToken cancellationToken)
    {
        var result = package.Parameters
            .Select(p => int.Parse(p))
            .Sum();

        await session.SendAsync(result.ToString(), cancellationToken);
    }
}