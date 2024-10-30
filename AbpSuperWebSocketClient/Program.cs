using WebSocket4Net;

var websocket = new WebSocket("WS://127.0.0.1:4040/chat");

await websocket.OpenAsync();

await websocket.SendAsync("Add 1 1");

while (true)
{
    var package = await websocket.ReceiveAsync();

    if (package == null)
        break;

    Console.WriteLine(package.Message);
}


await websocket.CloseAsync();