using Microsoft.AspNetCore.SignalR;

namespace QuickChats.Web.Hubs;

public class ChatHub : Hub
{
	public async Task OnMessageSentAsync(string messsage, string userName)
	{
		await Clients.All.SendAsync("onReceivedMessage", messsage, userName);
	}
}
