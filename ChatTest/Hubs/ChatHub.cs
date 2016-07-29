using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatTest.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }

        public void Send(string destination,string name, string message)
        {
            //if(destination =="client1")
            // Call the addNewMessageToPage method to update clients.
                Clients.User(destination).getMessage(name, message);
        }
    }
}