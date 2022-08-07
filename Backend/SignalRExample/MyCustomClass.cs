using Microsoft.AspNetCore.SignalR;
using SignalRExample.Hubs;

namespace SignalRExample
{
    public class MyCustomClass
    {
        readonly IHubContext<MyHub> _hubContext;
        public MyCustomClass(IHubContext<MyHub> hubContext)
        {
            _hubContext = hubContext;
        }
        public async Task SendMessageAsync(string message)
        {
            await _hubContext.Clients.All.SendAsync("receiveMessage", message);
        }
    }
}
