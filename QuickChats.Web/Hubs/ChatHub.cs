using Microsoft.AspNetCore.SignalR;

namespace QuickChats.Web.Hubs;

public class ChatHub : Hub
{
	public async Task OnMessageSentAsync()
	{
		await Clients.All.SendAsync("");
	}
}
