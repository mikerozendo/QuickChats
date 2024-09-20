using Microsoft.AspNetCore.SignalR;

namespace QuickChats.Web.Hubs;

public class ChatHub : Hub
{
	public async Task OnMessageSentAsync(string messsage, string userName)
	{
		await Clients.Others.SendAsync("onReceivedMessage", messsage, userName);
	}
}
