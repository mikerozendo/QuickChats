import * as signalR from './browser/signalr.js';
var hubConnection = new signalR.HubConnectionBuilder().withUrl("/hubs/Chat").build();
